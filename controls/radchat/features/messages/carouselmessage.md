---
title: CarouselMessage
page_title: CarouselMessage
description: Check our &quot;CarouselMessage&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-carouselmessage
tags: messages,carouselmessage
published: True
position: 4
---

# Carousel Message

The __CarouselMessage__ utilizes the [RadCarousel]({%slug carousel-overview%}) component for displaying its data. Its constructor accepts the following parameters.

* __MessageDisplayPosition displayPosition__
* __Author author__
* __IEnumerable source__
* __DateTime creationDate__

For the purpose of this example a sample collection of [ImageCards]({%slug chat-items-imagecard%}) will be defined.

__Example 1: Defining a CarouselMessage__ 
```C#
	List<ImageCardMessage> imageCards = new List<ImageCardMessage>();

            ImageCardMessage imageCardMessagePlane = new ImageCardMessage(this.currentAuthor);
            imageCardMessagePlane.ImageSource = new BitmapImage(new Uri("/Images/Filhas.png", UriKind.RelativeOrAbsolute));
            imageCardMessagePlane.Title = "Filhas";
            imageCardMessagePlane.CardOrientation = CardOrientation.Portrait;
            imageCardMessagePlane.ImageDisplayMode = ImageDisplayMode.Stretch;

            imageCards.Add(imageCardMessagePlane);

            ImageCardMessage imageCardMessageShip = new ImageCardMessage(this.currentAuthor);
            imageCardMessageShip.ImageSource = new BitmapImage(new Uri("/Images/Casadapaz.png", UriKind.RelativeOrAbsolute));
            imageCardMessageShip.Title = "Casadapaz";
            imageCardMessageShip.CardOrientation = CardOrientation.Portrait;
            imageCardMessageShip.ImageDisplayMode = ImageDisplayMode.Stretch;

            imageCards.Add(imageCardMessageShip);

            ImageCardMessage imageCardMessageTrain = new ImageCardMessage(this.currentAuthor);
            imageCardMessageTrain.ImageSource = new BitmapImage(new Uri("/Images/Hotelresidential.png", UriKind.RelativeOrAbsolute));
            imageCardMessageTrain.Title = "Hotelresidential";
            imageCardMessageTrain.CardOrientation = CardOrientation.Portrait;
            imageCardMessageTrain.ImageDisplayMode = ImageDisplayMode.Stretch;

            imageCards.Add(imageCardMessageTrain);

            CarouselMessage carouselMessage = new CarouselMessage(MessageDisplayPosition.Overlay, this.currentAuthor, imageCards);

            this.chat.AddMessage(carouselMessage);
```

#### __Figure 1: Defining CarouselMessage__
![Defining CalendarMessage](images/RadChat_Messages_Carousel_01.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})