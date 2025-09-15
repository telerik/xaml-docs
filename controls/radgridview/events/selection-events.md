---
title: Selection
page_title: Selection Events
description: Learn more about the selection events of Telerik's {{ site.framework_name }} DataGrid that occur each time there is a modification of the SelectedItems / SelectedCells collection.
slug: gridview-selection-events
tags: selection
published: True
position: 5
---

# Selection Events

There are a number of events relevant to the selection in the RadGridView control. The sequence of the events depends on the __SelectionUnit__ property:

* __FullRow__: The sequence of events is as follows&mdash; __CurrentCellInfoChanged__ -> __SelectionChanging__ -> __SelectedCellsChanging__ -> __SelectedCellsChanged__ -> __SelectionChanged__ .
* __Cell__: The sequence of events is as follows&mdash; __CurrentCellInfoChanged__ -> __SelectedCellsChanging__ -> __SelectedCellsChanged__.
* __Mixed__: The sequence of events depends on whether a row or a cell was selected.

The events are fired by RadGridView each time there is a modification of the __SelectedItems__ / __SelectedCells__ collection, regardless of the way it happened (by user input or programmatically). 

## SelectionChanging

It is fired once a selection is about to be performed and a change in the __SelectedItems__ collection is to be executed. This is the case when a row is to be selected or un-selected and the SelectionUnit is FullRow or Mixed.

__Subscribing to the SelectionChanging event__

```C#
	private void SelectionChanging(object sender, SelectionChangingEventArgs e)
	{
	}
```
```VB.NET
	Private Sub SelectionChanging(sender As Object, e As SelectionChangingEventArgs)
	End Sub
```

__SelectionChangingEventArgs__ exposes the following specific properties:

* __AddedItems__&mdash;A collection of the item(s) that has/have been added to the selection.
* __RemovedItems__&mdash;A collection of the item(s) that has/have been removed from the selection.
* __IsCancelable__&mdash;Gets a value that indicates whether the event is cancelable.
* __Cancel__&mdash;A boolean property that cancels the selection. 

## SelectionChanged

Fires each time there is a change in the __SelectedItems__ collection. This happens when a row has been selected or un-selected and the SelectionUnit is FullRow or Mixed.

__Subscribing to the SelectionChanged event__

```C#
	private void SelectionChanged(object sender, SelectionChangeEventArgs e)
	{
	}
```
```VB.NET
	Private Sub SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangeEventArgs)
	End Sub
```

The __SelectionChangeEventArgs__ class exposes the following specific properties:

* __AddedItems__&mdash;A collection of the items that have been added to the selection.
* __RemovedItems__&mdash;A collection of the items that have been removed from the selection.

## CurrentCellInfoChanged

This event is raised when a cell is selected. It fires before the __SelectionChanged__ event.

__Subscribing to the CurrentCellInfoChanged event__

```C#
	private void CurrentCellInfoChanged(object sender, GridViewCurrentCellInfoChangedEventArgs e)
	{
	}
```
```VB.NET
	Private Sub CurrentCellInfoChanged(ByVal sender As Object, ByVal e As GridViewCurrentCellInfoChangedEventArgs)
	End Sub
```

The __GridViewCurrentCellInfoChangedEventArgs__ class exposes the following specific properties:

* __NewCellInfo__&mdash;The new cell info.
* __OldCellInfo__&mdash;The old cell info.

## SelectedCellsChanging

This event is fired when a change in the __SelectedCells__ collection is about to be performed. This happens when a cell is to be selected or un-selected when the SelectionUnit is Cell or Mixed.

__Subscribing to the SelectedCellsChanging event__

```C#
	private void SelectedCellsChanging(object sender, GridViewSelectedCellsChangingEventArgs e)
	{
	}
```
```VB.NET
	Private Sub SelectedCellsChanging(sender As Object, e As GridViewSelectedCellsChangingEventArgs)
	End Sub
```

The __GridViewSelectedCellsChangingEventArgs__ class exposes the following specific properties:

* __AddedCells__&mdash;A collection of the cells that have been added to the selection.
* __RemovedCells__&mdash;A collection of the cells that have been removed from the selection.
* __IsCancelable__&mdash;Gets a value that indicates whether the event is cancelable.
* __Cancel__&mdash;A boolean property that cancels the cell selection.

## SelectedCellsChanged

Fires each time there is change in the __SelectedCells__ collection. This happens when a cell has been selected or un-selected when the SelectionUnit is Cell.

__Subscribing to the SelectedCellsChanged event__

```C#
	private void SelectedCellsChanged(object sender, GridViewSelectedCellsChangedEventArgs e)
	{
	}
```
```VB.NET
	Private Sub SelectedCellsChanged(sender As Object, e As GridViewSelectedCellsChangedEventArgs)
	End Sub
```

The __GridViewSelectedCellsChangedEventArgs__ class exposes the following specific properties:

* __AddedCells__&mdash;A collection of the cells that have been added to the selection.
* __RemovedCells__&mdash;A collection of the cells that have been removed from the selection.

## See Also

 * [Basic Selection]({%slug gridview-selection-basics%})