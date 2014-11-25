---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radganttview-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadGanttView__.

## List of all RadGanttView SDK examples:{% if site.site_name == 'WPF' %}

* __Baseline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control in order to add additional  custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF. The example shows how to create Baseline  objects in the Timeline of the control that represent the assigned resource to a specific task in the iteration. The iteration Baseline  is a summary of all Tasks Baseline intervals.

* __Bold Column's text for summary tasks__ - This example demonstrates how to set a custom FontWeight to the text in the CellTemplate of the Columns in the control based on if the task has children tasks.

* __Custom CellTemplate for tasks with children__ - This example demonstrates how to customize the CellTemplate base on the Tasks type. In the example in the CellTemplate the elements of the DataTemplate are customized based on the CanExpand property of the OriginalDataItem.

* __Custom cell templates__ - This project describes how to create a custom CellTemplate, CellEditTemplate, CellHighlightTemplate and CellSelectionTemplate  for the ColumnDefinitions in RadGanttView control for Silverlight and WPF.

* __Custom drag reorder behavior__ - This example demonstrates how to restrict the drag reorder of some tasks in the control with the use of a custom GanttDragDropBehavior. The example is available for both SIlverlight and WPF.

* __Custom gantt task with status__ - This example demonstrates how create custom GanttTask in order to add a Status property for each task for Silverlight and WPF.

* __Dependencies editing__ - This project demonstrates how to create, edit and delete a dependency to a Task in the RadGanttView control using an AutoCompleBox control for Silverlight and WPF. 

* __Drag drop from external source__ - This example demonstrates how to create drag and drop functionality between external controls and the GridView part of the control.

* __Event double click__ - This example demonstrates how to create double click on each GanttTask in the timeline for Silverlight and WPF.

* __Expand/Collapse CheckBox inside the Tree Column's Header__ - This example demonstrates how to add a CheckBox to the ContentTemplate of the ColumnHeaderContainer in order to expand and collapse the Tasks with sub Tasks in the control.

* __Grid sorting__ - This example demonstrates how to sort ascending or descending the task source of the RadGanttView by clicking on the grid header. This example is for Silverlight and WPF.

* __Global and National Holidays__ - This example demonstrates how to create a custom TimeLineVisualizationBehavior in order to render multiple containers in the TimeRuler of the control. In the example the containers represent national and global holidays of 2013.

* __Locking GanttDragDependenciesBehavior__ - This example demonstrates how to create a custom GanttDragDependenciesBehavior for the RadGanttView control in order to disable the creating of dependencies from and to specific tasks.

* __Modified tasks__ - This example demonstrates how to implement a solution for setting a tasks as 'dirty'. A dirty task is a task which properties have changed their initial values. You should note that when creating dependencies between Tasks via dragging, only the destination Task will be marked as dirty.

* __Pixels to PixelLength conversion__ - This example demonstrates how the conversion between real Pixels and the PixelLength property of the RadGanttView control is calculated. You can enter pixels (double) in the TextBlock and press enter or the convert button to convert those Pixels into PixelLength and instantly see the result in the RadGanttView control. The same could be done by entering PixelLength (TimeSpan) in the TextBlock.

* __Printing and exporting__ - This example demonstrates how to print the RadGanttView control's GridView and Timeline area for Silverlight and WPF.

* __Printing and exporting advanced__ - This example demonstrates how to print the RadGanttView controls content to A4 format and lets you choose which area to be exported and if the Headers should be included. It also shows how to create a custom print preview dialog with the use of RadWindow that shows how the pages will look after printing.

* __Project deadline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.

* __Recurring task__ - This project demonstrates how to create a recurring Task in the RadGanttView control for Silverlight and WPF.

* __Summary task visibility toggle behavior__ - This example demonstrates how to achieve a behavior with which the Summary task is hidden when its inner children tasks are visible and visible when they are collapsed.

* __Summary task consistency__ - This example demonstrates how to achieve consistency between inner tasks and their parent Summary task.  If a border's task Start/End property are changed the Summary task's Start/End properties will be updated accordingly. This example is available for Silverlight and WPF.

* __Task deadline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.

* __Task deadline property__ - The example demonstrates how to use and customize the built-in Deadline property of the GanttTask.

* __Task snapping DragDrop and Resize behavior__ - This example demonstrates how to create a custom GanttDragDropBehavior and SchedulingResizeBehavior in order to create a Task snapping behaviors. In the example if you resize a task or drag it its Start and End time will be snapped to 00:00.The example is available for Silverlight and WPF.

* __Tasks with different colors__ - This example demonstrates how to color the tasks depending on a property of the task.

* __How to extend the CurrentHour and interval indicators into the Timeline__ - This example demonstrates how to vertically extend the CurrentHourIndicator and the interval markers into the Timeline of the control.

