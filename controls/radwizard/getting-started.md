---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: wizard-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains the __RadWizard__ control.

>In order to use the __RadWizard__ control in your projects you have to add references to the following assemblies:
>* Telerik.Windows.Controls
>*	Telerik.Windows.Controls.Navigation
>{% if site.site_name == 'Silverlight' %}{% endif %}{% if site.site_name == 'WPF' %}*	Telerik.Windows.Data{% endif %} 
>
>You can find more info {% if site.site_name == 'Silverlight' %}[here]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[here]({%slug installation-installing-controls-dependencies-wpf%}){% endif %}  .

## Adding RadWizard to the Project
You can add __RadWizard__ in XAML or in code. You can also add the control by dragging it from the [Toolbox]({%slug installation-adding-to-vs-2017-toolbox%}). 

#### __[C#] Example 1: Adding a RadWizard in code__
{{region cs-radwizard-getting-started-0}}
	 RadWizard wizard = new RadWizard();
{{endregion}}

#### __[VB.NET] Example 1: Adding a RadWizard in code__
{{region vb-radwizard-getting-started-1}}
	 Private wizard As RadWizard = New RadWizard()
{{endregion}}

#### __[XAML]Example 2: Adding a RadWizard in XAML__
{{region xaml-radwizard-getting-started-2}}
	 <telerik:RadWizard x:Name="wizard" />
{{endregion}}

>In order to use __RadWizard__ you should define the following namespace:
__xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__
 
## Adding pages to RadWizard
 To add pages to __RadWizard__ you can use its __WizardPages__ collection, which consists of [__WizardPage__]({%slug wizard-pages%}) elements. Here is an example of defining a page in code and in xaml: 

#### __[C#] Example 3: Adding WizardPages in code__
{{region cs-radwizard-getting-started-3}}
	 wizard.WizardPages.Add(new WizardPage() { Content = "My Wizard Page Content" });
{{endregion}}

#### __[VB.NET] Example 3: Adding WizardPages in code__
{{region vb-radwizard-getting-started-4}}
	 wizard.WizardPages.Add(New WizardPage() With {.Content ="My Wizard Page Content"})
{{endregion}}

#### __[XAML]Example 4: Adding a WizardPage in XAML__
{{region xaml-radwizard-getting-started-5}}
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage Content="My Wizard Page Content" />
		</telerik:RadWizard.WizardPages>			
	</telerik:RadWizard>
{{endregion}}

#### __Figure 1: RadWizard with WizardPage__
![](images/GettingStarted-WizardPage.png)
>For more information on how to control the visualization of the buttons, check out the [Wizard Buttons]({%slug wizard-buttons%}) article.

# See also
* [Wizard Pages]({%slug wizard-pages%})

* [Navigation]({%slug wizard-navigation%})

* [Commands]({%slug wizard-features-commands%})