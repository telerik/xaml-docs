---
title: Getting Started
page_title: Getting Started
description: Get started with the Telerik RadStepProgressBar control.
slug: stepprogressbar-getting-started
tags: get,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} ProgressBar

This tutorial will walk you through the creation of a sample application that contains __RadStepProgressBar__.

The following picture shows the final result produced by the code of this tutorial.

![{{ site.framework_name }} RadStepProgressBar Overview](images/stepprogressbar-getting-started-0.png)
			
## Adding Telerik Assemblies Using NuGet

To use __RadStepProgressBar__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadStepProgressBar

To start using the RadStepProgressBar control, you can just populate its __Items__ collection with RadStepProgressBarItem objects. Each __RadStepProgressBar__ will produce a step visual element with track bar rendered between the steps. The following example shows how to add 3 steps along with text to each step added via the __Content__ property of the RadStepProgressBarItem elements. In the example, the second step is selected.

#### __[XAML]__
{{region stepprogressbar-getting-started-0}}
	<telerik:RadStepProgressBar SelectedIndex="1">
		<telerik:RadStepProgressBarItem Content="Step 1" />
		<telerik:RadStepProgressBarItem Content="Step 2" />
		<telerik:RadStepProgressBarItem Content="Step 3" />
	</telerik:RadStepProgressBar>
{{endregion}}

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF StepProgressBar Component](https://www.telerik.com/products/wpf/stepprogressbar.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Events]({%slug stepprogressbar-events%})
* [Data Binding]({%slug stepprogressbar-data-binding%})
* [Step Item Contents]({%slug stepprogressbar-step-contents%})
