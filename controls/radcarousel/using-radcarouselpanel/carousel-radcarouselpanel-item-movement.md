---
title: RadCarouselPanel Item Movement
page_title: RadCarouselPanel Item Movement
description: Check our &quot;RadCarouselPanel Item Movement&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: carousel-radcarouselpanel-item-movement
tags: radcarouselpanel,item,movement
published: True
position: 0
---

# RadCarouselPanel Item Movement

## Using the Public MoveBy Method

Items in the __RadCarouselPanel__ can be moved programmatically by using the public __MoveBy__ method that takes item displacement as its argument. The displacement variable can be any integer value. The __MoveBy__ method takes into account the path direction thus for positive displacement values it moves the items towards the end of the path and vice versa. For values of zero no items are moved. 



<snippet id='radcarousel-using-radcarouselpanel-carousel-radcarouselpanel-item-movement-block_1-xaml' />

![{{ site.framework_name }} RadCarousel RadCarouselPanel Item Movement](images/CarouselPanelMovement_01.png)



<snippet id='radcarousel-using-radcarouselpanel-carousel-radcarouselpanel-item-movement-block_2-cs' />
<snippet id='radcarousel-using-radcarouselpanel-carousel-radcarouselpanel-item-movement-block_2-vb' />


![{{ site.framework_name }} RadCarousel RadCarouselPanel Item Movement after MoveBy](images/CarouselPanelMovement_02.png)

## Using ScrollViewer

__RadCarouselPanel__ is a scrollable panel that can use __ScrollViewer__ to move its children around the path. This is done by wrapping the panel in a __ScrollViewer__. Moving the __ScrollBars__ will automatically trigger item displacement.



<snippet id='radcarousel-using-radcarouselpanel-carousel-radcarouselpanel-item-movement-block_3-xaml' />

![{{ site.framework_name }} RadCarousel RadCarouselPanel Item Movement via ScrollViewer](images/CarouselPanelMovement_03_thumb.png)
