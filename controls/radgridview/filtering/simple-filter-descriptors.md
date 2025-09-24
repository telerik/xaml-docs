---
title: Simple Filter Descriptors
page_title: Simple Filter Descriptors
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to create and combine simple filter descriptors.
slug: radgridview-filtering-simple-filter-descriptors
tags: simple,filter,descriptors
published: False
position: 2
---

# Simple Filter Descriptors

>Note that when programmatically filtering the __RadGridView__ via the __FilterDescriptor__ class, the UI filtering mechanism won't be affected. This means that the UI filtering will be applied only to the already filtered data, not to the entire data source of the __RadGridView__. In order to combine the both of them, you have to use __IColumnFilterDescriptor__ instead of __FilterDescriptor__ or __CompositeFilterDescritpor__. Learn more by reading [this article]({%slug radgridview-filtering-icolumn-filter-descriptors%}).

And now you can create a descriptor:



```XAML
	<telerik:FilterDescriptor Member="Country"
	              Operator="IsEqualTo"
	              Value="Germany"
	              IsCaseSensitive="True" />
```



```C#
	FilterDescriptor descriptor = new FilterDescriptor();
	descriptor.Member = "Country";
	descriptor.Operator = FilterOperator.IsEqualTo;
	descriptor.Value = "Germany";
	descriptor.IsCaseSensitive = true;
```



```VB.NET
	Dim descriptor As New FilterDescriptor()
	descriptor.Member = "Country"
	descriptor.Operator = FilterOperator.IsEqualTo
	descriptor.Value = "Germany"
	descriptor.IsCaseSensitive = True
```

* The __Member__ property defines the property, which values will be filtered.

* Comparison_OperatorsThe __Operator__ property allows you to define the type of operator. The possible values are: __Contains, EndsWith, IsContainedIn, IsEqualTo, IsGreaterThan, IsGreaterThanOrEqualTo, IsLessThan, IsLessThanOrEqualTo, IsNotEqualTo__ and __StartsWith__.

* The __Value__ property is the value your data will be compared against.

* The __IsCaseSensitive__ property allow you to implement __"Match Case"__ functionality. When set to __True__ the filter will match the case. False is the default value.

To use the created descriptor to filter the data in the __RadGridView__ you have to add it to the __FilterDescriptors__ collection. You can declare as many filter descriptors as needed.



```XAML
	<telerik:RadGridView x:Name="radGridView">
	    <telerik:RadGridView.FilterDescriptors>
	        <telerik:FilterDescriptor Member="Country"
	                              Operator="IsEqualTo"
	                              Value="Germany"
	                              IsCaseSensitive="True" />
	    </telerik:RadGridView.FilterDescriptors>
	</telerik:RadGridView>
```

When you add a new descriptor to the collection, the data is automatically filtered according to it.



```C#
	this.radGridView.FilterDescriptors.Add(descriptor);
```



```VB.NET
	Me.radGridView.FilterDescriptors.Add(descriptor)
```

After running the application with this descriptor defined, the __RadGridView__ data will be filtered by the Country column and the result will be the same as if you have clicked on the filter icon in the Country column header and have selected "Germany" as filtering value. 

>Adding or removing descriptors from the __FilterDescriptors__ collection won't raise the __Filtering__ and __Filtered__ events, although the data will be filtered.

>The built-in filtering also uses the __FilterDescriptors__ collection. When a header filter icon is clicked and new filter is defined, it is added to the __FilterDescriptors__ collection.

>tipIn case of a static data structure, known during design time, it is better to declare your default filtering in the XAML, rather than in your code-behind.

## See Also

 * [Basic Filtering]({%slug gridview-basic-filtering2%})

 * [Composite Filter Descriptors]({%slug radgridview-filtering-composite-filter-descriptors%})

 * [Column Filter Descriptors]({%slug radgridview-filtering-icolumn-filter-descriptors%})