* __Zero task level initially collapsed__ - This example demonstrates how to create a custom InitialExpandBehavior that will collapse the 'Big Iteration' task and expand its children tasks The example is available for Silverlight and WPF.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Baseline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control in order to add additional  custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF. The example shows how to create Baseline  objects in the Timeline of the control that represent the assigned resource to a specific task in the iteration. The iteration Baseline  is a summary of all Tasks Baseline intervals.

* __Bold Column's text for summary tasks__ - This example demonstrates how to set a custom FontWeight to the text in the CellTemplate of the Columns in the control based on if the task has children tasks.

* __Custom CellTemplate for tasks with children__ - This example demonstrates how to customize the CellTemplate base on the Tasks type. In the example in the CellTemplate the elements of the DataTemplate are customized based on the CanExpand property of the OriginalDataItem.

* __Custom cell templates__ - This project describes how to create a custom CellTemplate, CellEditTemplate, CellHighlightTemplate and CellSelectionTemplate  for the ColumnDefinitions in RadGanttView control for Silverlight and WPF.

* __Custom drag reorder behavior__ - This example demonstrates how to restrict the drag reorder of some tasks in the control with the use of a custom GanttDragDropBehavior. The example is available for both SIlverlight and WPF.

* __Custom gantt task with status__ - This example demonstrates how create custom GanttTask in order to add a Status property for each task for Silverlight and WPF.

* __Dependencies editing__ - This project demonstrates how to create, edit and delete a dependency to a Task in the RadGanttView control using an AutoCompleBox control for Silverlight and WPF. 

* __Drag drop from external source__ - This example demonstrates how to create drag and drop functionality between external controls and the GridView part of the control.

* __Event double click__ - This example demonstrates how to create double click on each GanttTask in the timeline for Silverlight and WPF.

* __Expand/Collapse CheckBox inside the Tree Column's Header__ - This example demonstrates how to add a CheckBox to the ContentTemplate of the ColumnHeaderContainer in order to expand and collapse the Tasks with sub Tasks in the control.

* __Grid sorting__ - This example demonstrates how to sort ascending or descending the task source of the RadGanttView by clicking on the grid header. This example is for Silverlight and WPF.

* __Global and National Holidays__ - This example demonstrates how to create a custom TimeLineVisualizationBehavior in order to render multiple containers in the TimeRuler of the control. In the example the containers represent national and global holidays of 2013.

* __Locking GanttDragDependenciesBehavior__ - This example demonstrates how to create a custom GanttDragDependenciesBehavior for the RadGanttView control in order to disable the creating of dependencies from and to specific tasks.

* __Modified tasks__ - This example demonstrates how to implement a solution for setting a tasks as 'dirty'. A dirty task is a task which properties have changed their initial values. You should note that when creating dependencies between Tasks via dragging, only the destination Task will be marked as dirty.

* __Pixels to PixelLength conversion__ - This example demonstrates how the conversion between real Pixels and the PixelLength property of the RadGanttView control is calculated. You can enter pixels (double) in the TextBlock and press enter or the convert button to convert those Pixels into PixelLength and instantly see the result in the RadGanttView control. The same could be done by entering PixelLength (TimeSpan) in the TextBlock.

* __Printing and exporting__ - This example demonstrates how to print the RadGanttView control's GridView and Timeline area for Silverlight and WPF.

* __Printing and exporting advanced__ - This example demonstrates how to print the RadGanttView controls content to A4 format and lets you choose which area to be exported and if the Headers should be included. It also shows how to create a custom print preview dialog with the use of RadWindow that shows how the pages will look after printing.

* __Project deadline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.

* __Recurring task__ - This project demonstrates how to create a recurring Task in the RadGanttView control for Silverlight and WPF.

* __Summary task visibility toggle behavior__ - This example demonstrates how to achieve a behavior with which the Summary task is hidden when its inner children tasks are visible and visible when they are collapsed.

* __Summary task consistency__ - This example demonstrates how to achieve consistency between inner tasks and their parent Summary task.  If a border's task Start/End property are changed the Summary task's Start/End properties will be updated accordingly. This example is available for Silverlight and WPF.

* __Task deadline__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.

* __Task deadline property__ - The example demonstrates how to use and customize the built-in Deadline property of the GanttTask.

* __Task snapping DragDrop and Resize behavior__ - This example demonstrates how to create a custom GanttDragDropBehavior and SchedulingResizeBehavior in order to create a Task snapping behaviors. In the example if you resize a task or drag it its Start and End time will be snapped to 00:00.The example is available for Silverlight and WPF.

* __Tasks with different colors__ - This example demonstrates how to color the tasks depending on a property of the task.

* __How to extend the CurrentHour and interval indicators into the Timeline__ - This example demonstrates how to vertically extend the CurrentHourIndicator and the interval markers into the Timeline of the control.

* __Zero task level initially collapsed__ - This example demonstrates how to create a custom InitialExpandBehavior that will collapse the 'Big Iteration' task and expand its children tasks The example is available for Silverlight and WPF.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).
