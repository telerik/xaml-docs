---
title: Enable Keyboard Input in WPF Window Opened from WinForms Application
description: This article explains how to enable keyboard input in the Label Filter dialog of RadPivotGrid opened from a WinForms application.
type: how-to
page_title: Enable Keyboard Input in the RadPivotFieldList Label Filter Window Used in WinForms Application
slug: kb-pivotgrid-enable-keyboard-input-in-winforms
tags: wpf, winforms, RadPivotGrid, keyboard input
res_type: kb
---
## Environment

| Property | Value |
| --- | --- |
| Product | RadPivotGrid for WPF |
| Version | 2023.1.117 |

## Description

The Label Filter dialog show through the RadPivotFieldList (part of RadPivotGrid) for WPF doesn't allow to input any values in its TextBox controls when the RadPivotFieldList for WPF is hosted in a WinForms application.

## Solution

To resolve this, you need to enable keyboard input in WPF dialog opened in the WinForms application. This is done by calling the `ElementHost.EnableModelessKeyboardInterop` static method with the opened WPF Window instance.


```C#
	public MainWindow()
	{
		InitializeComponent();
		this.radPivotFieldList.AddHandler(RoutedDialogEvents.RequestDialog, new EventHandler<DialogHostingRequestEventArgs>(this.OnDialogHostRequested), true);
	}

	private void OnDialogHostRequested(object sender, DialogHostingRequestEventArgs e)
	{
		var dialogContent = (FrameworkElement)e.DialogInfo.Content;
		var window = dialogContent.ParentOfType<Window>();
		if (window != null)
		{
			ElementHost.EnableModelessKeyboardInterop(window);
		}
	}
```
