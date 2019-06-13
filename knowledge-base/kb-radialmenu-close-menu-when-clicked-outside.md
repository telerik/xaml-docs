---
title: How to close RadRadialMenu when clicked outside of the menu
description: Close RadRadialMenu when lost focus
type: how-to
page_title: Hide RadRadialMenu if you clicked outside
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

How to close RadRadialMenu when clicked outside of the menu.

## Solution

1. Subscribe to the MouseLeftButtonDown event of the MainWindow.

	#### __[C#]__
	{{region  kb-radialmenu-close-menu-when-clicked-outside-0}}
		this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
	{{endregion}}
	
2. Execute the RadialMenuCommands.Hide command in the MouseLeftButtonDown event handler.

	#### __[C#]__
	{{region  kb-radialmenu-close-menu-when-clicked-outside-1}}
		private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			RadialMenuCommands.Hide.Execute(null, null);
		}
	{{endregion}}

## See Also  
* [Getting Started]({%slug radradialmenu-getting-started%})
* [RadialMenu Commands]({%slug radradialmenu-commands-radialmenu%})