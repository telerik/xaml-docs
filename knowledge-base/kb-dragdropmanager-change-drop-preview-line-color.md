---
title: How to Change Drop Preview Line color
page_title: Change Drop Preview Line color when dragging an item.
description: Set a style targeting telerik:LinearDropVisual element.
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

To change the color, create a style and target the __LinearDropVisual__ element. Then set the __BorderBrush__ property to the desired color.

#### __[XAML]__

{{region kb-dragdropmanager-change-drop-preview-line-color-0}}	
	<Style TargetType="telerik:LinearDropVisual">
		<Setter Property="BorderBrush" Value="Green"/>
	</Style>
{{endregion}}