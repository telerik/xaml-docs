---
title: Get aggregates from a group
page_title: Get aggregates from a group
description: Get started with the grouping functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to access the aggregates in a specific group.
slug: gridview-grouping-how-to-get-aggregates
tags: get,aggregates,from,a,group
published: True
position: 0
---

# Get aggregates from a group

This article shows how to obtain aggregates from a specific group in RadGridView.

In some cases when you define aggregates in RadGridView you need to access the ones in a specific group. You may do this very easily by iterating over the RadGridView groups, checking for a specific group key value and getting the aggregate result(s) as shown in __Example 1__.

__Example 1: Obtaining Group Aggregates__

```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    foreach (QueryableCollectionViewGroup item in this.radGridView.Items.Groups)
	    {
	        if (item.Key.Equals("24"))
	        {
	            MessageBox.Show(item.AggregateResults[0].FormattedValue.ToString());
	        }
	    }
	}
```
```VB.NET
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
	    For Each item As QueryableCollectionViewGroup In Me.radGridView.Items.Groups
	        If (item.Key.Equals("24")) Then
	            MessageBox.Show(item.AggregateResults(0).FormattedValue.ToString())
	        End If
	    Next
	End Sub
```

The [QueryableCollectionViewGroup](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.queryablecollectionviewgroup) class represents a wrapper over an __AggregateFunctionsGroup__ that allows for adding and removing of child items/groups. The snippet above simply checks for a key value equal to 24 and gets the formatted value of the first aggregate result.

## See Also

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})
