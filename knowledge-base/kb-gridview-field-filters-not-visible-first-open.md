---
title: Field Filters Not Visible when Filtering Control Is First Opened
description: When the Filtering Control is first opened, its field filters are not displayed.
page_title: Filter TextBoxes Missing On Initial Load of Filtering Popup
type: troubleshooting
slug: kb-gridview-field-filters-not-visible-first-open
position: 0
tags: field, filters, not, visible, missing, filteringcontrol, first, initial, opened, displayed, popup
ticketid: 1579426
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.3.912</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

The field filter controls (textboxes, comboboxes, etc.) of the FilteringControl popup of the RadGridView control are not displayed when the popup is first opened. Subsequently opening the popup displays the filters as expected.

## Solution

Such an issue can occur if a custom FilteringControl is defined and its base constructor is not called. This happens because the default FilteringControl class initializes most of its logic (along with the filter editors) in its constructor.

To resolve this, ensure that the constructor of the base FilteringControl class is called:


```C#
	public CustomFilteringControl(GridViewColumn column) : base(column)
	{
		// ...
	}
```

You can then assign the custom filtering control as follows:


```C#
	foreach (var column in GridView.Columns)
	{
		column.FilteringControl = new CustomFilteringControl(column);
	}
```

## See Also
* [Popup Filtering]({%slug gridview-filtering-basic%}#popup-filtering)
* [Custom Filtering Controls]({%slug gridview-filtering-custom-filtering-controls%})
