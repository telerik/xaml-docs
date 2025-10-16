---
title: How to Change Drop Preview Line Color
page_title: Change the Drop Preview Line Color when Dragging an Item
description: This article explains how to change the color of the drop preview line by setting a style targeting the LinearDropVisual element.
type: how-to
slug: kb-dragdropmanager-change-drop-preview-line-color
position: 0
tags: drop line color, preview line color, preview line, drop preview line color, line color
ticketid: 1537650
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.3.914</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>DragDropManager for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to change the color of the Drop Preview Line visual element.

## Solution

To change the color, create a style targeting the __LinearDropVisual__ element. Then set the __BorderBrush__ property to the desired color.



```XAML	
	<Style TargetType="telerik:LinearDropVisual">
		<Setter Property="BorderBrush" Value="Green"/>
	</Style>
```
