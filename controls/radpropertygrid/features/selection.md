---
title: Selection
page_title: Selection
description: Selection
slug: radpropertygrid-selection
tags: selection
published: True
position: 9
---

# Selection



RadPropertyGrid provides you with a selection functionality, which allows the user to select one or more items from the data displayed by the control.

## Selection Modes

RadPropertyGrid provides three selection modes, which allow you to manipulate the type of selection. This is controlled by the SelectionMode enumeration property which has the following entries:

* __Single__ - only one item can be selected at a time. __(default value)__

* __Multiple__ - items are added to the selection when they get clicked and get removed when they get clicked again.
          

* __Extended__ - items are added to the selection only by combining the mouse clicks with the __Ctrl__ or __Shift__ key.
          

>tip Pressing __Ctrl+A__ will select all items.
        

## Selected items

__RadPropertyGrid__provides several properties to get the data behind the selected items - __SelectedPropertyDefinition__, __SelectedField__ and __SelectedPropertyDefinitions__.
        

* __SelectedPropertyDefinition__ - the business object that sits behind the selected Property Definition.
          

* __SelectedField__ (marked as obsolete) - the business object that sits behind the selected Property Definition.
          

* __SelectedPropertyDefinitions__ - a collection of the business objects that sits behind the selected Property Definitions. It will contain more than one item when the __SelectionMode__ is either __Multiple__ or __Extended__.
          

## Events

There are two events relevant to the selection in RadPropertyGrid: __SelectionChanged__ and __SelectedFieldChanged__. Note that SelectedFieldChanged event is marked as obsolete.
        
