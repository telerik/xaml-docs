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

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create __RadDesktopAlert__:

#### __[C#]  Creating RadDesktopAlert__

{{region raddesktopalert-getting-started_0}}
	var alert = new RadDesktopAlert();
	alert.Header = "MAIL NOTIFICATION";
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting: ";
	alert.ShowDuration = 5000;
{{endregion}}

#### __[VB]  Creating RadDesktopAlert__

{{region raddesktopalert-getting-started_0}}
	Dim alert = New RadDesktopAlert()
	alert.Header = "MAIL NOTIFICATION"
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting: "
	alert.ShowDuration = 5000
{{endregion}}

In order to visualize it a new instance of __RadDesktopAlertManager__ should be created and the declared __RadDesktopAlert__ should be passed as a parameter to its __ShowAlert__ method:

#### __[C#]  Creating RadDesktopAlert__

{{region raddesktopalert-getting-started_1}}
	RadDesktopAlertManager bottomRightManager = new RadDesktopAlertManager();
	this.bottomRightManager.ShowAlert(alert);
{{endregion}}

#### __[VB]  Creating RadDesktopAlert__

{{region raddesktopalert-getting-started_1}}
	Dim bottomRightManager As New RadDesktopAlertManager()
	Me.bottomRightManager.ShowAlert(alert)
{{endregion}}

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Visual Structure]({%slug raddesktopalert-visual-structure%})
