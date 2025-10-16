---
title: How to Show RadTileView Scrollbars in RadRibbonView Backstage
description: This article shows how to display the scrollbars of a RadTileView in the backstage of a RadRibbonView.
type: how-to
page_title: Scrolling RadTileView in RadRibbonView Backstage
slug: kb-tileview-display-scrollbars-in-ribbon-backstage
position: 0
tags: tileview, display, scrollbars, ribbon, backstage
ticketid: 1444060
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadTileView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display the scrollbars of a RadTileView in the backstage of a RadRibbonView.

## Solution

To achieve this requirement, you first need to disable the ScrollViewer's scrollbars of the **RadRibbonBackstage**.

__Example 1: Disabling the scrollbars of the RadRibbonBackstage__

```XAML
    <telerik:RadRibbonBackstage ScrollViewer.HorizontalScrollBarVisibility="Disabled" ScrollViewer.VerticalScrollBarVisibility="Disabled">
```

Then you need to enable the scrolling in RadTileView by setting its **ColumnsCount**, **RowHeight** and **ColumnWidth** properties as explained in [this article]({%slug radtileview-howto-enable-scrollbars%}).

__Example 2: Enabling the scrollbars of the RadTileView__

```XAML
    <telerik:RadTileView ColumnsCount="3" RowHeight="200" ColumnWidth="150">
```

## See Also
* [Enable the Horizontal and Vertical ScrollBars]({%slug radtileview-howto-enable-scrollbars%})
