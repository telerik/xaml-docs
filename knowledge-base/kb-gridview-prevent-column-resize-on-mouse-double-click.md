---
title: Prevent GridView Column Resize on Mouse Double-Click
page_title: How to Prevent Resize of Column On Double-Click
description: This article shows how to prevent the column from resizing when double clicking its header.
type: how-to
slug: kb-gridview-prevent-column-resize-on-mouse-double-click
position: 0
tags: column resize, double-click resize, mouse click resize
ticketid: 1577940
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2 621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

RadGridView column resizes, when a double-click is performed between the header cells.

## Solution

1. Add a new event handler for the `PreviewMouseDoubleClick` event of the `GridViewHeaderCell` element via the `AddHandler` method.

__Add a new event handler for the PreviewMouseDoubleClick of the GridViewHeaderCell element__
```C#
    this.AddHandler(GridViewHeaderCell.PreviewMouseDoubleClickEvent, new MouseButtonEventHandler(OnPreviewMouseDoubleClick));
```
```VB.NET
    Me.AddHandler(GridViewHeaderCell.PreviewMouseDoubleClickEvent, New MouseButtonEventHandler(OnPreviewMouseDoubleClick))
```

2. In the new event handler, set the `e.Handled` property to `true`, if the `e.OriginalSource` is of type` Border`.

__Prevent the PreviewMouseDoubleClick event from bubbling if the OriginalSource is of type Border__
```C#
    private void OnPreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (e.OriginalSource is Border)
        {
            e.Handled = true;
        } 
    }
```
```VB.NET
    Private Sub OnPreviewMouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        If TypeOf e.OriginalSource Is Border Then
            e.Handled = True
        End If
    End Sub
```
