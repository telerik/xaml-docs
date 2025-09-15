---
title: Data Validation Lost on Switch Tabs 
description: Validation Gone When Changing Tabs in RadTabControl and LayoutControl.
page_title: Red Validation Borders Missing When Changing the Selected Tab of RadTabControl or LayoutControlTabGroup.
type: troubleshooting
slug: tabcontrol-validation-lost-on-switch-tabs
position: 0
tags: data,validation,switch,tabs
ticketid: 1428459
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.510</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadTabControl for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The red validation border is lost when switching tabs in RadTabControl or LayoutControlTabGroup.

## Solution

To resolve this, wrap the content of the corresponding tab item (RadTabItem or LayoutControlTabGroupItem) in an AdornerDecorator element.


```XAML
	<telerik:RadTabItem Header="Tab 1">
	   <AdornerDecorator>
			<TextBox />
	   </AdornerDecorator>
	</telerik:RadTabItem>
```
