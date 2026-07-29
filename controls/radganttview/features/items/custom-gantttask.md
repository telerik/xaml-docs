---
title: Custom GanttTask
page_title: Custom GanttTask
description: Check our &quot;Custom GanttTask&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-items-custom-gantttask
tags: custom,gantttask
published: True
position: 4
---

# Custom GanttTask

In __RadGanttView__ control you can create custom GanttTasks in order to customize the existing properties of the task or add custom properties. There are two approaches that could be used, the first one is to inherit from __GanttTask__ class and the second one is to create a class that implements __IGanttTask__, __ISummary__, __IMilestone__, __IDependant__ interfaces.

## Inheriting GanttTasks Class

The next example will demonstrate how to add an additional description property of type string to the tasks of the control by creating a custom class which inherits from GanttTasks class. This approach is appropriate when adding additional properties and not making customizations to the built-in properties of the GanttTask class.

>Before proceeding with this tutorial you should get familiar with [Implementing View-ViewModel]({%slug radganttview-populating-with-data-viewmodel%}) help article.

1. First you will need to create a class and inherits __GanttTask__ class:

	<snippet id='radganttview-features-items-custom-gantttask-block_1-cs' />


1. Define a field of type string that will be the custom description property:

	<snippet id='radganttview-features-items-custom-gantttask-block_2-cs' />


1. Next you will need to create a collection of __MyGanttTask__ objects in your __ViewModel__ and populate it with some sample data:

	<snippet id='radganttview-features-items-custom-gantttask-block_3-cs' />


The xaml of the GanttView control should look like this:

<snippet id='radganttview-features-items-custom-gantttask-block_4-xaml' />


The next screenshot show the final result (the Custom Description column shows the CustomDescription values):

![radganttview-features-items-custom-gantttask-1](images/radganttview-features-items-custom-gantttask-1.png)

## Implementing IGanttTask, ISummary, IMilestone, IDependant

This approach is more appropriate when customizing the existing properties of the GanttTask class (Start, End, Title, Resources, Children etc.). All that you will need to do is create a class that implements the following interfaces: IGanttTask, ISummary, IMilestone, IDependant.

>If you want to enable the creating of relations by dragging the mouse you will need to implement the IDependant interface.

The next code snippet shows a sample implementation of __IDependant__ interface:

<snippet id='radganttview-features-items-custom-gantttask-block_5-cs' />


>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomGanttTaskWithStatus).

## See Also

 * [Columns - Overview]({%slug radganttview-features-columns-types%})
