---
title: Use generic SortDescriptor
page_title: Use generic SortDescriptor
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to create generic expression SortDescriptor.
slug: gridview-sorting-generic-descriptor
tags: use,generic,sortdescriptor
published: True
position: 1
---

# Use generic SortDescriptor

This help article will show you how to create generic expression SortDescriptor&lt;T&gt; for a databound __RadGridView__. 

> This article will use the viewmodel and model defined in __Examples 3 and 4__ in the [Getting Started]({%slug gridview-getting-started2%}) article. Before continuing, you should familiarize yourself with it.

## Generic SortDescriptor

The __RadGridView__ control allows for ordering the data items by the result of a complex calculation without having to expose it through a read-only property. All you need to do is to use a __SortDescriptor&lt;TElement, TKey=&gt;__. In order to demonstrate this, we will setup the RadGridView as demonstrated in __Example 1__.

__Example 1: Setting up the RadGridView__

<snippet id='radgridview-sorting-how-to-generic-descriptor-example_1_setting_up_the_radgridview-xaml' />


After that, when the button is clicked we will create a generic SortDescriptor and add it to the __SortDescriptors__ collection of the RadGridView. Note, that in __Example 2__ we are simply returning a property of the bound object, however we have the option of working with all of its properties in order to construct a SortingExpression. 

__Example 2: Create a generic SortDescriptor__

<snippet id='radgridview-sorting-how-to-generic-descriptor-example_2_create_a_generic_sortdescriptor-cs' />

        
> For more information you can check the [Sorting section]({%slug gridview-sorting-basics%}).
        
## See Also

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
