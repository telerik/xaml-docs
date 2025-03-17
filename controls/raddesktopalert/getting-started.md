---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} DesktopAlert

This topic will walk you through the creating of __RadDesktopAlert__.    

## Adding Telerik Assemblies Using NuGet

To use __RadDesktopAlert__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding RadDesktopAlert in the Project

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create __RadDesktopAlert__ in code behind:

#### __[C#]  Creating RadDesktopAlert__

{{region cs-raddesktopalert-getting-started_0}}
	var alert = new RadDesktopAlert();
	alert.Header = "MAIL NOTIFICATION";
	alert.Content = "Hello, Here are two things that we noticed today on our daily meeting.";
	alert.ShowDuration = 3000;
{{endregion}}

#### __[VB]  Creating RadDesktopAlert__

{{region vb-raddesktopalert-getting-started_0}}
	Dim alert = New RadDesktopAlert()
	alert.Header = "MAIL NOTIFICATION"
	alert.Content = "Hello, Here are two things that we noticed today on our daily meeting."
	alert.ShowDuration = 3000
{{endregion}}

>__RadDesktopAlert__ is designed to work with [__RadDesktopAlertManager__]({%slug raddesktopalert-desktop-alert-manager%}). If just placed in XAML it won't be completely functional.

In order to visualize it, a new instance of __RadDesktopAlertManager__ should be created and the already declared above __RadDesktopAlert__ should be passed as a parameter to its __ShowAlert__ method:

#### __[C#]  Showing RadDesktopAlert__

{{region cs-raddesktopalert-getting-started_1}}
	RadDesktopAlertManager manager = new RadDesktopAlertManager();
	manager.ShowAlert(alert);
{{endregion}}

#### __[VB]  Showing RadDesktopAlert__

{{region vb-raddesktopalert-getting-started_1}}
	Dim manager As New RadDesktopAlertManager()
	manager.ShowAlert(alert)
{{endregion}}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadDesktopAlert__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 1__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 1: Merge the ResourceDictionaries__  
{{region raddesktopalert-getting-started_6}}
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

__Figure 1__ shows a __RadDesktopAlert__ with the **Windows8** theme applied.

#### __Figure 1: RadDesktopAlert with the Windows8 theme__
![RadDesktopAlert with Windows8 theme](images/raddesktopalert-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DesktopAlert Component](https://www.telerik.com/products/wpf/desktopalert.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

 * [Overview]({%slug raddesktopalert-overview%})
 * [Visual Structure]({%slug raddesktopalert-visual-structure%}) 
 * [Desktop Alert Manager]({%slug raddesktopalert-desktop-alert-manager%})
