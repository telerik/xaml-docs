---
title: Precision
page_title: Precision
description: Check our &quot;Precision&quot; documentation article for the RadRating {{ site.framework_name }} control.
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

__Example 1: Setting the Precision property to Item__
```XAML
	<telerik:RadRating Precision="Item"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
```

#### __Figure 1: Result from Example 1__
![RadRating with Precision](images/rating_precision_item.png)

__Example 2: Setting the Precision to Half__
```XAML
	<telerik:RadRating Precision="Half"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
```

#### __Figure 2: Result from Example 2__
![RadRating with Precision](images/rating_precision_half.png)

__Example 3: Setting the Precision to Exact__
```XAML
	<telerik:RadRating Precision="Exact"
	                   ToolTipService.ToolTip="{Binding RelativeSource={RelativeSource Self}, Path=Value}" />
```

#### __Figure 3: Result from Example 3__
![RadRating with Precision](images/rating_precision_exact.png)