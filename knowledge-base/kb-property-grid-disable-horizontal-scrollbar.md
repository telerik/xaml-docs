---
title: Disable the Horizontal Scrollbar of RadPropertyGrid
page_title: How to Hide Horizontal Scrollbar
description: This article will show you how to disable the horizontal scrollbar of RadPropertyGrid.
type: how-to
slug: kb-property-grid-disable-horizontal-scrollbar
position: 0
tags: horizontal, scrollbar, propertygrid
ticketid: 1548960
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2 621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadPropertyGrid for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Setting the `ScrollViewer.HorizontalScrollBarVisibility` directly onto the `RadPropertyGrid` control instance does not hide the horizontal scrollbar.

## Solution

1. Create a new `Style` with `TargetType="ScrollViewer"` in the `Resources` collection of the `RadPropertyGrid` element instance. 

2. Set the `HorizontalScrollBarVisibility` property to `Disabled` via a `Setter`.

__Disable horizontal scrollbar__
```XAML
	<telerik:RadPropertyGrid>
	    <telerik:RadPropertyGrid.Resources>
	        <Style TargetType="ScrollViewer">
	            <Setter Property="HorizontalScrollBarVisibility" Value="Disabled"/>
	        </Style>
	    </telerik:RadPropertyGrid.Resources>
	</telerik:RadPropertyGrid>
```
