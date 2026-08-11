---
title: Styles and Templates
page_title: Styles and Templates
description: This article explains how to modify the appearance of the RadTaskBoard control and its elements.
slug: radtaskboard-styles-and-templates
tags: getting,started
published: True
position: 8
---

# Styles and Templates

__RadTaskBoard__ allows you to easily modify its appearance by providing some useful properties.

## ItemTemplate and ItemTemplateSelector

You can configure the visualization of the data and the appearance of the card items via the **ItemTemplate** and the **ItemTemplateSelectior** properties.

__Define a custom ItemTemplate__

<snippet id='radtaskboard-styles-and-templates-block_1-xaml' />

If you wish to return different templates for the card items, you can use the **ItemTemplateSelectior** property and pass a custom **DataTemplateSelector** to it.

## ColumnHeaderTemplate

To further customize the headers of all columns, you can create your own DataTemplate and apply it to the __ColumnHeaderTemplate__ property of the RadTaskBoard.

__Set ColumnHeaderTemplate__

<snippet id='radtaskboard-styles-and-templates-block_2-xaml' />

## ItemContainerStyle and ItemContainerStyleSelectior

The task inside the __RadTaskBoard__ control are represented by a __RadTaskBoardItem__ elements. You can use the **ItemContainerStyle** property to style these individual elements.

__Specify ItemContainerStyle__

<snippet id='radtaskboard-styles-and-templates-block_3-xaml' />

If you wish to return different styles for the card items, you can use the **ItemContainerStyleSelectior** property and pass a custom **StyleSelector** to it.	
	
## See Also

* [Key Properties]({%slug radtaskboard-key-properties%})
* [Events]({%slug radtaskboard-events%})