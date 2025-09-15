---
title: ProductCard
page_title: ProductCard
description: Check our &quot;ProductCard&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-productcard
tags: messages,productcard
published: True
position: 2
---

# Product Card

__ProductCard__ extends __ImageCard__ by adding a few more fields for additional information intended to describe a product. Below are the properties that are specific for it.

* __RatingItemsCount__: controls the overall number of items based on which the product will be rated
* __Rating__: sets the rating value of the given card product
* __Price__: the product price

__Example 1: Defining a ProductCard__

```C#
	  ProductCardMessage productCardMessage = new ProductCardMessage(this.currentAuthor);
            
            productCardMessage.Title = "Health Insurance";
            productCardMessage.SubTitle = "Ensure your health now!";
            productCardMessage.Text = "We offer flexible health insurance packages!";
            productCardMessage.CardOrientation = CardOrientation.Portrait;
            productCardMessage.CloseAfterReport = true;
            productCardMessage.ImageDisplayMode = ImageDisplayMode.Stretch;
            productCardMessage.ImageSource = new BitmapImage(new Uri("/Images/insurance-Geico.png", UriKind.RelativeOrAbsolute));
            productCardMessage.RatingItemsCount = 5;
            productCardMessage.Price = "Starting from 200$/month";
            productCardMessage.Rating = 3;

            this.chat.AddMessage(productCardMessage);
```

Adding such __ProductCard__ will result in the following message.

#### __Figure 1: Defining ProductCard__
![Defining ImageCard](images/RadChat_ProductCard_01.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})