---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: databar-getting-started2
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the required steps for using __RadDataBar__. 

* [Assembly References](#assembly-references)
* [Adding RadDataBar to the Project](#adding-raddatabar-to-the-project)
* [Displaying collection of Bars](#displaying-collection-of-bars)

## Assembly References

In order to add __RadDataBar__ in your application, you need to add references to the following assemblies:

* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

## Adding RadDataBar to the Project

#### __[XAML] Example 1: Defining RadDataBar Declaratively__
{{region raddatabar-gettingstarted_0}}
	     <telerik:RadDataBar Height="30" 
                            BorderBrush="Gray"
							BorderThickness="1"/>
{{endregion}}

#### __Figure 1: Adding RadDataBar__
![Adding RadDataBar](images/RadDataBar_GettingStarted_01.png)

By default the __Value__ property of the control will have a value of __0__. It can be bound to a property of the business model so the required data is displayed. This is covered in details in the [Data Binding]({%slug raddatabar-databinding%}) topic.

## Displaying collection of Bars

__RadDataBar__ is intended to display a single value. When displaying a collection of values is needed, the __RadStackedDataBar__ control comes in handy. It will basically generate a bar for each value present in its __ItemsSource__. More information can be found in the [Data Binding]({%slug raddatabar-databinding%}) article.

## See Also

* [Properties]({%slug raddatabar-main_properties%})
* [Data Binding]({%slug raddatabar-databinding%})

