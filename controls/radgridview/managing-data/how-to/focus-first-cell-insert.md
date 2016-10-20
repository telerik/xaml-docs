---
title: Always focus the first cell on insert 
page_title: Always focus the first cell on insert 
description: Always focus the first cell on insert 
slug: gridview-how-to-focus-first-cell-insert
tags: always,focus,the,first,cell,on,insert,
published: True
position: 4
---

# Always focus the first cell on insert 

When you insert a new item (via the Insert key or the insert row) RadGridView will check which is your current column and focus that column in the newly added and probably blank row. This picture explains it better:

![](images/how_to_focus_first_cell.png)

This article shows how to make always the first column be focused when a new item is about to be inserted. You need to subscribe to the __AddingNewDataItem__ event of the RadGridView and set the current column in its event handler:

#### __C#__

{{region cs-gridview-how-to-focus-first-cell-insert_0}}
	private void clubsGrid_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
	{
	    var grid = e.OwnerGridViewItemsControl;
	    grid.CurrentColumn = grid.Columns[0];
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-how-to-focus-first-cell-insert_1}}
	Private Sub clubsGrid_AddingNewDataItem(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs)
	    Dim grid = e.OwnerGridViewItemsControl
	    grid.CurrentColumn = grid.Columns(0)
	End Sub
{{endregion}}

Now, no matter which is the current column, when you insert a new item - the first cell will always get the focus. 


