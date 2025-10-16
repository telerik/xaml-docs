---
title: GifMessage
page_title: GifMessage
description: Check our &quot;GifMessage&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-gifmessage
tags: messages,gifmessage
published: True
position: 6
---

# Gif Message

As its name states, the __GifMessage__ is intended to be used for displaying gif elements. It provides a single constructor which is illustrated below.

* __Author author__ 
* __Uri source__ 
* __DateTime creationDate__

So, a __GifMessage__ can be defined as follows.

__Example 1: Defining a GifMessage__

```C#
	GifMessage gifMessage = new GifMessage(this.currentAuthor, new Uri("/Images/pbox.gif", UriKind.Relative));

	this.chat.AddMessage(gifMessage);
```

#### __Figure 1: Defining GifMessage__
![Defining GifMessage](images/RadChat_Messages_Gif_01.gif)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})