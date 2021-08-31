---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadCalendar {{ site.framework_name }} control.
slug: radcalendar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadCalendar__. 

## Assembly References

In order to use the __RadCalendar__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

## Adding RadCalendar to the Project

**Example 1** demonstrates how you can add a RadCalendar in xaml.

#### __[XAML] Example 1: RadCalendar definition__
{{region xaml-radcalendar-getting-started_0}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center"  />
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office2016 Theme__
![RadCalendar Getting Started](images/RadCalendar_GettingStarted.png)

## Changing the number of shown months

You can control how many months are shown by setting the **Columns** property of the RadCalendar. Its default value is **one** and the maximum is **four**. **Example 2** demonstrates how you can achieve that.

#### __[XAML] Example 2: RadCalendar showing four months__
{{region xaml-radcalendar-getting-started_1}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center" Columns="4" ViewsHeaderVisibility="Visible"/>
{{endregion}}

#### __Figure 2: Result from Example 2 in the Office2016 Theme__
![RadCalendar with four months](images/RadCalendar_Columns.png)

## Hide Week Numbers and Weekdays

You have the option to hide the week numbers, as well as the weekdays. This can be done by setting the **AreWeekNumbersVisible** and **AreWeekNamesVisible** properties to **False**. **Example 3** demonstrates this:

#### __[XAML] Example 3: RadCalendar without week numbers and weekdays__
{{region xaml-radcalendar-getting-started_2}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center" AreWeekNumbersVisible="False" AreWeekNamesVisible="False" />
{{endregion}}

#### __Figure 3: Result from Example 3 in the Office2016 Theme__
![RadCalendar without week numbers and weekdays](images/RadCalendar_HideWeekNumbersAndDays.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Fluent.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Calendar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadCalendar__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
    * __Telerik.Windows.Controls.Input__
	
__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region xaml-radcalendar-getting-started_5}}
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

__Figure 4__ shows a __RadCalendar__ with the **Fluent** theme applied.
	
#### __Figure 4: RadCalendar with the Fluent theme__
![RadCalendar with Fluent theme](images/radcalendar-setting-theme.png)


## See Also

* [Calendar Basics]({%slug radcalendar-basics%})
* [Key Properties]({%slug radcalendar-key-properties%})
* [Globalization]({%slug radcalendar-globalization%})
* [How to Customize the Calendar Buttons]({%slug radcalendar-styling-and-appearance-daybuttonstyleselector%})