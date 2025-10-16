---
title: Connect to Azure Bot Service 
page_title: Connect to Azure Bot Service 
description: Check our &quot;Connect to Azure Bot Service&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-azure-bot-service
tags: azure, service
published: True
position: 2
---

# How to Connect to Azure Bot Service

This topic will guide you through the process of connecting **RadChat** to a chat bot created with **Azure Bot Service**. 

## What is Azure Bot Service 

Azure Bot Service provides an integrated environment that is purpose-built for bot development, enabling you to build, connect, test, deploy, and manage intelligent bots, all from one place. 

>important This article assumes that you have already [created](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart?view=azure-bot-service-3.0) and [registered](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-channel-connect-directline?view=azure-bot-service-3.0) a chat bot with the [Direct Line](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-3.0) channel. 

## Connect the RadChat to Azure Bot Service Direct Line

In order to connect the RadChat component to a chat bot using the Direct Line channel, you can download the [Microsoft.Bot.Connector.DirectLine](https://www.nuget.org/packages/Microsoft.Bot.Connector.DirectLine) nuget package. The two steps necessary are authenticating with the Direct Line API and starting a conversation. You can use the **Microsoft.Bot.Connector.DirectLine.DirectLineClient** and **Microsoft.Bot.Connector.DirectLine.Conversation** classes in order to achieve them. For more information about that, check out the [Key concepts in Direct Line API 3.0](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-3.0) article.

## Set up the RadChat

In order to prepare the RadChat control for interaction with a bot, you can create two authors: one for the client and one for the bot. You can set the CurrentAuthor of the of the RadChat to the client author. Optionally you can also set the TypingIndicatorText property. This way you can indicate that the chat bot is about to respond to a message. **Example 1** demonstrates how you can achieve this.

__Example 1: Setting up the RadChat__ 
```C#
    this.BotAuthor = new Author("Virtual Assistant");
    this.ClientAuthor = new Author("Client");
    this.radChat.CurrentAuthor = this.ClientAuthor;
    this.radChat.TypingIndicatorText = "Virtual Assistance is typing...";
```

## Send and receive messages

Messages between the bot and the client application can be exchanged using **HTTP GET** and **HTTP POST** requests or by using a websocket. **Example 2** shows a possible implementation of connecting to a chat bot using a WebSocket.

__Example 2: Setting up the RadChat__ 
```C#
    Conversation tokenResponse = new DirectLineClient("your direct line secret").Tokens.GenerateTokenForNewConversation();
 
    this.directLineClient = new DirectLineClient(tokenResponse.Token);
    this.conversation = directLineClient.Conversations.StartConversation();

    this.webSocketClient = new WebSocket(conversation.StreamUrl);
    this.webSocketClient.OnMessage += WebSocketClient_OnMessage;
    this.webSocketClient.Connect();
```

> For an example implementation of connecting to Direct Line using **HTTP GET** and **HTTP POST** requests, check out the [Direct Line Bot Sample](https://github.com/microsoft/BotBuilder-Samples/tree/v3-sdk-samples/CSharp/core-DirectLine) demo and for one using a websocket, check out the [Direct Line Bot Sample (using client WebSockets)](https://github.com/microsoft/BotBuilder-Samples/tree/v3-sdk-samples/CSharp/core-DirectLineWebSockets) demo.

## Send and receive activities

In order to exchange more than simple text messages, you can use [Activities](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-connector-api-reference?view=azure-bot-service-3.0#activity-object). For more information, check out the [Send an activity](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-send-activity?view=azure-bot-service-3.0) and [Receive and Activity](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-receive-activities?view=azure-bot-service-3.0) articles.

## Render Rich Cards

Using the Azure Bot Service you can create and return many different types of cards. You can check out the [Add rich card attachments to messages](https://docs.microsoft.com/en-us/azure/bot-service/dotnet/bot-builder-dotnet-add-rich-card-attachments?view=azure-bot-service-3.0) article in order to see all of the available types. When you receive a card from a chat bot, you can visualize it with one of the [Messages]({%slug chat-items-messages-overview%}) that the RadChat component provides. **Example 3** shows how you can add a [CarouselMessage]({%slug chat-items-carouselmessage%}) to the RadChat depending on the received Activity.

__Example 3: Adding a CarouselMessage to the RadChat__ 
```C#
    private void HandleCarouselMessage(Activity activity)
    {
        List<ImageCardMessage> cards = new List<ImageCardMessage>();
        var carouselMessage = new CarouselMessage(MessageDisplayPosition.Inline, this.BotAuthor, null)
        {
            CloseAfterReport = true
        };

        foreach (Attachment attachment in activity.Attachments)
        {
            HeroCard card = JsonConvert.DeserializeObject<HeroCard>(attachment.Content.ToString());

            var imageCardMessage = new ImageCardMessage(this.BotAuthor) { Title = card.Title, SubTitle = card.Subtitle, Text = card.Text };
            if (card.Images != null && card.Images.Count > 0)
            {
                imageCardMessage.ImageSource = this.DownloadImage(card.Images[0].Url);
            }

            foreach (var action in card.Buttons)
            {
                imageCardMessage.ReportActions.Add(new ValueResponseAction(imageCardMessage)
                {
                    CommandButtonVisibility = Visibility.Visible,
                    DataObjectValue = action.Value,
                    TextResultValue = action.Title,
                    Text = action.Title
                });
            }

            cards.Add(imageCardMessage);
        }

        carouselMessage.Source = cards;
        this.radChat.AddMessage(carouselMessage);
    }
```

> A useful nuget package for working with rich cards received from a bot is the [AdaptiveCards](https://www.nuget.org/packages/AdaptiveCards) package.

## Render Suggested Actions

The Azure Bot Service makes it possible to attach suggested actions to messages which contain possible options to the user. You can check out the [Add suggested actions to messages](https://docs.microsoft.com/en-us/azure/bot-service/dotnet/bot-builder-dotnet-add-suggested-actions?view=azure-bot-service-3.0) article. When you receive a message with suggested actions, you can visualize them by adding them to the [SuggestedActions]({%slug chat-items-suggested-actions%}) collection of the RadChat. **Example 4** shows demonstrates how you can add suggested actions depending on the received Activity.

__Example 4: Adding suggested action to the RadChat__ 
```C#
    private void HandleSuggestedActions(Activity activity)
    {
        if (activity.SuggestedActions != null)
        {
            this.radChat.SuggestedActions.Clear();

            if (activity.SuggestedActions != null)
            {
                foreach (var action in activity.SuggestedActions.Actions)
                {
                    this.radChat.SuggestedActions.Add(new SuggestedAction(action.Value.ToString()));
                }
            }
        }
    }
```

## See Also

* [Getting Started]({%slug chat-getting-started%})
* [Typing Indicator]({%slug chat-items-typing-indicator%})
* [Azure Cloud Integration Getting Started]({%slug cloud-integration-azure-getting-started%})
* [Azure Cloud Integration Blob Storage]({%slug cloud-integration-azure-blob-storage%})
* [Azure Cloud Integration TextAnalysis]({%slug cloud-integration-cognitive-services-text-analysis%})
