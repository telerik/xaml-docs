---
title: Getting Started
page_title: Getting Started
description: Get started with the Telerik RadStepProgressBar control.
slug: stepprogressbar-getting-started
tags: get,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadStepProgressBar__.

The following picture shows the final result produced by the code of this tutorial.

![WPF RadStepProgressBar ](images/stepprogressbar-getting-started-0.png)
			
## Assembly References

In order to use __RadStepProgressBar__, you will need to add references to the following assemblies:  
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

## See Also
* [Events]({%slug stepprogressbar-events%})
* [Data Binding]({%slug stepprogressbar-data-binding%})
* [Step Item Contents]({%slug stepprogressbar-step-contents%})