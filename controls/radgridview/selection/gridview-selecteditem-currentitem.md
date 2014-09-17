---
title: CurrentItem vs SelectedItem
page_title: CurrentItem vs SelectedItem
description: CurrentItem vs SelectedItem
slug: gridview-selection-selecteditem-currentitem
tags: currentitem,vs,selecteditem
published: True
position: 4
---

# CurrentItem vs SelectedItem



This article explains the usage of the SelectedItem and CurrentItem properties

## CurrentItem vs SelectedItem

__CurrentItem__: The CurrentItem property of the RadGridView corresponds to the CurrentItem of the bound ICollectionView. It may or may not coincide with the selected row.
        

__SelectedItem__: The SelectedItem property of the RadGridView is used to access the data item of the selected row. It changes its value every time when the row selection changes and exposes the object to which the row is bound.
        

>Prior to Q2 2010 version, the current item was synchronized with the selected item. As a result, the first row of the GridView was selected initially. To prevent this, you would simply need to set the __IsSynchronizedWithCurrentItem__ property of RadGridView to False. In Q2 2010 version, the IsSynchronizedWithCurrentItem is null by default - SelectedItem is synchronized with the CurrentItem only if CollectionView is used as ItemsSource

## SelectedItems

The __SelectedItems__ is a collection of data items, which holds the currently selected items. As it is a collection you can get, add and remove items from it. In this way you can easily manipulate the selection, e.g. selecting and deselecting items on certain criteria. You can use it when the SelectionUnit is set to FullRow (default), otherwise it is null. It will contain more than one item when the SelectionMode is either Multiple or Extended.

# See Also

 * [Basic Selection]({%slug gridview-selection-basics%})

 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})
