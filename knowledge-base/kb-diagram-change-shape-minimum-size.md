---
title: How to Resize Shape Below 15 Pixels
page_title: Change RadDiagramShape Minimum Size
description: Use the DiagramConstants class to lower the minimum width and height of the RadDiagram shapes.
type: how-to
slug: kb-diagram-change-shape-minimum-size
position: 0
tags: minimum,size,15,diagram
ticketid: 1428358
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.618</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDiagram for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to resize RadDiagramShape below the minimum size of 15px.

## Solution

Set the __DiagramConstants.MinimumShapeSize__ and __DiagramConstants.MinimumAdornerSize__ properties.


```C#
	public MainWindow()
	{
		DiagramConstants.MinimumAdornerSize = 3;
		DiagramConstants.MinimumShapeSize = 3;
		
		InitializeComponent();
	}
```
