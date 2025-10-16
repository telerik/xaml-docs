---
title: Disable Esc Key Press in RadNavigationView
description: Disable closing of the RadNavigationView menu when the Esc key is pressed. 
type: how-to
page_title: Cancel Menu Collapsing When Escape Button is Pressed
slug: kb-navigationview-disable-menu-collapse-on-esc-press
position: 0
tags: escape,exit,key
ticketid: 1502677
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadNavigationView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to disable the closing of the RadNavigationView menu on Esc key press.

## Solution

Subscribe to the __PreviewKeyDown__ event of RadNavigationView and handle it in case the Esc key is pressed.


```C#
	private void RadNavigationView_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == System.Windows.Input.Key.Escape)
		{
			e.Handled = true;
		}
	}
```