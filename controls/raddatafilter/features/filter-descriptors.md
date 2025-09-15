---
title: Filter Descriptors
page_title: Filter Descriptors
description: Check our &quot;Filter Descriptors&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: raddatafilter-features-filter-descriptors
tags: filter,descriptors
published: True
position: 2
---

# Filter Descriptors

The __RadDataFilter__ exposes a __FilterDescriptors__ collection, which contains the __FilterDescriptor__ objects which represent the user's filtering criteria, made via the UI. You can use this collection to either get the currently available __FilterDescriptor__ objects or to predefine the default filtering criteria. 

An example of the first scenario can be seen in the [Unbound Mode]({%slug raddatafilter-features-unbound-mode%}) topic, where the __FilterDescriptors__ collection of the __RadDataFilter__ gets synchronized with the __FilterDescriptors__ collection of the __RadGridView__.

If you want to predefine descriptors, you have to create the desired ones and add them to the FilterDescriptors collection after you set the __Source__ of the __RadDataFilter__.

>Changing the __Source__ of the __RadDataFilter__ will clear the __FilterDescriptors__ collection.

Here is an example of a predefined descriptor.

#### __XAML__

```XAML

	<telerik:RadDataFilter x:Name="radDataFilter" />
	```



#### __C#__

```C#

	this.radDataFilter.Source = SampleData.GetEmployees();
	this.radDataFilter.FilterDescriptors.Add( new FilterDescriptor( "Name", FilterOperator.Contains, "m" ) );
	```



#### __VB.NET__

```VB.NET

	Me.radDataFilter.Source = SampleData.GetEmployees()
	Me.radDataFilter.FilterDescriptors.Add(New FilterDescriptor("Name", FilterOperator.Contains, "m"))
	```



## See Also

 * [Getting Started]({%slug datafilter-getting-started%})

 * [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})

 * [Filter Editors]({%slug datafilter-editors%})
