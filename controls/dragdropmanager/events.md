---
title: Events
page_title: Events
description: Events
slug: dragdropmanager-events
tags: events
published: True
position: 3
---

# Events



__DragDropManager__ supports an event driven model. Both the drag source and the drop target use a standard set of events to handle drag-and-drop operations. The following tables summarize the standard drag-and-drop events.  

## Drag Source Events

* __DragInitialize__ -  The DragInitialize event occurs when an object is about to be dragged. All needed information about the drag should be passed to the event arguments. Drag start can be stopped by setting Cancel=true. This is a bubbling event.

* __GiveFeedback__ - This event occurs continuously during a drag-and-drop operation and enables the drop source to give feedback information to the user. This feedback is commonly given by changing the appearance of the mouse pointer to indicate the effects allowed by the drop target. This is a bubbling event.

* __QueryContinueDrag__ - This event occurs when there is a change in the keyboard or mouse button states during a drag-and-drop operation and enables the drop source to cancel the drag-and-drop operation depending on the key/button states. This is a bubbling event.

* __PreviewGiveFeedback__ - Tunneling version of GiveFeedback.

* __PreviewQueryContinueDrag__ - Tunneling version of QueryContinueDrag.

* __DragDropCompleted__ - This event occurs when an object is dropped on the drop target and is used to notify source for end of the drag operation. This is a bubbling event.

## Drop Target Events

* __DragEnter__ - This event occurs when an object is dragged into the drop target's boundary. This is a bubbling event.

* __DragLeave__ - This event occurs when an object is dragged out of the drop target's boundary. This is a bubbling event.

* __DragOver__ - This event occurs continuously while an object is dragged (moved) within the drop target's boundary. This is a bubbling event.

* __Drop__ - This event occurs when an object is dropped on the drop target. This is a bubbling event.

* __PreviewDragEnter__ - Tunneling version of DragEnter.

* __PreviewDragLeave__ - Tunneling version of DragLeave.

* __PreviewDragOver__ - Tunneling version of DragOver.

* __PreviewDrop__ - Tunneling version of Drop.



## How to attach DragDrop Events

The code snippet below illustrates how to attach to the DragDrop events:

#### __C#__

{{region dragdropmanager-events_0}}
	
	DragDropManager.AddDragInitializeHandler(source, new  Windows.DragDrop.DragInitializeEventHandler(OnDragInitialized));
	DragDropManager.AddDragDropCompletedHandler(source, new DragDropCompletedEventHandler(OnDragDropCompleted));
	DragDropManager.AddGiveFeedbackHandler(source, new Windows.DragDrop.GiveFeedbackEventHandler(OnGiveFeedBack));
	DragDropManager.AddQueryContinueDragHandler(source, new Windows.DragDrop.QueryContinueDragEventHandler(OnQueryContinue));
	DragDropManager.AddDragOverHandler(frameworkElement, OnElementDragOver);
	DragDropManager.AddDragLeaveHandler(frameworkElement, OnElementDragLeave);
	DragDropManager.AddDropHandler(frameworkElement, OnElementDrop);
	
	private void OnDragInitialized(object sender, DragInitializeEventArgs e)
	{
	}
	
	private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
	{
	}
	
	private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
	{
	}
	
	private void OnQueryContinue(object sender, Telerik.Windows.DragDrop.QueryContinueDragEventArgs args)
	{
	}
	
	private void OnElementDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
	}
	
	private void OnElementDragLeave(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
	{
	}
	
	private void OnElementDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
	}
	
	{{endregion}}



#### __VB.NET__

{{region dragdropmanager-events_1}}
	DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized))
	DragDropManager.AddDragDropCompletedHandler(Me, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
	DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
	DragDropManager.AddQueryContinueDragHandler(Me, New QueryContinueDragEventHandler(AddressOf OnQueryContinue))
	DragDropManager.AddDragOverHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragOver))
	DragDropManager.AddDragLeaveHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragLeave))
	DragDropManager.AddDropHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDrop)
	
	Private Sub OnDragInitialized(sender As Object, e As DragInitializeEventArgs)
	    End Sub
	
	Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
	    End Sub
	
	Private Sub OnGiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
	    End Sub
	
	Private Sub OnQueryContinue(sender As Object, e As QueryContinueDragEventArgs)
	    End Sub
	
	Private Sub OnElementDragOver(sender As Object, e As DragEventArgs)
	    End Sub
	
	Private Sub OnElementDrop(sender As Object, e As DragEventArgs)
	    End Sub
	
	Private Sub OnElementDragLeave(sender As Object, e As DragEventArgs)
	    End Sub
	
	{{endregion}}




