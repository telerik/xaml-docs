---
title: Connect RadChat to Bot and AI Services
page_title: Connect RadChat to Bot and AI Services
description: Learn how to connect RadChat to a bot, AI, or LLM backend by using secure service integration patterns and modern Azure guidance.
components: ["chat"]
slug: chat-azure-bot-service
tags: chat, bot, azure, directline, ai, llm, openai, agents
published: True
position: 13
---

# Connect RadChat to Bot and AI Services

This topic shows how to connect __RadChat__ to modern conversational backends, including bot services, AI endpoints, and LLM-powered agents. The control handles the chat UI, while your backend handles authentication, orchestration, and response generation.

## Choose a Backend Architecture

It is recommended for a production AI chat application to communicate with AI and bot services through a backend. This protects service credentials from client-side exposure and enables capabilities such as user authentication, access control, telemetry and more.

Select a backend architecture that best matches your scenario. The following table shows few examples covering different scenarios.

| Scenario | Recommended backend | Notes |
|---|---|---|
| You build a new AI assistant | ASP.NET Core API + Azure OpenAI Responses API | Preferred option for new LLM-powered experiences. |
| You already have a bot in production | Azure Bot Service with Direct Line | Keep bot logic unchanged and move token generation to your backend. |
| You need multi-channel agent orchestration | Microsoft 365 Agents SDK | Useful when your agent targets Teams, Microsoft 365 Copilot, web, and custom channels. |

## Set Up RadChat

To prepare the control for backend communication, configure a client author and an assistant author.

__Defining RadChat in XAML__
```XAML
<Grid xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	<telerik:RadChat x:Name="chat"
					 SendMessage="RadChat_SendMessage"
					 IsMoreButtonVisible="True" />
</Grid>
```

__Configuring authors and typing indicator__
```C#
using Telerik.Windows.Controls.ConversationalUI;

private readonly Author currentAuthor = new Author("client", "You");
private readonly Author assistantAuthor = new Author("assistant", "Assistant");

public MainWindow()
{
	this.InitializeComponent();

	this.chat.CurrentAuthor = this.currentAuthor;
	this.chat.TypingIndicatorText = "Assistant is typing...";
}
```

The __TypingIndicatorText__ property lets the end user know that the service is preparing a response.

## Send a Prompt and Receive a Response

Use a backend client abstraction so the UI code stays independent from any specific provider.

__Defining a backend client contract__
```C#
using Telerik.Windows.Controls.ConversationalUI;

public interface IChatServiceClient
{
	Task<ChatServiceResponse> SendAsync(
		string text,
		IReadOnlyList<PromptInputAttachedFile> attachedFiles,
		CancellationToken cancellationToken = default);
}

public sealed class ChatServiceResponse
{
	public string Text { get; set; }
	public IReadOnlyList<CardPayload> Cards { get; set; } = Array.Empty<CardPayload>();
	public IReadOnlyList<string> SuggestedActions { get; set; } = Array.Empty<string>();
}

public sealed class CardPayload
{
	public string Title { get; set; }
	public string SubTitle { get; set; }
	public string Text { get; set; }
}
```

__Implementing the backend client over HTTP__
```C#
using System.Linq;
using System.Net.Http.Json;

public sealed class HttpChatServiceClient : IChatServiceClient
{
	private readonly HttpClient httpClient;

	public HttpChatServiceClient(HttpClient httpClient)
	{
		this.httpClient = httpClient;
	}

	public async Task<ChatServiceResponse> SendAsync(
		string text,
		IReadOnlyList<PromptInputAttachedFile> attachedFiles,
		CancellationToken cancellationToken = default)
	{
		var requestPayload = new
		{
			text,
			files = attachedFiles.Select(x => new { x.FileName, x.FileSize }).ToArray()
		};

		using HttpResponseMessage response = await this.httpClient.PostAsJsonAsync(
			"api/chat",
			requestPayload,
			cancellationToken);

		response.EnsureSuccessStatusCode();

		return await response.Content.ReadFromJsonAsync<ChatServiceResponse>(cancellationToken: cancellationToken)
			?? new ChatServiceResponse();
	}
}
```

