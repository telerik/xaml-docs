---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radganttview-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadGanttView__.

## List of all RadGanttView SDK examples:

{% if site.site_name == 'WPF' %}

* __[Baseline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/Baseline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control in order to add additional  custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF. The example shows how to create Baseline  objects in the Timeline of the control that represent the assigned resource to a specific task in the iteration. The iteration Baseline  is a summary of all Tasks Baseline intervals.
* __[Bold Column's text for summary tasks](https://github.com/telerik/xaml-sdk/tree/master/GanttView/BoldParentTasks)__ - 
This example demonstrates how to set a custom FontWeight to the text in the CellTemplate of the Columns in the control based on if the task has children tasks.
* __[Custom CellTemplate for tasks with children](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CellTemplateBasedOnType)__ - 
This example demonstrates how to customize the CellTemplate base on the Tasks type. In the example in the CellTemplate the elements of the DataTemplate are customized based on the CanExpand property of the OriginalDataItem.
* __[Custom cell templates](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomCellTemplates)__ - This project describes how to create a custom CellTemplate, CellEditTemplate, CellHighlightTemplate and CellSelectionTemplate  for the ColumnDefinitions in RadGanttView control for Silverlight and WPF.
* __[Custom drag reorder behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomDragReorderBehavior)__ - This example demonstrates how to restrict the drag reorder of some tasks in the control with the use of a custom GanttDragDropBehavior. The example is available for both SIlverlight and WPF.
* __[Custom gantt task with status](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomGanttTaskWithStatus)__ - This example demonstrates how create custom GanttTask in order to add a Status property for each task for Silverlight and WPF.
* __[Dependencies editing](https://github.com/telerik/xaml-sdk/tree/master/GanttView/DependenciesEditing)__ - This project demonstrates how to create, edit and delete a dependency to a Task in the RadGanttView control using an AutoCompleBox control for Silverlight and WPF. 
* __[Drag drop from external source](https://github.com/telerik/xaml-sdk/tree/master/GanttView/DragDropFromExternalSource)__ - This example demonstrates how to create drag and drop functionality between external controls and the GridView part of the control.
* __[Event double click](https://github.com/telerik/xaml-sdk/tree/master/GanttView/EventDoubleClick)__ - This example demonstrates how to create double click on each GanttTask in the timeline for Silverlight and WPF.
* __[Expand/Collapse CheckBox inside the Tree Column's Header](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ExpandCollapseViaHeader)__ - 
This example demonstrates how to add a CheckBox to the ContentTemplate of the ColumnHeaderContainer in order to expand and collapse the Tasks with sub Tasks in the control.
* __[Grid sorting](https://github.com/telerik/xaml-sdk/tree/master/GanttView/GridSorting)__ - This example demonstrates how to sort ascending or descending the task source of the RadGanttView by clicking on the grid header. This example is for Silverlight and WPF.
* __[Global and National Holidays](https://github.com/telerik/xaml-sdk/tree/master/GanttView/HolidayEvents)__ - 
This example demonstrates how to create a custom TimeLineVisualizationBehavior in order to render multiple containers in the TimeRuler of the control. In the example the containers represent national and global holidays of 2013.
* __[Locking GanttDragDependenciesBehavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/LockingDragDependenciesBehavior)__ - 
This example demonstrates how to create a custom GanttDragDependenciesBehavior for the RadGanttView control in order to disable the creating of dependencies from and to specific tasks.
* __[Modified tasks](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ModifiedTasks)__ - This example demonstrates how to implement a solution for setting a tasks as 'dirty'. A dirty task is a task which properties have changed their initial values. You should note that when creating dependencies between Tasks via dragging, only the destination Task will be marked as dirty.
* __[Not allowed drop target TimeRuler slots](https://github.com/telerik/xaml-sdk/tree/master/GanttView/NotAllowedTargetDropSlots)__ - 
This example demonstrates how to create a custom GanttDragDropBehavior in order to achieve a behavior where drag and drop is not allowed in specific time frame slots of the TimeRuler of the control.
* __[Pixels to PixelLength conversion](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PixelsToPixelLengthConversion)__ - 
This example demonstrates how the conversion between real Pixels and the PixelLength property of the RadGanttView control is calculated. You can enter pixels (double) in the TextBlock and press enter or the convert button to convert those Pixels into PixelLength and instantly see the result in the RadGanttView control. The same could be done by entering PixelLength (TimeSpan) in the TextBlock.
* __[Printing and exporting](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PrintingAndExporting)__ - This example demonstrates how to print the RadGanttView control's GridView and Timeline area for Silverlight and WPF.
* __[Printing and exporting advanced](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PrintingAndExportingAdvanced)__ - This example demonstrates how to print the RadGanttView controls content to A4 format and lets you choose which area to be exported and if the Headers should be included. It also shows how to create a custom print preview dialog with the use of RadWindow that shows how the pages will look after printing.
* __[Project deadline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ProjectDeadline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.
* __['Recurring' task on mutiple rows](https://github.com/telerik/xaml-sdk/tree/master/GanttView/RecurringTask)__ - 
This project demonstrates how to create a 'recurring' Task in the RadGanttView control for Silverlight and WPF.
* __['Recurring' task on single row](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SameRowRecurringTask)__ - 
This project demonstrates how to implement a 'recurring' Task in the RadGanttView control for Silverlight and WPF. The task which has recurrences is displayed on the same row and the drag and drop of its 'recurrences' disabled.
* __[Start/End times EventContainers](https://github.com/telerik/xaml-sdk/tree/master/GanttView/StartEndEventContainers)__ - 
This example demonstrates how to use custom EventContainer instances in order to display labels for the Start and End time of each GanttTask except the milestone task.
* __[Summary task visibility toggle behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SummariesVisibilityToggle)__ - 
This example demonstrates how to achieve a behavior with which the Summary task is hidden when its inner children tasks are visible and visible when they are collapsed.
* __[Summary task consistency](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SummaryTaskConsistency)__ - This example demonstrates how to achieve consistency between inner tasks and their parent Summary task.  If a border's task Start/End property are changed the Summary task's Start/End properties will be updated accordingly. This example is available for Silverlight and WPF.
* __[Task deadline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskDeadline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.
* __[Task deadline property](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskDeadlineProperty)__ - The example demonstrates how to use and customize the built-in Deadline property of the GanttTask.
* __[Task snapping DragDrop and Resize behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskSnappingDragDropAndResizeBehavior)__ - This example demonstrates how to create a custom GanttDragDropBehavior and SchedulingResizeBehavior in order to create a Task snapping behaviors. In the example if you resize a task or drag it its Start and End time will be snapped to 00:00.The example is available for Silverlight and WPF.
* __[Tasks with different colors](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TasksWithDifferentColors)__ - This example demonstrates how to color the tasks depending on a property of the task.
* __[How to extend the CurrentHour and interval indicators into the Timeline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TimelineIntervalMarkers)__ - 
This example demonstrates how to vertically extend the CurrentHourIndicator and the interval markers into the Timeline of the control.

More details explanation of the use approach could be found here:
- For WPF: http://www.telerik.com/help/wpf/radganttview-howto-customize-the-timeline.html
- For Silverlight: http://www.telerik.com/help/silverlight/radganttview-howto-customize-the-timeline.html
* __[Zero task level initially collapsed](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ZeroTaskLevelInitiallyCollapsed)__ - This example demonstrates how to create a custom InitialExpandBehavior that will collapse the 'Big Iteration' task and expand its children tasks The example is available for Silverlight and WPF.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Baseline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/Baseline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control in order to add additional  custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF. The example shows how to create Baseline  objects in the Timeline of the control that represent the assigned resource to a specific task in the iteration. The iteration Baseline  is a summary of all Tasks Baseline intervals.
* __[Bold Column's text for summary tasks](https://github.com/telerik/xaml-sdk/tree/master/GanttView/BoldParentTasks)__ - 
This example demonstrates how to set a custom FontWeight to the text in the CellTemplate of the Columns in the control based on if the task has children tasks.
* __[Custom CellTemplate for tasks with children](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CellTemplateBasedOnType)__ - 
This example demonstrates how to customize the CellTemplate base on the Tasks type. In the example in the CellTemplate the elements of the DataTemplate are customized based on the CanExpand property of the OriginalDataItem.
* __[Custom cell templates](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomCellTemplates)__ - This project describes how to create a custom CellTemplate, CellEditTemplate, CellHighlightTemplate and CellSelectionTemplate  for the ColumnDefinitions in RadGanttView control for Silverlight and WPF.
* __[Custom drag reorder behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomDragReorderBehavior)__ - This example demonstrates how to restrict the drag reorder of some tasks in the control with the use of a custom GanttDragDropBehavior. The example is available for both SIlverlight and WPF.
* __[Custom gantt task with status](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomGanttTaskWithStatus)__ - This example demonstrates how create custom GanttTask in order to add a Status property for each task for Silverlight and WPF.
* __[Dependencies editing](https://github.com/telerik/xaml-sdk/tree/master/GanttView/DependenciesEditing)__ - This project demonstrates how to create, edit and delete a dependency to a Task in the RadGanttView control using an AutoCompleBox control for Silverlight and WPF. 
* __[Drag drop from external source](https://github.com/telerik/xaml-sdk/tree/master/GanttView/DragDropFromExternalSource)__ - This example demonstrates how to create drag and drop functionality between external controls and the GridView part of the control.
* __[Event double click](https://github.com/telerik/xaml-sdk/tree/master/GanttView/EventDoubleClick)__ - This example demonstrates how to create double click on each GanttTask in the timeline for Silverlight and WPF.
* __[Expand/Collapse CheckBox inside the Tree Column's Header](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ExpandCollapseViaHeader)__ - 
This example demonstrates how to add a CheckBox to the ContentTemplate of the ColumnHeaderContainer in order to expand and collapse the Tasks with sub Tasks in the control.
* __[Grid sorting](https://github.com/telerik/xaml-sdk/tree/master/GanttView/GridSorting)__ - This example demonstrates how to sort ascending or descending the task source of the RadGanttView by clicking on the grid header. This example is for Silverlight and WPF.
* __[Global and National Holidays](https://github.com/telerik/xaml-sdk/tree/master/GanttView/HolidayEvents)__ - 
This example demonstrates how to create a custom TimeLineVisualizationBehavior in order to render multiple containers in the TimeRuler of the control. In the example the containers represent national and global holidays of 2013.
* __[Locking GanttDragDependenciesBehavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/LockingDragDependenciesBehavior)__ - 
This example demonstrates how to create a custom GanttDragDependenciesBehavior for the RadGanttView control in order to disable the creating of dependencies from and to specific tasks.
* __[Modified tasks](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ModifiedTasks)__ - This example demonstrates how to implement a solution for setting a tasks as 'dirty'. A dirty task is a task which properties have changed their initial values. You should note that when creating dependencies between Tasks via dragging, only the destination Task will be marked as dirty.
* __[Not allowed drop target TimeRuler slots](https://github.com/telerik/xaml-sdk/tree/master/GanttView/NotAllowedTargetDropSlots)__ - 
This example demonstrates how to create a custom GanttDragDropBehavior in order to achieve a behavior where drag and drop is not allowed in specific time frame slots of the TimeRuler of the control.
* __[Pixels to PixelLength conversion](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PixelsToPixelLengthConversion)__ - 
This example demonstrates how the conversion between real Pixels and the PixelLength property of the RadGanttView control is calculated. You can enter pixels (double) in the TextBlock and press enter or the convert button to convert those Pixels into PixelLength and instantly see the result in the RadGanttView control. The same could be done by entering PixelLength (TimeSpan) in the TextBlock.
* __[Printing and exporting](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PrintingAndExporting)__ - This example demonstrates how to print the RadGanttView control's GridView and Timeline area for Silverlight and WPF.
* __[Printing and exporting advanced](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PrintingAndExportingAdvanced)__ - This example demonstrates how to print the RadGanttView controls content to A4 format and lets you choose which area to be exported and if the Headers should be included. It also shows how to create a custom print preview dialog with the use of RadWindow that shows how the pages will look after printing.
* __[Project deadline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ProjectDeadline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.
* __['Recurring' task on mutiple rows](https://github.com/telerik/xaml-sdk/tree/master/GanttView/RecurringTask)__ - 
This project demonstrates how to create a 'recurring' Task in the RadGanttView control for Silverlight and WPF.
* __['Recurring' task on single row](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SameRowRecurringTask)__ - 
This project demonstrates how to implement a 'recurring' Task in the RadGanttView control for Silverlight and WPF. The task which has recurrences is displayed on the same row and the drag and drop of its 'recurrences' disabled.
* __[Start/End times EventContainers](https://github.com/telerik/xaml-sdk/tree/master/GanttView/StartEndEventContainers)__ - 
This example demonstrates how to use custom EventContainer instances in order to display labels for the Start and End time of each GanttTask except the milestone task.
* __[Summary task visibility toggle behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SummariesVisibilityToggle)__ - 
This example demonstrates how to achieve a behavior with which the Summary task is hidden when its inner children tasks are visible and visible when they are collapsed.
* __[Summary task consistency](https://github.com/telerik/xaml-sdk/tree/master/GanttView/SummaryTaskConsistency)__ - This example demonstrates how to achieve consistency between inner tasks and their parent Summary task.  If a border's task Start/End property are changed the Summary task's Start/End properties will be updated accordingly. This example is available for Silverlight and WPF.
* __[Task deadline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskDeadline)__ - This example demonstrates how to customize the way items are rendered in the TimeLine portion of the control and add additional custom elements by creating a custom TimeLineVisualizationBehavior for Silverlight and WPF.
* __[Task deadline property](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskDeadlineProperty)__ - The example demonstrates how to use and customize the built-in Deadline property of the GanttTask.
* __[Task snapping DragDrop and Resize behavior](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TaskSnappingDragDropAndResizeBehavior)__ - This example demonstrates how to create a custom GanttDragDropBehavior and SchedulingResizeBehavior in order to create a Task snapping behaviors. In the example if you resize a task or drag it its Start and End time will be snapped to 00:00.The example is available for Silverlight and WPF.
* __[Tasks with different colors](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TasksWithDifferentColors)__ - This example demonstrates how to color the tasks depending on a property of the task.
* __[How to extend the CurrentHour and interval indicators into the Timeline](https://github.com/telerik/xaml-sdk/tree/master/GanttView/TimelineIntervalMarkers)__ - 
This example demonstrates how to vertically extend the CurrentHourIndicator and the interval markers into the Timeline of the control.

More details explanation of the use approach could be found here:
- For WPF: http://www.telerik.com/help/wpf/radganttview-howto-customize-the-timeline.html
- For Silverlight: http://www.telerik.com/help/silverlight/radganttview-howto-customize-the-timeline.html
* __[Zero task level initially collapsed](https://github.com/telerik/xaml-sdk/tree/master/GanttView/ZeroTaskLevelInitiallyCollapsed)__ - This example demonstrates how to create a custom InitialExpandBehavior that will collapse the 'Big Iteration' task and expand its children tasks The example is available for Silverlight and WPF.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).