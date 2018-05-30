---
title: ImageMessage
page_title: ImageMessage
description: ImageMessage
slug: chat-items-imagemessage
tags: messages,imagemessage
published: True
position: 7
---

# Image  Message

The usage of the __ImageMessage__ is similar to the one of the [GifMessage]({%slug chat-items-gifmessage%}). The difference is that instead of passing a Uri source, the constructor accepts an Image source.

* __Author author__
* __ImageSource source__
* __[DateTime creationDate = default(DateTime)]__

#### __[C#] Example 1: Defining an ImageMessage__
{{region radchat-messages-imagemessage_01}}
	 ImageMessage imageMessage =
                new ImageMessage(this.currentAuthor, new BitmapImage(new Uri("/Images/dog.jpg", UriKind.RelativeOrAbsolute)));
{{endregion}}

#### __Figure 1: Defining ImageMessage__
![Defining ImageMessage](images/RadChat_Messages_Image_01.png)

Furthermore, the __ImageMessage__ supports setting __Stretch__ and __Size__ for its image.

#### __[C#] Example 2: Setting the Stretch and Size of the message__
{{region radchat-messages-imagemessage_01}}
	ImageMessage imageMessage =
                new ImageMessage(this.currentAuthor, new BitmapImage(new Uri("/Images/dog.jpg", UriKind.RelativeOrAbsolute)));

            imageMessage.Stretch = Stretch.Fill;
            imageMessage.Size = new Size(150, 90);
{{endregion}}

#### __Figure 1: Defining ImageMessage__
![Defining ImageMessage](images/RadChat_Messages_Image_02.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})