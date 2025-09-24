---
title: Use generic FilterDescriptor
page_title: Use generic FilterDescriptor
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to use generic FilterDescriptor.
slug: gridview-filtering-generic-descriptor
tags: use,generic,filterdescriptor
published: True
position: 23
---

# Use generic FilterDescriptor

This help article will show you how to create generic expression FilterDescriptors<T> for __RadGridView__.
  
## Generic FilterDescriptor

The new FilterDescriptor<T> allows you to directly plug a predicate that determines which items are filtered. You just need to set a lambda to the FilteringExpression property like so:
        

__Example 3: Create a generic FilterDescriptor<T>.__



```C#
	var descriptor = new FilterDescriptor<Employee> { FilteringExpression = e => prospects.Contains(e) };
```


Then, you should add the defined FilterDescriptor to the __FilterDescriptors collection__ of __RadGridView__.
        

For more information you can check the [Filtering section]({%slug gridview-filtering-basic%})

## See Also

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
