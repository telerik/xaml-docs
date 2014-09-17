---
title: Changes
page_title: Changes
description: Changes
slug: radganttview-changes
tags: changes
published: True
position: 0
---

# Changes



This article describes the release history of the control.

For the complete Release History of RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to
        {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.
      

## Q1 2014

### What's Fixed

* Improve the style of the DragVisual in the Grid part of the control
                

## Q3 2013

### What's Fixed

* ZIndexManager, ZIndex returns incorrect type for GetValue. CompileTime Error occurs in some clients' solutions
                

* The most of the relation arrow is missing when dragging in the same row in Widnows8Touch theme
                

* Some tasks can be resized only from their most top or bottom edges
                

* An open locking options menu is not closed if you hover another item in the timeline
                

* Exception when resizing a column to its most left position
                

* Adding a child to collapsed task (not visible) throw an exception
                

* When the control is placed inside Docking and one of its columns has its IsFrozenColumn set to true that control overlaps the bounds of the Pane
                

## Q2 2013

### What's New

* Add interactive Resizable columns
                

* Add IsReorderOperation property to the SchedulingDragDropState class
                

* Add ToolTipTemplate property for the Event, Summary and Milestone containers
                

* Export to image formats (Printing support)
                

* Change the resizers for the Windows8Touch theme to circles in order to be better touchable
                

### What's Fixed{% if site.site_name == 'WPF' %}

* When TimeRulerLine's time range starts before the visible range, this line is rendered outside the time ruler
                  

* Column's width restrictions are initially disregarded
                  

* Extend the Columns AutoSizing mode with AutoByContent
                  

* Exception is thrown when dragging relation from one side of the task to the other
                  

* Can only drag task from selected cell
                  

* Sometimes when dragging task the wrong task is dragged
                  

* Drag reorder operation cannot start from a button control
                  

* Null Reference Exception in the Automation Peers when scrolling
                  

* Improve Gantt Performance
                  

* There is empty space between the summaries and its relations in Windows8 theme
                  {% endif %}{% if site.site_name == 'Silverlight' %}

* When TimeRulerLine's time range starts before the visible range, this line is rendered outside the time ruler
                  

* Column's width restrictions are initially disregarded
                  

* Extend the Columns AutoSizing mode with AutoByContent
                  

* Exception is thrown when dragging relation from one side of the task to the other
                  

* Can't drop task before or after another task after scrolling
                  

* Sometimes when dragging task the wrong task is dragged
                  

* Dragged Task is wrong when start to drag from its edges
                  

* InlineEditCommand command cannot be parsed by the XAML parser
                  

* Drag reorder operation cannot start from a button control
                  

* Improve Gantt Performance
                  

* There is empty space between the summaries and its relations in Windows8 theme
                  {% endif %}

## Q1 2013

### What's New

* Create relations with mouse

* Allow drag reorder of tasks 

* Add interactive Resizable columns

* Add UI Automation support

* Drop relative position for the grid reorder

* Add IsReorderOperation property to the SchedulingDragDropState class

* Add Drag&Drop items from external source

* Extend the Columns AutoSizing mode with AutoByContent

### What's Fixed

* GanttView DragCue is missing – only the Drop Cue is visible

* The GanttView is not expanded when try to scroll to not visible item

* Resizing and dragging Tasks that go out of the ViewPort is not smooth and causes Tasks to flicker

* Windows8 Theme: Add padding in the AppointmentItem to make text more readable

* When GanttView lost focus the VirtualizedGridPanel don't recycle the items

* When the Columns horizontal scroll bar is scrolled to the end and the grid area is enlarged, the headers are not scrolled correctly

* When in edit mode of a cell, followed by a non-editable cell, the keyboard navigation is broken

* Null reference exception is thrown when trying to ScrollIntoView before the Gantt is loaded

* GanttView is not destroyed by the GC, because of the TimelineVisualizationBehavior

* Tasks that end after the end of the VisibleRange don't render

* When TimeRulerLine's timeRange starts before the visible range, this line is rendered outside the time ruler

* Dragging task in the Gantts Grid leads to exception 

* Exception when expanding collapsed Task with previously added children

* Right Click events are handled which prevent the showing of the RadContextMenu

* If the SchedulingDragDropBehavior.CanStartDrag returns false, null reference exception is thrown

* If item is dragged from GanttView and dropped outside of the control, the item is removed from the Gantt source 

* If the DesiredSize is larger than 30 000 pixels, the UI elements are not rendered

## Q2 2012

### What's New

* 
                Built-in Drag&Drop functionality is added with a DragDropBehavior for customizing the way the Drag&Drop works. Check [here]({%slug radganttview-dragdrop-overview%}) for details.
              

* __SpecialSlotsGenerator__ property is added that allows coloring dates/time in different color using an instance of the __IRangeGenerator__ interface. More information can be found [here]({%slug radganttview-specialslots%}).
              

* __TimeLineFilteringBehavior__ property is added that allows filtering of the displayed dates/time using an instance of the __IRangeGenerator__ interface.
              
