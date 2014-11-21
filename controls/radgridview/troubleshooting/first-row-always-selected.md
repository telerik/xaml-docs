---
title: First Row is Always Selected
page_title: First Row is Always Selected
description: First Row is Always Selected
slug: gridview-troubleshooting-first-row-always-selected
tags: first,row,is,always,selected
published: True
position: 6
---

# First Row is Always Selected

__PROBLEM__

By default, the first row of the GridView is selected. This is also causing the [SelectionChanged]({%slug gridview-selection-events%}) event to fire when the grid is loaded. 

>tipThis behavior does not occur in __Q2 2010__ version and later. 

__CAUSE__

Let's first start with some definitions:

* __SelectedItem__ - this is the data item (business object) of the __selected row__. 

* __CurrentItem__ - holds the data item (business object) of the row which currently __holds the focus__. It may or may not coincide with the selected row.

With versions prior to Q2 2010, the __current item was synchronized with the selected item__ by default. As a result, the __first row__ of the GridView was __initially selected__.

__SOLUTION__

Set the __IsSynchronizedWithCurrentItem__ property of RadGridView to __False__.

>Since Q2 2010 version the __IsSynchronizedWithCurrentItem__ is null by default - SelectedItem is synchronized with the CurrentItem only if CollectionView is used as ItemsSource. 
