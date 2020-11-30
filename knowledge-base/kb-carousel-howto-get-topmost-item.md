---
title: Get the Topmost Item in RadCarousel
description: How to obtain the top CarouselItem.
type: how-to
page_title: Find the top element in RadCarousel
slug: kb-carousel-howto-get-topmost-item
position: 0
tags: carousel, top, item
ticketid: 1403251
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadCarousel for WPF</td>
	</tr>
</table>


## Description

How to get the uppermost item in RadCarousel.

## Solution

You can access the __RadCarouselPanel__, through the __FindCarouselPanel__ method of the RadCarousel. Then you can utilize its __TopContainer__ property. It will return the __CarouselItem__ visual element, however you can check its DataContext to get the bound object in an MVVM scenario.

#### __[C#]__
{{region cs-kb-carousel-howto-get-topmost-item-0}}
	RadCarouselPanel carouselPanel = this.MyCarousel.FindCarouselPanel();
    var topContainer = carouselPanel.TopContainer;
    var dataContext = (topContainer as CarouselItem).DataContext;
{{endregion}}

#### __[XAML]__
{{region xaml-kb-carousel-howto-get-topmost-item-1}}
	<telerik:RadCarousel x:Name="MyCarousel" 
                         ItemsSource="12345"/>
{{endregion}}

>tip You can handle the __TopContainerChanged__ event of the RadCarouselPanel in order to get notified when the TopContainer changes.
