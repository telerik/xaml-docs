---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDataBar {{ site.framework_name }} control.
slug: databar-getting-started2
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the required steps for using __RadDataBar__. 

## Assembly References

In order to add __RadDataBar__ in your application, you need to add references to the following assemblies:

* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

## Adding RadDataBar to the Project

#### __[XAML] Example 1: Defining RadDataBar Declaratively__
{{region raddatabar-gettingstarted_0}}
	     <telerik:RadDataBar Height="30" 
                            BorderBrush="Gray"
							BorderThickness="1"/>
{{endregion}}

#### __Figure 1: Adding RadDataBar__
![Adding RadDataBar](images/RadDataBar_GettingStarted_01.png)

By default the __Value__ property of the control will have a value of __0__. It can be bound to a property of the business model so the required data is displayed. This is covered in details in the [Data Binding]({%slug raddatabar-databinding%}) topic.

## Displaying collection of Bars

__RadDataBar__ is intended to display a single value. When you need to display a collection of values, you can use the __RadStackedDataBar__ and __RadStacked100DataBar__ controls. They will both generate a bar for each value present in its __ItemsSource__. 

The difference between the controls is how the sizes of the bars are calculated. The size of each bar in the **RadStackedDataBar** is calculated in accordance to the set **Minimum** and **Maximum**. On the other hand, each bar's size in the **RadStacked100DataBar** corresponds to the percent of the bar's value compared to the sum of all values in the stack.

More information can be found in the [Data Binding]({%slug raddatabar-databinding%}) article.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#DataBar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadDataBar__, you will need to merge the following resources:

	* __Telerik.Windows.Controls.DataVisualization__

__Example 2__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 2: Merge the ResourceDictionaries__  
{{region xaml-raddatabar-gettingstarted_2}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.DataVisualization.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 2__ shows a __RadDataBar__ with the **Windows8** theme applied.
	
#### __Figure 2: RadDataBar with the Windows8 theme__
![RadDataBar with Windows8 theme](images/raddatabar-setting-theme.png)

## See Also

* [Properties]({%slug raddatabar-main_properties%})
* [Data Binding]({%slug raddatabar-databinding%})

