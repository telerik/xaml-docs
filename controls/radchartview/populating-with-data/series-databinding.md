---
title: Create Data-Bound Chart
page_title: Create Data-Bound Chart
description: Check our &quot;Create Data-Bound Chart&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-databinding
tags: create,data-bound,chart
published: True
position: 0
---

# Create Data-Bound Chart

RadChartView supports data binding and manual population with data out of the box. The data binding feature is exposed by the different series and can be utilized by assigning a value to the __ItemsSource__ property of a series object. Each series has a collection of data points, that is, a data source which it displays according to the series type. For more information on chart series, please refer to our [Chart Series]({%slug radchartview-series-chartseries%}) topic. ItemsSource is of type IEnumerable and can therefore be bound to anything. If the data source is a collection of custom objects, users will have to provide a ValueBinding which will be used by the series to determine to which property the data points of the chart will be bound to.

If the data source consists of primitive numeric types (byte, short, int, float , double, decimal) the objects in the data source will be used directly as values for the data points.
Here are two examples of how to bind RadChartView to a data source of primitive types and to a data source of custom objects.

The following examples will demonstrate how to bind the [BarSeries]({%slug radchartview-series-barseries%}) of the chart.

> The DataPoints collection property of the series will be populated when their ItemsSource is used.

## Binding in XAML

The series in a chart can be bound through XAML assuming the DataContext of our series is the data source. First we are going to create a ViewModel class which will hold our collection of Product. We will use the Product class define in the __Example 1__.

__Example 1: Creating ViewModel class__

<snippet id='radchartview-populating-with-data-series-databinding-example_1_creating_viewmodel_class-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_1_creating_viewmodel_class-vb' />


The next step is to set the DataContext of the MainWindow to our ViewModel class.

__Example 2: Specifying DataContext of the MainWindow__

<snippet id='radchartview-populating-with-data-series-databinding-example_2_specifying_datacontext_of_the_mainwindow-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_2_specifying_datacontext_of_the_mainwindow-vb' />


__Example 3: Binding BarSeries in XAML__
<snippet id='radchartview-populating-with-data-series-databinding-example_3_binding_barseries_in_xaml-xaml' />


#### Figure 1: Binding BarSeries in XAML 

![Binding BarSeries in XAML](images/series-databinding_1.png)

## Binding BarSeries to primitive types

For any series object the data source can be set to an enumerable of primitive numerical types. In this case the data points' values will the values in the enumerable themselves. For example for any series object the following code binds it:

__Example 3: Binding BarSeries in XAML__
<snippet id='radchartview-populating-with-data-series-databinding-example_3_binding_barseries_in_xaml-xaml' />



__Example 4: Binding BarSeries to primitive types__
<snippet id='radchartview-populating-with-data-series-databinding-example_4_binding_barseries_to_primitive_types-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_4_binding_barseries_to_primitive_types-vb' />


#### Figure 2: Binding BarSeries to primitive types
![Binding BarSeries to primitive types](images/series-databinding_2.png)

## Binding BarSeries in code behind

Let's assume that we need to visualize how many products of certain types are sold for the last month. First we will create a product class and then we can bind a bar series to a collection of our products.

__Example 5: Creating Product class__

<snippet id='radchartview-populating-with-data-series-databinding-example_5_creating_product_class-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_5_creating_product_class-vb' />


__Example 6: Binding BarSeries in code behind__

<snippet id='radchartview-populating-with-data-series-databinding-example_6_binding_barseries_in_code_behind-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_6_binding_barseries_in_code_behind-vb' />


The two binding classes, __ValueBinding__ and __CategoryBinding__ are set so that the series knows which property to bind to the value of a data point and which property to bind
to the category of a data point. RadChart supports two types of binding objects out of the box and these are __PropertyNameDataPointBinding__ and __GenericDataPointBinding__.
The two binding classes do the same thing but they have different performance characteristics. PropertyNameDataPointBinding uses reflection internally to lookup values which can be slow and is not recommended for real-time charts where the items in the data source are updated frequently. For static charts it is preferred because they are very easy to use.
Also if binding is done through XAML, the PropertyNameDataPointBinding is the only approach. GenericDataPointBinding on the other hand has to be setup through code and is a lot faster because the user typically knows which property needs to be bound to the category or the value of the data points and can do the binding with a simple variable assignment, avoiding the slower reflection based approach.

If a series is bound to an observable collection, the series will update as soon as a property of a data item changes. If we needed to track the selling of our products in real-time, we can simply put the product types in an observable collection and whenever we update a product's sold quantity, the chart will be updated. For example:


__Example 7: Binding BarSeries to ObservableCollection__

<snippet id='radchartview-populating-with-data-series-databinding-example_7_binding_barseries_to_observablecollection-cs' />

<snippet id='radchartview-populating-with-data-series-databinding-example_7_binding_barseries_to_observablecollection-vb' />

	
The only requirement left for the code above to work is that our Product class needs to implement __INotifyPropertyChanged__ and raise the PropertyChanged event when its QuantitySold property changes. In __Example 8__ we will inherit ViewModelBase class which implement __INotifyPropertyChanged__ interface.

__Example 8: Creating Product class__
<snippet id='radchartview-populating-with-data-series-databinding-example_8_creating_product_class-cs' />



## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
