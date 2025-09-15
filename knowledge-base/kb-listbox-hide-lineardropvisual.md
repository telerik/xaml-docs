---
title: Remove the Preview Drop Line from RadListBox
description: How to hide the LinearDropVisual element when using ListBoxDragDropBehavior.
type: how-to
page_title: Hide the Linear Drop Visual in Telerik WPF ListBox
slug: kb-listbox-hide-lineardropvisual
position: 0
tags: dragdrop
ticketid: 1538096
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.2.615</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadListBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to hide the horizontal line (LinearDropVisual) displayed on drag over elements in RadListBox when the ListBoxDragDropBehavior is enabled.

## Solution

Create an implicit style targeting the LinearDropVisual control and set its Visibility to Collapsed.


```XAML
	<telerik:RadListBox.Resources>
		<Style TargetType="telerik:LinearDropVisual">
			<Setter Property="Visibility" Value="Collapsed" />
		</Style>
	</telerik:RadListBox.Resources>
```