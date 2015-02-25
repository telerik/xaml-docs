---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radspreadsheet-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



This article lists the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.

## What's Different in 2015 Q1

### Changed

__CellEditorBase__ no longer inherits from __Textbox__.


### Changed

Removed __CellEditor__'s InsertText(string), SetText(string, int), SetText(string) and ClearContent() methods.

### What to do now

Use the Text property.


### Changed

__ICellEditor__ interface:

* Changed the __TextChanged__ type from TextChangedEventHandler to EventHandler
* Changed the __SelectionChanged__ type from RoutedEventHandler to EventHandler
* Removed the __int CaretIndex__ property



### Changed      

The __DocumentContentChanged__ event of __CellEditor__ is obsolete.

### What to do now

Use the __TextChanged__ event instead.


## What's Different in 2014 Q3

### Changed

The __IsEnabled__ property of the WorkbookHistory class is changed to be by default false. . It is set to true when the Workbook is assigned to a RadSpreadsheet.
            

### What to do now

If you are modifying a Workbook without showing it in RadSpreadsheet and need to preserve the history, set the IsEnabled property to true.
            

## What's Different in 2014 Q1

### Changed

The __NameBox__ class uses a ViewModel.
            

### What to do now

Use the properties of the __NameBoxViewModel__.
            
