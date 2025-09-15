---
title: Listbox Scroll Per Pixel
page_title: Scroll RadListBox Items Per Pixel
description: Scroll per pixel instead per item when scrolling the items of the RadListBox control.
type: how-to
slug: kb-listbox-scroll-per-pixel
position: 0
tags: listbox, radlistbox, scroll, pixel, scroll per pixel
ticketid: 1541477
res_type: kb
category: knowledge-base
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadListBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The default behavior of the RadListBox control, when scrolling, is to scroll per item. This article shows how to scroll the content of the __ListBox__ control per pixel.

## Solution

Set the [ScrollViewer.CanContentScroll](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer.cancontentscroll?view=windowsdesktop-6.0) attached property, onto the __RadListBox__ control, to __False__. This will allow the user to scroll per pixels rather than per items.



```XAML
    <telerik:RadListBox ScrollViewer.CanContentScroll="False"/>
```