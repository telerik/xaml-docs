---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} ListBox

This tutorial will walk you through the required steps for using __RadListBox__. 

## Adding Telerik Assemblies Using NuGet

To use __RadListBox__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls.dll__

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadListBox__ control in XAML code:

## Adding RadListBox to the Project

__Example 1: Adding RadListBox__

```XAML
	<telerik:RadListBox x:Name="radListBox" Width="200" />
```

## Populating with Items

The control can either be populated by adding __RadListBoxItems__ to its __Items__ collection, or by its data binding support.

__Example 2: Adding RadListBoxItems__
```XAML
	<telerik:RadListBox  Width="200" x:Name="radListBox">
	    <telerik:RadListBoxItem Content="Australia" />
	    <telerik:RadListBoxItem Content="Brazil" />
	    <telerik:RadListBoxItem Content="Canada" />
	    <telerik:RadListBoxItem Content="China" />
	    <telerik:RadListBoxItem Content="England" />
	    <telerik:RadListBoxItem Content="Germany" />
	</telerik:RadListBox>
```

#### __[XAML] Example 3: Binding RadListBox

```XAML
	<telerik:RadListBox x:Name="radListBox" Width="200" 
						ItemsSource="{Binding Items}"/>
```

>More detailed information on how to populate __RadListBox__ with some data you can found [here]({%slug radlistbox-populating-with-data-overview%}).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ListBox Component](https://www.telerik.com/products/wpf/listbox.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

* [Overview]({%slug radlistbox-overview%})
* [Data Binding Support Overview]({%slug radlistbox-populating-with-data-binding-support-overview%})
* [Drag and Drop]({%slug radlistbox-features-dragdrop%})
* [Selection]({%slug radlistbox-features-selection%})
* [Auto Complete]({%slug radlistbox-features-autocomplete%})
