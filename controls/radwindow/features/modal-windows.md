---
title: Modal Windows
page_title: Modal Windows
description: Check our &quot;Modal Windows&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-features-modal-windows
tags: modal,windows
published: True
position: 11
---

# Modal Windows

__RadWindow__ can be displayed in two modes - as a normal __window__ or as a __modal dialog window__.

In the first case, the UI behind the RadWindow is still active. To open it as a normal window you have to call the __Show()__ method of the __RadWindow__ instance.

__Example 1: Showing a window__
```C#
	RadWindow radWindow = new RadWindow();
	radWindow.Show();
```
```VB.NET
	Dim radWindow As New RadWindow()
	radWindow.Show()
```

## Showing RadWindow as a modal dialog

To show the window as a modal dialog call the __ShowDialog()__ method. In this case, the UI behind the RadWindow gets inactive and cannot be used until the window is closed.

__Example 2: Showing a dialog__
```C#
	RadWindow radWindow = new RadWindow();
	radWindow.ShowDialog();
```
```VB.NET
	Dim radWindow As New RadWindow()
	radWindow.ShowDialog()
```

{% if site.site_name == 'Silverlight' %}
>tip When opened as a modal dialog the __RadWindow__ covers the UI behind it with a background. You can modify the color of this background via the __ModalBackground__ property of the RadWindow.
{% endif %}

## See Also
 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})
 * [Predefined Dialogs]({%slug radwindow-features-predefined-dialogs%})
 * [Window Header]({%slug radwindow-features-window-header%})
