---
title: DesktopAlertManager
page_title: DesktopAlertManager
description: DesktopAlertManager
slug: raddesktopalert-desktop-alert-manager
tags: desktopalertmanager,alert
published: True
position: 3
---

# Desktop Alert Manager

Using __RadDesktopAlertManager__ you could easily visualize and position __RadDesktopAlert__ on the screen. Thanks to __RadDesktopAlertManager__ you could also display multiple alerts on the screen - it takes care to calculate the location of all alerts, so they could not overlap. When an alert gets closed, all other alerts that are currently visualized on the screen get relocated.

__RadDesktopAlertManager__ could easily be initialized using one of the following constructors:

#### __[C#] Initializing of RadDesktopAlertManager__

{{region raddesktopalert-desktop-alert-manager_0}}
	var manager = new RadDesktopAlertManager();
	...
	var manager = new RadDesktopAlertManager(AlertScreenPosition.BottomCenter);
	...
	var manager = new RadDesktopAlertManager(AlertScreenPosition.TopCenter, 5);
	...
	var manager = new RadDesktopAlertManager(AlertScreenPosition.TopRight, new Point(0, 0));
	...
	var manager = new RadDesktopAlertManager(AlertScreenPosition.BottomCenter, new Point(0, 0), 10);
{{endregion}}

#### __[VB] Initializing of RadDesktopAlertManager__

{{region raddesktopalert-desktop-alert-manager_0}}
	Dim manager = New RadDesktopAlertManager()
	...
	Dim manager = New RadDesktopAlertManager(AlertScreenPosition.BottomCenter)
	...
	Dim manager = New RadDesktopAlertManager(AlertScreenPosition.TopCenter, 5)
	...
	Dim manager = New RadDesktopAlertManager(AlertScreenPosition.TopRight, New Point(0, 0))
	...
	Dim manager = New RadDesktopAlertManager(AlertScreenPosition.BottomCenter, New Point(0, 0), 10)
{{endregion}}

Except __ScreenPosition__ the __AlertsDistance__ and __ScreenPositionOffset__ could also be initialized using __RadDesktopAlertManager__'s constructors.

This article will provide some detailed information about the following properties of __RadDesktopAlertManager__: 

