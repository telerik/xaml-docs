---
title: DesktopAlertManager
page_title: DesktopAlertManager
description: Check our &quot;DesktopAlertManager&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-desktop-alert-manager
tags: desktopalertmanager,alert
published: True
position: 6
---

# DesktopAlertManager

Using __RadDesktopAlertManager__ you could easily visualize and position __RadDesktopAlert__ on the screen. Thanks to __RadDesktopAlertManager__, you could also display multiple alerts on the screen - it will calculate the location of all alerts so they could not overlap. When an alert gets closed, all other alerts that are currently visualized on the screen get relocated.

You can initialize __RadDesktopAlertManager__ using one of the following constructors:

__Initializing of RadDesktopAlertManager__

<snippet id='raddesktopalert-desktop-alert-manager-initializing_of_raddesktopalertmanager-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-initializing_of_raddesktopalertmanager-vb' />


This article will provide some detailed information about the following properties of __RadDesktopAlertManager__: 

* [Show/Hide Animation](#show-hide-animation)

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

__Example 1:  Showing RadDesktopAlert__

<snippet id='raddesktopalert-desktop-alert-manager-example_1_showing_raddesktopalert-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_1_showing_raddesktopalert-vb' />


By default, __RadDesktopAlert__ is shown and closed with an animation. However, there are some cases when you might need to disable these animations. You could easily disable the __ShowAnimation__ by setting the second parameter of the __ShowAlert__ method to false. Telerik introduced this feature with the Q3 2015 version release of UI for WPF:

__Example 2:  Show RadDesktopAlert without animation__

<snippet id='raddesktopalert-desktop-alert-manager-example_2_show_raddesktopalert_without_animation-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_2_show_raddesktopalert_without_animation-vb' />


## ShowAlert() MVVM

__RadDesktopAlert__ could also be visualized by passing an object of type __DesktopAlertParameters__ to the __ShowAlert__ method. This class that holds all parameters that you need to customize __RadDesktopAlert__ and it is MVVM friendly. It was created to visualize and customize __RadDesktopAlert__ within MVVM scenarios. 

__Example 3__ demonstrates how to display an alert in a MVVM scenario:

__Example 3:  Creating RadDesktopAlert in MVVM__

<snippet id='raddesktopalert-desktop-alert-manager-example_3_creating_raddesktopalert_in_mvvm-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_3_creating_raddesktopalert_in_mvvm-vb' />


## CloseAlert() and CloseAllAlerts()

You could close __RadDesktopAlert__  in code behind before its duration has expired using the __CloseAlert__ method of __RadDesktopAlertManager__. The __DesktopAlert__ control you want to close should be passed as a parameter to this method.

__Example 4__ shows how to close __RadDesktopAlert__:

__Example 4:  Closing single RadDesktopAlert__

<snippet id='raddesktopalert-desktop-alert-manager-example_4_closing_single_raddesktopalert-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_4_closing_single_raddesktopalert-vb' />


Using the __CloseAllAlerts__ method of __RadDesktopAlertManager__, all currently opened __RadDesktopAlerts__ could be closed.

__Example 5__ demonstrates how to close all opened __RadDesktopAlerts__:

__Example 5:  Closing all RadDesktopAlerts__

<snippet id='raddesktopalert-desktop-alert-manager-example_5_closing_all_raddesktopalerts-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_5_closing_all_raddesktopalerts-vb' />


If you want to close __RadDesktopAlert__ without using an animation you need to pass false as a second parameter for the __CloseAlert__ method and as a first parameter for the __CloseAllAlerts__ method. Telerik introduced this feature with the Q3 2015 release of UI for WPF:

__Example 6__ demonstrates how to close RadDesktopAlert without using an animation:

__Example 6:  Closing RadDesktopAlert without an animation__

<snippet id='raddesktopalert-desktop-alert-manager-example_6_closing_raddesktopalert_without_an_animation-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_6_closing_raddesktopalert_without_an_animation-vb' />


## GetAllAlerts()

You could easily get a collection of all currently opened __RadDesktopAlerts__ using the __GetAllAlerts__ method introduced with Q3 2015 release version of UI for WPF. By calling it an IEnumerable collection with __RadDesktopAlerts__ will be returned.

__Example 7__ shows how to get all __RadDesktopAlert__:

__Example 7:  Getting all opened RadDesktopAlerts__

<snippet id='raddesktopalert-desktop-alert-manager-example_7_getting_all_opened_raddesktopalerts-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_7_getting_all_opened_raddesktopalerts-vb' />


## Show/Hide Animation

Using the __ShowAnimation__ and __HideAnimation__ properties of RadDesktopAlertManager you could easily apply a custom Animation or group animations. That animation will start when you show or hide a __RadDesktopAlert__ on the screen.

__Example 8: Applying ShowAnimation - FadeAnimation__  
<snippet id='raddesktopalert-desktop-alert-manager-example_8_applying_showanimation_fadeanimation-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_8_applying_showanimation_fadeanimation-vb' />


__Example 9: Applying ShowAnimation - RevealAnimation__  
<snippet id='raddesktopalert-desktop-alert-manager-example_9_applying_showanimation_revealanimation-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_9_applying_showanimation_revealanimation-vb' />


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

__Example 10: Setting AlertsReorderAnimationDuration__

<snippet id='raddesktopalert-desktop-alert-manager-example_10_setting_alertsreorderanimationduration-cs' />

<snippet id='raddesktopalert-desktop-alert-manager-example_10_setting_alertsreorderanimationduration-vb' />


## See Also  
 * [Overview]({%slug raddesktopalert-overview%})
 * [Getting Started]({%slug raddesktopalert-getting-started%}) 
 * [DesktopAlert Key Properties]({%slug raddesktopalert-features-key-properties%})
