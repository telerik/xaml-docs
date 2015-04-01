---
title: Changes
page_title: Changes
description: Changes
slug: radribbonview-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the __RadRibbonView__ control.

To see the fixes and features included in our latest official release please refer to our {% if site.site_name == 'Silverlight' %} [Release History](http://www.telerik.com/support/whats-new/silverlight/release-history) {% endif %} {% if site.site_name == 'WPF' %} [Release History](http://www.telerik.com/support/whats-new/wpf/release-history) {% endif %}.


## Q1 2014

### What's Fixed

* RibbonView does not close its SelectedTab Popup

* Design-time exceptions

* Dynamically added controls to the Items property of the RibbonView are placed inside the RibbonTabs header

* Implicit style doesn't apply on RadRibbonTabs which are added via PRISM

* NullReferenceException design-time exception is thrown in VS designer

* RibbonWindow throws a TypeInitializationException when used with VSTO Addin

* Right Alt key should also activate the Key Tips

* The Image is displayed on top of the Content 

* VS Designer trows exceptions if a RibbonTab is placed in a UserControl

* When a view doesn't specify DesignHeight/Width, the RibbonView throws design-time exception if it contains ContextualGroups

* Does not work correctly when non-transparent grid is used as a content

* RibbonTitle bar (including the Contextual tab header) goes over the Window Buttons 

* The title is not displayed.

* The title is not trimmed when resizing

* Ability to bind the screentip to text and image

* Expose a property to control the visibility of the background behind the RibbonTab.Headers 

* RibbonView does not extract its template in SL using Blend

* RibbonGroup Image in collapsed state have white border

* RibbonView does not show all of its tabs

### What's New

* Add a way to include "Press F1 for help" to screentips

* Add DataBinding Support for ContextualGroups/ContextualTabs

	>tip This feature is further described in the [Contextual Tabs]({%slug radribbonview-contextual-tabs%}) tutorial.				  

* Allow hiding the tab headers

	>tip This feature is further described in the [Ribbon Tab](B28AD160-10F3-4D23-9EE0-A46DF9B2DA6D#Adding_Tab_Items) tutorial.				  

* Implement Character Ellipses in the Title

* Allow multiple gesture keys to be set

	>tip This feature is further described in the [Keyboard Support]({%slug radribbonview-keyboard-support%}) tutorial.				  

* The Title of the RadRibbonWindow should be created from the Title and ApplicationName strings of the RibbonView automatically

* Allow easily customizing the ApplicationButton Width

	>tip Use the __RadRibbonView ApplicationButtonStyle__ property to apply a custom __Width__ on the __ApplicationButton__ as described in the [Styling the ApplicationButton]({%slug radribbonview-styling-applicationbutton%}) tutorial.				  

* Add ScreenTip for the Application Button

	>tip Use the __RadRibbonView ApplicationButtonStyle__ property to set a __ScreenTip__ for the __ApplicationButton__.				  

* Ability to bind the screentip to text and image

	>tip This feature is further described in the [Screen Tips]({%slug radribbonview-screentips%}) tutorial.				  

## Q2 2013

### What's Fixed

* Fixed: Allow resizing in a databound RibbonView 

* Fixed: ApplicaionName is not visible 

* Fixed: BackstageSelectedItem not show correctly after theme changed runtime 

* Fixed: Buttons content is placed under the image and is clipped if longer than the RibbonButton itself

* Fixed: Cannot add RadDocking control without dimensions in the RadRibbonWindow

* Fixed: Creating RadRibbonWindow in separate STA thread throws an exception 

* Fixed: Don't display the selected content when clicking on a minimized tab while the Backstage menu is opened

* Fixed: Don't open a ScreenTip while hovering over the DropDownContent of a RibbonSplitButton 

* Fixed: Gallery background and RibbonDropDownButton border are with wrong colors in Expression Dark

* Fixed: GalleryItems have poorly visible hover effect

* Fixed: If the BackstageMenu control is used outside the RibbonView control, its visual selection state is incorrect 

* Fixed: If two buttons have the same KeyTip.AccessText and the first button is Collapsed, hitting the AccessText shortcut will still execute its action 

* Fixed: In some themes the background highlighting of a selected collapsed group isn't reset as expected

* Fixed: KeyTips's AccessText is entered in editable control 

* Fixed: MinMaxClose buttons of the RadRibbonWindow in Windows XP are aligned to bottom

* Fixed: Misplaced KeyTips when using RibbonWindow on two or more monitors 

* Fixed: Not selected tabs' foreground is wrong when changing implicit themes run time

* Fixed: Pressing the ApplicationButton does not open the Backstage in some scenarios 

* Fixed: Selection issues when using the MinimizeButton

* Fixed: System.IO.FileNotFoundException thrown when application runs on window8 with all exceptions enabled in VS 

* Fixed: The Font color of the Application button is hard to read

* Fixed: The KeyTip AccessText is not displayed when the QAT is databound 

* Fixed: The RadRibbonBackstageItems show empty key tips even if they don't define any value for the KeyTipService.AccessText attached property 

* Fixed: There is NullReferenceException when a styled Window hold the control 

* Fixed: When IsBackstageOpen is initially set to True, the BackstageItems cannot be selected

* Fixed: When ResizeMode is NoResize or CanMinimize a horizontal white line appears at the bottom of the window 

* Fixed: When the DropDown of a DropDownButton/SplitButton is opened through a KeyTip with two-letter AccessText, the DropDownContent items cannot be properly accessed 

* Fixed: When the RibbonView is placed in a RibbonWindow, there is a space left around the ribbon

* Fixed: Wrong visual display of disabled BackstageItem{% if site.site_name == 'Silverlight' %}

* Fixed: In SL, RibbonComboBox does not show the SelectedState of the SelectedComboBoxitem {% endif %}

### What's New

* Feature: Consider changing the RibbonSplitButton Windows8 style 

* Feature: Don't display the selected content when clicking on a minimized tab while the Backstage menu is opened

* Feature: The Backstage focus behavior should be improved 

* Feature: When the Backstage is open the KeyTips should start from its content 

## Q1 2013

### What's Fixed

* Fixed: When maximizing the Ribbon, groups are not resized as expected

* Fixed: Blurred images inside button groups

* Fixed: If the Width property of a RibbonGroup is set, the ribbon scrolling mechanism doesn't work correctly

* Fixed: Setting the IsSelected to true on RadRibbonTab from a RadRibbonContextualGroup does not work as expected

* Fixed: Change the RadCollapsiblePanel to display its optimum layout in a CollapsedGroup.DropDown

* Fixed: RadCollapsiblePanel stops working after some resizing of the ribbon

* Fixed: Contextual groups hide/show issue

* Fixed: The ribbon buttons do not center their icon

* Fixed: The Image and Text of the RibbonButtons cannot be centered

* Fixed: RadRibbonTabs do not go into "MouseOver" state properly when their MinWidth is set

* Fixed: Null reference exception when RibbonButton bound to empty text

* Fixed: Changing DataContext does not remove selected tab content

* Fixed: The arrow in the Large sized RadRibbonDropDownButton is not positioned correctly

* Fixed: Activating Window's system menu when clicking in the top half of the ApplicationMenu

* Fixed: Application menu flickers when it is opened

* Fixed: Application theme is not applied to classes that inherit from RadRibbonGroup

* Fixed: Change the RibbonRadioButton Foreground on Selected

* Fixed: Changing theme in run-time from a RibbonDropDownButton placed in the RibbonView throws exception

* Fixed: Check for Division by zero in calculating rows in RadRibbonGallery.

* Fixed: Continious MouseOver near the edge of a RadRibbonGroup

* Fixed: ContextualGroup Header goes behind the Title of the RadRibbonWindow

* Fixed: Design time Errors for missing icons when using implicit themes

* Fixed: Icons are not included correctly in NoXaml dlls and this causes a design time error

* Fixed: If a RibbonTab contains a Collapsed RibbonGroup, the variants resizing logic doesn't work correctly

* Fixed: Memory leak

* Fixed: Misplaced ContextualGroupHeader on activation

* Fixed: Not showing tab's content when changing the tab's visibility asynchronously

* Fixed: RadRibbonGallery does not show initially the SelectedItem in databinding scenarios

* Fixed: RadRibbonSplitButton throws exception.

* Fixed: RibbonGallery UpDownButtonTitle and MoreButtonTitle properties are not applied in WPF

* Fixed: Setting the Content of a RibbonSplitButton added to a second RibbonTab throws an exception

* Fixed: Setting the WindowIconVisibility property throws exception

* Fixed: Support for browser zooming

* Fixed: The application menu doesn't reposition itself when the window is resized

* Fixed: The popup with minimized tabs isn't closed	

* Fixed: The RadRibbonComboBox DropDownContent doesn't display the selected item

* Fixed: The text in the RadRibbonDropDownButton and RadRibbonSplitButton is not aligned

* Fixed: There is a black border line under the selected tab

* Fixed: Tooltip icon should not be streched – ScreenTip

* Fixed: When group is collapsed, the buttons in the popup are not sized correctly

* Fixed: When placed in Window with ResizeMode=CanResizeWithGrip, the BackStage does not open and exception is printed in output.

* Fixed: When RadRibbonDropDownButton is pressed in the Application Menu the menu closes

* Fixed: When the ribbon is minimized with a double click on a tab header, the QAT menu minimization option isn't updated

* Fixed: Allow setting an ImageSource as the source of the RibbonWindow.Icon

* Fixed: The RibbonWindow cannot be moved by dragging the left area of the TitleBar

### What's New

* Feature: Add DialogLauncherCommand functionality to RadRibbonGroup

* Feature: Make the height of the ribbon flexible

* Feature: Synchronize the ContextualTabs placement with the corresponding ContextualHeader's Width

* Feature: New ButtonGroup style

## Q3 2012

### What's Fixed

* Fixed: RadRibbonWindow's title is cut, when maximized

* Fixed: RibbonGroup variants priorities aren't applied as expected throughout the tab

* Fixed: UI Automation peers don't work if a RibbonView's element is put in a panel

* Fixed: When RibbonGroup has Visibility = Hidden the keytips of the controls inside it are still shown

## Q2 2012

### What's Fixed

* Fixed: AccessText does not show on a RibbonGroup when it is in Collapsed RibbonGroupVariant

* Fixed: Black Square Occurs when Backstage is Opened in XBAP

* Fixed: Disable the QAT Minimize the Ribbon option if the ribbon isn't minimizable and change the caption of the item if the ribbon is minimized.

* Fixed: A ContextualGroup Header isn't moved when displaying a non-contextual collapsed RibbonTab

* Fixed: Populating a RibbonGroup in xaml causes the designer to switch the selection to the last tab of the ribbon

* Fixed: When the BackstageMenu is open, the parent Window cannot be resized

* Fixed: If you click on a KeyTip of a RadMenuItem in the DropDownContent of a DDButton/SplitButton, the DropDown content is closed but the key tips are not

* Fixed: The RibbonWindow Icon property isn't applied.

* Fixed: When SplitButton or DropDownButton is used in the ApplicationMenu, the DropDownContent is not placed in the "Recent Documents" section

* Fixed: KeyTips are not shown on RadRibbonGroups

* Fixed: Clicking a RibbonButton in ApplicationMenu does not close the menu

* Fixed: UI Automation peers of the RadRibbonView crash IE

* Fixed: An exception is thrown when the ribbon contains a ContextualGroup without tabs

* Fixed: Resizing a RibbonView that contains an active contextual group containing at least one contextual tab, throws an exception

>You can examine the Q2 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2012-version-2012-2-607.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2012-version-2012-2-607-2457892840.aspx){% endif %}.			  

## Q1 2012

### What's Fixed

* Fixed: The style of the RibbonDropDownButton doesn`t load in Expression Blend if the DropDownContent is set

* Fixed: RadRibbonToggleButton`s text is too light when the button is ON and ExpressionDarkTheme is applied

* Fixed: The KeyTips of collapsed elements are displayed

* Fixed: Define the ContextualGroup width accordingly to the width of its header

* Fixed: When a Group's Visibility is set to Invisible, some spacing is not removed

* Fixed:  The arrow of the DropDownButton of the RadRibbonGallery has wrong layout in Metro and Expression_Dark themes

* Fixed: Cannot be used in XBAP in Q3 2011

* Fixed: Wrong state visualization of the RadRibbonToggleButton when the theme is set as an element theme on the RadRibbonView

* Fixed: KeyTips are not shown when they are set on controls placed in middle-row of the RibbonGroup

* Fixed: InvalidOperationException occurs when a collapsed RibbonTab has active ContextualGroup

* Fixed: Add a possibility to choose between MS Office look and MS theme look of the RadRibbonWindow

### What's New

* Feature: RibbonWindow's chrome should be themable

* Feature: Add databinding support for RibbonGroup.Variants collection

>You can examine the Q1 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.
