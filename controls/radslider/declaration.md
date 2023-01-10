---
title: Getting Started
page_title: Getting Started
description: This article demonstrates how to create a sample application containing a RadSlider.
slug: radslider-declaration
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadSlider Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadSlider__. 

## Assembly References

In order to use the __RadSlider__ control in your projects, you have to add references to the following assemblies:

* __Telerik.Windows.Controls__
				
## Adding RadSlider to the Project

You can add __RadSlider__ in XAML or in code as demonstrated in examples 1 and 2 respectively. 

> In order to use the RadSlider control, you need to declare the following namespace: xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

#### __[XAML] Example 1: Adding RadSlider in XAML__
{{region xaml-radslider-declaration_0}}
	<telerik:RadSlider Value="5" Minimum="0" Maximum="100" SmallChange="1" />
{{endregion}}

#### __[C#] Example 2: Adding RadSlider in code__
{{region cs-radslider-declaration_1}}
	RadSlider slider = new RadSlider();
	slider.Maximum = 100;
	slider.Minimum = 0;
	slider.Value = 5;
	slider.SmallChange = 1;
{{endregion}}

#### __[VB.NET] Example 2: Adding RadSlider in code__
{{region vb-radslider-declaration_2}}
	Dim slider As New RadSlider()
	slider.Maximum = 100
	slider.Minimum = 0
	slider.Value = 5
	slider.SmallChange = 1
{{endregion}}

#### Figure 1: Result from Examples 1 and 2
![RadSlider](images/radslider_gettingstarted.png)

> By default the __Value__ of the RadSlider will be constantly updated while the thumb is dragged. If you want the value to be updated only once, when the thumb is released, you can set the __IsDeferredDraggingEnabled__ property to __True__.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Slider/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadSlider, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radslider-getting-started_7}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadSlider with the **Windows8** theme applied.

#### __Figure 1: RadSlider with the Windows8 theme__
![RadSlider with Windows8 theme](images/radslider-setting-theme.png)

## See Also
* [Visual Structure]({%slug radslider-visual-structure%})
* [Events]({%slug radslider-events-overview%})
* [Orientation]({%slug radslider-orientation%})
* [Ticks and tick frequency]({%slug radslider-ticks-and-tick-frequency%})
