---
title: Drag-drop between ListBox and ScheduleView
page_title: Drag-drop between ListBox and ScheduleView
description: Check our &quot;Drag-drop between ListBox and ScheduleView&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-behaviors-listboxandscheduleview
tags: drag-drop,between,listbox,and,scheduleview
published: True
position: 2
---

# Drag-drop between ListBox and ScheduleView

To enable drag-drop between a ListBox and a RadScheduleView, on the ListBox should be attached a ListBoxDragDropBehavior and a DataConverter. The DataConverter should convert the dragged items from the ListBox into a ScheduleViewDragDropPayload and vice versa.          

Following is an example demonstrating how to convert appointments between a ListBox and a ScheduleView:

* Create the DataConverter:

<snippet id='dragdropmanager-behaviors-listboxandscheduleview-block_1-cs' />

* Add CustomScheduleViewDragDropBehavior class which inherits ScheduleViewDragDropBehavior:      	

<snippet id='dragdropmanager-behaviors-listboxandscheduleview-block_2-cs' />

* The final configuration of the two controls in XAML should look like:

<snippet id='dragdropmanager-behaviors-listboxandscheduleview-block_3-xaml' />

Here is the result:

![dragdropmanager listboxandscheduleview](images/dragdropmanager_listboxandscheduleview.png)
