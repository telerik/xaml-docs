---
title: Set Drag Visual Offset
page_title: Set Drag Visual Offset
description: Set Drag Visual Offset
slug: dragdropmanager-howto-set-dragvisualoffset
tags: set,drag,visual,offset
publish: True
position: 5
---

# Set Drag Visual Offset



The DragVisualOffset property gets or sets the mouse offset relative to the drag source. You can use it in combination with the RelativeStartPoint properties of the DragInitializeEventArgs in order to calculate and set your own offset.

The RelativeStartPoint property gives you the relative coordinates of the mouse pointer when starting a drag operation. If you need an additional offset you can use the relative point, create a new one that has the necessary values. And then you can assign it to the DragVisualOffset property, like so: 

#### __C#__

{{region dragdropmanager-howto-set-dragvisualoffset_0}}
	    private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	          {     
	              args.DragVisualOffset = new Point(args.RelativeStartPoint.X - 25, args.RelativeStartPoint.Y - 25);              
	          }
	{{endregion}}



#### __VB.NET__

{{region dragdropmanager-howto-set-dragvisualoffset_1}}
	    Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
	        args.DragVisualOffset = New Point(args.RelativeStartPoint.X - 25, args.RelativeStartPoint.Y - 25)
	    End Sub
	{{endregion}}


