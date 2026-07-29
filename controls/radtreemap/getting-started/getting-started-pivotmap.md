---
title: Getting Start with RadPivotMap
page_title: Getting Start with RadPivotMap
description: Check our &quot;Getting Start with RadPivotMap&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-getting-started-pivotmap
tags: getting-started, pivotmap
published: True
position: 1
---

# Getting Start with {{ site.framework_name }} RadPivotMap

This tutorial will walk you through the creation of a sample application that contains __RadPivotMap__ control.
			
## Adding Telerik Assemblies Using NuGet

To use __RadPivotMap__ when working with NuGet packages, install the `Telerik.Windows.Controls.DataVisualization.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Setting up the Data Source

To populate the control with tiles you will need to provide a collection of items that will be assigned to its __ItemsSource__ property. 

For this example we will use a simple flat structure consisting of movies gross sales information.

__Defining the models__
<snippet id='radtreemap-getting-started-getting-started-pivotmap-block_1-cs' />

__Populating a collection with the data__
<snippet id='radtreemap-getting-started-getting-started-pivotmap-block_2-cs' />

## Setting up the RadPivotMap

To set up the control you can set few esential properties - __ItemsSource__, __ValuePath__ and __GroupDefinitions__. The GroupDefinitions is a collection of GroupDefinition objects which contain information that tells the pivot map how to fetch the groups from the  objects in the ItemsSource. 

The __ValuePath__ determines the size of the tile.

The __Member__ determines the name of the corresponding group.

The __LabelPath__ determines the label that will be displayed over the tile.

__Defining RadPivotMap__
<snippet id='radtreemap-getting-started-getting-started-pivotmap-block_3-xaml' />

__Setting the ItemsSource in XAML__
<snippet id='radtreemap-getting-started-getting-started-pivotmap-block_4-xaml' />

__Setting the ItemsSource in code (see Example 2)__
<snippet id='radtreemap-getting-started-getting-started-pivotmap-block_5-xaml' />

__RadPivotMap__  

![{{ site.framework_name }} RadTreeMap with ItemsSource](images/radtreemap-getting-started-pivotmap-0.png)

>tip Avoid inserting RadPivotMap in panels that measure its children with Infinity. In this case, the control cannot properly measure and arrange its child visuals. Examples for panels that measure the control with Infinity size are StackPanel, ScrollViewer or a Grid's Row/ColumnDefinition with its size (Width or Height) set to Auto. Instead, use panels that measure its children with the available space.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TreeMap and PivotMap Component](https://www.telerik.com/products/wpf/treemap-and-pivotmap.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Mappings]({%slug radtreemap-mappings%})
* [Colorizers]({%slug radtreemap-colorizers%})