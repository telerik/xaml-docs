---
title: Getting Started
page_title: Getting Started
description: Introduction, Getting Started.
slug: radchartview-introduction
tags: introduction, getting, started
published: True
position: 0
---

# Getting Started

__RadChartView__ is essentially a toolset of charting components designed to help you create a variety of rich data-visualization applications. This tutorial will walk you through the creation of a sample application that contains a RadChartView component.

## Chart Types 

The RadChartView suite provides four different chart types.

* __RadCartesianChart__
* __RadPieChart__
* __RadPolarChart__
* __RadFunnelChart__

Each of these charting components is designed to best fit specific use cases. You can read more about the charts in the [ChartTypes]({%slug radchartview-chart-types%}) help article.        

## Adding Telerik Assemblies Using NuGet

To use RadChartView when working with NuGet packages, install the `Telerik.Windows.Controls.Chart.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Chart__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the UI for WPF suite in {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining a Chart

For demonstration purposes, this tutorial will use the __RadCartesianChart__ component. It uses a Cartesian coordiante system to display different series and it is the most commonly used charting component. __Example 1__ demonstrates how to define the RadCartesianChart in XAML.  

__Example 1: Chart definition__
<snippet id='radchartview-getting-started-introduction-example_1_chart_definition-xaml' />


> The `telerik` namespace points to the telerik schema. `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

If you run the project at this stage, __RadCartesianChart__ will inform you that there are no axes defined, as seen in __Figure 1__.

#### __Figure 1: RadCartesianChart without its axes set__
![Rad Chart View-Axis Not Set Message](images/RadChartView-AxisNotSetMessage.png)

The Cartesian coordinate system is constructed using horizontal and vertical axes. __RadChartView__ exposes different types of axes that can be combined horizontally and vertically in different ways based on the scenario. You can find more information about them in our [Axis]({%slug radchartview-axes-axis%}) article.

This example will demonstrate a common scenario with a LinearAxis as the vertical axis of the chart and a CategoricalAxis as horizontal axis. __Example 2__ demonstrates how to define them in XAML.  

__Example 2: Chart axes definition__
<snippet id='radchartview-getting-started-introduction-example_2_chart_axes_definition-xaml' />


In the cases where no series are defined in the definition of the charting components, a message will be displayed to prompt you to enter a series.

#### __Figure 2: RadCartesianChart without any series added in its Series collection__
![Rad Chart View-No Series Added Message](images/RadChartView-NoSeriesAddedMessage.png)

## Defining a Series

__RadChartView__ exposes a large variety of series that can be used in different scenarios. Please take a look at the [Series]({%slug radchartview-series-chartseries%}) article to find out more about the available types.

To complete the task of this tutorial, you need to define series with data points that will be rendered inside the charting component. You can do this by manually populating the __Series__ collection of the __RadCartesianChart__ control.         

__Example 3: Sample BarSeries definition__
<snippet id='radchartview-getting-started-introduction-example_3_sample_barseries_definition-xaml' />


This chart definition will be rendered on the screen as demonstrated in __Figure 3__.

#### __Figure 3: RadCartesianChart displaying a BarSeries__
![Rad Chart View-Getting Started Bar Series](images/RadChartView-GettingStartedBarSeries.png)

If you feel more confident working with code than with markup, you can achieve the same layout with the snippet from __Example 4__.

__Example 4: Sample chart definition in code__
<snippet id='radchartview-getting-started-introduction-example_4_sample_chart_definition_in_code-cs' />

<snippet id='radchartview-getting-started-introduction-example_4_sample_chart_definition_in_code-vb' />


In order to use the chartview components in code, you will need to add the required *using* directives that point to the Telerik namespaces.

__Example 5: Required usings for the chartview components__
<snippet id='radchartview-getting-started-introduction-example_5_required_usings_for_the_chartview_components-cs' />

<snippet id='radchartview-getting-started-introduction-example_5_required_usings_for_the_chartview_components-vb' />


## Bind the Chart

Although you can easily populate the __RadCartesianChart Series__ directly with DataPoint objects, in most real-life applications, you will populate the series with business data. This is why all series types expose an __ItemsSource__ property. You can bind that property to a collection of business items. And if you use a collection that implements the __INotifyCollectionChanged__ interface, then any changes within the business data will be immediately reflected in the appropriate __RadChartView__ components and vice versa. You can find more information in the [Populating with Data]({%slug radchartview-series-databinding%}) section of our documentation.

## Categorical vs Numerical Data

When choosing the correct series and axes to display your data, it is important to consider whether it is categorical or numerical. Here are some basic definitions for both types:

* __Categorical Data__: A type of data that can be stored into groups or categories with the aid of names or labels.
* __Numerical Data__: A type of data that is expressed in terms of numbers rather than natural language descriptions.

The RadChartView suite provides series and axes to display both kinds of data. You can check out the [Series to Axes Dependencies]({%slug radchartview-series-and-axes%}) article, which lists the different types of series and the axes that they support. Most series require one categorical and one numerical axis, however the **Scatter** type series support two numerical axes. 

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ChartView Component](https://www.telerik.com/products/wpf/chartview.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Overview]({%slug radchartview-overview%})
* [Series and Axes]({%slug radchartview-series-and-axes%})
* [Rendering]({%slug radchartview-features-rendering%})
* [RadLegend Support]({%slug radchartview-features-radlegend-support%})
* [Dynamic Number of Series]({%slug radchartview-features-chartseriesprovider%})
* [Empty Content]({%slug radchartview-features-empty-content%})
