---
title: Disable Esc Key Press in RadNavigationView
description: Disable closing of the RadNavigationView menu when the Esc key is pressed. 
components: ["navigationview"]
type: how-to
page_title: Cancel Menu Collapsing When Escape Button is Pressed
slug: kb-navigationview-disable-menu-collapse-on-esc-press
position: 0
tags: radnavigationview, escape,exit,key
ticketid: 1502677
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<th scope="row">Product Version</th>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<th scope="row">Product</th>
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