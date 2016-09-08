---
title: Modal Windows
page_title: Modal Windows
description: Modal Windows
slug: radwindow-features-modal-windows
tags: modal,windows
published: True
position: 11
---

# Modal Windows

When you want to display the __RadWindow__ you have two options - to display it as a __window__ or as a __modal dialog window__.

In the first case, the UI behind the __RadWindow__ is still active. To open it as a normal window you have to call the __Show()__ method of the __RadWindow__ instance.

#### __C#__

{{region cs-radwindow-features-modal-windows_0}}
	RadWindow = new RadWindow();
	radWindow.Show();
{{endregion}}

#### __VB.NET__

{{region vb-radwindow-features-modal-windows_1}}
	Dim radWindow As New RadWindow()
	radWindow.Show()
{{endregion}}

In the second case the UI behind the __RadWindow__ gets inactive and cannot be used until the __RadWindow__ is closed. To open it as a modal dialog window you have to call the __ShowDialog()__ method of the __RadWindow__ instance.

#### __C#__

{{region cs-radwindow-features-modal-windows_2}}
	RadWindow radWindow = new RadWindow();
	radWindow.ShowDialog();
{{endregion}}

#### __VB.NET__

{{region vb-radwindow-features-modal-windows_3}}
	Dim radWindow As New RadWindow()
	radWindow.ShowDialog()
{{endregion}}

{% if site.site_name == 'Silverlight' %}
>tipWhen opened as a modal dialog the __RadWindow__ covers the UI behind it with a background. You can modify the color of this background via the __ModalBackground__ property of the __RadWindow__.
{% endif %}

# See Also

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [Predefined Dialogs]({%slug radwindow-features-predefined-dialogs%})

 * [Window Header]({%slug radwindow-features-window-header%})
