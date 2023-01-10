---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadWizard {{ site.framework_name }} control.
slug: wizard-getting-started
tags: getting,started
published: True
position: 2
---

# {{ site.framework_name }} RadWizard Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadWizard__ control.

* [Assembly References](#assembly-references)
* [Adding RadWizard to the Project](#adding-radwizard-to-the-project)
* [Adding pages to RadWizard](#adding-pages-to-radwizard)

## Assembly References

In order to use the __RadWizard__ control in your projects you have to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__  
{% if site.site_name == 'WPF' %} 
* __Telerik.Windows.Data__  
{% endif %} 

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding RadWizard to the Project

You can add __RadWizard__ in XAML or in code. You can also add the control by dragging it from the {% if site.framework_name == 'WPF' %}[Toolbox]({%slug installation-adding-to-vs-2015-toolbox-wpf%}){% else %}[Toolbox]({%slug installation-adding-to-vs-2015-toolbox-sl%}){% endif %}. 

#### __[XAML] Example 1: Adding a RadWizard in XAML__
{{region xaml-radwizard-getting-started-2}}
	 <telerik:RadWizard x:Name="wizard" />
{{endregion}}

>In order to use __RadWizard__ you should define the following namespace:
__xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__

#### __[C#] Example 2: Adding a RadWizard in code__
{{region cs-radwizard-getting-started-0}}
	 RadWizard wizard = new RadWizard();
{{endregion}}

#### __[VB.NET] Example 2: Adding a RadWizard in code__
{{region vb-radwizard-getting-started-1}}
	Private wizard As RadWizard = New RadWizard()
{{endregion}}
 
## Adding pages to RadWizard

 To add pages to __RadWizard__ you can use its __WizardPages__ collection, which consists of [__WizardPage__]({%slug wizard-pages%}) elements. Here is an example of defining a page in code and in xaml: 

#### __[XAML] Example 3: Adding a WizardPage in XAML__
{{region xaml-radwizard-getting-started-5}}
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage Content="My Wizard Page Content" />
		</telerik:RadWizard.WizardPages>			
	</telerik:RadWizard>
{{endregion}}

#### __[C#] Example 4: Adding WizardPages in code__
{{region cs-radwizard-getting-started-3}}
	 wizard.WizardPages.Add(new WizardPage() { Content = "My Wizard Page Content" });
{{endregion}}

#### __[VB.NET] Example 4: Adding WizardPages in code__
{{region vb-radwizard-getting-started-4}}
	 wizard.WizardPages.Add(New WizardPage() With {.Content ="My Wizard Page Content"})
{{endregion}}

#### __Figure 1: RadWizard with WizardPage__
![{{ site.framework_name }} RadWizard RadWizard with WizardPage](images/GettingStarted-WizardPage.png)

>For more information on how to control the visualization of the buttons, check out the [Wizard Buttons]({%slug wizard-buttons%}) article.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#GridView/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadWizard__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 5__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 5: Merge the ResourceDictionaries__  
{{region radtreeview-getting-started_08}}
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

__Figure 2__ shows __RadWizard__ with the **Windows8** theme applied.
	
#### __Figure 2: RadWizard with the Windows8 theme__
![Telerik {{ site.framework_name }} Wizard-windows8](images/RadWizard-windows8.png)

## See also
* [Wizard Pages]({%slug wizard-pages%})
* [Navigation]({%slug wizard-navigation%})
* [Commands]({%slug wizard-features-commands%})
