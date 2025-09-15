---
title: WindowsFormsHost inside RadWindow is not visible
description: Example showing how to host WindowsFormsHost control in RadWindow.
type: how-to
page_title: How to Display WinForms controls in RadWindow
slug: kb-window-howto-display-windowsformshost-in-radwindow
position: 0
tags: windowsformshost,radwindow,display
ticketid: 1130704
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWindow for WPF and Silverlight</td>
	</tr>
</table>

## Description

**WindowsFormsHost** is not displayed when set as the content of a **RadWindow** control.

## Solution

To display the content of the WindowsFormsHost you need to make the RadWindow control non-transparent. This can be achieved by setting the attached **WindowInteropHelper.AllowTransparency** property to **False**.


```C#
	public App()
	{
		var window = new MainWindow();
		RadWindowInteropHelper.SetAllowTransparency(window, false);
		window.Show();
	}
```

## See Also

* [RadWindowInteropHelper]({%slug radwindow-features-radwindowinterophelper%})
* [Host WebBrowser in RadWindow]({%slug radwindow-how-to-host-webbrowser-in-radwindow%})
* [Use RadWindow as User Control]({%slug radwindow-how-to-use-radwindow-as-user-control%})
