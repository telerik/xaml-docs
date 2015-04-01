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

{% if site.site_name == 'WPF' %}

* __[Appointment color based on resource](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AppointmentColorBasedOnResource)__ - This example demonstrates how you can apply different color for the same appointment according to the assigned resources.
* __[Appointments reminders](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AppointmentsReminders)__ - This example demonstrates how to implement reminders for the appointments in RadScheduleView for Silverlight and WPF.
* __[Avoid overlapping appointments](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AvoidOverlappingAppointments)__ - This example demonstrates how you could prevent overlapping appointments when drag-and-drop or resize an appointment. In order to achieve it you should create a custom DragDropBehavior and check in CanDrop and CanResize methods whether the destination slot contains any appointments. Additionally, you should customize the RecurrenceChoiceDragDropDialog to handle the case when a whole series of a recurrent appointment is dragged.


* __[Custom DragDropBehavior](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CustomDragDropBehavior)__ - 
This example shows how to implement and use a custom ScheduleViewDragDropBehavior. The functionality of example is explained below and demonstrates the use of all the methods available for overriding:
-	Drag and drop between ScheduleView and ListBox
-	Custom Appointment with IsReadOnly property which cannot be moved or resized and has different Background color (Red in the example)
-	The Appointments cannot be resized to a duration below 30 minutes and above 2 hours
-	All of the non ReadOnly Appointments in with same Resource should move together when single Appointment is dragged
-	Appointments cannot be moved from one Resource to another
-	Dragging Appointment with Control key pressed doesn't copy the Appointment

* __[Custom time ruler lines timeline view](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CustomTimeRulerLinesTimelineView)__ - The example shows how to customize the TimeRulerItemsSyleSelector of the ScheduleView in order to apply different Styles to the TimeRulerLines. This is used, for example, to distinguish the weeks in TimelineViewDefinition. 
* __[Cut copy paste appointments](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CutCopyPasteAppointments)__ - This example demonstrates how to cut, copy and paste appointments with the keyboard combinations (Ctrl+X, Ctrl+C, Ctrl+V) as well as with a ContextMenu.
* __[With Database](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Database/WPF_CS)__ - 
This example demonstrates how to bind the RadScheduleView to a database. For more details on the approach, please refer to the following documentation:
http://www.telerik.com/help/wpf/radscheduleview-populating-with-data-binding-to-db-overview.html

You can find a VB version of the project at the following link:
https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Database/WPF_VB
* __[Exporting](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Exporting)__ - This example demonstrates how you can use the ExportExtensions class (part of the Telerik.Windows.Controls assembly) in order to export the ScheduleView to an image or a XPS file ready for printing.
* __[Grouping and filtering with tree view](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/GroupingAndFilteringWithTreeView)__ - This example demonstrates grouping and filtering with TreeView control.
* __[Hierarchical Grouping And Filtering With TreeView](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/HierarchicalGroupingAndFilteringWithTreeView)__ - 
This example demonstrates hierarchical grouping and filtering using TreeView control.
* __[Month tick provider](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/MonthTickProvider)__ - This example demonstrates how to customize the GroupTickLength property of the TimelineViewDefinition of the ScheduleView in order to make it look like YearView.
* __[MonthView initially expanded](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/MonthViewInitiallyExpanded)__ - 
This example demonstrates how to make the MonthView to be expanded by default when the control loads for Silverlight and WPF.
* __[Remove delete button](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/RemoveDeleteButton)__ - This example demonstrates how to remove the Delete button from the Appointmnets in ScheduleView for Silverlight and WPF.
* __[Resources paging](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/ResourcesPaging)__ - This example demonstrates how to implement resources paging in RadScheduleView in the cases when there are too many resources.
* __[Slots and appointments navigation](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SlotsAndAppointmentsNavigation)__ - This example demonstrates how to implement navigation through the Appointments and Slots in the VisibleRange of the ScheduleView for Silverlight and WPF.
* __[SpecialSlots ToolTip](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SpecialSlotsToolTip)__ - 
This project demonstrates a way to set a ToolTip on a SpecialSlot.
* __[SpecialSlots ZIndex](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SpecialSlotsZIndex)__ - 
This example illustrates how you can choose which special slot to stay on top of the other by setting its ZIndex.
There is a possible approach the ZIndex to be bound in order to be manipulated from the ViewModel.
The button changes the ZIndex of the ReadOnlySlot in DayView, WeekView and Timeline.
The ZIndex of the NonWorkingHourSlots is bound to the ViewModel statically for MonthView.
* __[Today ViewDefinition](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/TodayViewDefinition)__ - 
This example demonstrates how to create a custom ViewDefinition for the RadScheduleView control in order to create one that will dispaly only the current (today) day for Silverlight and WPF.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Appointment color based on resource](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AppointmentColorBasedOnResource)__ - This example demonstrates how you can apply different color for the same appointment according to the assigned resources.
* __[Appointments reminders](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AppointmentsReminders)__ - This example demonstrates how to implement reminders for the appointments in RadScheduleView for Silverlight and WPF.
* __[Avoid overlapping appointments](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/AvoidOverlappingAppointments)__ - This example demonstrates how you could prevent overlapping appointments when drag-and-drop or resize an appointment. In order to achieve it you should create a custom DragDropBehavior and check in CanDrop and CanResize methods whether the destination slot contains any appointments. Additionally, you should customize the RecurrenceChoiceDragDropDialog to handle the case when a whole series of a recurrent appointment is dragged.


