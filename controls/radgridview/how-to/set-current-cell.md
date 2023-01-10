---
title: Set the Current Cell
page_title: Set the Current Cell
description: Learn how to set the current cell of the Telerik {{ site.framework_name }} DataGrid by specifying an item from the Items collection and a column from the Columns collection.
slug: gridview-how-to-set-current-cell
tags: set,the,current,cell
published: True
position: 5
---

# {{ site.framework_name }} RadGridView Set the Current Cell

You can set the current cell of the RadGridView control by using the __CurrentCellInfo__ class.

**Example 1** demonstrates how to so in the **Loaded** event handler by specifying an item from the control's **Items** collection and a column from the **Columns** collection.

#### __[C#] Example 1: Setting the current cell via an item and a column__

{{region cs-gridview-how-to-set-current-cell_0}}
	private void gridView_Loaded(object sender, EventArgs e)
	{
        gridView.CurrentCellInfo = new GridViewCellInfo(gridView.Items[5], gridView.Columns["Number"]);
        gridView.Focus();
	}
{{endregion}}

#### __[VB.NET] Example 1: Setting the current cell via an item and a column__

{{region vb-gridview-how-to-set-current-cell_1}}
	Private Sub gridView_Loaded(ByVal sender As Object, ByVal e As EventArgs)
		gridView.CurrentCellInfo = New GridViewCellInfo(gridView.Items(5), gridView.Columns("Number"))
		gridView.Focus()
	End Sub
{{endregion}}

>important Please note that for this to work, the control must be loaded.

**Figure 1** demonstrates that the current cell is set and at this point if you hit **F2** that cell will go in edit mode.

{% figure 1, "RadGridView with changed current cell", "gridview_set_current_cell.png" %}

## See Also

* [Change Background for Disabled Grid Elements]({%slug gridview-how-to-set-background-disabled-cell%})
* [Cancel Edit On LostFocus]({%slug gridview-how-to-cancel-edit-on-lost-focus%})