__Handling the SendMessage event and calling the backend__
```C#
using System.Net.Http.Json;
using System.Windows;
using Telerik.Windows.Controls.ConversationalUI;

private readonly IChatServiceClient chatClient =
	new HttpChatServiceClient(new HttpClient { BaseAddress = new Uri("https://localhost:7158/") });

private CancellationTokenSource activeRequestCancellation;

private async void RadChat_SendMessage(object sender, SendMessageEventArgs e)
{
	if (e.Message is not TextMessage outgoingTextMessage)
	{
		return;
	}

	this.activeRequestCancellation?.Cancel();
	this.activeRequestCancellation = new CancellationTokenSource();

	this.chat.TypingIndicatorVisibility = Visibility.Visible;

	try
	{
		ChatServiceResponse response = await this.chatClient.SendAsync(
			outgoingTextMessage.Text,
			e.AttachedFiles,
			this.activeRequestCancellation.Token);

		if (!string.IsNullOrWhiteSpace(response.Text))
		{
			this.chat.AddMessage(new TextMessage(this.assistantAuthor, response.Text));
		}

		this.UpdateSuggestedActions(response.SuggestedActions);
		this.AddCardMessages(response.Cards);
	}
	catch (OperationCanceledException)
	{
		// A newer user message canceled the in-flight request.
	}
	catch (Exception)
	{
		this.chat.AddMessage(new TextMessage(
			this.assistantAuthor,
			"I could not process your request. Try again."));
	}
	finally
	{
		this.chat.TypingIndicatorVisibility = Visibility.Collapsed;
	}
}
```

This pattern works with Azure OpenAI, Direct Line proxies, and any custom service that returns normalized response payloads.

## Render Cards and Suggested Actions

When your backend returns structured content, map it to __RadChat__ message types.

__Rendering card messages and suggested actions__
```C#
private void AddCardMessages(IEnumerable<CardPayload> cards)
{
	foreach (CardPayload card in cards)
	{
		var cardMessage = new CardMessage(this.assistantAuthor)
		{
			Title = card.Title,
			SubTitle = card.SubTitle,
			Text = card.Text
		};

		this.chat.AddMessage(cardMessage);
	}
}

private void UpdateSuggestedActions(IEnumerable<string> actions)
{
	this.chat.SuggestedActions.Clear();

	foreach (string actionText in actions)
	{
		this.chat.SuggestedActions.Add(new SuggestedAction(actionText));
	}
}
```

For carousel-style UI or domain-specific cards, map your backend payloads to [Messages]({%slug chat-items-messages-overview%}) and [Suggested Actions]({%slug chat-items-suggested-actions%}) types.

## Stream Responses Incrementally

If your backend supports streaming tokens, append chunks to a single __TextMessage__ instance.

__Updating a chat message while streaming__
```C#
private async Task AddStreamedResponseAsync(
	IAsyncEnumerable<string> responseChunks,
	CancellationToken cancellationToken)
{
	var streamedMessage = new TextMessage(this.assistantAuthor, string.Empty);
	this.chat.AddMessage(streamedMessage);

	await foreach (string chunk in responseChunks.WithCancellation(cancellationToken))
	{
		streamedMessage.Text += chunk;
	}
}
```

Streaming gives faster perceived response time and a more natural assistant experience.

## See Also

* [Getting Started]({%slug chat-getting-started%})
* [Typing Indicator]({%slug chat-items-typing-indicator%})
* [Message Attachments]({%slug chat-attachments%})
* [Messages Overview]({%slug chat-items-messages-overview%})
* [Azure OpenAI Responses API](https://learn.microsoft.com/en-us/azure/foundry/openai/how-to/responses)
