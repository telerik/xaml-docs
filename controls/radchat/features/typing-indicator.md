---
title: Typing Indicator
page_title: Typing Indicator
description: Check our &quot;Typing Indicator&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-typing-indicator
tags: typing, indicator
published: True
position: 1
---

# Typing Indicator

The __TypingIndicator__ functionality of the Conversational UI can be used to indicate that an __Author__ is typing. This is done through the following properties.

* __TypingIndicatorVisibility__: It is of type __Visibility__. By default its value is set to __Collapsed__. In order the __TypingIndicator__ to be displayed it can be set to __Visible__.
* __TypingIndicatorText__: A string property that specifies what text to be displayed when an __Author__ is typing.
* __TypingIndicatorIcon__: An ImageSource property through which a custom icon for the __TypingIndicator__ can be applied.

__Example 1: Setting the TypingIndicator__
```C#
			var textMessage = new TextMessage(this.currentAuthor, "Hello", "sent");
            textMessage.InlineViewModel.StatusVisibility = Visibility.Visible;

            this.chat.AddMessage(textMessage);

            this.chat.TypingIndicatorText = this.otherAuthor.Name + " is typing...";
            this.chat.TypingIndicatorVisibility = Visibility.Visible;
            this.chat.TypingIndicatorIcon = new BitmapImage(new Uri("/Images/PeterJohnson.jpeg", UriKind.RelativeOrAbsolute));
```

Setting the __TypingIndicator__ in such manner will have the following result.

#### __Figure 1: Setting the TypingIndicator__

![Setting the TypingIndicator](images/RadChat_Items_TypeIndicator_01.png)

## See Also

* [Overview]({%slug chat-overview%})

* [Getting Started]({%slug chat-getting-started%})

* [Messages Overview]({%slug chat-items-messages-overview%})