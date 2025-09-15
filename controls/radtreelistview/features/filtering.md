---
title: Filtering
page_title: Filtering
description: Check our &quot;Filtering&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-features-filtering
tags: filtering
published: True
position: 7
---

# Filtering

## 

The __RadTreeListView__ provides you with a built-in filtering functionality, which allows the user to easily filter the data by one or more columns.

Clicking the filtering icon in the column headers opens a menu with the distinct values for the current column and the user can select which of these values to be displayed. The user can also enter a filter criterion in the filter box. A drop-down list allows for selecting a filter expression that is applied to the criterion for the column. The case sensitivity can also be specified via a check box. When the user presses the filter button, the grid displays only the records matching the filter criteria specified by using the filter boxes. 

>Only the values at the highest level of the hierarchy are included in the distinct filter list.

In order to filter __TreeListView__'s low level nodes directly through the distinct values listbox, you can manually set its __ItemsSource__. Just subscribe to the __DistinctValuesLoading__ event of __TreeListView__ and set the __e.ItemsSource__ to the collection you want to show.  

__Example 1: Setting the ItemsSource of the GridViewDistinctValuesLoadingEventArgs__
```C#

	private void radTreeListView_DistinctValuesLoading(object sender, GridView.GridViewDistinctValuesLoadingEventArgs e)
	{
	    e.ItemsSource = WarehouseService.GetNames();
	}
```

As the __RadTreeListView__ directly inherits the __RadGridView__ it uses its filtering mechanism. The __RadGridView__ allows you to implement programmatic filtering, custom filtering and more. To learn more read the [respective topics]({%slug gridview-filtering-basic%}) in the __RadGridView's__ documentation.

## Utilizing the AutoExpandItemsAfterFilter property

Since **R2 2018 SP1** you have the option to prevent the expanding of the RadTreeListView items after it is filtered. You can do that by setting the **AutoExpandItemsAfterFilter** property to **False**. The default value of the property is **True** which keeps the previous behavior of expanding all items after filtering.

__Example 2: Setting the AutoExpandItemsAfterFilter property__
```XAML
	 <telerik:RadTreeListView AutoExpandItemsAfterFilter="False" >
```

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Sorting]({%slug radtreelistview-features-sorting%})

 * [Selection]({%slug radtreelistview-features-selection%})
