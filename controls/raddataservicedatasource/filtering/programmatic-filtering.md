---
title: Programmatic Filtering
page_title: Programmatic Filtering
description: Programmatic Filtering
slug: raddataservicedatasource-filtering-programmatic-filtering
tags: programmatic,filtering
published: True
position: 0
---

# Programmatic Filtering



## 

Programmatic filtering is performed by adding a FilterDescriptor object to the FilterDescriptors collection of the control. 

For example: 

#### __C#__

{{region raddataservicedatasource-filtering-programmatic-filtering_0}}
	FilterDescriptor fd = new FilterDescriptor("PostalCode", FilterOperator.IsEqualTo, 1010);
	this.radDataServiceDataSource.FilterDescriptors.Add(fd);
	{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-filtering-programmatic-filtering_1}}
	Dim fd As New FilterDescriptor("PostalCode", FilterOperator.IsEqualTo, 1010)
	Me.radDataServiceDataSource.FilterDescriptors.Add(fd)
	{{endregion}}



On running the application, the following grid will be displayed:




         
      ![](images/RadDataServiceDataSource_ProgrammaticFiltering2.png)



You can build infinitely nested hierarchies of filters by using the CompositeFilterDescriptor class. The following code will return all people that were born in the 1980’s, but you could easily replace f1 or f2 with another composite filter to achieve logical nesting:

#### __C#__

{{region raddataservicedatasource-filtering-programmatic-filtering_2}}
	CompositeFilterDescriptor cfd = new CompositeFilterDescriptor();
	cfd.LogicalOperator = FilterCompositionLogicalOperator.Or;
	FilterDescriptor f1 = new FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin");
	cfd.FilterDescriptors.Add(f1);
	FilterDescriptor f2 = new FilterDescriptor("City", FilterOperator.IsEqualTo, "Madrid);
	cfd.FilterDescriptors.Add(f2);
	this.radDataServiceDataSource.FilterDescriptors.Add(cfd);
	{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-filtering-programmatic-filtering_3}}
	Dim cfd As New CompositeFilterDescriptor()
	cfd.LogicalOperator = FilterCompositionLogicalOperator.[Or]
	Dim f1 As New FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin")
	cfd.FilterDescriptors.Add(f1)
	Dim f2 As New FilterDescriptor("City", FilterOperator.IsEqualTo, "Madrid")
	cfd.FilterDescriptors.Add(f2)
	Me.radDataServiceDataSource.FilterDescriptors.Add(cfd)
	{{endregion}}



Once the application is loaded, you will see the prefiltered grid: 




         
      ![](images/RadDataServiceDataSource_ProgrammaticFiltering.png)
