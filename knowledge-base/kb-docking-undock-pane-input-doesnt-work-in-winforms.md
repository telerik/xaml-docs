---
title: Undocking a RadPane in WinForms Hosted WPF UserControl, Text Cannot be Entered to a TextBox Inside the Pane
description: Keyboard input doesn't work in RadPane if hosted in WinForms application and if the pane is floating.
page_title: Text Input Disabled When the Undocked RadDocking Pane is Hosted in WinForms Application
type: troubleshooting
slug: kb-docking-undock-pane-input-doesnt-work-in-winforms
position: 0
tags: keyboard,interoperability,modeless,keyboard
ticketid: 1464649
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadDocking for WPF</td>
	</tr>
</table>

## Description

Keyboard input doesn't work in RadPane if hosted in WinForms application and undocked.

## Solution

Subscribe to the PaneStateChanged event of RadDocking and enable modeless keyboard interoperability for the Window hosting the floating pane.


```C#
	private void RadDocking_PaneStateChange(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
		var pane = e.OriginalSource as RadPane;
		if (pane != null && pane.IsFloating)
		{
			var window = Window.GetWindow(pane);
			System.Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop(window);
		}
	}
```
