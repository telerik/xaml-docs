---
title: Restricting the Drag of a WPF Window in Predefined Bounds
description: Learn how to restrict the dragging bounding box of a WPF Window.
type: how-to
page_title: Pevent WPF to be Moved Outside of Specifid Boundaries
meta_title: Restricting RadPane Movement Within Parent UserControl
slug: kb-common-restrict-window-dragging
tags: radpane, raddocking, restriction, movement, wpf, usercontrol
res_type: kb
ticketid: 1664752
---

## Environment

<table>
<tbody>
<tr>
<td> Product </td>
<td>
UI for WPF
</td>
</tr>
<tr>
<td> Version </td>
<td>
2025.2.521
</td>
</tr>
</tbody>
</table>

## Description

How to restict the dragging of a WPF Window to a specific bounding rectangle.

## Solution

To restrict the dragging of a window, you can add a WndProct hook to the `HwndSource` of the `Window` object.

```csharp
	private RECT restrictedBounds = new RECT() { Left = 150, Top = 150, Right = 795, Bottom = 577 };
	   
	private void HookWindowHandler(Window window)
	{	
		// note that in order for the PresentationSource.FromVisual() method call to return a HwndSource the Show() method of the window should be already called
		mSource = (HwndSource)PresentationSource.FromVisual(window);
		mSource.AddHook(WndProc);
	}    

	private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		if (msg == (int)WindowsMessage.WM_MOVING)
		{
			RECT window = (RECT)Marshal.PtrToStructure(lParam, typeof(RECT));
			if (window.Left < restrictedBounds.Left)
			{
				window.Right = window.Right + restrictedBounds.Left - window.Left;
				window.Left = restrictedBounds.Left;
			}
			if (window.Top < restrictedBounds.Top)
			{
				window.Bottom = window.Bottom + restrictedBounds.Top - window.Top;
				window.Top = restrictedBounds.Top;
			}
			if (window.Right >= restrictedBounds.Right)
			{
				window.Left = restrictedBounds.Right - window.Right + window.Left - 1;
				window.Right = restrictedBounds.Right - 1;
			}
			if (window.Bottom >= restrictedBounds.Bottom)
			{
				window.Top = restrictedBounds.Bottom - window.Bottom + window.Top - 1;
				window.Bottom = restrictedBounds.Bottom - 1;
			}
			Marshal.StructureToPtr(window, lParam, true);

			handled = true;
			return new IntPtr(1);
		}

		handled = false;
		return IntPtr.Zero;
	}	

	[StructLayout(LayoutKind.Sequential)]
	struct RECT
	{
		public int Left, Top, Right, Bottom;
	}

	enum WindowsMessage
	{
		WM_MOVING = 0x0216
	}
```

