---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadProgressBar {{ site.framework_name }} control.
slug: getting_started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} ProgressBar

This tutorial will walk you through the creation of a sample application that contains __RadProgressBar__.

## Adding Telerik Assemblies Using NuGet

To use __RadProgressBar__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining RadProgressBar

To set up a RadProgressBar, set its __Minimum__, __Maximum__ and __Value__ properties. They control the value range of the control and the current position of the [progress indicator]({%slug radprogressbar-structure%}).

__Example 1: Defining RadProgressBar in XAML__
```XAML
	<telerik:RadProgressBar Minimum="-50" Maximum="50" Value="10"/>
```

__Example 2: Defining RadProgressBar in code__
```C#
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Minimum = -50;
	progressBar.Maximum = 50;
	progressBar.Value = 10;
```
```VB.NET
	Dim progressBar = New RadProgressBar()
	progressBar.Minimum = -50
	progressBar.Maximum = 50
	progressBar.Value = 10
```

![{{ site.framework_name }} RadProgressBar Minimum Maximum and Value Setup](images/radprogressbar-getting-started-0.png)

## Changing Orientation

The default orientation of RadProgressBar is horizontal. To change this, set the __Orientation__ property to __Vertical__.

__Example 3: Setting orientation in XAML__
```XAML
	<telerik:RadProgressBar Minimum="-50" Maximum="50" Value="10" 
							Width="8" Height="200"
							Orientation="Vertical"/>
```

__Example 4: Setting orientation in code__
```C#
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Minimum = -50;
	progressBar.Maximum = 50;
	progressBar.Value = 10;
	progressBar.Width = 8;
	progressBar.Height = 200;
	progressBar.Orientation = Orientation.Vertical;
```
```VB.NET
	Dim progressBar = New RadProgressBar()
	progressBar.Minimum = -50
	progressBar.Maximum = 50
	progressBar.Value = 10
	progressBar.Width = 8
	progressBar.Height = 200
	progressBar.Orientation = Orientation.Vertical
```

![{{ site.framework_name }} RadProgressBar with Vertical Orientation](images/radprogressbar-getting-started-1.png)

## Indeterminate State

This state presents a visualization of an unspecified waiting time. To enable it, set the the __IsIndeterminate__ property of RadProgressBar to __True__.

__Example 5: Enabling intereminate state in XAML__
```XAML
	<telerik:RadProgressBar IsIndeterminate="True" />
```

__Example 6: Enabling intereminate state in code__
```C#
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = true;
```
```VB.NET
	Dim progressBar = New RadProgressBar()
	progressBar.IsIndeterminate = True
```

![{{ site.framework_name }} RadProgressBar Indeterminate](images/radprogressbar-getting-started-2.gif)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#PanelBar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadProgressBar, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 7__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 7: Merge the ResourceDictionaries__  
```XAML
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
```

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadProgressBar with the **Windows8** theme applied.

#### __Figure 1: RadProgressBar with the Windows8 theme__
![RadProgressBar with Windows8 theme](images/radprogressbar-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ProgressBar Component](https://www.telerik.com/products/wpf/progressbar.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Changing Colors]({%slug radprogressbar-changing-colors%})
