---
title: Not all values are shown in the distinct values filter
page_title: Not all values are shown in the distinct values filter
description: Learn how to make all items in a filtering popup column visible in the distinct values filter when working with Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-not-all-values-shown-filtering
tags: not,all,values,are,shown,in,the,distinct,values,filter
published: False
position: 4
---

# Not all values are shown in the distinct values filter

__PROBLEM__

When you have a lot of data (thousands of items) and you open the built-in filtering popup of a column you will see that not all of the items are visible in the distinct values filter.

__CAUSE__

To improve performance RadGridView shows only the first 1000 items in the distinct values listbox. You can easily override that behavior by following the solution below.

__SOLUTION__

You can manually set the ItemsSource of the distinct values listbox. Just subscribe to the __DistinctValuesLoading__ event of RadGridView and set the __e.ItemsSource__ to the items you want to show. 

Here is a small example:



```C#
	private void radGridView_DistinctValuesLoading(object sender, GridViewDistinctValuesLoadingEventArgs e)
	{
	    if ((string)e.Column.Header == "Name")
	    {
	        e.ItemsSource = radGridView.GetDistinctValues(e.Column, true, radGridView.Items.Count);
	    }
	}
```

Now the listbox in the filtering control will be populated with all the 2000 items. 


