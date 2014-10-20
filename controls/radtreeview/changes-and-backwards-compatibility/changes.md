---
title: Changes
page_title: Changes
description: Changes
slug: radtreeview-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the RadTreeView control

## Q1 2014
### What's Fixed

* Fixed: The lines of the control look jagged 

* Fixed: DragDrop operation produces exception when ScrollViewer is removed from the TreeView's ControlTemplate

## Q2 2013
### What's Fixed

* Fixed: AllowDrop is initially set to True

* Fixed: DropPreviewLine is incorrectly positioned in zoomed browser 

* Fixed: Exception occurs when several DragNDrop operations are performed on static RadTreeViewItems with default Style applied 

* Fixed: Highlighting the RadTreeViewItems is not correct when hosted in a native TabControl 

* Fixed: MemoryLeak when using the RadTreeView with RadContextMenu 

* Fixed: MouseOver is not updated properly when header content captures the mouse

* Fixed: Selection should not be cleared when selected item is replaced with itself

* Fixed: The DragCue does not use Nested Item Templates 

* Fixed: The DragCue offset is wrong when the DragActionContent is long 

* Fixed: The DropPreviewLine is positioned incorrectly 

* Fixed: The RadTreeViewItems are expanded if during a drag operation, the mouse hovers over them, even if the drop is outside the item 

* Fixed: When dragging a RadTreeViewItem, if it isn't removed from its original source, its mouseover state isn't changed 

* Fixed: Wrong ItemTemplate is used in the DragVisualCue in certain databinding scenarios 

### What's New

* Feature: Ability to turn auto-scroll on/off 

* Feature: Allow adjusting the size of the drop zones 

* Feature: Drop line before the first RadTreeViewItem needed 

* Feature: Implement AutoScrolling During Drag/Drop 

* Feature: Refactor Drag Drop logic to use the new API 

## Q1 2013
### What's Fixed

* Fixed: Dynamic implicit theme change breaks expand/collapse animations

* Fixed: Built-in drag and drop does not work in ElementHost

* Fixed: Does not resize smoothly when placed in RadWindow and has Auto Width

* Fixed: DragDrop when bound to XML throws a null ref exception

* Fixed: Drop position is not calculated correctly in winforms window

* Fixed: Dynamic FontSize bug in Windows8 theme

* Fixed: Handling PreviewCollasped when the last item is removed does not update state

* Fixed: Having ComboBox as item header and IsDragDropEnabled=True disallows scrolling in the ComboBox's drop-down

* Fixed: Multiple selected items are not deselected correctly when single selecting another

* Fixed: Newly added items can't be selected

* Fixed: NullRef if SelectedItem is removed in the Selected handler

* Fixed: Problem when reloading treeview while editting an item

* Fixed: Setting IsInEditMode in the  MouseDoubleClick event handler doesn`t work properly

* Fixed: The DragTooltip Content doesn't properly update when dragging TreeViewItems in an unpinned pane

* Fixed: When the control is used in the RibbonView.Backstage menu, its DragTooltip isn't properly updated during drag

* Fixed: Wrong visualization of the node connecting line

### What's New

* Feature: Obsolete TreeView RadioButtons support

* Feature: Add touch support for scrolling

## Q3 2012
### What's Fixed

* Fixed: Changing the height of TreeViewItem not respected by TreeViewPanel

* Fixed: Move operation causes exception in the virtualization panel

### What's New

* Feature: Touch Support for Scrolling

## Q2 2012
### What's Fixed

* Fixed: Keyboard Navigation Not Relative to Focused Item 

* Fixed: The SelectedItem is not updated after change of the ItemSource collection

* Fixed: In SL 5, when the CheckState of the RadTreeViewItem is bound via StyleBindings, Null Reference exception occurs

* Fixed: Opening MessageBox on DoubleClick with enabled drag drop functionality freezes the mouse interaction

>You can examine the Q2 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2012-version-2012-2-607.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2012-version-2012-2-607-2457892840.aspx){% endif %}.
			
## Q1 2012
### What's Fixed

* Fixed: PreviewDragStarted fires if you handle PreviewSelected/PreviewUnselected 

* Fixed: In ExpressionDark and Metro Theme, Foreground color is too light when a RadTreeViewItem is first selected and expanded

* Fixed: Edit mode does not starts when fast clicks are performed over tree items and then F2 is pressed

* Fixed: The IsDropPreviewLineEnabled property is not shown in the Properties Window

* Fixed: SelectedItem property description is wrong

* Fixed: When a RadContextMenu is opened, the RadTreeViewItem behind stays in MouseOver state

### What's New

* Feature: Changing the IsDragDropEnabled Should Update Existing Items

* Feature: Add Double Click Event

>You can examine the Q1 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.
			  
