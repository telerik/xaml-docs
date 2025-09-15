---
title: Getting Started
page_title: Getting Started
description: Check our &quot;RadCalculator&quot; documentation article for the RadCalculator {{ site.framework_name }} control.
slug: radcalculator-gettingstarted
tags: radcalculator
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} Calculator

This tutorial will walk your through the creation of a sample application that contains `RadCalculator`.		  

## Adding Telerik Assemblies Using NuGet

To use `RadCalculator` when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
		
## Adding RadCalculator to the Project

__Defining RadCalculator__  
```XAML		
		<telerik:RadCalculator />		
```

#### __RadCalculator example__
![A picture showing {{ site.framework_name }} RadCalculator](images/RadCalculator-Basic.png)

The calculated value can be accessed via the `Value` property of `RadCalculator`.

The current history can be accessed via the `History` property of `RadCalculator`.

## Performing Calculations

`RadCalculator` allows you to perform all the basic calculations - __addition, subtraction, multiplication, division__. All of them can be executed either by the corresponding buttons or through the keyboard. Once a particular operation is executed, the history is updated accordingly.

__Basic Calculations with RadCalculator__  

![A picture showing {{ site.framework_name }} RadCalculator with basic calculations](images/RadCalculator-BasicCalculations.png)

`RadCalculator` allows you to perform also a couple of more complex calculations - __square root, reciprocal, percent, negate__. All of them can be executed either by the corresponding buttons or through the keyboard. 

__Complex Calculations with RadCalculator__  

![A picture showing {{ site.framework_name }} RadCalculator with complex calculations](images/RadCalculator-ComplexCalculations.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Material.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Calculator/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the `RadCalculator`, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 2__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Merge the ResourceDictionaries__  
```XAML
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Material;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
```

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.
	
__RadCalculator with the Material theme__  

![{{ site.framework_name }} RadCalculator with Material theme](images/calculator-material-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Calculator Component](https://www.telerik.com/products/wpf/calculator.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Calculator Picker]({%slug radcalculatorpicker-gettingstarted%})
