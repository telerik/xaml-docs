---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: radcolorpicker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} ColorPicker

## Adding Telerik Assemblies Using NuGet

To use __RadColorPicker__ when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Selection

__RadColorPicker__ is a control that displays  a set of palettes from which the user can select a single color.		

>In order to use __RadColorPicker__ in your projects you have to add references to the following two assemblies 
>	- __Telerik.Windows.Controls__ 
>	- __Telerik.Windows.Controls.Input__

It has a __SelectedColor__ property, which is of __Color__ type and it is used to store selected color value.		

__Example 1__
<snippet id='radcolorpicker-getting-started-example_1-xaml' />


__Example 2__
<snippet id='radcolorpicker-getting-started-example_2-cs' />

<snippet id='radcolorpicker-getting-started-example_2-vb' />

    
Whenever a color is selected the __SelectedColorChanged__ event is raised:		

__Example 3__
<snippet id='radcolorpicker-getting-started-example_3-cs' />

<snippet id='radcolorpicker-getting-started-example_3-vb' />


## Populating

You can populate the __RadColorSelector__  with any of the built-in palettes using the __ColorPreset__ enum . It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.		

* __MainPalette__ property:			

	__Example 4__
	<snippet id='radcolorpicker-getting-started-example_4-xaml' />


	__Example 4__
	<snippet id='radcolorpicker-getting-started-example_4-cs' />

	<snippet id='radcolorpicker-getting-started-example_4-vb' />


* __HeaderPalette__ property:

	__Example 6__
	<snippet id='radcolorpicker-getting-started-example_6-xaml' />


	__Example 7__
	<snippet id='radcolorpicker-getting-started-example_7-cs' />

	<snippet id='radcolorpicker-getting-started-example_7-vb' />


* __StandardPalette__ property:			

	__Example 8__
	<snippet id='radcolorpicker-getting-started-example_8-xaml' />


	__Example 9__
	<snippet id='radcolorpicker-getting-started-example_9-cs' />

	<snippet id='radcolorpicker-getting-started-example_9-vb' />


If you prefer to use your own collection of Colors you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.		

* __StandardPaletteItemSource__ property			

	__Example 10__
	<snippet id='radcolorpicker-getting-started-example_10-xaml' />


	__Example 11__
	<snippet id='radcolorpicker-getting-started-example_11-cs' />

	<snippet id='radcolorpicker-getting-started-example_11-vb' />


* __HeaderPaletteItemSource__ property			

	__Example 12__
	<snippet id='radcolorpicker-getting-started-example_12-xaml' />


	__Example 13__
	<snippet id='radcolorpicker-getting-started-example_13-cs' />

	<snippet id='radcolorpicker-getting-started-example_13-vb' />


* __MainPaletteItemSource__ property

	__Example 14__
	<snippet id='radcolorpicker-getting-started-example_14-xaml' />


	__Example 15__
	<snippet id='radcolorpicker-getting-started-example_15-cs' />

	<snippet id='radcolorpicker-getting-started-example_15-vb' />


## Events

* __SelectedColorChanged__ __RadColorPicker__ has __SelectedColor__ property which is of __Color__ type and is used to store selected color value. Whenever a color is selected __SelectedColorChanged__ event is raised.			

* __DropDownClosed__ Raised when the SplitButton is closed.			

* __DropDownOpening__ Raised when the SplitButton is about to be opened.			

* __DropDownOpened__ Raised when the SplitButton is opened.			

* __Click__ Raised when the left part of the SplitButton is clicked.			

## Properties

* __IsDropDownOpen__ - Opens or closes the drop down content.			

* __DropDownPlacement__ - Sets the DropDownPlacement of the drop down content			

* __ContentTemplate__ - Should be used to define the custom Content of the RadColorPicker. Content property should not be used for this purpose			

* __PaletteItemsTemplate__ - Should be used in MVVM scenarios to get or set the ContentTemplate of the RadColorPaletteViewItems from the MainPalette, HeaderPalette, StandartPalette. It is not applied to RecentPalette items.			

* __ColorPropertyPath__ - the control uses this path to find the property of type __System.Windows.Media.Color__ in the DataContext of the RadColorPaletteViewItems. The behavior of this property mimics the behavior of the __ItemsControl.DisplayMemberPath__ property. 			

* __SelectedItem__ - should be used in MVVM scenarios and it holds the selected ViewModel - the DataContext of the selected RadColorPaletteViewItem.			

* __IsRecentColorsActive__ - defines wether a customized color, not existing in the MainPalette, HeaderPalette, StandartPalette or RecentPalette should be added in the RecentColorsPaletteView. If there is such a color this palette will be visible.			

* __AdditionalContent__ - can be used to add customized content under RadColorPicker control.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ColorPicker Component](https://www.telerik.com/products/wpf/colorpicker.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}


