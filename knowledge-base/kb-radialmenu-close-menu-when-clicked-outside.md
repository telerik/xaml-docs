---
title: How to close RadRadialMenu with an outside click
description: Close RadRadialMenu on lost focus.
type: how-to
page_title: Hide RadRadialMenu if you click outside
slug: kb-radialmenu-close-menu-when-clicked-outside
position: 0
tags: RadialMenuCommands, MouseLeftButtonDown, RadialContextMenu
ticketid: 1412949
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
	    	<td>RadRadialMenu for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to close RadRadialMenu on a click outside the element.

## Solution

1. Subscribe to the MouseLeftButtonDown event of the MainWindow.
	
	```C#
		this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
	```
	
2. Execute the RadialMenuCommands.Hide command in the MouseLeftButtonDown event handler.
	
	```C#
		private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			RadialMenuCommands.Hide.Execute(null, null);
		}
	```

## See Also  
* [Getting Started]({%slug radradialmenu-getting-started%})
* [RadialMenu Commands]({%slug radradialmenu-commands-radialmenu%})
