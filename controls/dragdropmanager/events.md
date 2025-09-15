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
```C#	

	public MainWindow()
	{
		InitializeComponent();
	
		DragDropManager.AddDragInitializeHandler(source, new  Windows.DragDrop.DragInitializeEventHandler(OnDragInitialized));
		DragDropManager.AddDragDropCompletedHandler(source, new DragDropCompletedEventHandler(OnDragDropCompleted));
		DragDropManager.AddGiveFeedbackHandler(source, new Windows.DragDrop.GiveFeedbackEventHandler(OnGiveFeedBack));
		DragDropManager.AddQueryContinueDragHandler(source, new Windows.DragDrop.QueryContinueDragEventHandler(OnQueryContinue));
		DragDropManager.AddDragOverHandler(frameworkElement, OnElementDragOver);
		DragDropManager.AddDragLeaveHandler(frameworkElement, OnElementDragLeave);
		DragDropManager.AddDropHandler(frameworkElement, OnElementDrop);
		
		// to unsubscribe from an event, use the remove methods of DragDropManager
		// e.g.: 
		// DragDropManager.RemoveDragInitializeHandler(frameworkElement, OnDragInitialized);
		// DragDropManager.RemoveDragLeaveHandler(frameworkElement, OnElementDragLeave);
	}

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
```
```VB.NET
	Public Sub New()
		InitializeComponent()
		
		DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized))
		DragDropManager.AddDragDropCompletedHandler(Me, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
		DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
		DragDropManager.AddQueryContinueDragHandler(Me, New QueryContinueDragEventHandler(AddressOf OnQueryContinue))
		DragDropManager.AddDragOverHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragOver))
		DragDropManager.AddDragLeaveHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragLeave))
		DragDropManager.AddDropHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDrop)
	EndSub
	
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
```

In order for the `DragInitialize` event and the other [drag source events](#drag-source-events) to occur, the `DragDropManager.AllowDrag` or `DragDropManager.AllowCapturedDrag` attached property has to be set to `True` on the source element.

In order for the `Drop` and the other drop [Target Events](#drop-target-events) to occur, the [AllowDrop](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement.allowdrop?view=windowsdesktop-8.0) property of the drop target element has to be set to `True`.

__Setting AllowDrag and AllowDrop__  
```XAML	
	<Border x:Name="dragSource" telerik:DragDropManager.AllowDrag="True" />
	
	<Border x:Name="dropTarget" AllowDrop="True" />
```

## Drag Source Events

* `DragInitialize`&mdash;The DragInitialize event occurs when an object is about to be dragged. This is a bubbling event. All needed information about the drag should be passed to the event arguments. Drag start can be stopped by setting `Cancel=true`. 
	
	__DragDropManager DragInitialize event handler__  
	```C#	
		private void OnDragInitialized(object sender, DragInitializeEventArgs e)
		{
		 // sets the allowed effects of the drag/drop operation
		 e.AllowedEffects = DragDropEffects.All;

		 // sets the drag visual/cue shown during the drag/drop action
		 e.DragVisual = new TextBlock() { Text = "Dragging..." };

		 // sets the dragged data
		 e.Data = myDragPayload;

		 // sets the offset of the DragVisual from the mouse position
		 e.DragVisualOffset = new Point(10, 10);

		 // set e.Cancel if the drag operation shouldn't start
		 //e.Cancel = true;
		}
	```

* `GiveFeedback`&mdash;This event occurs continuously during a drag-and-drop operation and enables the drop source to give feedback information to the user. This is a bubbling event. This feedback is commonly given by changing the appearance of the mouse pointer to indicate the effects allowed by the drop target.

	__DragDropManager GiveFeedback event handler__  
	```C#	
		private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
		{
			DragDropEffects effects = e.Effects;
			
			// set this to false in order to hide the default cursor shown during the drag/drop operation
			e.UseDefaultCursors = false;
			
			// use this method to set a custom cursor
			e.SetCursor(Cursors.Wait);
		}
	```	
 
* `QueryContinueDrag`&mdash;This event occurs when there is a change in the keyboard or mouse button states during a drag-and-drop operation and enables the drop source to cancel the drag-and-drop operation depending on the key/button states. This is a bubbling event.
	
	__DragDropManager QueryContinueDrag event handler__  
	```C#	
		private void OnQueryContinue(object sender, Telerik.Windows.DragDrop.QueryContinueDragEventArgs args)
		{
			bool isEscapePressed = e.EscapePressed;
			
			// gets or sets the status of the drag operation
			e.Action = DragAction.Continue;
			
			// holds information about the state of the modifier keys on the keyboard and the mouse buttons
			DragDropKeyStates keyStates = e.KeyStates;
		}
	```		

* `PreviewGiveFeedback`&mdash;Tunneling version of GiveFeedback.

	__DragDropManager PreviewGiveFeedback event handler__  
	```C#	
		private void OnPreviewGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
		{
			DragDropEffects effects = e.Effects;
			
			// set this to false in order to hide the default cursor shown during the drag/drop operation
			e.UseDefaultCursors = false;
			
			// use this method to set a custom cursor
			e.SetCursor(Cursors.Wait);
		}
	```	

* `PreviewQueryContinueDrag`&mdash;Tunneling version of `QueryContinueDrag`.

	__DragDropManager PreviewQueryContinueDrag event handler__  
	```C#	
		private void OnPreviewQueryContinue(object sender, Telerik.Windows.DragDrop.QueryContinueDragEventArgs args)
		{
			bool isEscapePressed = e.EscapePressed;
			
			// gets or sets the status of the drag operation
			e.Action = DragAction.Continue;
			
			// holds information about the state of the modifier keys on the keyboard and the mouse buttons
			DragDropKeyStates keyStates = e.KeyStates;
		}
	```	
	
* `DragDropCompleted`&mdash;This event occurs when an object is dropped on the drop target and is used to notify source for end of the drag operation. This is a bubbling event.

	__DragDropManager DragDropCompleted event handler__  
	```C#	
		private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
		{
			DragDropEffects effects = e.Effects;
			object draggedData = e.Data;
		}
	```	

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
	```C#	
		private void OnDragOver(object sender, DragEventArgs e)
		{
			// gets the effects allowed by the originator of the drag/drop operation in DragInitialize
			DragDropEffects allowedEffects = e.AllowedEffects;
			
			// sets the drag/drop effects for the hovered element
			e.Effects = DragDropEffects.All;
			
			// gets the dragged data object
			object draggedData = e.Data;	
		}
	```

## See Also

* [DragDropManager Migration]({%slug dragdropmanager-migration%})
