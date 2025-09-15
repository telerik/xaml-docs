---
title: In Code-Behind
page_title: In Code-Behind
description: Check our &quot;In Code-Behind&quot; documentation article for the RadRating {{ site.framework_name }} control.
slug: populating-in-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind

This tutorial will walk you through the common tasks of [adding](#Adding_RadRatingItems) and [removing](#Removing_RadRatingItems) __RadRatingItems__ programmatically.			

Example 1 demonstrates a regular __RadRating__ declaration:

__Example 1: Declare a RadRating__
```XAML
	<telerik:RadRating x:Name="radRating"/>
```

#### __Figure 1: Result from Example 1__
![RadRating](images/rating_default.png)

## Adding RadRatingItems

In order to add new rating items to a __RadRating__ control, you have to perform several simple steps:				

* Create an instance of the __RadRatingItem__ class					

* Set its properties such as __Content__ if you need so					

* Add it to the __RadRating__'s __Items__ collection					

	__Example 2: Adding RadRatingItems__
	```C#
		RadRatingItem ratingItem = new RadRatingItem();
		this.radRating.Items.Add(ratingItem);
	```
```VB.NET
		Dim ratingItem As New RadRatingItem()
		Me.radRating.Items.Add(ratingItem)
	```

#### __Figure 2: Result from Example 2__
![RadRating](images/rating_wit_6_items.png)

In order to clear the default rating items and add new you have to add one additional step to the previous:

* Clear the __Items__ collection of the __RadRating__ control					

* Create an instance of the __RadRatingItem__ class					

* Set its properties such as __Content__ if you need so					

* Add it to the __RadRating__'s __Items__ collection					

__Example 3: Clearing the Items collection__
```C#
	this.radRating.Items.Clear(); 
	RadRatingItem ratingItem = new RadRatingItem();
	ratingItem.Content = "1";
	this.radRating.Items.Add(ratingItem);
	ratingItem = new RadRatingItem();
	ratingItem.Content = "2";
	this.radRating.Items.Add(ratingItem);
```
```VB.NET
	Me.radRating.Items.Clear() 
	Dim ratingItem As New RadRatingItem()
	ratingItem.Content = "1"
	Me.radRating.Items.Add(ratingItem)
	ratingItem As New RadRatingItem()
	ratingItem.Content = "2"
	Me.radRating.Items.Add(ratingItem)
```

#### __Figure 3: Result from Example 3__
![RadRating](images/rating_with__2_items.png)

>tip Consider declaring rating items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## Removing RadRatingItems

In order to remove a specific __RadRatingItem__, you should remove it from the __RadRating__'s __Items__ collection.				

__Example 4: Removing RadRatingItems__
```C#
	private void RemoveRatingItem( RadRatingItem itemToRemove )
	{
	   this.radRating.Items.Remove( itemToRemove );
	}
```
```VB.NET
	Private Sub RemoveRatingItem(ByVal itemToRemove As RadRatingItem)
	    Me.radRating.Items.Remove(itemToRemove)
	End Sub
```