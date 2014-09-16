---
title: Changes
page_title: Changes
description: Changes
slug: raddocking-changes
tags: changes
publish: True
position: 0
---

# Changes



This article describes the release history of the control.

## Q1 2014

### What's New

* Support of nested RadDocking inside other RadDocking instances
                

### What's Fixed

* AutoHideArea is opening when pin/unpin another Pane
                

* ActivePaneChanged event is triggered twice when closing Pane with index bigger than 1
                

* Saving the layout of a Docking control which contains empty DocumentHost generates incorrect xml code
                

* When Saving and Loading a layout which has empty DocumentHost, an ArgumentOutOfRangeException is thrown
                

* Removing item from the PanesSource collection causes NullReferenceException
                

* HorizontalAlignment is not working inside Header Template in Windows8 theme
                

* Bindings with ElementName are not working in the DocumentHost
                

## Q3 2013

### What's New

* Added "PaneActivationMode" property. Using the feature you are able to choose whitch RadPane will be focused after closing the active one
                

* Make it possible to hide the drop cue of the PaneGroup tab strip when dragging Panes separately from the compass
                

### What's Fixed

* The FontSize of the ToolWindow's content is set incorrectly from the Header's FontSize.
                

* Resizer is moved when dragging a tool window over it in Touch
                

* ToolWindow is automatically pinned when moved
                

* Exception is being thrown when you drop Pane on the Compass and immediately after the drop the mouse left button is clicked
                

* If there is a BusyIndicator in one of the Panes that hasn't been activated the compasses are shown incorrectly
                

* If you have an active RadPane and make another RadPane from the same group active, the Autohide popup collapses
                

* CodedUI can't find RadPane's content with the default search criteria.
                

* ToolWindow is automatically pinned when moved.
                

* AutomationPeers: not able to locate the AutoHide area
                

* When the control is shown inside a different Thread which ApartmentState i set to STA, when a floating Pane is floated out of the main Window an ArgumentNullException is thrown
                

* DocumentHost PaneGroup menu items have icon column event when there is no icon.
                

* Child Window is hidden behind its parent Window if the parent has RadDocking and WPF WebBrowser with pdf document in it.
                

* AutomationPeers: Not able to locate items inside Dock after drag Panes
                

* When add and remove Tab items with RadDocking in it, an error is thrown.
                

* Docked PaneGroups does not have selected item if pane is made floating on MainWindow_OnLoaded event.
                

* The RadPane located in a ToolWindow loses activation on a mouse Right Click Down
                

## Q2 2013

### What's New

* Keyboard navigation improvements
                

### What's Fixed{% if site.site_name == 'WPF' %}

* Showing the compass is slow and when drag a pane, it is lagging
                  

* Problem with SerializationTags in Save/Load layout when RadDocking is placed into a DataTemplate
                  {% endif %}

* Right Click on Panes Content does not trigger ActivePaneChanged event
                

* The theme is not applied on RadResizers when the StyleManager is used
                

* When trying to reorder RadPanes that are placed inside another RadPane an exception is thrown
                

* When object of MarshalByRefObject type is placed in the AutoHideArea its content is not clickable
                

* Canceling PreviewShowCompass doesn't prevent the empty document host compass from showing
                

* NullRefenrenceException if RadDocking's theme is defined at the same place where the control is used
                

* Elements which don't belong to the RadDocking control can be dropped in it using DragDropManager
                

* On the last Pane close the ActivePaneChanged event is not triggered, but the ActivePane is changed
                

* Resizers are hidden behind RadPaneGroup if you have more RadPaneGroups inside RadSplitContainer of DocumentHost
                

* When DragDropMode="Deferred" and there is some UI element in the RadPane's content the pane can be dragged by clicking on its content
                

* Change AutoHideArea animations to start when the popup is loaded
                

* Can drop in the middle of a pane group even if the compass is not shown (forbidden) in Windows8Touch theme
                

* Drag causes NullReferenceException if a RadGridView is placed in nested RadPane/RadPaneGroups
                

* When using Tab to navigate to the RadListBox it cycles through all items, instead of just the selected one
                

## Q1 2013

### What's New

* Implement TabStripPlacement property

* Allow the AutoHideArea events to be customizable 

* Dragging and dropping panes without being able to leave them floating. Check [here]({%slug raddocking-features-dragdropmode%}) for more details.
                

### What's Fixed

* Select the following pane after unpinning a pane

* Change design of Compass to remove the little tab-like indicators in the center indicator; Indicators are too small to signify anything and do not look ok

* After changing themes at runtime pinning a RadPane may display a tab, in spite it is the only pane into the RadPaneGroup

* Exception is thrown when binding IsHidden property in floating pane

* An exception is thrown when the IsHidden property of a RadPane is bound with FallbackValue="True" 

* Make ContextMenu of the RadPane to show only on right-click in the Header

* The last pane in a PaneGroup stays alive even if it is removed from the parent 

* Elements in Pane are not accessible from Visual Studio Coded UI Test Builder

* Disable expand of the RadPane on mouse hover 

* IsPinned property of the RadPane control throws an exception when bound 

* Memory leak of Docking control 

* An exception is thrown when the IsPinned property is bound with FallbackValue="False"

* Docking panes issue in Silverlight 5 and OOB multiple windows 
