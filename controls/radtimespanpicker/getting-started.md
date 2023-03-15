---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadTimeSpanPicker {{ site.framework_name }} control.
slug: radtimespanpicker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} TimeSpanPicker

This topic will walk you through the creating of  __RadTimeSpanPicker__.    

>In order to use __RadTimeSpanPicker__ in your project you have to add references to the following two assemblies:
> * Telerik.Windows.Controls.dll
> * Telerik.Windows.Controls.Input.dll

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create __RadTimeSpanPicker__ in XAML

#### __[XAML]Example 1: Creating RadTimeSpanPicker__

{{region xaml-radtimespanpicker-getting-started_0}}
	<telerik:RadTimeSpanPicker GenerateDefaultComponents="True"/>
{{endregion}}

You can also create __RadTimeSpanPicker__ in code-behind:

#### __[C#]Example 2:  Creating RadTimeSpanPicker in code__

{{region cs-radtimespanpicker-getting-started_0}}
	RadTimeSpanPicker timeSpanPicker = new RadTimeSpanPicker();
	timeSpanPicker.GenerateDefaultComponents = true;
{{endregion}}

#### __[VB]Example 2:  Creating RadTimeSpanPicker in code__

{{region vb-radtimespanpicker-getting-started_0}}
	Dim timeSpanPicker As New RadTimeSpanPicker()
	timeSpanPicker.GenerateDefaultComponents = True
{{endregion}}

By setting the __GenerateDefaultComponents__ property to __True__ the control will use the default components for hours, minutes and seconds. If you need to visualize some of the other built-in components or a custom component of your own you could add them as shown below to the TimeSpanComponents collection:

#### __[XAML]Example 3: Adding TimeSpanComponents__

{{region xaml-radtimespanpicker-getting-started_1}}
	<telerik:RadTimeSpanPicker>
	    <telerik:RadTimeSpanPicker.TimeSpanComponents>
		<telerik:DayTimeSpanComponent/>
		<telerik:HourTimeSpanComponent/>
		<telerik:MinuteTimeSpanComponent/>
		<telerik:SecondTimeSpanComponent/>
		<telerik:MillisecondTimeSpanComponent/>
	    </telerik:RadTimeSpanPicker.TimeSpanComponents>
	</telerik:RadTimeSpanPicker>
{{endregion}}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadTimeSpanPicker, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 4__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 4: Merge the ResourceDictionaries__  
{{region radtimepicker-getting-started_4}}
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

__Figure 1__ shows a RadTimeSpanPicker with the **Windows8** theme applied.

#### __Figure 1: RadTimeSpanPicker with the Windows8 theme__
![RadTimeSpanPicker with Windows8 theme](images/RadTimeSpanPicker-setting-theme.png)

## See Also 
 * [Overview]({%slug radtimespanpicker-overview%}) 
 * [Visual Structure]({%slug radtimespanpicker-visual-structure%})
