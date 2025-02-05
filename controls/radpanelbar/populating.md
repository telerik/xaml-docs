---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: radpanelbar-populating
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadPanelBar__. 

* [Assembly References](#assembly-references)
* [Adding RadPanelBar to the Project](#adding-radpanelbar-to-the-project)
* [Declaratively populating the RadPanelBar control Items collection](#declaratively-populating-the-radpanelbar-control-items-collection)
* [Databinding the RadPanelBar control](#databinding-the-radpanelbar-control)

## Assembly References

In order to use __RadPanelBar__ control in your projects you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
{% if site.site_name == 'WPF' %}
* __Telerik.Windows.Data__
{% endif %}

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadPanelBar__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Adding RadPanelBar to the Project

**Example 1** demonstrates how you can add a RadPanelBar in xaml.

#### __[XAML] Example 1: RadPanelBar with statically declared items in xaml__
{{region xaml-radpanelbar-populating_0}}
	<telerik:RadPanelBar>
	    <telerik:RadPanelBarItem Header="Item 1" />
	    <telerik:RadPanelBarItem Header="Item 2" />
	    <telerik:RadPanelBarItem Header="Item 3" />
	</telerik:RadPanelBar>
{{endregion}}

#### __Figure 1: Result from Example 1 in Office2016 Theme__
![RadPanelBar Getting Started](images/panelbar_getting_started.png)

## Declaratively Populating the Items Collection of the RadPanelBar Control

**Example 2** demonstrates how you can add __RadPanelBarItems__ directly to the __Items__ collection of the RadPanelBar in code behind:			

#### __[C#] Example 2: Adding RadPanelBarItems in code__
{{region cs-radpanelbar-populating_2}}
	RadPanelBar myPanelBar = new RadPanelBar();
	RadPanelBarItem item1 = new RadPanelBarItem() { Header = "Item 1" };
	RadPanelBarItem item2 = new RadPanelBarItem() { Header = "Item 2" };
	RadPanelBarItem item3 = new RadPanelBarItem() { Header = "Item 3" };
	myPanelBar.Items.Add(item1);
	myPanelBar.Items.Add(item2);
	myPanelBar.Items.Add(item3);
{{endregion}}

#### __[VB.NET] Example 2: Adding RadPanelBarItems in code__
{{region vb-radpanelbar-populating_3}}
	Dim myPanelBar As New RadPanelBar()
	Dim item1 As New RadPanelBarItem() With {
	.Header = "Item 1"
			}
	Dim item2 As New RadPanelBarItem() With {
	.Header = "Item 2"
			}
	Dim item3 As New RadPanelBarItem() With {
	.Header = "Item 3"
			}
	myPanelBar.Items.Add(item1)
	myPanelBar.Items.Add(item2)
	myPanelBar.Items.Add(item3)
{{endregion}}

## Databinding the RadPanelBar Control		  

**RadPanelBar** can be also be bound to a collection of objects. You can learn more about this in the [Bind to Object Data]({%slug radpanelbar-object-data%}) article in our documentation.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#PanelBar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadPanelBar, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radpanelbar-getting-started_4}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 2__ shows a RadPanelBar with the **Windows8** theme applied.

#### __Figure 2: RadPanelBar with the Windows8 theme__
![RadPanelBar with Windows8 theme](images/radpanelbar-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF PanelBar Component](https://www.telerik.com/products/wpf/panelbar.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Events]({%slug radpanelbar-events-overview%})
* [How to Display Hierarchical Data]({%slug howto-display-hierarchical-data%})