* __[Custom DragDropBehavior](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CustomDragDropBehavior)__ - 
This example shows how to implement and use a custom ScheduleViewDragDropBehavior. The functionality of example is explained below and demonstrates the use of all the methods available for overriding:
-	Drag and drop between ScheduleView and ListBox
-	Custom Appointment with IsReadOnly property which cannot be moved or resized and has different Background color (Red in the example)
-	The Appointments cannot be resized to a duration below 30 minutes and above 2 hours
-	All of the non ReadOnly Appointments in with same Resource should move together when single Appointment is dragged
-	Appointments cannot be moved from one Resource to another
-	Dragging Appointment with Control key pressed doesn't copy the Appointment

* __[Custom time ruler lines timeline view](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CustomTimeRulerLinesTimelineView)__ - The example shows how to customize the TimeRulerItemsSyleSelector of the ScheduleView in order to apply different Styles to the TimeRulerLines. This is used, for example, to distinguish the weeks in TimelineViewDefinition. 
* __[Cut copy paste appointments](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CutCopyPasteAppointments)__ - This example demonstrates how to cut, copy and paste appointments with the keyboard combinations (Ctrl+X, Ctrl+C, Ctrl+V) as well as with a ContextMenu.
* __[With Database](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Database/SL_CS/WithDB)__ - 
This example demonstrates how to bind the RadScheduleView to a database. For more details on the approach, please refer to the following documentation:
http://www.telerik.com/help/silverlight/radscheduleview-populating-with-data-binding-to-db-overview.html

You can find a VB version of the project at the following link:
https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Database/SL_VB
* __[Exporting](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/Exporting)__ - This example demonstrates how you can use the ExportExtensions class (part of the Telerik.Windows.Controls assembly) in order to export the ScheduleView to an image or a XPS file ready for printing.
* __[Grouping and filtering with tree view](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/GroupingAndFilteringWithTreeView)__ - This example demonstrates grouping and filtering with TreeView control.
* __[Hierarchical Grouping And Filtering With TreeView](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/HierarchicalGroupingAndFilteringWithTreeView)__ - 
This example demonstrates hierarchical grouping and filtering using TreeView control.
* __[Month tick provider](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/MonthTickProvider)__ - This example demonstrates how to customize the GroupTickLength property of the TimelineViewDefinition of the ScheduleView in order to make it look like YearView.
* __[MonthView initially expanded](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/MonthViewInitiallyExpanded)__ - 
This example demonstrates how to make the MonthView to be expanded by default when the control loads for Silverlight and WPF.
* __[Remove delete button](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/RemoveDeleteButton)__ - This example demonstrates how to remove the Delete button from the Appointmnets in ScheduleView for Silverlight and WPF.
* __[Resources paging](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/ResourcesPaging)__ - This example demonstrates how to implement resources paging in RadScheduleView in the cases when there are too many resources.
* __[Slots and appointments navigation](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SlotsAndAppointmentsNavigation)__ - This example demonstrates how to implement navigation through the Appointments and Slots in the VisibleRange of the ScheduleView for Silverlight and WPF.
* __[SpecialSlots ToolTip](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SpecialSlotsToolTip)__ - 
This project demonstrates a way to set a ToolTip on a SpecialSlot.
* __[SpecialSlots ZIndex](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/SpecialSlotsZIndex)__ - 
This example illustrates how you can choose which special slot to stay on top of the other by setting its ZIndex.
There is a possible approach the ZIndex to be bound in order to be manipulated from the ViewModel.
The button changes the ZIndex of the ReadOnlySlot in DayView, WeekView and Timeline.
The ZIndex of the NonWorkingHourSlots is bound to the ViewModel statically for MonthView.
* __[Today ViewDefinition](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/TodayViewDefinition)__ - 
This example demonstrates how to create a custom ViewDefinition for the RadScheduleView control in order to create one that will dispaly only the current (today) day for Silverlight and WPF.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).