---
title: Use expression descriptors
page_title: Use Expression Descriptors
description: Learn how to create generic expression descriptors (SortDescriptor, GroupDescriptors and FilterDescriptors) for RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-howto-use-expression-descriptors
tags: use,expression,descriptors
published: True
position: 15
---

# Use Expression Descriptors

This help article will show you how to create generic expression descriptors (SortDescriptor<T>, GroupDescriptors<T> and FilterDescriptors<T>) for __RadGridView__.

## Sorting

You can order your data items by the result of a complex calculation without having to expose it through a read-only property. All you need to do is to use the new __SortDescriptor<TElement, TKey="">__:
        

__Example 1: Create a generic SortDescriptor<T>.__



```C#
	var descriptor = new SortDescriptor<Employee, double>
	{
	    SortingExpression = e => e.Orders.SelectMany(o => o.Details).Sum(d => d.UnitPrice * d.Quantity),
	    SortDirection = ListSortDirection.Descending
	};
```

Then, you should add the defined SortDescriptor to the __SortDescriptors collection__ of __RadGridView__.

For more information you can check the [Sorting section]({%slug gridview-sorting-basics%})

## Grouping

You can also group objects by the result of an equally complex operation:

__Example 2: Create a generic GroupDescriptor<T>.__



```C#
	var descriptor = new GroupDescriptor<Employee, int, int>
	{
	    GroupingExpression = e => e.Orders.Where(o => o.Details.Any(d => d.Product.ProductName.Contains("Syrup"))).Count(),
	    SortDirection = ListSortDirection.Ascending
	};
```

Then, add the defined GroupDescriptor to the __GroupDescriptors collection__ of __RadGridView__.
        

For more information you can check the [Grouping section]({%slug gridview-grouping-basics%})

## Filtering

The new FilterDescriptor<T> allows you to directly plug a predicate that determines which items are filtered. You just need to set a lambda to the FilteringExpression property like so:

__Example 3: Create a generic FilterDescriptor<T>.__



```C#
	var descriptor = new FilterDescriptor<Employee> { FilteringExpression = e => prospects.Contains(e) };
```

Then, you should add the defined FilterDescriptor to the __FilterDescriptors collection__ of __RadGridView__.

For more information you can check the [Filtering section]({%slug gridview-filtering-basic%})
