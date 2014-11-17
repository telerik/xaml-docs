---
title: Changes
page_title: Changes
description: Changes
slug: radtabcontrol-changes
tags: changes
published: True
position: 0
---

# Changes



This article describes the release history of the RadTabControl control

## Q2 2013

### What's Fixed

* Fixed: In Windows8Theme, the content of a nested TabControl isn't visible 

### What's New

* Feature: Add content presenter after tab items strip 

## Q1 2013

### What's Fixed

* Fixed: The content of a TabItem cannot be located by Coded UI Test

* Fixed: Apply a Transparent Background in the EmptyScrollViewer style

* Fixed: If the control is wrapped in a ScrollViewer and it also contains a RadGridView, setting the GridView.Columns size to '*' doesn't work

* Fixed: In WPF (ClickOnce) the selected Tab is completely white

* Fixed: It is not possible to set the content of a RadTabItem programmatically

* Fixed: Pressing "Tab" key does not change the focus

* Fixed: Refresh of the UI Automation tree do not refresh the RadTabItem

* Fixed: The AutomationProperties class members aren't used in the automation support implementation of the RadTabItems

* Fixed: When ContentPresenter or ContentControl's content is bound in ContentTemplate an  exception occurs

* Fixed: When TabOrientation="Horizontal", the tabs could be added Top to Bottom with the first tab at the top

* Fixed: Recursive Call to Automation Peer API

## Q2 2012

### What's Fixed

* Fixed: In Databound TabControl the scroll buttons are only visible after window resizing 

* Fixed: Right Arrow button behaves abnormally when dynamically add tab items multiple times

* Fixed: DropDownButton Disappears when resizing the browser

* Fixed: Using ExecutionMode = Legacy in RadTabControl does not work correctly

* Fixed: If the control is wrapped in a ScrollViewer and it also contains a RadGridView, setting the GridView.Columns size to '*' doesn't work 

* Fixed: After maximize/minimize operations  the control Previous/Next arrows missing

* Fixed: Activate the TabItem.Header MouseOver state only when the mouse is over the header

* Fixed: The content of the TextBlocks in the content of the TabItems isn't visible in Metro theme

## Q1 2012

### What's Fixed

* Fixed: Strange behavior of the "RightArrow" key in a RadTabItem's content 

* Fixed: DisplayMemberPath doesn't work

* Fixed: AllowDragReorder set to true breaks the Mouse Selection in a TextBox in a TabItem's Content

* Fixed: When the TabControl is placed in a star-sized row/column the tabs cannot be reordered. And an exception is thrown when trying to drag a TabItem from a parent to a child TabControl.

### What's New

* Feature: Add a HeaderBackground property to control the Background of the HeaderBackground ControlTemplate element

>You can examine the Q1 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.
			  

# See Also
