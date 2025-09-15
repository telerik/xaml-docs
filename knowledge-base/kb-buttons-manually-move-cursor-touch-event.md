---
title: Move the Cursor Away From the RadButton Control
page_title:  Manually Move the Cursor From the RadButton Instance
description: Manually move the cursor away when a button is touched via a touch device.
type: how-to
slug: kb-buttons-manually-move-the-cursor
position: 0
tags: buttons, mouserover effect, cursor
ticketid: 1540434
res_type: kb
category: knowledge-base
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.915</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Buttons for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Using a device that supports both mouse and touch input, can cause the mouse to go to the tapped location, causing the button to apply a trigger for the __IsMouseOver__ property.

## Solution

Subscribe to the __TouchUp__ event of the __RadButton__ control, and use the __Win32 API__ to manually move the cursor away from the button.



```C#
	[DllImport("User32.dll")]
	private static extern bool SetCursorPos(int X, int Y);

	private void RadNumericUpDown_TouchUp(object sender, TouchEventArgs e)
	{
	    SetCursorPos(0, 0);
	}
```
```VB.NET
	<DllImport("User32.dll")>
    Private Shared Function SetCursorPos(ByVal X As Integer, ByVal Y As Integer) As Boolean

    Private Sub RadNumericUpDown_TouchUp(ByVal sender As Object, ByVal e As TouchEventArgs)
        SetCursorPos(0, 0)
    End Sub
```