---
title: DesktopAlertManager
page_title: DesktopAlertManager
description: Check our &quot;DesktopAlertManager&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-desktop-alert-manager
tags: desktopalertmanager,alert
published: True
position: 6
---

# {{ site.framework_name }} RadDesktopAlert DesktopAlertManager

Using __RadDesktopAlertManager__ you could easily visualize and position __RadDesktopAlert__ on the screen. Thanks to __RadDesktopAlertManager__, you could also display multiple alerts on the screen - it will calculate the location of all alerts so they could not overlap. When an alert gets closed, all other alerts that are currently visualized on the screen get relocated.

You can initialize __RadDesktopAlertManager__ using one of the following constructors:

#### __[C#] Initializing of RadDesktopAlertManager__

{{region cs-raddesktopalert-desktop-alert-manager_0}}
	var manager = new RadDesktopAlertManager();
	manager = new RadDesktopAlertManager(AlertScreenPosition.BottomCenter);
	manager = new RadDesktopAlertManager(AlertScreenPosition.TopCenter, 5);
	manager = new RadDesktopAlertManager(AlertScreenPosition.TopRight, new Point(0, 0));
	manager = new RadDesktopAlertManager(AlertScreenPosition.BottomCenter, new Point(0, 0), 10);
{{endregion}}

#### __[VB] Initializing of RadDesktopAlertManager__

{{region vb-raddesktopalert-desktop-alert-manager_0}}
	Dim manager = New RadDesktopAlertManager()
	manager = New RadDesktopAlertManager(AlertScreenPosition.BottomCenter)
	manager = New RadDesktopAlertManager(AlertScreenPosition.TopCenter, 5)
	manager = New RadDesktopAlertManager(AlertScreenPosition.TopRight, New Point(0, 0))
	manager = New RadDesktopAlertManager(AlertScreenPosition.BottomCenter, New Point(0, 0), 10)
{{endregion}}

This article will provide some detailed information about the following properties of __RadDesktopAlertManager__: 

