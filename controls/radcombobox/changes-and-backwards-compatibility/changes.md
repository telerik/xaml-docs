---
title: Changes
page_title: Changes
description: Changes
slug: radcombobox-changes
tags: changes
publish: True
position: 0
---

# Changes



This article describes the release history of the control.

For the complete Release History of RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to
                {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.
            

## Q3 2013

### What's Fixed

* When the ComboBox is focused via some other controls event the focus is passed and lost immediately
                                

* ComboBox UI issue in Transparent Theme
                                

## Q2 2013

### What's Fixed

* Make the scrolling smooth with touch framework
                                

## Q1 2013

### What's New

* DropDownWidth property is added

### What's Fixed

* When theme is set in XAML through StyleManager and the ItemsSource is set in XAML the RadComboBoxItems are with default theme 

* Setting IsMouseWheelEnabled = False has no effect

* CanAutocompleteSelectItems=false doesn't highlight the item, when there is already selected item

* Made the ItemsControl.IsTextSearchCaseSensitive work for RadComboBox

* When the DropDown is open and EnableMouseWheel is true, when scrolling outside the ComboBox the Popup stays open and detaches from the control

* The selection is reset when Select Control Pattern of an ComboBoxItem automation peer is called
