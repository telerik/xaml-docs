---
title: How to Auto-Size RadGridView's Rows
description: Auto-size the rows of the RadGridView control based on its height.
type: how-to
page_title: Automatically adjust the RowHeight based on the size of the RadGridView control.
slug: kb-gridview-howto-autosize-rows
tags: rows, resize, auto, height
ticketid: 1416431
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.1.220</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to auto-size the rows of the RadGridView control based on its height.

## Solution

1. Define the following method in the code-behind of the control which holds your RadGridView instance:
	
	```C#
		private void AdjustRowHeight()
		{
			var scrollViewer = this.radGridView.ChildrenOfType<GridViewScrollViewer>().First();
			double rowHeight = (scrollViewer.ActualHeight - scrollViewer.HeaderRow.ActualHeight) / this.radGridView.Items.Count;
			if (rowHeight > 0)
			{
				this.radGridView.RowHeight = rowHeight;
			}
		}
	```

What this does is to get the actual height of the **GridViewScrollViewer** - which is the element that holds all the rows of the control - and subtract from it the height of the header row element. This height is then divided by the total row count.

2. Call the **AdjustRowHeight** method in the **Loaded** and **SizeChanged** events of the RadGridView control:
	
	```C#
		private void RadGridView_Loaded(object sender, RoutedEventArgs e)
		{
			this.AdjustRowHeight();
		}

		private void RadGridView_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			this.AdjustRowHeight();
		}
	```

## See Also
* [ChildrenOfType]({%slug common-visual-tree-helpers%})
