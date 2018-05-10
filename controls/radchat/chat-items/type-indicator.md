---
title: Type Indicator
page_title: Type Indicator
description: Type Indicator
slug: chat-items-type-indicator
tags: type, indicator
published: True
position: 1
---

# Type Indicator

The __TypeIndicator__ functionality of the Conversational UI can be used to indicate that an __Author__ is typing. This is done through the following properties.

* __TypeIndicatorVisibility__: It is of type __Visibility__.By default its value is set to __Collapsed__. In order the __TypeIndicator__ to be displayed it can be set to __Visible__.
* __TypeIndicatorText__: A string property that specifies what text to be displayed when an __Author__ is typing.
* __TypeIndicatorIcon__: An ImageSource property through which a custom icon for the __TypeIndicator__ can be applied.

#### __[C#] Example 1: Setting the TypeIndicator__
{{region radchat-messages-typeindicator_01}}
			var textMessage = new TextMessage(this.currentAuthor, "Hello", "sent");
            textMessage.InlineViewModel.StatusVisibility = Visibility.Visible;

            this.chat.AddMessage(textMessage);

            this.chat.TypingIndicatorText = this.otherAuthor.Name + " is typing...";
            this.chat.TypingIndicatorVisibility = Visibility.Visible;
            this.chat.TypingIndicatorIcon = new BitmapImage(new Uri("/Images/PeterJohnson.jpeg", UriKind.RelativeOrAbsolute));
{{endregion}}

Setting the __TypeIndicator__ in such manner will have the following result.

#### __Figure 1: Setting the TypeIndicator__

![Setting the TypeIndicator](images/RadChat_Items_TypeIndicator_01.png)

## See Also

* [Overview]({%slug chat-overview%})

* [Getting Started]({%slug chat-getting-started%})

* [Messages Overview]({%slug chat-items-messages-overview%})