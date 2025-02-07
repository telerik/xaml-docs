---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started with {{ site.framework_name }} Menu

This tutorial will walk you through the creation of a `RadMenu` and will show you how to:

* [Assembly References](#assembly-references)

* [Adding RadMenu](#adding-radmenu)

* [Adding Menu Items](#adding-menu-items)

* [Populating the RadMenu with Data](#populating-the-radmenu-with-data)

* [Styles and Templates](#styles-and-templates)

* [Working with the RadMenu](#work-with-the-radmenu)

>tip Before reading this tutorial you should get familiar with the [Visual Structure]({%slug radmenu-visual-structure%}) of the `RadMenu` control.

## Assembly References

In order to use the RadMenu control in your projects you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use RadMenu when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Adding RadMenu

You can include the control in your application by either dragging it from the toolbox in Visual Studio, or by manually declaring it. Below is an example of how to include the RadMenu control in XAML code:

#### __[XAML] Adding RadMenu__

{{region xaml-radmenu-getting-started_0}}
	<Grid>
	    <telerik:RadMenu/>
	</Grid>
{{endregion}}

If you run your application now you will see an empty RadMenu that contains no items.

## Add Menu Items

You can populate the control by either adding the RadMenuItems to its `Items` collection, or by utilizing its data binding support.

#### __[XAML] Adding RadMenuItems__

{{region xaml-radmenu-getting-started_1}}
	<telerik:RadMenu>
	    <telerik:RadMenuItem Header="Item 1">
	        <telerik:RadMenuItem Header="SubItem 1" />
	        <telerik:RadMenuItem Header="SubItem 2" />
	    </telerik:RadMenuItem>
	</telerik:RadMenu>
{{endregion}}

__RadMenu with added items__

![RadMenu example result](images/menu-getting-started-result.png)

## Populating the RadMenu with Data

The scenario described in the previous sections shows the usage of static items. To learn more about these type of scenarios read [here]({%slug radmenu-populating-with-data-using-static-items%}).

However, in most of the cases you have to bind your RadMenu to a collection of business objects. Check out the following topics which describe in details how to work with dynamic data.

* [Data Binding Support Overview]({%slug radmenu-populating-with-data-data-binding-support-overview%}) - describes the various data sources for the RadMenu and shows you many tips and tricks. Read this topics in order to achieve basic knowledge about how the binding mechanism works at the RadMenu.

* [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}) - shows you how to bind the RadMenu to a collection of business objects.

* [Template and Styles Selectors]({%slug radmenu-populating-with-data-template-and-style-selectors%}) - describes the possibilities to adjust the appearance of the RadMenu's items depending on the data they hold. 

## Styles and Templates

Take a look at the [Styles and Templates]({%slug radmenu-styles-and-templates-overview%}) section which is entirely dedicated to styling and templating the RadMenu control.

## Work with the RadMenu

In order to learn how to use the RadMenu and what capabilities it holds, read the various topics that describe its features.

* [Opening Modes]({%slug radmenu-features-opening-modes%})

* [Opening and Closing Delays]({%slug radmenu-features-opening-and-closing-delays%})

* [Orientation]({%slug radmenu-features-orientation%})

 {% if site.site_name == 'Silverlight' %}
* [Animation]({%slug radmenu-features-animation%})
 {% endif %}

* [Commands]({%slug radmenu-features-commands%})

* [Checkable Items]({%slug radmenu-features-checkable-items%})

* [Separator Items]({%slug radmenu-features-separator-items%})

* [Click Modes]({%slug radmenu-features-click-modes%})

 {% if site.site_name == 'Silverlight' %}
* [Boundaries Detection]({%slug radmenu-boundaries-detection%})
 {% endif %}

* [Keyboard Navigation]({%slug radmenu-keyboard-navigation%})

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (example: __Telerik.Windows.Themes.Windows8.dll__). You can see the different themes applied in the __Theming__ examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Menu/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the `RadMenu`, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

The next example demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Merge the ResourceDictionaries__  
{{region radmenu-getting-started_6}}
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

The following image shows a `RadMenu` with the `Windows8` theme applied.

__RadMenu with the Windows8 theme__

![RadMenu with Windows8 theme](images/radmenu-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Menu Component](https://www.telerik.com/products/wpf/menu.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

 * [Overview]({%slug radmenu-overview%})

 * [Visual Structure]({%slug radmenu-visual-structure%})

 * [Populating with Data - Overview]({%slug radmenu-populating-with-data-overview%})

 * [Styles and Templates - Overview]({%slug radmenu-styles-and-templates-overview%})

 * [Events - Overview]({%slug radmenu-events-overview%})
