---
title: Modal Windows
page_title: Modal Windows
description: Check our &quot;Modal Windows&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-features-modal-windows
tags: modal,windows
published: True
position: 11
---

# {{ site.framework_name }} RadWindow Modal Windows

__RadWindow__ can be displayed in two modes - as a normal __window__ or as a __modal dialog window__.

In the first case, the UI behind the RadWindow is still active. To open it as a normal window you have to call the __Show()__ method of the __RadWindow__ instance.

#### __[C#] Example 1: Showing a window__
{{region cs-radwindow-features-modal-windows_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.Show();
{{endregion}}

#### __[VB.NET Example 1: Showing a window__
{{region vb-radwindow-features-modal-windows_1}}
	Dim radWindow As New RadWindow()
	radWindow.Show()
{{endregion}}

## Showing RadWindow as a modal dialog

To show the window as a modal dialog call the __ShowDialog()__ method. In this case, the UI behind the RadWindow gets inactive and cannot be used until the window is closed.

#### __[C#] Example 2: Showing a dialog__
{{region cs-radwindow-features-modal-windows_2}}
	RadWindow radWindow = new RadWindow();
	radWindow.ShowDialog();
{{endregion}}

#### __[VB.NET] Example 2: Showing a dialog__
{{region vb-radwindow-features-modal-windows_3}}
	Dim radWindow As New RadWindow()
	radWindow.ShowDialog()
{{endregion}}

{% if site.site_name == 'Silverlight' %}
>tip When opened as a modal dialog the __RadWindow__ covers the UI behind it with a background. You can modify the color of this background via the __ModalBackground__ property of the RadWindow.
{% endif %}

## See Also
 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})
 * [Predefined Dialogs]({%slug radwindow-features-predefined-dialogs%})
 * [Window Header]({%slug radwindow-features-window-header%})
