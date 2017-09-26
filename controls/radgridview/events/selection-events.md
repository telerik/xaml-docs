---
title: Selection
page_title: Selection
description: Selection
slug: gridview-selection-events
tags: selection
published: True
position: 5
---

# Selection


There are a couple of events relevant to the selection in RadGridView: [SelectionChanging](#selectionchanging-event), [SelectionChanged](#selectionchanged-event), [CurrentCellChanged](#currentcellchanged-event), [SelectedCellsChanging](#selectedcellschanging-event) and [SelectedCellsChanged](#selectedcellschanged-event). The sequence of the events depends on the __SelectionUnit__ property:

* __FullRow__ - the __SelectionChanged__ is fired first and after that the __CurrentCellChanged__ event fires 

* __Cell__ - the __SelectedCellsChanged__ is fired first and after that the __CurrentCellChanged__ event fires

The events are fired by RadGridView each time there is a modification of the __SelectedItems__ / __SelectedCells__ collection, regardless of the way it happened (by user input or programmatically). 

## SelectionChanging event

It is fired once a selection is about to be performed and a change in the SelectedItems collection is to be executed (a row is to be selected or un-selected and SelectionUnit="FullRow").

#### __C#__

{{region cs-gridview-selection-events_0}}
	private void SelectionChanging(object sender, SelectionChangingEventArgs e)
	{
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-selection-events_1}}
	Private Sub SelectionChanging(sender As Object, e As SelectionChangingEventArgs)
	End Sub
{{endregion}}


__SelectionChangingEventArgs__ exposes the following specific properties:__AddedItems__ - a collection of the item(s) that has/have been added to the selection. __RemovedItems__ - a collection of the item(s) that has/have been removed from the selection. __IsCancelable__ - gets a value that indicates whether the event is cancelable. __Cancel__ - a boolean property that enables canceling the selection. 

## SelectionChanged event

Fires each time there is a change in the __SelectedItems__ collection (a row has been selected or un-selected and SelectionUnit="FullRow").

#### __C#__

{{region cs-gridview-selection-events_2}}
	private void SelectionChanged(object sender, SelectionChangeEventArgs e)
	{
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-selection-events_3}}
	Private Sub SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangeEventArgs)
	End Sub
{{endregion}}


The __SelectionChangeEventArgs__ class exposes the following specific properties:

* __AddedItems__ - a collection of the item(s) that has/have been added to the selection

* __RemovedItems__ - a collection of the item(s) that has/have been removed from the selection

## CurrentCellChanged event

This event is raised when a cell is selected. It fires before the __SelectionChanged__ (when SelectionUnit="FullRow") or before the __SelectedCellsChanged__ (when SelectionUnit="Cell").

#### __C#__

{{region cs-gridview-selection-events_4}}
	private void CurrentCellChanged(object sender, GridViewCurrentCellChangedEventArgs e)
	{
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-selection-events_5}}
	Private Sub CurrentCellChanged(ByVal sender As Object, ByVal e As GridViewCurrentCellChangedEventArgs)
	End Sub
{{endregion}}


The __GridViewCurrentCellChangedEventArgs__ class exposes the following specific properties:

* __NewCell__ - an instance of the newly selected cell

* __OldCell__ - an instance of the previously selected cell

## SelectedCellsChanging event

This event is fired on the time a change in the SelectedCells collection is about to be performed (a cell is to be selected or un-selected when the SelectionUnit="Cell").

#### __C#__

{{region cs-gridview-selection-events_6}}
	private void SelectedCellsChanging(object sender, GridViewSelectedCellsChangingEventArgs e)
	{
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-selection-events_7}}
	Private Sub SelectedCellsChanging(sender As Object, e As GridViewSelectedCellsChangingEventArgs)
	End Sub
{{endregion}}


The __GridViewSelectedCellsChangingEventArgs__ class exposes the following specific properties:

* __AddedCells__ - a collection of the cell(s) that has/have been added to the selection

* __RemovedCells__ - a collection of the cell(s) that has/have been removed from the selection

* __IsCancelable__ - gets a value that indicates whether the event is cancelable

* __Cancel__ - a boolean property that enables canceling the cell selection

## SelectedCellsChanged event

Fires each time there is change in the __SelectedCells__ collection (a cell has been selected or un-selected when the SelectionUnit="Cell").

#### __C#__

{{region cs-gridview-selection-events_8}}
	private void gridView_SelectedCellsChanged(object sender, GridViewSelectedCellsChangedEventArgs e)
	{
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-selection-events_9}}
	Private Sub gridView_SelectedCellsChanged(sender As Object, e As GridViewSelectedCellsChangedEventArgs)
	End Sub
{{endregion}}

The __GridViewSelectedCellsChangedEventArgs__ class exposes the following specific properties:

* __AddedCells__ - a collection of the cell(s) that has/have been added to the selection

* __RemovedCells__ - a collection of the cell(s) that has/have been removed from the selection

## See Also

 * [Basic Selection]({%slug gridview-selection-basics%})
