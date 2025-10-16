---
title: Enabling Horizontal Scroll for Group Header in RadGridView
description: Learn how to make the GroupHeaderRow in DataGrid for WPF scroll horizontally together with the grid content.
type: how-to
page_title: How to Enable Horizontal Scrolling on GroupHeaderRow in RadGridView
slug: kb-gridview-horizontal-scroll-groupheaderrow
tags: radgridview, wpf, groupheaderrow, horizontal, scroll, customization
res_type: kb
ticketid: 1668005
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
<td>2024.3.924</td>
</tr>
</tbody>
</table>

## Description

How to enable horizontal scrolling in the group header row of RadGridView for WPF.

## Solution

By default the GroupHeaderRow element doesn't scroll horizontally. To allow this, you can set the `SelectiveScrollingGrid.SelectiveScrollingOrientation` attached property on one of the visual children of the row. 

You can do this by [modifying the GroupHeaderRow's ControlTemplate]({%slug styling-apperance-editing-control-templates%}) or programmatically through the `RowLoaded` event. Basically, you need to find the `ToggleButton` element with `x:Name="HeaderButton"` and set the attached property on it.

The following example shows how to use the `RowLoaded` event.


```C#
	private void gridView_RowLoaded(object sender, Telerik.Windows.Controls.GridView.RowLoadedEventArgs e)
	{
		if (e.Row is GroupHeaderRow)
		{
			var button = e.Row.ChildrenOfType<ToggleButton>()
				.FirstOrDefault(x => Telerik.Windows.Controls.GridView.SelectiveScrollingGrid.GetSelectiveScrollingOrientation(x) == SelectiveScrollingOrientation.Vertical);         
			Telerik.Windows.Controls.GridView.SelectiveScrollingGrid.SetSelectiveScrollingOrientation(button, SelectiveScrollingOrientation.Both);
			Telerik.Windows.Controls.GridView.SelectiveScrollingGrid.SetSelectiveScrollingClip(button, true);
		}
	}
```

