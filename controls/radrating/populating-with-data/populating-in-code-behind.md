---
title: In Code-Behind
page_title: In Code-Behind
description: In Code-Behind
slug: populating-in-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind



This tutorial will walk you through the common tasks of [adding](#Adding_RadRatingItems) and [removing ](#Removing_RadRatingItems) __RadRatingItems__ programmatically.
			

Here is a regular __RadRating__ declaration:
		
			

#### __XAML__

{{region populating-in-code-behind_0}}
	<telerik:RadRating x:Name="radRating"/>
	{{endregion}}


where __telerik__ points to: __<xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" />__

![](images/rating_default.png)

## Adding RadRatingItems

In order to add new rating items to a __RadRating__ control, you have to perform several simple steps:
				

* Create an instance of the __RadRatingItem__ class
					

* Set its properties such as __Content__ if you need so
					

* Add it to the __RadRating__'s __Items__ collection
					

#### __C#__

{{region populating-in-code-behind_1}}
	RadRatingItem ratingItem = new RadRatingItem();
	this.radRating.Items.Add(ratingItem);
	{{endregion}}



#### __VB.NET__

{{region populating-in-code-behind_2}}
	Dim ratingItem As New RadRatingItem()
	Me.radRating.Items.Add(ratingItem)
	{{endregion}}



The result is shown on the image below:

![](images/rating_wit_6_items.png)

In order to clear the default rating items and add new you have to add one additional step to the previous:

* Clear the __Items__ collection of the __RadRating__ control
					

* Create an instance of the __RadRatingItem__ class
					

* Set its properties such as __Content__ if you need so
					

* Add it to the __RadRating__'s __Items__ collection
					

#### __C#__

{{region populating-in-code-behind_3}}
	this.radRating.Items.Clear(); 
	RadRatingItem ratingItem = new RadRatingItem();
	ratingItem.Content = "1";
	this.radRating.Items.Add(ratingItem);
	ratingItem = new RadRatingItem();
	ratingItem.Content = "2";
	this.radRating.Items.Add(ratingItem);
	{{endregion}}



#### __VB.NET__

{{region populating-in-code-behind_4}}
	Me.radRating.Items.Clear() 
	Dim ratingItem As New RadRatingItem()
	ratingItem.Content = "1"
	Me.radRating.Items.Add(ratingItem)
	ratingItem As New RadRatingItem()
	ratingItem.Content = "2"
	Me.radRating.Items.Add(ratingItem)
	{{endregion}}



The result is shown on the image below:

![](images/rating_with__2_items.png)

>tipConsider declaring rating items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## Removing RadRatingItems

In order to remove a specific __RadRatingItem__, you should remove it from the __RadRating__'s __Items__ collection.
				

#### __C#__

{{region populating-in-code-behind_5}}
	private void RemoveRatingItem( RadRatingItem itemToRemove )
	{
	   this.radRating.Items.Remove( itemToRemove );
	}
	{{endregion}}



#### __VB.NET__

{{region populating-in-code-behind_6}}
	Private Sub RemoveRatingItem(ByVal itemToRemove As RadRatingItem)
	    Me.radRating.Items.Remove(itemToRemove)
	End Sub
	{{endregion}}


