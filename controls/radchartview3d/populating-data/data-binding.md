---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadChartView3D {{ site.framework_name }} control.
slug: radchartview3d-populating-data-databinding
tags: axes,3d,chartview,data,binding,itemssource,valuebinding,
published: True
position: 3
---

# Data Binding

This article explains how to bind a 3D chart series to a collection of business objects. To data bound the series you can use its __ItemsSource__ property. The property is of type __IEnumerable__ so you can use most collection types. 

The chart creates a __DataPoint3D__ model for each business object in the ItemsSource collection. To map the properties of the business object to the DataPoint3D you can use the series value binding properties.

* __XValueBinding__: The binding that will be used to fill the data point model XValue property.
* __YValueBinding__: The binding that will be used to fill the data point model YValue property.
* __ZValueBinding__: The binding that will be used to fill the data point model ZValue property.

The properties are of type __DataPointBinding__ which is an abstract class that has two implementations - __PropertyNameDataPointBinding__ and __GenericDataPointBinding__.

The __PropertyNameDataPointBinding__ expect a path (name) to a property in the business object of the data point. The binding class  obtains the property using reflection, gets the corresponding value and assigns it to the data point model. This type of binding is used when you set the value binding properties in XAML.

__Example 1: Using PropertyNameDataPointBinding__
<snippet id='radchartview3d-populating-data-data-binding-example_1_using_propertynamedatapointbinding-cs' />


__Example 2: Setting PropertyNameDataPointBinding in XAML__
<snippet id='radchartview3d-populating-data-data-binding-example_2_setting_propertynamedatapointbinding_in_xaml-xaml' />


The __GenericDataPointBinding&lt;TElement, TResult&gt;__ expects a function that selects a value from the business object. Then it sets this value to the corresponding property of the data point model. This type of binding can be used only in code. 

__Example 3: Using GenericDataPointBinding__
<snippet id='radchartview3d-populating-data-data-binding-example_3_using_genericdatapointbinding-cs' />

	
In summary, to bind data to a 3D chart series, you will need to set 4 properties - __YValueBinding, XValueBinding, ZValueBinding and ItemsSource__.

__Example 4: Setting binding properties in XAML__
<snippet id='radchartview3d-populating-data-data-binding-example_4_setting_binding_properties_in_xaml-xaml' />


## Complete Example

This section contains a complete data binding example.

__Step 1: Create the business object for the data point__
<snippet id='radchartview3d-populating-data-data-binding-step_1_create_the_business_object_for_the_data_point-cs' />


__Step 2: Set up the chart in XAML__
<snippet id='radchartview3d-populating-data-data-binding-step_2_set_up_the_chart_in_xaml-xaml' />


__Step 3: Create a new collection and assing it to the DataContext of the chart__
<snippet id='radchartview3d-populating-data-data-binding-step_3_create_a_new_collection_and_assing_it_to_the_datacontext_of_the_chart-cs' />

	
#### __Figure 1: Data bound BarSeris3D__
![{{ site.framework_name }} RadChartView3D Data bound BarSeris3D](images/radchartview3d-populating-data-databinding-0.png)
	
## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Sampling]({%slug radchartview3d-populating-data-sampling%})
* [Chart Grid]({%slug radchartview3d-chartgrid%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
