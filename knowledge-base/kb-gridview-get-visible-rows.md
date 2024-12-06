---
title: Get Visible Rows in RadGridView
description: How to get the visible rows (GridViewRow) containers of RadGridView in the viewport.
type: how-to
page_title: Access the GridViewRow Containers in the Viewport of Telerik DataGrid
slug: kb-gridview-get-visible-rows
tags: radgridview, wpf, data-binding, mvvm, observablecollection, row-data
res_type: kb
ticketid: 1672688
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadGridView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

How to get the visible rows (GridViewRow) containers of RadGridView in the viewport.

## Solution

To get the visible rows, you can first use the [ChildrenOfType<T> extension method]({%slug common-visual-tree-helpers%}). This will allow you to access the generated `GridViewRow` containers. These are the containers within the viewport, plus couple more below and above the viewport. 

Then, you can iterate the rows collection and get only the rows which bounds are contained in the bounds of the parent `GridViewVirtualizingPanel`.

#### __[C#]__
{{region kb-gridview-get-visible-rows-0}}
	 private void GetVisibleRowsButton_Click(object sender, RoutedEventArgs e)
	 {
		 var panel = this.gridView.FindChildByType<GridViewVirtualizingPanel>();
		 var visibleRows = this.gridView.ChildrenOfType<GridViewRow>().Where(row => IsRowInViewport(panel, row));            
	 }

	 bool IsRowInViewport(GridViewVirtualizingPanel panel, UIElement element)
	 {
		 var transform = element.TransformToVisual(panel);
		 var startPosition = transform.Transform(new Point(0, 0));

		 var elementBounds = new Rect(startPosition, new Size(1, element.DesiredSize.Height));
		 var viewport = new Rect(new Point(0, 0), new Size(panel.ViewportWidth, panel.ViewportHeight));

		 bool result = viewport.Contains(elementBounds);
		 return result;
	 }
{{endregion}}

