---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadRating {{ site.framework_name }} control.
slug: radrating-getting-started
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadRating Getting Started

This topic helps you to quickly get started using the __RadRating__ control. It focuses on the following: 

* [Assembly References](#assembly-references)
* [Adding RadRating to the Project](#adding-radrating-to-the-project)
* [Key Properties](#key-properties)
* [Events](#events)

## Assembly References

In order to use __RadRating__ in your projects you have to add references to the following two assemblies:
 * __Telerik.Windows.Controls__
 * __Telerik.Windows.Controls.Input__

## Adding RadRating to the project

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadRating__ control in code behind and *XAML* code:

> In order to use the RadRating control, you need to declare the following namespace: xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

#### __[XAML] Example 1: Instantiating a RadRating control in Xaml__
{{region radrating-getting-started_0}}
	<telerik:RadRating />
{{endregion}}

#### __[C#] Example 2: Instantiating a RadRating control in code__
{{region radrating-getting-started_1}}
	RadRating ratingControl = new RadRating();
{{endregion}}

#### __[VB.NET] Example 2: Instantiating a RadRating control__
{{region radrating-getting-started_2}}
	Dim ratingControl As New RadRating()
{{endregion}}

#### Figure 1: RadRating
![RadRating](images/rating_default.png)

## Key Properties

 * **Value**: Gets or sets the value of the RadRating.
 * **Precision**: Gets or sets the precision of the RadRating.
 * **NumberOfItemsToGenerate**: Gets or sets the number of items to generate.
 * **IsReadOnly**: Gets or sets a value indicating whether the RadRating instance is read only.

## Events 

 * **ValueChanged**: Occurs when value of the RadRating has changed. The ValueChanged event handler receives two arguments:
  * The sender argument contains the RadRating. This argument is of type object, but can be cast to the RadRating type.
  * The event arguments are of type RoutedPropertyChangedEventArgs.
  
## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Rating/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadRating, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region RadPivotGrid-getting-started_7}}
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

__Figure 2__ shows a RadRating with the **Windows8** theme applied.

#### __Figure 2: RadRating with the Windows8 theme__
![RadRating with Windows8 theme](images/radrating-setting-theme.png)  

## See also
 * [Precision]({%slug rating-features-precision%})
 * [Populating with Data]({%slug populating-overview%})
 * [Make the RadRating read only]({%slug howto-make-readonly%})