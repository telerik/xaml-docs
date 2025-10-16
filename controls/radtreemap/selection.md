---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-selection
tags: selection
published: True
position: 6
---

# Selection

__RadTreeMap__ and __RadPivotMap__ support selection functionality which is disabled by default. You can enable it by setting the control's __IsSelectionEnabled__ property to __True__.

> The following examples use __RadTreeMap__ but the same properties are exposed by the __RadPivotMap__ control as well.


```XAML
	<telerik:RadTreeMap IsSelectionEnabled="True">
```


```C#
	treeMap.IsSelectionEnabled = true;
```
```VB.NET
	treeMap.IsSelectionEnabled = True
```

## Selection Modes

The selection feature supports several modes which you can set through the __SelectionMode__ property.
* __Single__ (default value): This mode allows selection of a single item only. Clicking an item will select it and deselect the previously selected one, if there is such.
* __Multiple__: This mode allows selection of multiple items. Clicking an item will select it and it will keep the previously selected items.
* __Extended__: This mode combines the Single and Multiple modes. Clicking an item deselect the others, however, if the Ctrl key is pressed the previous selection will be preserved.


```XAML
	<telerik:RadTreeMap SelectionMode="Extended" />
```
	

```C#
	treeMap.SelectionMode = System.Windows.Controls.SelectionMode.Extended;
```
```VB.NET
	treeMap.SelectionMode = System.Windows.Controls.SelectionMode.Extended
```


## Related Properties

__RadTreeMap__ and __RadPivotMap__ controls expose several properties which allow you to access the current selected item(s).
* __SelectedItem__: Gets the selected item.
* __SelectedItems__: Gets a read-only collection that contains the selected items.
* __SelectedValue__: Gets or sets a value from the SelectedItem.
* __SelectedValuePath__: Gets or sets a path that is used to get the SelectedValue for the SelectedItem.

## Events

There are couple events which are fired when the selection is changed - __SelectionChanged__ and __PreviewSelectionChanged__. Their handlers use an object of type __SelectionChangedRoutedEventArgs__ as a second parameter that holds information about the selection.	

## See Also
* [Overview]({%slug radtreemap-overview %})
* [SDK Examples]({%slug radtreemap-sdk-examples %})
* [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap %})
* [Populating With Data RadPivotMap]({%slug radtreemap-populating-with-data-radpivotmap %})
