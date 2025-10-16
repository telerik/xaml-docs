---
title: Hiding the Field Filters in RadGridView Popup Filter Control
description: This article shows how to hide the field filters shown in the RadGridView's WPF FilteringControl.
type: how-to
page_title: How to Remove the FieldFilters in RadGridView Popup Filter Control
slug: kb-gridview-hide-fieldfilters
tags: radgridview, popup filter control, hide fieldfilter, radcombobox, visibility
res_type: kb
---
## Environment

| Property | Value |
|----------|-------|
| Product  | RadGridView for WPF |

## Description

How to remove the field filters in the FilteringControl shown in the RadGridView's column filter popup.

## Solution 1

To hide the two field filters, set the [ShowFieldFilters]({%slug gridview-filtering-basic%}) property of the GridView column to `false`.


```XAML
	<telerik:GridViewDataColumn ShowFieldFilters="False" />
```

## Solution 2

To hide only one of the filters, use the Loaded event of the `FilteringControl` in order to access the corresponding visual elements. Then, set their `Visibility` to `Collapsed`.


```C#
	static MainWindow()
	{
		EventManager.RegisterClassHandler(typeof(FilteringControl), FilteringControl.LoadedEvent, new RoutedEventHandler(OnFilteringControlLoaded));
	}

	private static void OnFilteringControlLoaded(object sender, RoutedEventArgs e)
	{
		var filteringControl = (FilteringControl)sender;
		var comboBoxes = filteringControl.ChildrenOfType<RadComboBox>();
		
		var logicalOperatorComboBox = comboBoxes.FirstOrDefault(x => x.Name == "PART_LogicalOperatorsComboBox");
		if (logicalOperatorComboBox != null)
		{
			logicalOperatorComboBox.Visibility = Visibility.Collapsed;
		}

		var filter2ComboBox = comboBoxes.FirstOrDefault(x => x.Name == "PART_Filter2ComboBox");
		if (filter2ComboBox != null)
		{
			filter2ComboBox.Visibility = Visibility.Collapsed;
		}

		var filter2Editor = filteringControl.ChildrenOfType<ContentControl>().FirstOrDefault(x => x.Name == "PART_Filter2ContentControl");
		if (filter2Editor != null)
		{
			filter2Editor.Visibility = Visibility.Collapsed;
		}
	}
```
