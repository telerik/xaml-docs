---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with WPF DateRangePicker

This tutorial will walk you through the creation of a sample application that contains `RadDateRangePicker`. Before that you may want to get familiar with the [Visual Structure]({%slug raddaterangepicker-visual-structure%}) article.

## Adding Telerik Assemblies Using NuGet

To use `RadDateRangePicker` when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

## Adding RadDateRangePicker to the Project

The following example shows how to define `RadDateRangePicker` in a XAML page. 

#### __[XAML] Adding RadDateRangePicker in XAML__
{{region raddaterangepicker-getting-started-0}}
	<telerik:RadDateRangePicker />
{{endregion}}

![A picture showing RadDateRangePicker for WPF in Getting Started setup](images/raddaterangepicker-getting-started-0.png)

To get started with the control you don't need to set any properties. In case you need to manually set the selected range, use the `StartDate` and `EndDate` of `RadDateRangePicker`. The properties can be set directly or via data binding.

#### __[XAML] Setting the selection__
{{region raddaterangepicker-getting-started-1}}
	<telerik:RadDateRangePicker StartDate="2024/1/19" EndDate="2024/2/5" />
{{endregion}}

## Showing the Drop Down Manually

The drop down with the calendars can be manually toggled via the `IsDropDownOpen` property of `RadDateRangePicker`.

#### __[C#] Showing the drop down programmatically__
{{region raddaterangepicker-getting-started-2}}
	this.dateRangePicker.IsDropDownOpen = true;
{{endregion}}

## Read-Only Dates Text Input

To make the date range text input area read-only, set the `IsReadOnly` property of `RadDateRangePicker` to `True`.

#### __[C#] Making the text area read-only__
{{region raddaterangepicker-getting-started-2}}
	<telerik:RadDateRangePicker IsReadOnly="True" />
{{endregion}}

![A picture showing a read-only RadDateRangePicker for WPF](images/raddaterangepicker-getting-started-1.png)

## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DateTimePicker Component](https://www.telerik.com/products/wpf/daterangepicker.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
