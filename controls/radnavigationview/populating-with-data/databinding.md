---
title: Data Binding
page_title: Data Binding
description: This article demonstrates how the RadNavigationView can be bound to a collection of custom objects.
slug: radnavigationview-populating-with-data-databinding
tags: databinding, populating, data
position: 0
---

# Data Binding

__RadNavigationView__ can be bound to a collection of objects through its ItemsSource property. This article will demonstrate how to data bind a collection of custom objects to RadNavigationView.

>Note that for every business object from the data bound collection, RadNavigationView will generate a RadNavigationViewItem container representing this object.

## Creating the Model and View Model

For the purposes of this article, we will create a simple object and a view model which will hold a collection of our models. The IconGlyph property of the NavigationItemModel holds the string which will be set to the Icon property of the RadNavigationViewItem. For more information about it, check out the [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%}) article in our documentation.

__Example 1: Creating the model and viewmodel__
<snippet id='radnavigationview-populating-with-data-databinding-block_1-cs' />
<snippet id='radnavigationview-populating-with-data-databinding-block_1-vb' />


## Defining the RadNavigationView

After we have created the viewmodel, the next step is to create an instance and set it to the DataContext of a RadNavigationView. This is demonstrated in __Example 2__. Note, that the change of the RadNavigationView Content is animated by a [RadTransitionControl]({%slug radtransition-getting-started%}), which is bound to its SelectedItem. Additionally, a ContentTemplate is specified for the RadTransitionControl.

__Example 2: Defining the control and the necessary styles__
<snippet id='radnavigationview-populating-with-data-databinding-block_2-xaml' />

#### __Figure 1: Result from Example 2 in the Office2016 theme__
![DataBound RadNavigationView](images/RadNavigationView_DataBinding.gif)

>For another, more complicated, databinding example, check out the __First Look__ RadNavigationView example from the [WPF Controls Samples application](https://demos.telerik.com/wpf/).

## See Also 
* [Getting Started]({%slug radnavigationview-getting-started%})
* [Display Mode]({%slug radnavigationview-display-mode%})