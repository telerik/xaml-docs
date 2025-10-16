---
title: Set Drag Visual Offset
page_title: Set Drag Visual Offset
description: Check our &quot;Set Drag Visual Offset&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-howto-set-dragvisualoffset
tags: set,drag,visual,offset
published: True
position: 5
---

# Set Drag Visual Offset

The drag visual offset is the offset of the drag visual relative to the drag source element.

The offset can be set in the __DragDropManager.DragInitialize__ event handler, via the __DragVisualOffset__ property of DragInitializeEventArgs.

The DragVisualOffset property can be used in combination with the __RelativeStartPoint__ property of DragInitializeEventArgs in order to calculate and set a proper offset. The RelativeStartPoint property gives you the relative coordinates of the mouse cursor when starting a drag operation.

__Example 1: Setting up the view__
```XAML
	<Border x:Name="element" Background="#27A306" Width="100" Height="100" telerik:DragDropManager.AllowDrag="True" AllowDrop="True" />
```

__Example 2: Setting DragVisualOffset__
```C#
	public MainWindow()
	{
		InitializeComponent();
		DragDropManager.AddDragInitializeHandler(this.element, OnElementDragInitialize);
	}

	private void OnElementDragInitialize(object sender, DragInitializeEventArgs e)
	{
		e.AllowedEffects = DragDropEffects.All;
		e.DragVisual = new TextBlock() { Text = "Dragging...", Background = Brushes.Bisque };

		e.DragVisualOffset = new Point(e.RelativeStartPoint.X - 25, e.RelativeStartPoint.Y - 25);
	}
```
```VB.NET	
    Public Sub New()
        InitializeComponent()
        DragDropManager.AddDragInitializeHandler(Me.element, AddressOf OnElementDragInitialize)
    End Sub

    Private Sub OnElementDragInitialize(ByVal sender As Object, ByVal e As DragInitializeEventArgs)
        e.AllowedEffects = DragDropEffects.All
        e.DragVisual = New TextBlock() With {
            .Text = "Dragging...",
            .Background = Brushes.Bisque
        }
		
        e.DragVisualOffset = New Point(e.RelativeStartPoint.X - 25, e.RelativeStartPoint.Y - 25)
    End Sub
```

![{{ site.framework_name }} Set Drag Visual Offset](images/dragdropmanager-howto-set-dragvisualoffset-0.png)
