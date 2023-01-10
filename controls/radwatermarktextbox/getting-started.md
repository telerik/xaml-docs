---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadWatermarkTextBox {{ site.framework_name }} control.
slug: watermarktextbox-getting-started
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadWatermarkTextBox Getting Started

This tutorial will walk you through the required steps for using __RadWatermarkTextBox__. 

* [Assembly References](#assembly-references)
* [Setting the WatermarkContent](#setting-watermark-content)

## Assembly References

In order to use __RadWatermarkTextBox__ in your application, you need to add reference to the following assembly.

* __Telerik.Windows.Controls__

## Adding RadWatermarkTextBox to the Project 

#### __[XAML] Example 1: Defining RadWatermarkTextBox__
{{region radwatermarktextbox-gettingstarted_0}}
	<telerik:RadWatermarkTextBox/>
{{endregion}}

#### __Figure 1: Defining RadWatermarkTextBox__
![Defining RadWatermarkTextBox](images/RadWatermarkTextBox_GettingStarted_01.png)

## Setting the WatermarkContent

> __RadWatermarkTextBox__ supports setting its __WatermarkContent__ or __WatermarkTemplate__ for visualizing the needed information. These mechanisms are covered in details in the [Features]({%slug radwatermarktextbox-features%}) topic.

#### __[XAML] Example 2: Setting the WatermarkContent__
{{region radwatermarktextbox-gettingstarted_1}}
	<telerik:RadWatermarkTextBox WatermarkContent="Please enter your name"/>
{{endregion}}

#### __Figure 2: Setting the WatermarkContent__

![Setting the WatermarkContent](images/RadWatermarkTextBox_GettingStarted_02.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#GridView/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For RadWatermarkTextBox, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radwatermarktextbox-getting-started_08}}
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				</ResourceDictionary.MergedDictionaries>
			</ResourceDictionary>
		</Application.Resources>
{{endregion}}

__Figure 3__ shows RadWatermarkTextBox with the **Windows8** theme applied.
	
#### __Figure 3: RadWatermarkTextBox with the Windows8 theme__
![Telerik {{ site.framework_name }} RadWatermarkTextBox -windows8](images/RadWatermarkTextBox-windows8.png)

## See also

* [Overview]({%slug radwatermarktextbox-overview%})
* [Features]({%slug radwatermarktextbox-features%})

