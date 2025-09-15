---
title: How to Center the Zoom on the Selected Items
page_title: Zoom in the region of the Selected Shapes
description: How to Center the Zoom on the Selection.
type: how-to
slug: kb-diagram-howto-zoom-in-selection
position: 0
tags: center, zoom, selection
ticketid: 1448223
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
			<td>RadDiagram for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to force the zoom operation inside the selection boundaries.

## Solution

Handle the __PreviewZoom__ event of the RadDiagram and use its __BringIntoView__ method in conjunction with its __Zoom__ property. 


```C#
	private void diagram_PreviewZoom(object sender, Telerik.Windows.Controls.Diagrams.DiagramZoomEventArgs e)
    {
        e.Handled = true;
        this.diagram.BringIntoView(diagram.SelectionBounds, false);
        this.diagram.Zoom = e.TargetZoom;
    }
```