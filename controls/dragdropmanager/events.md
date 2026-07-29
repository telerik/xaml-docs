---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-events
tags: events
published: True
position: 3
---

# Events

`DragDropManager` supports an event driven model. Both the drag source and the drop target use a standard set of events to handle drag-and-drop operations. This article lists the standard drag-and-drop events and how subscribe to them.

## Subscribing to DragDropManager Events

The event handler subscription in DragDropManager can happen only in the code. There is no support to do that in XAML like with other WPF events.

To subscribe to an event, use the Add&lt;event name&gt;Handler methods. The following code snippet shows how to do this.

__Subscribing and unsubscribing to DragDropManager events__  
<snippet id='dragdropmanager-events-block_1-cs' />
<snippet id='dragdropmanager-events-block_1-vb' />


In order for the `DragInitialize` event and the other [drag source events](#drag-source-events) to occur, the `DragDropManager.AllowDrag` or `DragDropManager.AllowCapturedDrag` attached property has to be set to `True` on the source element.

In order for the `Drop` and the other drop [Target Events](#drop-target-events) to occur, the [AllowDrop](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement.allowdrop?view=windowsdesktop-8.0) property of the drop target element has to be set to `True`.

__Setting AllowDrag and AllowDrop__  
<snippet id='dragdropmanager-events-block_2-xaml' />

## Drag Source Events

* `DragInitialize`&mdash;The DragInitialize event occurs when an object is about to be dragged. This is a bubbling event. All needed information about the drag should be passed to the event arguments. Drag start can be stopped by setting `Cancel=true`. 
	
	__DragDropManager DragInitialize event handler__  
<snippet id='dragdropmanager-events-block_3-cs' />

* `GiveFeedback`&mdash;This event occurs continuously during a drag-and-drop operation and enables the drop source to give feedback information to the user. This is a bubbling event. This feedback is commonly given by changing the appearance of the mouse pointer to indicate the effects allowed by the drop target.

	__DragDropManager GiveFeedback event handler__  
<snippet id='dragdropmanager-events-block_4-cs' />
 
* `QueryContinueDrag`&mdash;This event occurs when there is a change in the keyboard or mouse button states during a drag-and-drop operation and enables the drop source to cancel the drag-and-drop operation depending on the key/button states. This is a bubbling event.
	
	__DragDropManager QueryContinueDrag event handler__  
<snippet id='dragdropmanager-events-block_5-cs' />

* `PreviewGiveFeedback`&mdash;Tunneling version of GiveFeedback.

	__DragDropManager PreviewGiveFeedback event handler__  
<snippet id='dragdropmanager-events-block_6-cs' />

* `PreviewQueryContinueDrag`&mdash;Tunneling version of `QueryContinueDrag`.

	__DragDropManager PreviewQueryContinueDrag event handler__  
<snippet id='dragdropmanager-events-block_7-cs' />
	
* `DragDropCompleted`&mdash;This event occurs when an object is dropped on the drop target and is used to notify source for end of the drag operation. This is a bubbling event.

	__DragDropManager DragDropCompleted event handler__  
<snippet id='dragdropmanager-events-block_8-cs' />

## Drop Target Events

* `DragEnter`&mdash;This event occurs when an object is dragged into the drop target's boundary. This is a bubbling event.
* `DragLeave`&mdash;This event occurs when an object is dragged out of the drop target's boundary. This is a bubbling event.
* `DragOver`&mdash;This event occurs continuously while an object is dragged (moved) within the drop target's boundary. This is a bubbling event.
* `Drop`&mdash;This event occurs when an object is dropped on the drop target. This is a bubbling event.
* `PreviewDragEnter`&mdash;Tunneling version of DragEnter.
* `PreviewDragLeave`&mdash;Tunneling version of DragLeave.
* `PreviewDragOver`&mdash;Tunneling version of DragOver.
* `PreviewDrop`&mdash;Tunneling version of Drop.

All the drop target events share the same event arguments - `DragEventArgs` - therefore the same handler signature. The following example shows an event handler that can be used with all the previous events.

__DragOver PreviewDragEnter event handler__  

<snippet id='dragdropmanager-events-block_9-cs' />

## See Also

* [DragDropManager Migration]({%slug dragdropmanager-migration%})
