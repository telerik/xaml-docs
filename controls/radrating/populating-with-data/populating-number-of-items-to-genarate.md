---
title: Using the NumberOfItemsToGenarate property
page_title: Using the NumberOfItemsToGenarate property
description: Check our &quot;Using the NumberOfItemsToGenarate property&quot; documentation article for the RadRating {{ site.framework_name }} control.
slug: populating-number-of-items-to-genarate
tags: using,the,numberofitemstogenarate,property
published: True
position: 1
---

# Using the NumberOfItemsToGenarate property

This tutorial will show the way of populating __RadRating__ using the __NumberOfItemsToGenerate__ property.

Example 1 demonstrates a regular __RadRating__ declaration:

__Example 1: Declare a RadRating__
```XAML
	<telerik:RadRating x:Name="radRating"/>
```

#### __Figure 1: Result from Example 1__
![RadRating](images/rating_default.png)

If you want to set a specific number of rating items you should set the __NumberOfItemsToGenerate__ property:

__Example 2: Setting the NumberOfItemsToGenerate__
```XAML
    <telerik:RadRating x:Name="radRating" NumberOfItemsToGenerate="3" />
```

#### __Figure 2: Result from Example 2__
![RadRating](images/rating_with_3_items.png)