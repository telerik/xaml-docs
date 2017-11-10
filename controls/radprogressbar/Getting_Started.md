---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: getting_started
tags: getting,started
published: True
position: 2
---

# Getting Started

>In order to use __RadProgressBar__ control in your projects you have to add a reference to the __Telerik.Windows.Controls__ assembly.<br/>{% if site.site_name == 'WPF' %}You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

Getting started with the __RadProgressBar__ control is pretty straightforward. To begin with, you should include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadProgressBar__ control in *C#*, *VB.NET* and *XAML* code:

#### __[C#] Example 1: Create RadProgressBar in code__
{{region cs-Getting_Started_0}}
	RadProgressBar progressBar = new RadProgressBar();
{{endregion}}

#### __[VB.NET] Example 1: Create RadProgressBar in code__
{{region vb-Getting_Started_1}}
	Dim progressBar As New RadProgressBar()
{{endregion}}

#### __[XAML] Example 2: Create RadProgressBar in XAML__
{{region xaml-Getting_Started_2}}
	<telerik:RadProgressBar />
{{endregion}}

You may need to change the __Minimum__ and __Maximum__ values of the control by setting the corresponding properties. The default values are 0 and 100.

#### __[C#] Example 3: Set Minimum and Maximum properties in code__
{{region cs-Getting_Started_3}}
	progressBar.Minimum = 10;
	progressBar.Maximum = 20;
{{endregion}}

#### __[VB.NET] Example 3: Set Minimum and Maximum properties in code__
{{region vb-Getting_Started_4}}
	progressBar.Minimum = 10
	progressBar.Maximum = 20
{{endregion}}

#### __[XAML] Example 4: Set Minimum and Maximum properties in XAML__
{{region xaml-Getting_Started_5}}
	<telerik:RadProgressBar Minimum="10" Maximum="20" />
{{endregion}}

You can fill the RadProgressBar during runtime by changing its __Value__ property.

#### __[C#] Example 5: Change RadProgressBar value__
{{region cs-Getting_Started_6}}
	progressBar.Value += 5;
{{endregion}}

#### __[VB.NET] Example 5: Change RadProgressBar value__
{{region cs-Getting_Started_7}}
	progressBar.Value += 5
{{endregion}}