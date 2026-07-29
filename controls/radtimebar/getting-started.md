---
title: Getting Started
page_title: Getting Started
description: This article explains how you can setup the RadTimeBar control in xaml or in code and also how you can integrate the RadSparkLine component with it. 
slug: radtimebar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} TimeBar

This tutorial will walk you through the creation of a sample application that contains __RadTimeBar__.

## Adding Telerik Assemblies Using NuGet

To use __RadTimeBar__ when working with NuGet packages, install the `Telerik.Windows.Controls.DataVisualization.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining the Control

Defining the control requires setting several vital properties. Those are __PeriodStart__, __PeriodEnd__ and __Intervals__.

__Example 1: Adding RadTimeBar in XAML__
<snippet id='radtimebar-getting-started-block_1-xaml' />

__Example 2: Adding RadTimeBar in code__
<snippet id='radtimebar-getting-started-block_2-cs' />
<snippet id='radtimebar-getting-started-block_3-vb' />

#### __Figure 1: RadTimeBar__
![{{ site.framework_name }} RadTimeBar RadTimeBar](images/radtimebar-getting-started-0.png)

## Setting the Visible Period

The visible period defines what portion of the period to be brought into the viewport. This can be also looked as zooming. The visible period is defined via the __VisiblePeriodStart__ and __VisiblePeriodEnd__ properties.

__Example 3: Setting the visible period in XAML__
<snippet id='radtimebar-getting-started-block_4-xaml' />

__Example 4: Setting the visible period in code__
<snippet id='radtimebar-getting-started-block_5-cs' />
<snippet id='radtimebar-getting-started-block_6-vb' />

#### __Figure 2: RadTimeBar with visible period set__
![{{ site.framework_name }} RadTimeBar RadTimeBar with visible period set](images/radtimebar-getting-started-1.png)

## Selecting an Interval

To select an interval you can set the RadTimeBar's __SelectionStart__ and __SelectionEnd__ properties.

__Example 5: Setting the selection in XAML__
<snippet id='radtimebar-getting-started-block_7-xaml' />

__Example 6: Setting the selection in code__
<snippet id='radtimebar-getting-started-block_8-cs' />
<snippet id='radtimebar-getting-started-block_9-vb' />

#### __Figure 3: RadTimeBar with selection defined__
![{{ site.framework_name }} RadTimeBar RadTimeBar with selection defined](images/radtimebar-getting-started-2.png)

## Hosting Another Control

The RadTimeBar component allows you to host another control in it, thus enchancing the visualization. The most common scenario is hosting a RadSparkline control.

The following example demonstrates how to populate a simple RadLinearSparkline with data and host it in RadTimeBar. Read more about the RadSparkline controls in its [help documentation]({%slug radsparkline_overview%}).

__Example 7: Hosting RadSparkline in RadTimeBar in XAML__
<snippet id='radtimebar-getting-started-block_10-xaml' />

__Example 8: Hosting RadSparkline in RadTimeBar in code__
<snippet id='radtimebar-getting-started-block_11-cs' />
<snippet id='radtimebar-getting-started-block_12-vb' />

__Example 9: Setting up the ItemsSource of the sparkline control__
<snippet id='radtimebar-getting-started-block_13-cs' />
<snippet id='radtimebar-getting-started-block_14-vb' />

#### __Figure 4: RadTimeBar and RadSparkline__
![{{ site.framework_name }} RadTimeBar RadTimeBar and RadSparkline](images/radtimebar-getting-started-3.png)

#### DataBinding the RadSparkLine

In order to learn how you can bind the ItemsSource of a RadSparkLine component in general, you can read the [DataBinding]({%slug radsparkline_databinding%}) article in the RadSparkLine section.

> In case the ItemsSource of the sparkline is a collection of business objects, where the property bound to the XValue of the sparkline is of type DateTime, you need to make sure that the collection is ordered (ascending) by that property. This is needed for the virtualization of the RadSparkLine, which is enabled by the __EnableSparklineVirtualization__ property of the RadTimeBar(__True__ by default).

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#TimeBar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadTimeBar, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.DataVisualization__

__Example 10__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 10: Merge the ResourceDictionaries__  
<snippet id='radtimebar-getting-started-block_15-xaml' />

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 5__ shows a RadTimeBar with the **Windows8** theme applied.

#### __Figure 5: RadTimeBar with the Windows8 theme__
![RadTimeBar with Windows8 theme](images/RadTimeBar-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TimeBar Component](https://www.telerik.com/products/wpf/timebar.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Properties]({%slug radtimebar-properties%})
* [SDK Examples]({%slug radtimebar-sdk-examples%})
* [MVVM Support]({%slug radtimebar-mvvm-support%})