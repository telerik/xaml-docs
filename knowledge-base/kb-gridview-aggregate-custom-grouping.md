---
title: Apply Aggregate Functions When Using Generic Group Descriptors
description: This article showcases how to apply aggregate functions when using the generic group descriptors.
page_title: Set Aggregate Functions On Generic Group Descriptors
type: how-to
slug: kb-gridview-aggregate-custom-grouping
position: 0
tags: gridview, custom grouping, aggregate, function, groupdescriptor
ticketid: 1697759
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.3.815</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Apply aggregate functions when using the generic group descriptors.

## Solution

To apply aggregate functions when working with [generic group descriptors]({%slug gridview-grouping-generic-descriptor%}), you can define your function, and add it to its `AggregateFunctions` collection.

#### __[C#] Generic group descriptor with aggregate function__
{{region kb-gridview-aggregate-custom-grouping-0}}
    var descriptor = new GroupDescriptor<Employee, int, int> 
    { 
        GroupingExpression = e => e.Orders.Where(o => o.Details.Any(d => d.Product.ProductName.Contains("Syrup"))).Count(), 
        SortDirection = ListSortDirection.Ascending 
    };
    
    descriptor.AggregateFunctions.Add(new SumFunction(){ Caption = "Sum of syrups: ", SourceField = "Product" });
{{endregion}}