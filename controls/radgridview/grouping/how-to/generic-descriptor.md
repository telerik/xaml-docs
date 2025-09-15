---
title: Use generic GroupDescriptor
page_title: Use Generic GroupDescriptor
description: Get started with the grouping functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to create generic expression GroupDescriptors. 
slug: gridview-grouping-generic-descriptor
tags: use,generic,groupdescriptor
published: True
position: 2
---

# Use Generic GroupDescriptor

This help article will show you how to create generic expression GroupDescriptors<T> for __RadGridView__.
## Generic GroupDescriptor

You can also group objects by the result of an equally complex operation:

__Example 1: Create a generic GroupDescriptor<T>.__

#### __C#__

```C#
	var descriptor = new GroupDescriptor<Employee, int, int>
	{
	    GroupingExpression = e => e.Orders.Where(o => o.Details.Any(d => d.Product.ProductName.Contains("Syrup"))).Count(),
	    SortDirection = ListSortDirection.Ascending
	};
```

Then, add the defined GroupDescriptor to the __GroupDescriptors collection__ of __RadGridView__.
        
For more information you can check the [Grouping section]({%slug gridview-grouping-basics%}).
    
## See Also

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
