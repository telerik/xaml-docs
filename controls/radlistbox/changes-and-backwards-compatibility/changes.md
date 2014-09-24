---
title: Changes
page_title: Changes
description: Changes
slug: radlistbox-changes
tags: changes
published: True
position: 0
---

# Changes



This article describes the release history of the control.

For the complete Release History of RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to
        {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.
      

## Q1 2014

### What's New

* Extend the ListBoxDragVisualProvider to include DropTarget, DropPosition and DragTarget
                

* Improve the style of the ListBoxDragVisual
                

## Q3 2013

### What's Fixed

* Cannot interact with a button placed in ListBoxItem in Windows8TouchTheme
                

## Q2 2013

### What's New

* Enable the smooth scrolling of the ListBox with all panels with touch
                

### What's Fixed

* Calling ScrollIntoView before RadListBox is loaded results in incorrect selection behavior
                

* RadListBox selection is cleared when the control is used in ItemsTemplate
                

* NullReferenceException thrown in GeneratePanelInfo()
                

* NullReferenceException in RadListBox when using touch and the ColorPicker
                

* NullReferenceException is thrown in RadListBox with CollectionViewSource set to Empty
                

* RadListBoxItem do not get implicit style in Windows8Touch
                

* DropCue is missing when dragging item
                

* KeyDown shouldn't be handled if TextSearch is disabled
                

* Prevent the ScrollViewer from receiving focus to let a RadListBoxItem to receive the focus when the user navigates to the RadListBox control
                

## Q1 2013

### What's New

* Added DropCueTemplate when Drag-Drop

* Added MouseDoubleClick event for the listbox items

* Keyboard support for VirtualizingWrapPanel

### What's Fixed

* Calling ScrollIntoView before the control is loaded results in incorrect selection behavior

* Issue with ListBoxDragDropBehavior when AllowReorder is set to False, the dragged item is moved after the last item

* Cannot drop item in the end of the ListBox

* In Static ListBox dropped item always goes as a last element

* LinearDropVisual stays visible when drag and drop between multiple listbox controls

* Added disabled state for the RadListBox control

* Telerik Commands cannot be set inline in XAML

* Setting RadListBoxItem.IsSelected property in xaml doesn't select the item

* The RadListBox control throws an exception when setting SelectedItem before it is loaded

* Page Up/Down always moves with 10 items it should go to the top/bottom of visible range

* Cannot manipulate SelectedItem in the SelectionChanged event handler

* IsSelected and IsHighlighted dependency properties are now public

* ListBoxItem is not selected when initially IsSelected is bound to true

* SelectedValue is not updating selection when is bound
