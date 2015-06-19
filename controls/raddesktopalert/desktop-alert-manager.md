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

This article will provide some detailed information about the following properties of __RadDesktopAlertManager__: 

* [Show/HideAnimation](#show/hideanimation)

* [ScreenPosition](#screenposition)

## Show/HideAnimation

Using the Show/HideAnimation properties of __RadDesktopAlertManager__ you could easily apply, create a custom Animation or group animations. That animation should be visualized when __RadDesktopAlert__ gets show or hide from the screen. For example this is how a __FadeAnimation__ could be applied:

#### __[C#]  Applying ShowAnimation__

{{region raddesktopalert-desktop-alert-manager_0}}
	RadDesktopAlertManager selectedDesktopAlertManager = new RadDesktopAlertManager();
	this.SelectedDesktopAlertManager.ShowAnimation = new FadeAnimation
	{ 
		Direction = AnimationDirection.Out, 
		MinOpacity = 0.5d, 
		MaxOpacity = 0.9d, 
		SpeedRatio = 0.5d 
	};
{{endregion}}

#### __[VB]  Applying ShowAnimation__

{{region raddesktopalert-desktop-alert-manager_0}}
	Dim selectedDesktopAlertManager As New RadDesktopAlertManager()
	Me.SelectedDesktopAlertManager.ShowAnimation = New FadeAnimation() With 
	{ 
		Key .Direction = AnimationDirection.Out, 
		Key .MinOpacity = 0.5, 
		Key .MaxOpacity = 0.9, 
		Key .SpeedRatio = 0.5 
	}
{{endregion}}

## ScreenPosition

Using the __ScreenPosition__ property you could easily define the position of __RadDesktopAlert__ where you want to be visualized. It accepts a value of type __AlertScreenPosition__. The positions you could choose from are as follows:

* __TopLeft__

* __TopCenter__

* __TopRight__

* __BottomLeft__

* __BottomCenter__

* __BottomRight__

## ShowAlert method

In order __RadDesktopAlert__ to be visualized you need to pass it as a parameter to the __ShowAlert__ method of __RadDesktopAlertManager__.

__RadDesktopAlert__ could also be visualized by passing an object of type __DesktopAlertParameters__ to the __ShowAlert__ method. This is a class that holds all parameters that you need to customize __RadDesktopAlert__ and it is MVVM friendly - it's main idea is for visualization and customization of __RadDesktopAlert__ within MVVM scenarios. The following example will demonstrate how to display an alert in such MVVM scenario.

First, you need to create a new class named ViewModel. Inside it an object of type __RadDesktopAlertManager__ and a method that calls __ShowAlert__ need to be initialized. For example, the method will be called when a new mail gets received:

#### __[C#]  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_1}}
	public class ViewModel
    {
		private RadDesktopAlertManager desktopAlertManager;
		
		 public ViewModel()
        {
            this.desktopAlertManager = new RadDesktopAlertManager(AlertScreenPosition.BottomRight, 5d);
        }
	}
{{endregion}}

#### __[VB]  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_1}}
	Public Class ViewModel
		Private desktopAlertManager As RadDesktopAlertManager
		
		Public Sub New()
			Me.desktopAlertManager = New RadDesktopAlertManager(AlertScreenPosition.BottomRight, 5.0)
		End Sub
	End Class
{{endregion}}

Once the method gets called __RadDesktopAlert__ could easily be visualized by passing __DesktopAlertParameters__ to the __ShowAlert__ method of __RadDesktopAlertManager__:

#### __[C#]  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_2}}
	private void ReceiveNewMail()
    {
		this.desktopAlertManager.ShowAlert(new DesktopAlertParameters
		{
			Header = "New mail",
			Content = "Hello, Here are two things that we noticed today on our front-end meeting",
			Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 },
			IconColumnWidth = 48,
			IconMargin = new Thickness(10, 0, 20, 0)
		});
	}
{{endregion}}

#### __[VB#]  Creating RadDesktopAlert in MVVM__

{{region raddesktopalert-desktop-alert-manager_2}}
	Private Sub OnPauseResumeMailboxCommandExecuted(param As Object)
		Me.desktopAlertManager.ShowAlert(New DesktopAlertParameters() With {
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
	End Sub
{{endregion}}

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Getting Started]({%slug raddesktopalert-getting-started%})