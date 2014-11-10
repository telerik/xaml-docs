---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radrating-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



## 

Getting started with the __RadRating__ control is pretty straightforward.

>In order to use __RadRating__ in your projects you have to add references to the following two assemblies:<br/>*__Telerik.Windows.Controls__<br/>* __Telerik.Windows.Controls.Input__<br/>{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}{% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadRating__ control in code behind and *XAML* code:

#### __XAML__

{{region radrating-getting-started_0}}
	<xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"/>
	
	...
	<telerik:RadRating />
	{{endregion}}



#### __C#__

{{region radrating-getting-started_1}}
	RadRating ratingControl = new RadRating();
	{{endregion}}



#### __VB.NET__

{{region radrating-getting-started_2}}
	Dim ratingControl As New RadRating()
	{{endregion}}



![](images/rating_default.png)
