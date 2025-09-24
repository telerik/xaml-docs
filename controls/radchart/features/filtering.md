---
title: Filtering
page_title: Filtering
description: Check our &quot;Filtering&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-filtering
tags: filtering
published: True
position: 26
---

# Filtering



## 

>This feature is available in data bound scenarios only!

The __RadChart__ allows you to programmatically filter its data. This is achieved via the __FilterDescriptors__ property of the __RadChart__ or the __FilterDescriptors__ property of the __SeriesMapping__. This collection allows you to use descriptors which define the sorting member and the sorting direction for the data to which the __RadChart__ is bound. As this is a collection you are able not only to add, but also to remove or clear the entries in it, too.

The items in this collection are of type __ChartFilterDescriptor__. It exposes a few important properties:

* __Member__ - defines the field of the data object, by which the data will be filtered.

* __Operator__-  defines the operator, which will be applied to the filtering criteria.

* __Value__ - defines the value that will be compared with the value of the __Member__ property via the __Operator__ property.

Here is an example of a chart without filter descriptors.

![{{ site.framework_name }} RadChart without Filter Descriptors](images/RadChart_Features_Filtering_01.png)

Here is an example of implementing filtering.

>tipTo use the __ChartFilterDescriptors__ in XAML you have to declare the following namespace:



```XAML
	<!--  xmlns:telerikCharting="clr-namespace:Telerik.Windows.Controls.Charting;assembly=Telerik.Windows.Controls.Charting"  -->
```





```XAML
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.FilterDescriptors>
	        <telerik:ChartFilterDescriptor Member="Quantity"
	                                       Operator="IsLessThanOrEqualTo"
	                                       Value="150" />
	    </telerik:RadChart.FilterDescriptors>
	</telerik:RadChart>
```





```C#
	ChartFilterDescriptor descriptor = new ChartFilterDescriptor();
	descriptor.Member = "Quantity";
	descriptor.Operator = FilterOperator.IsLessThanOrEqualTo;
	descriptor.Value = 150;
	this.radChart.FilterDescriptors.Add(descriptor);
```





```VB.NET
	Dim descriptor As New ChartFilterDescriptor()
	descriptor.Member = "Quantity"
	descriptor.[Operator] = FilterOperator.IsLessThanOrEqualTo
	descriptor.Value = 150
	Me.radChart.FilterDescriptors.Add(descriptor)
```
    
Here is a snapshot of the result.
    ![{{ site.framework_name }} RadChart with Filtered Data](images/RadChart_Features_Filtering_02.png)
