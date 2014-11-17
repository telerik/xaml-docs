---
title: Use generic SortDescriptor
page_title: Use generic SortDescriptor
description: Use generic SortDescriptor
slug: gridview-sorting-generic-descriptor
tags: use,generic,sortdescriptor
published: True
position: 1
---

# Use generic SortDescriptor

This help article will show you how to create generic expression SortDescriptor<T> for __RadGridView__.

## Generic SortDescriptor

You can order your data items by the result of a complex calculation without having to expose it through a read-only property. All you need to do is to use the new __SortDescriptor<TElement, TKey="">__:
       
__Example 1: Create a generic SortDescriptor<T>.__

#### __C#__

{{region gridview-howto-use-expression-descriptors_0}}

	var descriptor = new SortDescriptor<Employee, double>
	{
	    SortingExpression = e => e.Orders.SelectMany(o => o.Details).Sum(d => d.UnitPrice * d.Quantity),
	    SortDirection = ListSortDirection.Descending
	};
{{endregion}}

Then, you should add the defined SortDescriptor to the __SortDescriptors collection__ of __RadGridView__.
        
For more information you can check the [Sorting section]({%slug gridview-sorting-basics%}).
        
# See Also

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
