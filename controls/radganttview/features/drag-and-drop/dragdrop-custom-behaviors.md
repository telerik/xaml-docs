---
title: Custom Drag and Drop Behaviors
page_title: Custom Drag and Drop Behaviors
description: Check our &quot;Custom Drag and Drop Behaviors&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-dragdrop-custom-behaviors
tags: custom,drag,and,drop,behaviors
published: True
position: 2
---

# Custom Drag and Drop Behaviors

__RadGanttView__ provides the option to customize its DragDrop and Resize behaviors in order to add some custom logic for drag and drop as well as resizing of tasks. This topic describes all the available methods you can use to implement custom drag and drop/resizing functionality.

## Custom DragDropBehavior

In order to create a custom DragDropBehavior you will need to create a class that inherits from __Telerik.Windows.Controls.GanttView.GanttDragDropBehavior__ and override its methods. The following methods could be overridden:

* __CanStartDrag__(SchedulingDragDropState state) – returns a Boolean value that determines if the drag operation of tasks could start

* __CanDrop__(SchedulingDragDropState state) – returns a Boolean value that determines if the drop operation of tasks can be executed

* __Drop__(SchedulingDragDropState state) – occurs when a task has been dropped

The next example shows how to create a custom GanttDragDropBehavior in order to prevent the drag-drop of Milestone tasks.

* Create a CustomDragDragDropBehavior class and override its CanStartDrag method:



<snippet id='radganttview-features-drag-and-drop-dragdrop-custom-behaviors-block_1-cs' />


* Set the just created class as RadGanttView DragDropBehavior:



<snippet id='radganttview-features-drag-and-drop-dragdrop-custom-behaviors-block_2-xaml' />


The dragging of milestone tasks will be disabled.

## Custom ResizeBehavior

In order to create a custom ResizeBehavior you will need to create a class that inherits from __Telerik.Windows.Controls.Scheduling.SchedulingResizeBehavior__ and override its methods. The following methods could be overridden: 

* __CanResize__(SchedulingResizeState state) - returns a Boolean value that determines if the resize operation of the task is allowed

* __CanStartResize__(SchedulingResizeState state) - returns a Boolean value that determines if the resize operation of the task could start

* __Resize__(SchedulingResizeState state) – occurs when a task is being resized

* __ResizeCanceled__(SchedulingResizeState state) – occurs when the resize operation is canceled.

The next example will demonstrate how to create custom __SchedulingResizeBehavior__ in order to create a behavior that will snap the Start and End times of the resized Task to the nearest day.

* Create a custom SchedulingResizeBehavior class and override its Resize method:



<snippet id='radganttview-features-drag-and-drop-dragdrop-custom-behaviors-block_3-cs' />


* Set the newly created class to the RadGanttView ResizeBehavior:



<snippet id='radganttview-features-drag-and-drop-dragdrop-custom-behaviors-block_4-xaml' />


The next figures shows the final result. When the Start or End of a Task is resized by resizing the task object it is snapped to the nearest Day depending on if the Task has been resized above 12:00 PM or not:

Figure 1. Resizing a task and dropping it to 9/18/2013 6:00 PM.

![radganttview-dragdrop-custom-behaviors-1](images/radganttview-dragdrop-custom-behaviors-1.jpg)

Figure 2. The task’s end time is snapped to 9/19/2013 12:00 AM.

![radganttview-dragdrop-custom-behaviors-2](images/radganttview-dragdrop-custom-behaviors-2.jpg)
