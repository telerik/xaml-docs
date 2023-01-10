---
title: RadCalculator
page_title: RadCalculator
description: Check our &quot;RadCalculator&quot; documentation article for the RadCalculator {{ site.framework_name }} control.
slug: radcalculator-gettingstarted
tags: radcalculator
published: True
position: 0
---

# {{ site.framework_name }} RadCalculator Getting Started

This tutorial will walk your through the creation of a sample application that contains __RadCalculator__ and will show you how to:
		  
* Use RadCalculator in your project

* Perform basic calculations

* Perform more complicated calculations

For the purpose of this example, you will need to create an empty {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF {% endif %}Application project and open it in Visual Studio.

## Assembly References

In order to use __RadCalculator__ in your projects, you have to add reference to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
		  
## Adding RadCalculator to the Project

#### __[XAML] Example 1: Defining RadCalculator__

{{region xaml-radcalculator-getting-started_0}}

	<UserControl x:Class="RadCalculator.MainPage"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:my="clr-namespace:RadCalculator"
	             mc:Ignorable="d" d:DesignHeight="700" d:DesignWidth="700">   
	  
		<Grid x:Name="LayoutRoot" Background="White" >
			<telerik:RadCalculator />		
	    </Grid>
	</UserControl>
	{{endregion}}

Now if you run the application, you will have a RadCalculator:

#### __Figure 1: Defining RadCalculator__
![Rad Calculator-Basic](images/RadCalculator-Basic.png)

## Performing Basic Calculations with RadCalculator

__RadCalculator__ allows you to perform all the basic calculations - addition, subtraction, multiplication, division. All of them can be executed either by the corresponding buttons or through the keyboard. Once a particular operation is executed, the history is updated accordingly:

#### __Figure 2: Basic Calculations with RadCalculator__
![Rad Calculator-Basic Calculations](images/RadCalculator-BasicCalculations.png)

## Performing Complex Calculations with RadCalculator

__RadCalculator__ allows you to perform a couple of more complex calculations - square root, reciprocal, percent, negate. All of them can be executed either by the corresponding buttons or through the keyboard. Once a particular operation is executed, the history is updated accordingly:

#### __Figure 3: Complex Calculations with RadCalculator__
![Rad Calculator-Complex Calculations](images/RadCalculator-ComplexCalculations.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Fluent.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Calculator/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadCalculator__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 2__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 2: Merge the ResourceDictionaries__  
{{region xaml-radcalculator-getting-started_5}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 4__ shows a __RadCalculator__ with the **Fluent** theme applied.
	
#### __Figure 4: RadCalculator with the Fluent theme__
![RadCalculator with Fluent theme](images/radcalculator-setting-theme.png)

## See Also

* [RadCalculatorPicker Getting Started]({%slug radcalculatorpicker-gettingstarted%})
