---
title: Declaratively
page_title: Declaratively
description: Declaratively
slug: populating-declaratively
tags: declaratively
published: True
position: 2
---

# Declaratively

This tutorial will walk you through the common task of populating __RadRating__ with __RadRatingItems__ declaratively.

Here is a regular __RadRating__ declaration:

#### __XAML__
{{region populating-declaratively_0}}
	<xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"/>
	...
	<telerik:RadRating x:Name="radRating">
	</telerik:RadRating>
{{endregion}}

![](images/rating_default.png)

In order to add rating items you need to use the __RadRating's__ __Items__ property. The __Items__ property is an __ItemCollection__ which contains your __RadRatingItems__. For example, insert the following lines to the declaration of your __RadRating__ and see how it will change.

#### __XAML__
{{region populating-declaratively_1}}
	<telerik:RadRating x:Name="radRating">
	    <telerik:RadRatingItem Content="1" />
	    <telerik:RadRatingItem Content="2" />
	    <telerik:RadRatingItem Content="3" />
	    <telerik:RadRatingItem Content="4" />
	    <telerik:RadRatingItem Content="5" />
	    <telerik:RadRatingItem Content="6" />
	    <telerik:RadRatingItem Content="7" />
	    <telerik:RadRatingItem Content="8" />
	    <telerik:RadRatingItem Content="9" />
	    <telerik:RadRatingItem Content="10" />
	</telerik:RadRating>
{{endregion}}

![](images/rating_with_10_items.png)

>tip Consider declaring rating items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.
