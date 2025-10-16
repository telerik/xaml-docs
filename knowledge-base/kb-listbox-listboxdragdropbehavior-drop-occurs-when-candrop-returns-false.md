---
title: The ListBoxDragDropBehavior's Drop Event Occurs When CanDrop Returns False
description: Drop event can occur even when CanDrop returns false when moving fast with the mouse.
page_title: Returning False From CanDrop Can Sometimes Raise the Drop Event From the RadListBox's Default DragDropBehavior
type: how-to
slug: kb-listbox-listboxdragdropbehavior-drop-occurs-when-candrop-returns-false
position: 0
tags: listbox, listboxdragdropbehavior, candrop, false, drop
res_type: kb
ticketid: 1621835
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.3.1114</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadListBox for WPF</td>
	</tr>
</table>

## Description

The `Drop` event handler of the `RadListBox`'s default `ListBoxDragDropBehavior` can occur even if the `CanDrop` event returns __false__. This can be present in a scenario when moving fast with the mouse while dragging and dropping an element.

This behavior comes from the WPF framework. When dragging and dropping an element fast, the visual elements that are part of the RadListBoxItem's `ControlTemplate` invoke the `Drop` method. It is then bubbled to the RadListBox control.

## Solution

Create a new class that derives from the `ListBoxDragDropBehavior` and override the `Drop` method. In it, retrieve the return value of the the `CanDrop` method invocation. If the return value is __true__, call the base Drop method.

__Custom ListBoxDragDropBehavior with overridden Drop method__
```C#
	public class CustomListBoxDragDropBehavior : ListBoxDragDropBehavior
	{
	    public override void Drop(DragDropState state)
	    {
	        if (this.CanDrop(state))
	        {
	            base.Drop(state);
	        }
	    }
	}
```
```VB.NET
	Public Class CustomListBoxDragDropBehavior
	    Inherits ListBoxDragDropBehavior

	    Public Overrides Sub Drop(ByVal state As DragDropState)
	        If Me.CanDrop(state) Then
	            MyBase.Drop(state)
	        End If
	    End Sub
	End Class
```