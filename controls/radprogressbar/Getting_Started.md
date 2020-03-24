---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadProgressBar {{ site.framework_name }} control.
slug: getting_started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadProgressBar__.

## Assembly References

In order to use __RadProgressBar__, you will need to add references to the __Telerik.Windows.Controls__ dll.

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining RadProgressBar

To set up a RadProgressBar, set its __Minimum__, __Maximum__ and __Value__ properties. They control the value range of the control and the current position of the [progress indicator]({%slug radprogressbar-structure%}).

#### __[XAML] Example 1: Defining RadProgressBar in XAML__
{{region radprogressbar-getting-started-0}}
	<telerik:RadProgressBar Minimum="-50" Maximum="50" Value="10"/>
{{endregion}}

#### __[C#] Example 2: Defining RadProgressBar in code__
{{region radprogressbar-getting-started-1}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Minimum = -50;
	progressBar.Maximum = 50;
	progressBar.Value = 10;
{{endregion}}

#### __[VB.NET] Example 2: Defining RadProgressBar in code__
{{region radprogressbar-getting-started-2}}
	Dim progressBar = New RadProgressBar()
	progressBar.Minimum = -50
	progressBar.Maximum = 50
	progressBar.Value = 10
{{endregion}}

![](images/radprogressbar-getting-started-0.png)

## Changing Orientation

The default orientation of RadProgressBar is horizontal. To change this, set the __Orientation__ property to __Vertical__.

#### __[XAML] Example 3: Setting orientation in XAML__
{{region radprogressbar-getting-started-3}}
	<telerik:RadProgressBar Minimum="-50" Maximum="50" Value="10" 
							Width="8" Height="200"
							Orientation="Vertical"/>
{{endregion}}

#### __[C#] Example 4: Setting orientation in code__
{{region radprogressbar-getting-started-4}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Minimum = -50;
	progressBar.Maximum = 50;
	progressBar.Value = 10;
	progressBar.Width = 8;
	progressBar.Height = 200;
	progressBar.Orientation = Orientation.Vertical;
{{endregion}}

#### __[VB.NET] Example 4: Setting orientation in code__
{{region radprogressbar-getting-started-5}}
	Dim progressBar = New RadProgressBar()
	progressBar.Minimum = -50
	progressBar.Maximum = 50
	progressBar.Value = 10
	progressBar.Width = 8
	progressBar.Height = 200
	progressBar.Orientation = Orientation.Vertical
{{endregion}}

![](images/radprogressbar-getting-started-1.png)

## Indeterminate State

This state presents a visualization of an unspecified waiting time. To enable it, set the the __IsIndeterminate__ property of RadProgressBar to __True__.

#### __[XAML] Example 5: Enabling intereminate state in XAML__
{{region radprogressbar-getting-started-6}}
	<telerik:RadProgressBar IsIndeterminate="True" />
{{endregion}}

#### __[C#] Example 6: Enabling intereminate state in code__
{{region radprogressbar-getting-started-7}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = true;
{{endregion}}

#### __[VB.NET] Example 6: Enabling intereminate state in code__
{{region radprogressbar-getting-started-8}}
	Dim progressBar = New RadProgressBar()
	progressBar.IsIndeterminate = True
{{endregion}}

![](images/radprogressbar-getting-started-2.gif)

## See Also  
* [Changing Colors]({%slug radprogressbar-changing-colors%})
