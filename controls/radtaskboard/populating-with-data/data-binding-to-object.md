---
title: Binding to Object
page_title: Binding to Object
description: Check our &quot;Binding to Object&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-populating-with-data-data-binding-to-object
tags: binding,to,object
published: True
position: 3
---

# Binding to Object

To bind the __RadTaskBoard__ to a collection with custom objects you can use its __ItemsSource__ property. 

The following tutorial will guide you how to bind a __RadTaskBoard__ to a collection of custom business objects.

First, we will specify the following classes, which are going to be used to populate the RadTaskBoard control.

__Example 1: Creating ViewModels__
<snippet id='radtaskboard-populating-with-data-data-binding-to-object-block_1-cs' />

Next, we can go ahead and define the RadTaskBoard in our view:

__Example 2: Defining RadTaskBoard in XAML__
<snippet id='radtaskboard-populating-with-data-data-binding-to-object-block_2-xaml' />

Since the control is bound a collection of custom objects, you need to declare the ItemTemplate property. You have two options here. 

* If you want to use the default look of the card, you can just bind your properties. You can place a __RadTaskBoardCard__ element in the DataTemplate and bind its properties to the properties from the business object.

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

__Example 3: Defining RadTaskBoardCard in ItemTemplate__
<snippet id='radtaskboard-populating-with-data-data-binding-to-object-block_3-xaml' />

* If you want to have your own look. You can place your structure in the DataTemplate applied to the ItemTemplate property of the __RadTaskBoard__.

__Example 3: Defining RadTaskBoard in XAML__
<snippet id='radtaskboard-populating-with-data-data-binding-to-object-block_4-xaml' />

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})