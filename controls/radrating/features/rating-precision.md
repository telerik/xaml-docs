---
title: Precision
page_title: Precision
description: Precision
slug: rating-features-precision
tags: precision
publish: True
position: 0
---

# Precision



Users can use the __Precision__ property to control the rating precision. The property have three predefined values: 

* __Item__ - you can rate with whole item/star 

* __Half__ - you can rate with half item/star 

* __Exact__ - you can rate with custom precision 

## Setting the Precision property to Item

#### __XAML__

{{region rating-features-precision_0}}
	<telerik:RadRating Precision="Item"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
	{{endregion}}



![](images/rating_precision_item.png)

## Setting the Precision to Half

#### __XAML__

{{region rating-features-precision_1}}
	<telerik:RadRating Precision="Half"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
	{{endregion}}



![](images/rating_precision_half.png)

## Setting the Precision to Exact

#### __XAML__

{{region rating-features-precision_2}}
	<telerik:RadRating Precision="Exact"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
	{{endregion}}



![](images/rating_precision_exact.png)


