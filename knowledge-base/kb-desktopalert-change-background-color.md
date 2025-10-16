---
title: Set RadDesktopAlert Control's Background Color
page_title: Set RadDesktopAlert control's background color when showing a new object of type RadDesktopAlert.
description: Change default background color of the RadDesktopAlert control when creating a new class instance.
type: how-to
slug: kb-desktopalert-change-background-color
position: 0
tags: desktop, alert, background
ticketid: 1534079
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
	    	<td>RadDesktopAlert for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to change the __RadDesktopAlert__ control's background color.

## Solution

When creating a new __RadDesktopAlert__ instance, set the __Background__ property to be the desired color.



```C#
	var alert = new RadDesktopAlert
	{
		Background = Brushes.Red
	};
```
```VB.NET
	Dim alert = New RadDesktopAlert With {
		.Background = Brushes.Red
	}
```