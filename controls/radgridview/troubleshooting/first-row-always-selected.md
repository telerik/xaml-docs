---
title: First Row is Always Selected
page_title: First Row is Always Selected
description: Get staretd with Telerik's {{ site.framework_name }} DataGrid and learn how not to have the first row selected by default.
slug: gridview-troubleshooting-first-row-always-selected
tags: first,row,is,always,selected
published: True
position: 6
---

# First Row is Always Selected

__PROBLEM__

By default, the first row of the RadGridView is selected. This is also causing the [SelectionChanged]({%slug gridview-selection-events%}) event to fire when the control is loaded.

>tip This behavior does not occur in versions after __Q2 2010__. 

__CAUSE__

Let's first start with some definitions:

* __SelectedItem__: Holds the data item (business object) of the __selected row__. 

* __CurrentItem__: Corresponds to the **CurrentItem** of the bound **ICollectionView**. It may or may not coincide with the selected row.

With versions prior to Q2 2010, the __current item was synchronized with the selected item__ by default. As a result, the __first row__ of the control was __initially selected__.

__SOLUTION__

Set the __IsSynchronizedWithCurrentItem__ property of RadGridView to __False__.

>Since Q2 2010 version the __IsSynchronizedWithCurrentItem__ is **null** by default - SelectedItem is synchronized with the CurrentItem only if a **CollectionView** is used as **ItemsSource**. 

## See Also

* [CurrentItem, SelectedItem & SelectedItems]({%slug gridview-selection-selecteditem-currentitem%})
* [Basic Selection]({%slug gridview-selection-basics%})
