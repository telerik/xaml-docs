---
title: Handle Cell\Row Mouse Events
page_title: Handle Cell\Row Mouse Events
description: Check out our article demonstrating how to add handlers for the various mouse events to the cell and row elements in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-handle-cell-row-mouse-events
tags: handle,cell,row,mouse,events
published: True
position: 6
---

# Handle Cell\Row Mouse Events

This article will demonstrate how to handle RadGridView's [CellLoaded](#cellloaded-event) & [RowLoaded](#rowloaded-event) events to add handlers for the various mouse events to the control's cell and row elements. The [CellUnloaded](#cellunloaded-event) and [RowUnloaded](#rowunloaded-event) events can in turn be used to remove those handlers in order to avoid memory leaks.

>important You should **not** directly set properties of the visual elements (**GridViewCell**, **GridViewRow**) as this will result in inconsistent behavior due to the control's [UI Virtualization]({%slug radgridview-features-ui-virtualization%}) mechanism. Instead, you should use the underlying data items.

## CellLoaded Event

The **CellLoaded** event fires anytime a cell appears in the viewport.

The **CellLoaded** event handler receives two arguments:

* The **sender** argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **CellEventArgs** object. This object exposes a **Cell** property - the loaded cell.

**Example 1** uses the CellLoaded event to handle the left-click on a **GridViewCell** and **GridViewHeaderCell**.

__Example 1: Handling CellLoaded__
```C#
	private void RadGridView_CellLoaded(object sender, RowLoadedEventArgs e)  
	{  
		if (e.Cell is GridViewHeaderCell)
		{
			e.Cell.AddHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnHeaderCellMouseLeftButtonDown), true);
		}
		else if (e.Cell is GridViewCell)
		{
			e.Cell.AddHandler(GridViewCell.MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnCellMouseLeftButtonDown), true);
		}
	}

	private void OnHeaderCellMouseLeftButtonDown(object sender, MouseButtonEventArgs mouseButtonEventArgs)
	{
	    MessageBox.Show("Left-clicked header cell!");
	}

	private void OnCellMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		MessageBox.Show("Left-clicked cell!");
	}
```
```VB.NET
	Private Sub RadGridView_CellLoaded(ByVal sender As Object, ByVal e As RowLoadedEventArgs)
		If TypeOf e.Cell Is GridViewHeaderCell Then
			e.Cell.AddHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, New MouseButtonEventHandler(OnHeaderCellMouseLeftButtonDown), True)
		ElseIf TypeOf e.Cell Is GridViewCell Then
			e.Cell.AddHandler(GridViewCell.MouseLeftButtonDownEvent, New MouseButtonEventHandler(AddressOf OnCellMouseLeftButtonDown), True)
		End If
	End Sub

	Private Sub OnHeaderCellMouseLeftButtonDown(ByVal sender As Object, ByVal mouseButtonEventArgs As MouseButtonEventArgs)
		MessageBox.Show("Left-clicked header cell!")
	End Sub

	Private Sub OnCellMouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
		MessageBox.Show("Left-clicked cell!")
	End Sub
```

## CellUnloaded event

The **CellUnloaded** event occurs anytime a cell disappears from the viewport.

The **CellUnloaded** event handler receives two arguments:

* The sender argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **CellEventArgs** object. This object exposes a **Cell** property - the unloaded cell.

A common scenario in which the CellUnloaded can be used is to remove the handler(s) added in the CellLoaded event.

__Example 2: Handling CellUnloaded__
```C#
	private void RadGridView_CellUnloaded(object sender, CellEventArgs e)
	{
		e.Cell.RemoveHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnHeaderCellMouseLeftButtonDown));
		e.Cell.RemoveHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnCellMouseLeftButtonDown));
	}
```
```VB.NET
	Private Sub RadGridView_CellUnloaded(ByVal sender As Object, ByVal e As CellEventArgs)
		e.Cell.RemoveHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, New MouseButtonEventHandler(OnHeaderCellMouseLeftButtonDown))
		e.Cell.RemoveHandler(GridViewHeaderCell.MouseLeftButtonDownEvent, New MouseButtonEventHandler(OnCellMouseLeftButtonDown))
	End Sub
```

## RowLoaded Event

The **RowLoaded** event fires anytime a row appears in the viewport.

The **RowLoaded** event handler receives two arguments:

* The **sender** argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **RowLoadedEventArgs** object. This object has the following properties:

	* **DataElement**: Gets the data element (data context) for the row being loaded.
	
	* **GridViewDataControl**: The **GridViewDataControl** control holding the row being loaded.
	
	* **Row**: The row being loaded.

**Example 1** uses the RowLoaded event to handle the right-click on a **GridViewRow**.

__Example 3: Handling RowLoaded\RowUnloaded__
```C#
	private void RadGridView_RowLoaded(object sender, RowLoadedEventArgs e)  
	{  
		if (e.Row is GridViewRow && !(e.Row is GridViewNewRow))  
	    {  
	    	e.Row.AddHandler(GridViewRow.MouseRightButtonDownEvent, new MouseButtonEventHandler(OnMouseRightButtonDown), true);
	    }  
	}

	private void OnMouseRightButtonDown(object sender, MouseButtonEventArgs mouseButtonEventArgs)
	{
		var row = sender as GridViewRow;
		var club = row.DataContext as Club;
		MessageBox.Show($"Right-clicked {club.Name}!");
	}
```
```VB.NET
	Private Sub RadGridView_RowLoaded(ByVal sender As Object, ByVal e As RowLoadedEventArgs)
		If TypeOf e.Row Is GridViewRow AndAlso Not (TypeOf e.Row Is GridViewNewRow) Then
			e.Row.AddHandler(GridViewRow.MouseRightButtonDownEvent, New MouseButtonEventHandler(OnMouseRightButtonDown), True)
		End If
	End Sub

	Private Sub OnMouseRightButtonDown(ByVal sender As Object, ByVal mouseButtonEventArgs As MouseButtonEventArgs)
		Dim row = TryCast(sender, GridViewRow)
		Dim club = TryCast(row.DataContext, Club)
		MessageBox.Show($"Right-clicked {club.Name}!")
	End Sub
```

## RowUnloaded event

The **RowUnloaded** event occurs anytime a row disappears from the viewport.

The **RowUnloaded** event handler receives two arguments:

* The sender argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **RowLoadedEventArgs** object. This object has the following properties:

	* **DataElement**: Gets the data element (data context) for the row being unloaded.

	* **GridViewDataControl**: The gridview control holding the row being unloaded.

	* **Row**: The row being unloaded.

A common scenario in which the RowUnloaded can be used is to remove the handler(s) added in the RowLoaded event.

__Example 4: Handling CellUnloaded__
```C#
	private void RadGridView_RowUnloaded(object sender, RowUnloadedEventArgs e)
	{
		e.Row.RemoveHandler(GridViewRow.MouseRightButtonDownEvent, new MouseButtonEventHandler(OnMouseRightButtonDown));
	}
```
```VB.NET
	Private Sub RadGridView_RowUnloaded(ByVal sender As Object, ByVal e As RowUnloadedEventArgs)
		e.Row.RemoveHandler(GridViewRow.MouseRightButtonDownEvent, New MouseButtonEventHandler(OnMouseRightButtonDown))
	End Sub
```
