---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-features-selection
tags: radtilelist, selection
published: True
position: 3
---

# Selection in RadTileList

As of Q1 2016, __RadTileList__ exposes a __SelectionMode__ property allowing you to control whether the user can select more than one item in the tile list.

This article covers the following topics:

* [SelectionMode](#selection-mode)
* [SelectedItem and SelectedItems](#selecteditem-and-selecteditems)
* [Reacting to Changes in the Selection](#reacting-to-changes-in-the-selection)


## Selection Mode

The __SelectionMode__ property of RadTileList controls whether users can select one or multiple items and how selecting multiple items can be achieved. The enumeration exposes the following values:

* __Single:__ The user can select only one item at a time.
* __Multiple:__ The user can select multiple items without holding down a modifier key.
* __Extended:__ The user can select multiple consecutive items while holding down the <code>SHIFT</code> key or multiple non-consecutive items by holding down the <code>CTRL</code> key.

__Example 1__ demonstrates how you can set the __SelectionMode__ property in XAML.

__Example 1: Set SelectionMode of RadTileList to Multiple__
```XAML
	<telerik:RadTileList x:Name="RadTileList" SelectionMode="Multiple"/>
```

__Figure 1__ shows the result when Multiple selection is enabled and several tiles are included in the selection.

#### __Figure 1: Multiple selection in RadTileList__
![Grouping SL](images/RadTileList_Features_Selection_01.PNG)

## SelectedItem and SelectedItems

RadTileList exposes the __SelectedItem__ and __SelectedItems__ properties in order to grant you access to the selected item in the items of the control. 

The __SelectedItem__ property corresponds to the item the user has clicked or tapped when SelectionMode is Single.

__SelectedItems__ is a collection of items containing all selected items in the control when SelectionMode is set to Multiple or Extended.

>important The __SelectedItems__ collection will remain empty when SelectionMode is set to Single and you change the selected item. However, when in Multiple or Extended selection mode, __SelectedItem__ will be set to the last item added to the selected items that is still included in the selection.

## Reacting to changes in the selection

Regardless of the mode the selection is in, the __SelectionChanged__ event will be raised when the user changes the selected item or items in RadTileList. The event arguments are of [SelectionChangedEventArgs](https://msdn.microsoft.com/en-us/library/system.windows.controls.selectionchangedeventargs) type, so you gain access to the items removed or added to the selection.

The snippet in __Example 2__ demonstrates how you can react to a change in the current selection.

__Example 2: SelectionChanged event handler for RadTileList__
```C#
	private void EmployeesTileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	    if (e.RemovedItems.Count == 0)
	    {
	        MessageBox.Show("Please choose an employee");
	    }
	}
```
```VB.NET
	Private Sub EmployeesTileList_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
	    If e.RemovedItems.Count = 0 Then
	        MessageBox.Show("Please choose an employee")
	    End If
	End Sub
```


## See Also

* [Populating RadTileList with Tiles ]({%slug radtilelist-getting-started-populating-with-tiles%})
* [SelectionChangedEventArgs on MSDN](https://msdn.microsoft.com/en-us/library/system.windows.controls.selectionchangedeventargs)

