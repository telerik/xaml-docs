---
title: Prevent Maximize and Restore on RadWindow TitleBar Double Click
description: Learn how to block the default double-click actions on the header of a RadWindow in UI for WPF to prevent state changes from maximized to restored.
type: how-to
page_title: Prevent Double-Click on RadWindow Header in UI for WPF
meta_title: Prevent Double-Click on RadWindow Header in UI for WPF
slug: kb-window-prevent-double-click-on-window-header
tags: radwindow, ui-for-wpf, header, double-click, maximize, state-change
res_type: kb
ticketid: 1708855
---

## Environment
<table>
<tbody>
<tr>
<td> Product </td>
<td>
Window for UI for WPF
</td>
</tr>
<tr>
<td> Version </td>
<td> 2025.3.813 </td>
</tr>
</tbody>
</table>

## Description

How to prevent the default double-click behavior on the titlebar (header) of a [RadWindow]({%slug radwindow-overview%}) or a native WPF Window. 

By default, double-clicking on the header causes the window to switch states from maximized to restored or vice versa. 

## Solution

To prevent the default behavior, you can use interop methods to remove the maximize box of the host window of the RadWindow control. Then, you can add a procedure hook and prevent the button double click on the titlebar or on the top resize handle of the window.

The example below checks for the `HTTOP` and `HTCAPTION` hit test messages. You an read about these in the [official win32 docs](https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest).


```csharp
// The purpose of this method is to demonstrate one way to subscribe for the HostCreated event of RadWindow.
// This setup may vary based on your exact implementation and usage of the control.
public void ShowWindow()
{
	var window = new RadWindow();
	window.HostCreated += RadWindow_HostCreated;
	window.Show();
}

private const int GWL_STYLE = -16;
private const int WS_MAXIMIZEBOX = 0x10000;
private const int WM_NCLBUTTONDBLCLK = 0x00A3;
private const int HTTOP = 12;
private const int HTCAPTION = 2;

[DllImport("user32.dll")]
private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

[DllImport("user32.dll")]
private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

private void RadWindow_HostCreated(object sender, HostWindowCreatedEventArgs e)
{
	e.HostWindow.SourceInitialized += Window_SourceInitialized;
}

private void Window_SourceInitialized(object sender, EventArgs e)
{
	// Remove maximize box, thus disabling maximize on double click of the titlebar
	IntPtr hwnd = new WindowInteropHelper((Window)sender).Handle;
	var value = GetWindowLong(hwnd, GWL_STYLE);
	SetWindowLong(hwnd, GWL_STYLE, (int)(value & ~WS_MAXIMIZEBOX));

	// Add window procedure hook
	HwndSource source = HwndSource.FromHwnd(hwnd);
	source.AddHook(WndProc);
}

private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
{
	// Block double-click on top resize border (vertical maximize) and the titlebar
	if (msg == WM_NCLBUTTONDBLCLK && (wParam.ToInt32() == HTTOP || wParam.ToInt32() == HTCAPTION))
	{
		handled = true;
		return IntPtr.Zero;
	}
	return IntPtr.Zero;
}
```

