---
title: Binding to CollectionViewSource
page_title: Binding to CollectionViewSource
description: Check our &quot;Binding to CollectionViewSource&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-populating-with-data-data-binding-to-collectionviewsource
tags: binding,to,collectionviewsource
published: True
position: 2
---

# Binding to CollectionViewSource

__RadTaskBoard__ accepts __CollectionViewSource__ as data source and it will evaluate its __GroupDescriptions__ and generate corresponding columns based on that.

The following tutorial will guide you how to bind a __RadTaskBoard__ to a CollectionViewSource of __TaskBoardCardModel__.

First, we will initialize a CollectionViewSource, which is going to be used to populate the RadTaskBoard control. Next, we can create our data and set __PropertyGroupDescription__ to the State property. This property will be used to group the __CollectionViewSource__.

#### __[C#] Example 1:  Creating ViewModel
<snippet id='radtaskboard-populating-with-data-data-binding-to-cvs-block_1-cs' />

What's left is to set the DataContext of the Window and declare RadTaskBoard control in XAML.

> You don't need to set the GroupMemberPath property of the RadTaskBoard when the control's ItemsSource is bound to a CollectionViewSource collection. The first PropertyGroupDescription will be used by the RadTaskBoard to group the items.

__Example 3: Set the ViewModel as DataContext__
<snippet id='radtaskboard-populating-with-data-data-binding-to-cvs-block_2-xaml' />

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

__Example 3: Defining RadTaskBoard in XAML__
<snippet id='radtaskboard-populating-with-data-data-binding-to-cvs-block_3-xaml' />

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to Object]({%slug radtaskboard-populating-with-data-data-binding-to-object%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})