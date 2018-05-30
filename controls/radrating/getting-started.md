---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radrating-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This topic helps you to quickly get started using the __RadRating__ control. It focuses on the following: 

* [Assembly References](#assembly-references)
* [Adding RadRating to the Project](#adding-radrating-to-the-project)
* [Key Properties](#key-properties)
* [Events](#events)

## Assembly References

In order to use __RadRating__ in your projects you have to add references to the following two assemblies:
 * __Telerik.Windows.Controls__
 * __Telerik.Windows.Controls.Input__

## Adding RadRating to the project

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadRating__ control in code behind and *XAML* code:

> In order to use the RadRating control, you need to declare the following namespace: xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

#### __[XAML] Example 1: Instantiating a RadRating control in Xaml__
{{region radrating-getting-started_0}}
	<telerik:RadRating />
{{endregion}}

#### __[C#] Example 2: Instantiating a RadRating control in code__
{{region radrating-getting-started_1}}
	RadRating ratingControl = new RadRating();
{{endregion}}

#### __[VB.NET] Example 2: Instantiating a RadRating control__
{{region radrating-getting-started_2}}
	Dim ratingControl As New RadRating()
{{endregion}}

#### Figure 1: RadRating
![RadRating](images/rating_default.png)

## Key Properties

 * **Value**: Gets or sets the value of the RadRating.
 * **Precision**: Gets or sets the precision of the RadRating.
 * **NumberOfItemsToGenerate**: Gets or sets the number of items to generate.
 * **IsReadOnly**: Gets or sets a value indicating whether the RadRating instance is read only.

## Events 

 * **ValueChanged**: Occurs when value of the RadRating has changed. The ValueChanged event handler receives two arguments:
  * The sender argument contains the RadRating. This argument is of type object, but can be cast to the RadRating type.
  * The event arguments are of type RoutedPropertyChangedEventArgs.

## See also
 * [Precision]({%slug rating-features-precision%})
 * [Populating with Data]({%slug populating-overview%})
 * [Make the RadRating read only]({%slug howto-make-readonly%})