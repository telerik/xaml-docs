---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: getting_started
tags: getting,started
publish: True
position: 2
---

# Getting Started



## 

>

In order to use __RadProgressBar__ control in your projects you have to add a reference to the __Telerik.Windows.Controls__ assembly. {% if site.site_name == 'WPF' %}

You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %}

You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

Getting started with the __RadProgressBar__ control is pretty straightforward. To begin with, you should include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadProgressBar__ control in *C#* and *XAML* code:

#### __C#__

{{region Getting_Started_0}}
	RadProgressBar progressBar = new RadProgressBar();
	{{endregion}}



#### __XAML__

{{region Getting_Started_1}}
	<telerik:RadProgressBar />
	{{endregion}}



You may need to change the __Minimum__ and __Maximum__ values of the control by setting the corresponding properties. The default values are 0 and 100.

#### __C#__

{{region Getting_Started_2}}
	progressBar.Minimum = 10;
	progressBar.Maximum = 20;
	{{endregion}}



#### __XAML__

{{region Getting_Started_3}}
	<telerik:RadProgressBar Minimum="10" Maximum="20" />
	{{endregion}}




