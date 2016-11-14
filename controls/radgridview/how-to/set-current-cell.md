---
title: Set the current cell
page_title: Set the current cell
description: Set the current cell
slug: gridview-how-to-set-current-cell
tags: set,the,current,cell
published: True
position: 5
---

# Set the current cell

As of __Q1 2010 SP2__ release, you are able to set the current cell of the gridview by using the __CurrentCellInfo__ class. In the older version you could only get the current cell, but not set it.

The code below shows how to set the current cell (it will be on the sixth row and in the second column):

#### __C#__

{{region cs-gridview-how-to-set-current-cell_0}}
	private void gridView_DataLoaded(object sender, EventArgs e)
	{
	    Dispatcher.BeginInvoke(new Action(() =>
	    {
	        gridView.CurrentCellInfo = new GridViewCellInfo(gridView.Items[5], gridView.Columns["Text"]);
	        gridView.Focus();
	    }));
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-how-to-set-current-cell_1}}
	Private Sub gridView_DataLoaded(ByVal sender As Object, ByVal e As EventArgs)
		Dispatcher.BeginInvoke(New Action(Sub()
			gridView.CurrentCellInfo = New GridViewCellInfo(gridView.Items(5), gridView.Columns("Text"))
			gridView.Focus()
		End Sub))
	End Sub
{{endregion}}

As you can see in the code above, to set the current cell you need to set the row (via the Items collection) and the column (via the Columns collection).

The screenshot below shows that the current cell is set and now if you hit F2 that cell will go in edit mode.

![](images/gridview_set_current_cell.png)


