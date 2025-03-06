---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} ColorEditor

This article will help you get started with the Telerik RadColorEditor control

## Adding Telerik Assemblies Using NuGet

To use __RadColorEditor__ when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding __RadColorEditor__ to the Project

You can add __RadColorEditor__ manually by writing the XAML code in __Example 1__. You can also add the control by dragging it from the Visual Studio Toolbox and dropping it over the XAML view.

#### __[XAML] Example 1: Adding RadColorEditor in XAML__
{{region radcoloreditor-getting-started_0}}
	<Grid>
		<telerik:RadColorEditor x:Name="colorEditor" />
	</Grid>
{{endregion}}

## Selection

The __RadColorEditor__ is a control that displays a custom palette from which users can select a single color. The control exposes a __SelectedColor__ property, which is of type __Color__ and is used to store the selected color value.						

#### __[XAML] Example 2: Setting the SelectedColor property__
{{region radcoloreditor-getting-started_1}}
	<telerik:RadColorEditor SelectedColor="Red" />
{{endregion}}

#### __[C#] Example 2: Setting the SelectedColor property in code behind__
{{region radcoloreditor-getting-started_2}}
	RadColorEditor colorEditor = new RadColorEditor();
	colorEditor.SelectedColor = Colors.Red;
{{endregion}}

#### __[VB.NET] Example 2: Setting the SelectedColor property in code behind__
{{region radcoloreditor-getting-started_3}}
	Dim colorEditor As New RadColorEditor()
	colorEditor.SelectedColor = Colors.Red
{{endregion}}

Whenever a color is selected the __SelectedColorChanged__ event is raised:						

#### __[XAML] Example 3: Subscribing to SelectedColorChanged event__
{{region radcoloreditor-getting-started_4}}
	<telerik:RadColorEditor x:Name="colorEditor" SelectedColorChanged="colorEditor_SelectedColorChanged " />
{{endregion}}

#### __[C#] Example 4: Subscribing to SelectedColorChanged event in code behind__
{{region radcoloreditor-getting-started_5}}
	colorEditor.SelectedColorChanged += new EventHandler<ColorChangeEventArgs>(colorEditor_SelectedColorChanged);
	
	private void colorEditor1_SelectedColorChanged(object sender, ColorChangeEventArgs e)
	{
	   Color selectedColor = e.Color;
	}
{{endregion}}

#### __[VB.NET] Example 4: Subscribing to SelectedColorChanged event in code behind__
{{region radcoloreditor-getting-started-6}}
	colorEditor.SelectedColorChanged += New EventHandler(Of ColorChangeEventArgs)(colorEditor_SelectedColorChanged)
	
	Private Sub colorEditor1_SelectedColorChanged(ByVal sender As Object, ByVal e As ColorChangeEventArgs)
		Dim selectedColor As Color = e.Color
	End Sub
{{endregion}}

## Set Color Settings Panel Width

Since the R3 2021 SP1 release, RadColorEditor exposes the __ColorSettingsPanelWidth__ property for setting the width of the color settings panel area.

#### __[XAML] Example 5: Setting the ColorSettingsPanelWidth property__
{{region radcoloreditor-getting-started_7}}
	<telerik:RadColorEditor x:Name="colorEditor" ColorSettingsPanelWidth="450" />
{{endregion}}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#ColorEditor/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadColorEditor__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 6__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 6: Merge the ResourceDictionaries__  
{{region radcoloreditor-getting-started_8}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 4__ shows a __RadColorEditor__ with the **Windows8** theme applied.
	
#### __Figure 4: RadCalculator with the Windows8 theme__
![RadCalculator with Windows8 theme](images/radcoloreditor-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ColorEditor Component](https://www.telerik.com/products/wpf/coloreditor.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
 * [Overview]({%slug radcoloreditor-overview%})
 * [Structure]({%slug radcoloreditor-structure%})
