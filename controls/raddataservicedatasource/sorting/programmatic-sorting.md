---
title: Programmatic Sorting
page_title: Programmatic Sorting
description: Check our &quot;Programmatic Sorting&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-sorting-programmatic-sorting
tags: programmatic,sorting
published: True
position: 0
---

# {{ site.framework_name }} RadDataServiceDataSource Programmatic Sorting

Programmatic sorting is performed by adding a __SortDescriptor__ object to the __SortDescriptors__ collection of the control. 

For example: 

#### __C#__

{{region raddataservicedatasource-sorting-programmatic-sorting_0}}

	SortDescriptor sd = new SortDescriptor();
	sd.Member = "ContactTitle";
	sd.SortDirection = ListSortDirection.Descending;
	this.customersDataSource.SortDescriptors.Add(sd);
{{endregion}}

#### __VB.NET__

{{region raddataservicedatasource-sorting-programmatic-sorting_1}}

	Dim sd As New SortDescriptor()
	sd.Member = "ContactTitle"
	sd.SortDirection = ListSortDirection.Descending
	Me.customersDataSource.SortDescriptors.Add(sd)
{{endregion}}

Once the application is loaded, the __RadGridView__ will be visualized as follows:
![{{ site.framework_name }} RadDataServiceDataSource Programmatic Sorting](images/RadDataServiceDataSource_ProgrammaticSorting.png)

>caution Adding several __SortDescriptors__ to the collection will perform the sorting in the respective order.