* [Show/Hide Animation](#showhide-animation)

* [ScreenPosition](#screenposition)

* [AlertsDistance](#alertsdistance)

* [AlertsReorderAnimationDuration](#alertsreorderanimationduration)

And the following methods of __RadDesktopAlertManager__:

* [ShowAlert](#showalert)

* [ShowAlert MVVM](#showalert-mvvm)

* [CloseAlert and CloseAllAlerts](#closealert-and-closeallalerts)

* [GetAllAlerts](#getallalerts )

## ShowAlert()

In order for __RadDesktopAlert__ to be visualized you need to pass it as a parameter to the __ShowAlert__ method of __RadDesktopAlertManager__.

__Example 1__ demonstrates how to visualize __RadDesktopAlert__.

#### __[C#] Example 1:  Showing RadDesktopAlert__

{{region cs-raddesktopalert-desktop-alert-manager_1}}
	var alert = new RadDesktopAlert
	{
	    Header = "MAIL NOTIFICATION",
	    Content = "Hello, Here are two things that we noticed today on our daily meeting.",
	    Command = new DelegateCommand(this.OnCommandExecuted),
	    ShowDuration = 5000,
	};
	manager.ShowAlert(alert);
{{endregion}}

#### __[VB] Example 1:  Showing RadDesktopAlert__

{{region vb-raddesktopalert-desktop-alert-manager_1}}
	Dim alert = New RadDesktopAlert() With {
	     .Header = "MAIL NOTIFICATION",
	     .Content = "Hello, Here are two things that we noticed today on our daily meeting.",
	     .Command = New DelegateCommand(OnCommandExecuted),
	     .ShowDuration = 5000
	}
	manager.ShowAlert(alert)
{{endregion}}

By default, __RadDesktopAlert__ is shown and closed with an animation. However, there are some cases when you might need to disable these animations. You could easily disable the __ShowAnimation__ by setting the second parameter of the __ShowAlert__ method to false. Telerik introduced this feature with the Q3 2015 version release of UI for WPF:

#### __[C#]Example 2:  Show RadDesktopAlert without animation__

{{region cs-raddesktopalert-desktop-alert-manager_2}}
	manager.ShowAlert(new DesktopAlertParameters
	{
	    Header = "New mail",
	    Content = "Hello, Here are two things that we noticed today on our front-end meeting",
	    Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 },
	    IconColumnWidth = 48,
	    IconMargin = new Thickness(10, 0, 20, 0)
	}, false);
{{endregion}}

#### __[VB] Example 2:  Show RadDesktopAlert without animation__

{{region vb-raddesktopalert-desktop-alert-manager_2}}
	manager.ShowAlert(New DesktopAlertParameters() With {
	     .Header = "New mail",
	     .Content = "Hello, Here are two things that we noticed today on our meeting",
	     .Icon = New Image() With {
	         .Source = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource),
	         .Width = 48,
	         .Height = 48
	    },
	     .IconColumnWidth = 48,
	     .IconMargin = New Thickness(10, 0, 20, 0)
	}, False)
{{endregion}}

## ShowAlert() MVVM

__RadDesktopAlert__ could also be visualized by passing an object of type __DesktopAlertParameters__ to the __ShowAlert__ method. This class that holds all parameters that you need to customize __RadDesktopAlert__ and it is MVVM friendly. It was created to visualize and customize __RadDesktopAlert__ within MVVM scenarios. 

__Example 3__ demonstrates how to display an alert in a MVVM scenario:

#### __[C#]Example 3:  Creating RadDesktopAlert in MVVM__

{{region cs-raddesktopalert-desktop-alert-manager_3}}
	manager.ShowAlert(new DesktopAlertParameters
	{
	    Header = "New mail",
	    Content = "Hello, Here are two things that we noticed today on our front-end meeting",
	    Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 },
	    IconColumnWidth = 48,
	    IconMargin = new Thickness(10, 0, 20, 0),
	    Sound = System.Media.SystemSounds.Beep
	});
{{endregion}}

#### __[VB] Example 3:  Creating RadDesktopAlert in MVVM__

{{region vb-raddesktopalert-desktop-alert-manager_3}}
	manager.ShowAlert(New DesktopAlertParameters() With {
	     .Header = "New mail",
	     .Content = "Hello, Here are two things that we noticed today on our meeting",
	     .Icon = New Image() With {
	         .Source = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource),
	         .Width = 48,
	         .Height = 48
	    },
	     .IconColumnWidth = 48,
	     .IconMargin = New Thickness(10, 0, 20, 0)
	})
{{endregion}}

## CloseAlert() and CloseAllAlerts()

You could close __RadDesktopAlert__  in code behind before its duration has expired using the __CloseAlert__ method of __RadDesktopAlertManager__. The __DesktopAlert__ control you want to close should be passed as a parameter to this method.

__Example 4__ shows how to close __RadDesktopAlert__:

#### __[C#] Example 4:  Closing single RadDesktopAlert__

{{region cs-raddesktopalert-desktop-alert-manager_4}}
	manager.CloseAlert(alert);
{{endregion}}

#### __[VB] Example 4:  Closing single RadDesktopAlert__
{{region vb-raddesktopalert-desktop-alert-manager_4}}
	manager.CloseAlert(alert)
{{endregion}}

Using the __CloseAllAlerts__ method of __RadDesktopAlertManager__, all currently opened __RadDesktopAlerts__ could be closed.

__Example 5__ demonstrates how to close all opened __RadDesktopAlerts__:

#### __[C#]Example 5:  Closing all RadDesktopAlerts__

{{region cs-raddesktopalert-desktop-alert-manager_5}}
	manager.CloseAllAlerts();
{{endregion}}

#### __[VB]Example 5:  Closing all RadDesktopAlerts__

{{region vb-raddesktopalert-desktop-alert-manager_5}}
	manager.CloseAllAlerts()
{{endregion}}

If you want to close __RadDesktopAlert__ without using an animation you need to pass false as a second parameter for the __CloseAlert__ method and as a first parameter for the __CloseAllAlerts__ method. Telerik introduced this feature with the Q3 2015 release of UI for WPF:

__Example 6__ demonstrates how to close RadDesktopAlert without using an animation:

#### __[C#]Example 6:  Closing RadDesktopAlert without an animation__

{{region cs-raddesktopalert-desktop-alert-manager_6}}
	manager.CloseAlert(alert, false);
	manager.CloseAllAlerts(false);
{{endregion}}

#### __[VB]Example 6:  Closing RadDesktopAlert without an animation__

{{region vb-raddesktopalert-desktop-alert-manager_6}}
	manager.CloseAlert(alert, False)
	manager.CloseAllAlerts(False)
{{endregion}}

## GetAllAlerts()

You could easily get a collection of all currently opened __RadDesktopAlerts__ using the __GetAllAlerts__ method introduced with Q3 2015 release version of UI for WPF. By calling it an IEnumerable collection with __RadDesktopAlerts__ will be returned.

__Example 7__ shows how to get all __RadDesktopAlert__:

#### __[C#] Example 7:  Getting all opened RadDesktopAlerts__

{{region cs-raddesktopalert-desktop-alert-manager_7}}
	IEnumerable alerts = manager.GetAllAlerts();
{{endregion}}

#### __[VB] Example 7:  Getting all opened RadDesktopAlerts__
{{region vb-raddesktopalert-desktop-alert-manager_7}}
	Dim alerts As IEnumerable = manager.GetAllAlerts()
{{endregion}}

## Show/Hide Animation

Using the __ShowAnimation__ and __HideAnimation__ properties of RadDesktopAlertManager you could easily apply a custom Animation or group animations. That animation will start when you show or hide a __RadDesktopAlert__ on the screen.

#### __[C#] Example 8: Applying ShowAnimation - FadeAnimation__  
{{region cs-raddesktopalert-desktop-alert-manager_8}}
	manager.ShowAnimation = new FadeAnimation
	{
	    Direction = AnimationDirection.Out,
	    MinOpacity = 0.5d,
	    MaxOpacity = 0.9d,
	    SpeedRatio = 0.5d
	};
{{endregion}}

#### __[VB] Example 8: Applying ShowAnimation - FadeAnimation__  
{{region vb-raddesktopalert-desktop-alert-manager_8}}
	manager.ShowAnimation = New FadeAnimation() With
	{
	     .Direction = AnimationDirection.Out,
	     .MinOpacity = 0.5,
	     .MaxOpacity = 0.9,
	     .SpeedRatio = 0.5
	}
{{endregion}}

#### __[C#] Example 9: Applying ShowAnimation - RevealAnimation__  
{{region cs-raddesktopalert-desktop-alert-manager_10}}
	manager.ShowAnimation = new RevealAnimation()
	{
		Duration = TimeSpan.FromMilliseconds(1000),
		Orientation = Orientation.Horizontal,
		AnimationDirection = AnimationDirection.In,
	};
{{endregion}}

#### __[VB] Example 9: Applying ShowAnimation - RevealAnimation__  
{{region vb-raddesktopalert-desktop-alert-manager_11}}	
	manager.ShowAnimation = new RevealAnimation() With
	{
		.Duration = TimeSpan.FromMilliseconds(1000),
		.Orientation = Orientation.Horizontal,
		.AnimationDirection = AnimationDirection.In,
	}
{{endregion}}

>If you set a Show/HideAnimation to __null__ in order to disable it during runtime it will affect the next __RadDesktopAlert__ that will be shown or hidden.

## ScreenPosition

Using the __ScreenPosition__ property you could easily define the position of where you want __RadDesktopAlert__ to be visualized. It accepts a value of type __AlertScreenPosition__. The screen positions you can set are as follows:

* __TopLeft__

* __TopCenter__

* __TopRight__

* __BottomLeft__

* __BottomCenter__

* __BottomRight__

>The __ScreenPosition__ property is initialized and set only through __RadDesktopAlertManager__'s constructor.

## AlertsDistance

You could easily set the distance between the currently open __RadDesktopAlerts__ using the __AlertsDistance__ property of the __RadDesktopAlertManager__. If the property is changed during runtime, it will immediately number the open __RadDesktopAlerts__ and the distance between them will be changed  according to the newly applied value.

## AlertsReorderAnimationDuration

With Q3 2015 released version of WPF a brand new property __AlertsReorderAnimationDuration__ was introduce. It is of type integer and represents the number of milliseconds the animation used for updating the order of all instances of __RadDesktopAlert__.

#### __[C#] Example 10: Setting AlertsReorderAnimationDuration__

{{region cs-raddesktopalert-desktop-alert-manager_9}}
	manager.AlertsReorderAnimationDuration = 1000;
{{endregion}}

#### __[VB] Example 10:  Setting AlertsReorderAnimationDuration__

{{region vb-raddesktopalert-desktop-alert-manager_9}}
	manager.AlertsReorderAnimationDuration = 1000
{{endregion}}

## See Also  
 * [Overview]({%slug raddesktopalert-overview%})
 * [Getting Started]({%slug raddesktopalert-getting-started%}) 
 * [DesktopAlert Key Properties]({%slug raddesktopalert-features-key-properties%})
