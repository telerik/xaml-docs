---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: raddesktopalert-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This topic will walk you through the creating of __RadDesktopAlert__.    

>In order to use __RadDesktopAlert__ in your project you have to add references to the following three assemblies:
> * Telerik.Windows.Controls.dll
> * Telerik.Windows.Controls.Navigation.dll
> * Telerik.Windows.Data.dll

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create __RadDesktopAlert__ in code behind:

#### __[C#]  Creating RadDesktopAlert__

{{region cs-raddesktopalert-getting-started_0}}
	var alert = new RadDesktopAlert();
	alert.Header = "MAIL NOTIFICATION";
	alert.Content = "Hello, Here are two things that we noticed today on our daily meeting.";
	alert.ShowDuration = 3000;
{{endregion}}

#### __[VB]  Creating RadDesktopAlert__

{{region vb-raddesktopalert-getting-started_0}}
	Dim alert = New RadDesktopAlert()
	alert.Header = "MAIL NOTIFICATION"
	alert.Content = "Hello, Here are two things that we noticed today on our daily meeting."
	alert.ShowDuration = 3000
{{endregion}}

>__RadDesktopAlert__ is designed to work with [__RadDesktopAlertManager__]({%slug raddesktopalert-desktop-alert-manager%}). If just placed in XAML it won't be completely functional.

In order to visualize it, a new instance of __RadDesktopAlertManager__ should be created and the already declared above __RadDesktopAlert__ should be passed as a parameter to its __ShowAlert__ method:

#### __[C#]  Showing RadDesktopAlert__

{{region cs-raddesktopalert-getting-started_1}}
	RadDesktopAlertManager manager = new RadDesktopAlertManager();
	manager.ShowAlert(alert);
{{endregion}}

#### __[VB]  Showing RadDesktopAlert__

{{region vb-raddesktopalert-getting-started_1}}
	Dim manager As New RadDesktopAlertManager()
	manager.ShowAlert(alert)
{{endregion}}

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Visual Structure]({%slug raddesktopalert-visual-structure%})
 
 * [Desktop Alert Manager]({%slug raddesktopalert-desktop-alert-manager%})
