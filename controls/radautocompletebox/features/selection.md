---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-features-selection
tags: selection
published: True
position: 2
---

# Selection

The purpose of this article is to show you the basic properties exposed by the __RadAutoCompleteBox__ for working with __selection__.

## SelectionMode

The RadAutoCompleteBox control provides two selection modes, which allow you to manipulate the type of selection. This is controlled by the SelectionMode enumeration property which has the following values:

* __Multiple__: Multiple items can be added to the selection. __(default value)__

* __Single__: Only one item can be selected at a time.

## SelectedItem and SelectedItems

RadAutoCompleteBox exposes the __SelectedItem__ and __SelectedItems__ properties in order to grant you access to the selected item in the items of the control.

The __SelectedItem__ property corresponds to the item the user has selected when SelectionMode is Single.

__SelectedItems__ is a collection of items containing all selected items in the control when SelectionMode is set to Multiple.

>important The __SelectedItems__ collection will always contain a single item when SelectionMode is set to Single and you change the selected item. When in Multiple selection mode, __SelectedItem__ will be set to the first item added to the selected items that is still included in the selection.

**Example 1** demonstrates how to get ahold of the selected items and also determine which item was selected first when in Multiple selection mode.

__Example 1: Working with SelectedItem and SelectedItems__

```C#
	private void AutoComplete_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedCountries = autoComplete.SelectedItems;
		var firstSelectedCountry = autoComplete.SelectedItem as Country;
	}
```
```VB.NET	
	Private Sub AutoComplete_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
		Dim selectedCountries = autoComplete.SelectedItems
		Dim firstSelectedCountry = TryCast(autoComplete.SelectedItem, Country)
	End Sub
```

## See Also

 * [Events]({%slug radautocompletebox-events%})
 * [Key Properties]({%slug radautocompletebox-features-key-properties%})