---
title: Mouse Support
page_title: Mouse Support
description: Check our &quot;Mouse Support&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-mouse-support
tags: mouse,support
published: True
position: 7
---

# Mouse Support

__RadRibbonView__ exposes several useful events, which can help you control the mouse interaction and get notified when mouse events occur. Moreover, by using the mouse you can perform some most common tasks, such as:

* __Execute actions__ - use your mouse to click any of the built-in or custom actions displayed by the __RadRibbonView__.				

* __Minimize the ribbon bar__ - to toggle the minimization state of the __RadRibbonView__ just double click on any of its tab headers.				

## Events

Here is a list of the mouse events exposed by the __RadRibbonView__ object:

* __MouseWheel__ - occurs when the user rotates the mouse wheel. The type of the passed event arguments is __MouseWheelEventArgs.__

* __MouseMove__ - occurs when the coordinate position of the mouse changes. The type of the passed event arguments is __MouseEventArgs.__

* __MouseLeftButtonDown__ - occurs when the left mouse button is pressed. The type of the passed event arguments is __MouseButtonEventArgs.__

* __MouseLeftButtonUp__ - occurs when the left mouse button is released. The type of the passed event arguments is __MouseButtonEventArgs.__

* __MouseLeave__ - occurs when the mouse leaves the control. The type of the passed event arguments is __MouseEventArgs.__

* __MouseEnter__ - occurs when the mouse enters the control. The type of the passed event arguments is __MouseEventArgs.__

* __LostMouseCapture__ - occurs when the object loses mouse capture. The type of the passed event arguments is __MouseEventArgs.__

In the example below you can see how to attach to __MouseWheel__ event from XAML.				


```XAML
	<telerik:RadRibbonView x:Name="radRibbonView" MouseWheel="radRibbonView_MouseWheel" />
```

>tip It is always a good practice to attach your event handlers in the XAML, whenever your application logic allows this.

And also from the code-behind:


```C#
	radRibbonView.MouseWheel+=new MouseWheelEventHandler(radRibbonView_MouseWheel);
```
```VB.NET
	radRibbonView.MouseWheel += New MouseWheelEventHandler(radRibbonView_MouseWheel)
```

The implementation of the event handler __radRibbonView_MouseWheel()__ is located in the code-behind file (C# or VB.NET) and looks like this:


```C#
	private void radRibbonView_MouseWheel(object sender, MouseWheelEventArgs e)
	{
		MessageBox.Show("The mouse wheel has changed: " + e.Delta);
	}
```
```VB.NET
	Private Sub radRibbonView_MouseWheel(sender As Object, e As MouseWheelEventArgs)
		MessageBox.Show("The mouse wheel has changed: " & Convert.ToString(e.Delta))
	End Sub
```

>You can attach to the other mouse events in the same way.