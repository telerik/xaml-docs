---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radscheduleview-sdk-examples
tags: sdk,examples
published: True
position: 7
---

# SDK Examples


The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadScheduleView__.

## List of all RadScheduleView SDK examples:

* __Appointment color based on resource__ - This example demonstrates how you can apply different color for the same appointment according to the assigned resources.

* __Appointments reminders__ - This example demonstrates how to implement reminders for the appointments in RadScheduleView for Silverlight and WPF.

* __Avoid overlapping appointments__ - This example demonstrates how you could prevent overlapping appointments when drag-and-drop or resize an appointment. In order to achieve it you should create a custom DragDropBehavior and check in CanDrop and CanResize methods whether the destination slot contains any appointments. Additionally, you should customize the RecurrenceChoiceDragDropDialog to handle the case when a whole series of a recurrent appointment is dragged.

* __Custom DragDropBehavior__ - This example shows how to implement and use a custom ScheduleViewDragDropBehavior. The functionality of example is explained below and demonstrates the use of all the methods available for overriding:
	-	Drag and drop between ScheduleView and ListBox
	-	Custom Appointment with IsReadOnly property which cannot be moved or resized and has different Background color (Red in the example)
	-	The Appointments cannot be resized to a duration below 30 minutes and above 2 hours
	-	All of the non ReadOnly Appointments in with same Resource should move together when single Appointment is dragged
	-	Appointments cannot be moved from one Resource to another
	-	Dragging Appointment with Control key pressed doesn't copy the Appointment


* __With Database__ - This example demonstrates how to bind the RadScheduleView to a database. 

* __Grouping and filtering with tree view__ - This example demonstrates grouping and filtering with TreeView control.

* __Hierarchical Grouping And Filtering With TreeView__ - This example demonstrates hierarchical grouping and filtering using TreeView control.

* __Month tick provider__ - This example demonstrates how to customize the GroupTickLength property of the TimelineViewDefinition of the ScheduleView in order to make it look like YearView.

* __MonthView initially expanded__ - This example demonstrates how to make the MonthView to be expanded by default when the control loads for Silverlight and WPF.

* __Remove delete button__ - This example demonstrates how to remove the Delete button from the Appointmnets in ScheduleView for Silverlight and WPF.

* __Resources paging__ - This example demonstrates how to implement resources paging in RadScheduleView in the cases when there are too many resources.

* __Slots and appointments navigation__ - This example demonstrates how to implement navigation through the Appointments and Slots in the VisibleRange of the ScheduleView for Silverlight and WPF.

* __SpecialSlots ToolTip__ - This project demonstrates a way to set a ToolTip on a SpecialSlot.

* __SpecialSlots ZIndex__ - This example illustrates how you can choose which special slot to stay on top of the other by setting its ZIndex.
There is a possible approach the ZIndex to be bound in order to be manipulated from the ViewModel.
The button changes the ZIndex of the ReadOnlySlot in DayView, WeekView and Timeline.
The ZIndex of the NonWorkingHourSlots is bound to the ViewModel statically for MonthView.

* __Today ViewDefinition__ - This example demonstrates how to create a custom ViewDefinition for the RadScheduleView control in order to create one that will dispaly only the current (today) day for Silverlight and WPF.

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).