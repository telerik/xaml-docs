---
title: Precision
page_title: Precision
description: Precision
slug: rating-features-precision
tags: precision
published: True
position: 0
---

# Precision

Users can use the __Precision__ property to control the rating precision. The property have three predefined values: 

* __Item__ - you can rate with whole item/star 

* __Half__ - you can rate with half item/star 

* __Exact__ - you can rate with custom precision 

#### __[XAML] Example 1: Setting the Precision property to Item__
{{region xaml-rating-features-precision_0}}
	<telerik:RadRating Precision="Item"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
{{endregion}}

#### __Figure 1: Result from Example 1__
![RadRating with Precision](images/rating_precision_item.png)

#### __[XAML] Example 2: Setting the Precision to Half__
{{region xaml-rating-features-precision_1}}
	<telerik:RadRating Precision="Half"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
{{endregion}}

#### __Figure 2: Result from Example 2__
![RadRating with Precision](images/rating_precision_half.png)

#### __[XAML] Example 3: Setting the Precision to Exact__
{{region xaml-rating-features-precision_2}}
	<telerik:RadRating Precision="Exact"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
{{endregion}}

#### __Figure 3: Result from Example 3__
![RadRating with Precision](images/rating_precision_exact.png)