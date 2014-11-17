---
title: Using the NumberOfItemsToGenarate property
page_title: Using the NumberOfItemsToGenarate property
description: Using the NumberOfItemsToGenarate property
slug: populating-number-of-items-to-genarate
tags: using,the,numberofitemstogenarate,property
published: True
position: 1
---

# Using the NumberOfItemsToGenarate property



## 

This tutorial will show the way of populating __RadRating__ using the __NumberOfItemsToGenerate__ property.

Here is a regular __RadRating__ declaration:

#### __XAML__

{{region populating-number-of-items-to-genarate_0}}
	<telerik:RadRating x:Name="radRating"/>
	{{endregion}}


where __telerik__ points to: __<xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" />__

![](images/rating_default.png)

If you want to set a specific number of rating items you should set the __NumberOfItemsToGenerate__ property:

#### __XAML__

{{region populating-number-of-items-to-genarate_1}}
    <telerik:RadRating x:Name="radRating" NumberOfItemsToGenerate="3" />
	{{endregion}}



![](images/rating_with_3_items.png)
