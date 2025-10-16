---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} Menu

This topic will walk you through the creating of __RadRadialMenu__.    

## Adding Telerik Assemblies Using NuGet

To use __RadRadialMenu__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

## RadRadialMenu as a Normal Menu

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the RadRadialMenu control in code behind and XAML code: 

__Creating RadRadialMenu__

```XAML
	<telerik:RadRadialMenu>
	    <telerik:RadRadialMenuItem Header="Item 1" />
	    <telerik:RadRadialMenuItem Header="Item 2" />
	    <telerik:RadRadialMenuItem Header="Item 3" />
	</telerik:RadRadialMenu>
```

where *telerik* namespace is defined like this:        



```XAML
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
```

__Creating RadRadialMenu with code__

```C#
	var radialMenu = new RadRadialMenu();
	
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 1" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 2" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 3" });
```

## RadRadialMenu as a Context Menu

Here is a simple example demonstrating how to declare a __RadRadialMenu__ instance as a context menu for a TextBox using its __ShowEventName__ and __HideEventName__ properties.

__RadialMenu as a ContextMenu__

```XAML
	<TextBox Text="Some Text">
	    <telerik:RadRadialMenu.RadialContextMenu>
	        <telerik:RadRadialMenu ShowEventName="GotFocus" HideEventName="LostFocus">
	            <telerik:RadRadialMenuItem Header="Item 1" />
	            <telerik:RadRadialMenuItem Header="Item 2" />
	            <telerik:RadRadialMenuItem Header="Item 3" />
	        </telerik:RadRadialMenu>
	    </telerik:RadRadialMenu.RadialContextMenu>
	</TextBox>
```

For further reference check [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%}) topic.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#RadialMenu/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadRadialMenu, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 1__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 1: Merge the ResourceDictionaries__  
```XAML
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
```

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadRadialMenu with the **Windows8** theme applied.

#### __Figure 1: RadRadialMenu with the Windows8 theme__
![RadRadialMenu with Windows8 theme](images/radradialmenu-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF RadialMenu Component](https://www.telerik.com/products/wpf/radialmenu.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

 * [Getting Started]({%slug radradialmenu-getting-started%})

 * [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%})
