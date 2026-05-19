---
title: Suggested Actions
page_title: Suggested Actions
description: Check our &quot;Suggested Actions&quot; documentation article for the RadChat WPF control.
slug: chat-items-suggested-actions
tags: suggested, actions
published: True
position: 2
---

# Suggested Actions

__Conversational UI__ supports adding message suggestions in the chat's UI that can be used easily send text to the chat. 

## Adding the SuggestedAction

To add suggestions, use the `SuggestedActions` collection of `RadChat`. 

```C#
private Author currentAuthor;
private Author otherAuthor;

public MainWindow()
{
	InitializeComponent();

	currentAuthor = new Author("1") { Name = "Peter" };
	otherAuthor = new Author("2") { Name = "Steven" };
	this.chat.CurrentAuthor = currentAuthor;

	var textMessage = new TextMessage(this.currentAuthor, "Hello", "sent");
	textMessage.InlineViewModel.StatusVisibility = Visibility.Visible;

	this.chat.AddMessage(textMessage);

	this.chat.SuggestedActions.Add(new SuggestedAction("Hi, there!"));
}
```

![Adding a SuggestedAction](images/RadChat_Items_SuggestedActions_01.png)

The `SuggestedActions` are visible by default. In case they need to hide the suggestions, set the `SuggestedActionsVisibility` property of `RadChat` to `Collapsed`.

## Handling the SuggestedActionReported event

When the user selects a given suggestion, the `SuggestedActionReported` is raised. Through it the user input can be modified. Its arguments expose the following members.

* `CloseAfterReport`: A boolean property that controls whether the message will be removed after it reports a result.
* `PostResultInline`: A boolean property that determines whether the suggestion should be posted as an inline text message or not.
* `Text`: The text result.

```C#
private void Chat_SuggestedActionReported(object sender, SuggestedActionsEventArgs e)
{
	if (e.Text == "Hi, there!")
	{
		e.CloseAfterReport = false;
		e.PostResultInline = false;

		this.chat.AddMessage(this.otherAuthor, e.Text);
	}
}
```

![Handling the SuggestedActionReported event](images/RadChat_Items_SuggestedActions_02.png)

## SuggestedActionsOrientation

To set the layout orientation of the suggested actions, use the `SuggestedActionsOrientation` property of `RadChat`.

```XAML
<telerik:RadChat x:Name="chat" SuggestedActionsOrientation="Vertical"/>
```

![SuggestedActions with Vertical orientation](images/RadChat_Items_SuggestedActions_03.png)

## See Also  
* [Overview]({%slug chat-overview%})
* [Getting Started]({%slug chat-getting-started%})
* [Messages Overview]({%slug chat-items-messages-overview%})