---
title: Changes
page_title: Changes
description: Changes
slug: radbuttons-changes
tags: changes
published: True
position: 1
---

# Changes



This article describes the release history of the RadButtons controls

## Q2 2013

### What's Fixed

* Fixed: Disabled state is not consistent

* Fixed: DropDownButton doesn't open on Enter if before that you've opened/closed the button with mouse

* Fixed: Refactor RadButton's AutomationPeers to work like native buttons 

* Fixed: The DropDownContent of a DropDownButton stays opened when PressMode="Press"

### What's New

* Feature: Visual improvement of RadSplitButton 

## Q1 2013

### What's Fixed

* Fixed: DropDownButton DropDownContentPopup is placed incorrectly when setting PopupPlacementTarget and zooming the browser

* Fixed: DropDownPopup is not on the correct position if the application is zoomed

* Fixed: Incorrect positioning in RadDropDownButton of a popup opened from the DropDownButton's content and effect is applied

* Fixed: It isn't possible to set the DropDownContent with DataTemplate

* Fixed: RadSplitButton's IsTabStop="False" is applied only for the DropDownPart and the ActionPart is still included in the tab navigation

* Fixed: StringFormat property on Binding fails to work in the RadButton.

* Feature: The Content and DropDownContent of the DropDownButton cannot be data bound

### What's New

* Feature: Create a button behavior that allows button click when in IsManipulationEnabled=True container

## Q1 2012

### What's Fixed

* Fixed: DropDownButton: Mouse Clicking then pressing Escape multiple times works in a different way than just mouse clicking multiple times

* Fixed: DropDownButton: Clicking on the button when it is place in DropDownContent of another button does not work as expected

* Fixed: IsEnabled doesn't work when the buttons are in RibbonView/Bar and their CanExecute is True

* Fixed: RadDropDownButton and RadSplitButton don't close on click outside when in RadWindow

* Fixed: IsBackgroundVisible property doesn't work

## Q1 2012

### What's Fixed

* Fixed: Create Automation peer for RadButtons

* Fixed: IsEnabled property should be with higher priority than returned value from CanExecute method of a Command

* Fixed: Space key has to be hit twice when editing DropDownContent of a DropDownButton

* Fixed: RadioButton does not work correctly in certain situations when it is checked and Metro theme is applied

* Fixed: Modify the Metro theme Pressed state implementation

* Fixed: DropDownButtons do not work correctly with TextBoxes in their DropDownContent

* Fixed: Wrong foreground of RadSplitButton in Expression_Dark theme

* Fixed: Incorrect behavior when you initially have IsEnabled = false

* Fixed: RadButtons don't recognize access keys in ExpressionDark

>You can examine the Q1 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.
			  
