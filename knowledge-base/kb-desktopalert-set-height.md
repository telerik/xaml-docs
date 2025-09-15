---
title: How to Make RadDesktopAlert's Height scale Based on its Content.
description: This article shows how you can set the height of RadDesktopAlert to be set based on its content's height.
page_title: Make DesktopAlert's Height Change Based on its Content.
type: how-to
slug: kb-desktopalert-set-height
position: 0
tags: wpf, desktopalert, height, scale, content
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.2.514</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadListBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The `RadDesktopAlert`'s `Height` property is set to a certain value based on the theme that is applied. This will cause the content to not be fully displayed in scenarios where the value set to the `Content` property exceeds the predefined height value.

## Solution

To scale the height of the RadDesktopAlert's height based on the displayed content, set the Height property to `Auto`.

__Setting the Height property of RadDesktopAlert to Auto__
```XAML
	<telerik:RadDesktopAlert Height="Auto"/>
```