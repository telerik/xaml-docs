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

This tutorial will show the way of populating __RadRating__ using the __NumberOfItemsToGenerate__ property.

Example 1 demonstrates a regular __RadRating__ declaration:

#### __[XAML] Example 1: Declare a RadRating__
{{region xaml-populating-number-of-items-to-genarate_0}}
	<telerik:RadRating x:Name="radRating"/>
{{endregion}}

#### __Figure 1: Result from Example 1__
![RadRating](images/rating_default.png)

If you want to set a specific number of rating items you should set the __NumberOfItemsToGenerate__ property:

#### __[XAML] Example 2: Setting the NumberOfItemsToGenerate__
{{region xaml-populating-number-of-items-to-genarate_1}}
    <telerik:RadRating x:Name="radRating" NumberOfItemsToGenerate="3" />
{{endregion}}

#### __Figure 2: Result from Example 2__
![RadRating](images/rating_with_3_items.png)