* [Show/HideAnimation](#show/hideanimation)

* [ScreenPosition](#screenposition)

* [AlertsDistance](#alertsdistance)

## Show/HideAnimation

Using the Show/HideAnimation properties of __RadDesktopAlertManager__ you could easily apply, create a custom Animation or group animations. That animation should be visualized when __RadDesktopAlert__ gets show or hide from the screen.

__Example 1__ demonstates how a __FadeAnimation__ could be applied:

#### __[C#] Example 1: Applying ShowAnimation__

{{region raddesktopalert-desktop-alert-manager_1}}
	this.manager.ShowAnimation = new FadeAnimation
	{ 
		Direction = AnimationDirection.Out, 
		MinOpacity = 0.5d, 
		MaxOpacity = 0.9d, 
		SpeedRatio = 0.5d 
	};
{{endregion}}

#### __[VB] Example 1: Applying ShowAnimation__

{{region raddesktopalert-desktop-alert-manager_1}}
	Me.manager.ShowAnimation = New FadeAnimation() With 
	{ 
		Key .Direction = AnimationDirection.Out, 
		Key .MinOpacity = 0.5, 
		Key .MaxOpacity = 0.9, 
		Key .SpeedRatio = 0.5 
	}
{{endregion}}

>The Show/HideAnimation could easily be disabled by setting it to __null__. If a new Show/HideAnimation is applied during runtime it will affect the next __RadDesktopAlert__ that will be visualized after the apply.

## ScreenPosition

Using the __ScreenPosition__ property you could easily define the position of __RadDesktopAlert__ where you want to be visualized. It accepts a value of type __AlertScreenPosition__. The positions you could choose from are as follows:

* __TopLeft__

* __TopCenter__

* __TopRight__

* __BottomLeft__

* __BottomCenter__

* __BottomRight__

>The __ScreenPosition__ property is initialized and set only through __RadDesktopAlertManager__'s constructor.

## ShowAlert method

In order __RadDesktopAlert__ to be visualized you need to pass it as a parameter to the __ShowAlert__ method of __RadDesktopAlertManager__.

__Example 2__ demonstrates how to visualize __RadDesktopAlert__ by passing it as a parameter to the __ShowAlert__ method:

#### __[C#] Example 2:  Showing RadDesktopAlert__

{{region raddesktopalert-desktop-alert-manager_2}}
	var alert = new RadDesktopAlert
	{
		Header = "MAIL NOTIFICATION",
		Content = "Hello, Here are two things that we noticed today on our daily meeting.",
		Command = new DelegateCommand(OnCommandExecuted),
		ShowDuration = 5000,
	};
	this.manager.ShowAlert(alert);
{{endregion}}

#### __[VB] Example 2:  Showing RadDesktopAlert__

{{region raddesktopalert-desktop-alert-manager_2}}
	Dim alert = New RadDesktopAlert() With {
		Key .Header = "MAIL NOTIFICATION",
		Key .Content = "Hello, Here are two things that we noticed today on our daily meeting.",
		Key .Command = New DelegateCommand(OnCommandExecuted),
		Key .ShowDuration = 5000
	}
	Me.manager.ShowAlert(alert)
{{endregion}}

## ShowAlert MVVM

__RadDesktopAlert__ could also be visualized by passing an object of type __DesktopAlertParameters__ to the __ShowAlert__ method. This is a class that holds all parameters that you need to customize __RadDesktopAlert__ and it is MVVM friendly - it's main idea is for visualization and customization of __RadDesktopAlert__ within MVVM scenarios. 

__Example 3__ demonstrates how to display an alert in such MVVM scenario:

#### __[C#]Example 3:  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_3}}
	this.manager.ShowAlert(new DesktopAlertParameters
	{
		Header = "New mail",
		Content = "Hello, Here are two things that we noticed today on our front-end meeting",
		Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 },
		IconColumnWidth = 48,
		IconMargin = new Thickness(10, 0, 20, 0)
	});
{{endregion}}

#### __[VB] Example 3:  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_3}}
	Me.manager.ShowAlert(New DesktopAlertParameters() With {
		Key .Header = "New mail",
		Key .Content = "Hello, Here are two things that we noticed today on our meeting",
		Key .Icon = New Image() With {
			Key .Source = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource),
			Key .Width = 48,
			Key .Height = 48
		},
		Key .IconColumnWidth = 48,
		Key .IconMargin = New Thickness(10, 0, 20, 0)
	})
{{endregion}}

## CloseAlert and CloseAllAlerts

You could easily close __RadDesktopAlert__  in code - behind before its duration has expired using the __CloseAlert__ method of __RadDesktopAlertManager__. The __DesktopAlert__ control you want to close should be passed as a parameter to this method.

__Example 4__ shows how to close __RadDesktopAlert__:

#### __[C#] Example 4:  Closing single RadDesktopAlert__

{{region raddesktopalert-desktop-alert-manager_4}}
	this.manager.CloseAlert(this.alert);
{{endregion}}

#### __[VB] Example 4:  Closing single RadDesktopAlert__
	Me.manager.CloseAlert(Me.alert)
{{region raddesktopalert-desktop-alert-manager_4}}

Using the __CloseAllAlerts__ method of __RadDesktopAlertManager__ all currently opened __RadDesktopAlerts__ could be closed.

__Example 5__ demonstrates how to close all opened __RadDesktopAlerts__:

#### __[C#]Example 5:  Closing single RadDesktopAlert__

{{region raddesktopalert-desktop-alert-manager_5}}
	this.manager.CloseAllAlerts();
{{endregion}}

#### __[VB]Example 5:  Closing single RadDesktopAlert__

{{region raddesktopalert-desktop-alert-manager_5}}
	Me.manager.CloseAllAlerts()
{{endregion}}

## AlertsDistance

You could easily set the distance between the currently opened on the screen __RadDesktopAlerts__ using the __AlertsDistance__ property of the __RadDesktopAlertManager__. If the property is changed during runtime it will affect immediately the opened __RadDesktopAlerts__ and the distance between them will be changed  according to the newly applied value.

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Getting Started]({%slug raddesktopalert-getting-started%})