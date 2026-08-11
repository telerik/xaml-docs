---
title: Programmatic Sorting
page_title: Programmatic Sorting
description: Check our &quot;Programmatic Sorting&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-sorting-programmatic-sorting
tags: programmatic,sorting
published: True
position: 0
---

# Programmatic Sorting

Programmatic sorting is performed by adding a __SortDescriptor__ object to the __SortDescriptors__ collection of the control. 

For example: 



<snippet id='raddataservicedatasource-sorting-programmatic-sorting-block_1-cs' />

<snippet id='raddataservicedatasource-sorting-programmatic-sorting-block_1-vb' />


Once the application is loaded, the __RadGridView__ will be visualized as follows:
![{{ site.framework_name }} RadDataServiceDataSource Programmatic Sorting](images/RadDataServiceDataSource_ProgrammaticSorting.png)

>caution Adding several __SortDescriptors__ to the collection will perform the sorting in the respective order.