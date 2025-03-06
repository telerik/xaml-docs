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

#### __[XAML] Example 1: Adding RadListBox__

{{region xaml-radlistbox-getting-started_0}}
	<telerik:RadListBox x:Name="radListBox" Width="200" />
{{endregion}}

## Populating with Items

The control can either be populated by adding __RadListBoxItems__ to its __Items__ collection, or by its data binding support.

#### __[XAML] Example 2: Adding RadListBoxItems__
{{region xaml-radlistbox-getting-started_1}}
	<telerik:RadListBox  Width="200" x:Name="radListBox">
	    <telerik:RadListBoxItem Content="Australia" />
	    <telerik:RadListBoxItem Content="Brazil" />
	    <telerik:RadListBoxItem Content="Canada" />
	    <telerik:RadListBoxItem Content="China" />
	    <telerik:RadListBoxItem Content="England" />
	    <telerik:RadListBoxItem Content="Germany" />
	</telerik:RadListBox>
{{endregion}}

#### __[XAML] Example 3: Binding RadListBox

{{region xaml-radlistbox-getting-started_2}}
	<telerik:RadListBox x:Name="radListBox" Width="200" 
						ItemsSource="{Binding Items}"/>
{{endregion}}

>More detailed information on how to populate __RadListBox__ with some data you can found [here]({%slug radlistbox-populating-with-data-overview%}).

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Fluent.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#ListBox/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadListBox__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radlistbox-getting-started_2}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/>				
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

__Figure 4__ shows __RadMap__ with the **Fluent** theme applied.
	
#### __Figure 4: RadListBox with the Fluent theme__
![Telerik {{ site.framework_name }} ListBox-fluent](images/radlistbox-fluent.png)

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
