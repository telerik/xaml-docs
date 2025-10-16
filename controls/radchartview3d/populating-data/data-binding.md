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
```C#
	chartSeries3D.XValueBinding = new PropertyNameDataPointBinding("MyXValue");
```

__Example 2: Setting PropertyNameDataPointBinding in XAML__
```XAML
	<telerik:BarSeries3D XValueBinding="MyXValue"/>
```

The __GenericDataPointBinding&lt;TElement, TResult&gt;__ expects a function that selects a value from the business object. Then it sets this value to the corresponding property of the data point model. This type of binding can be used only in code. 

__Example 3: Using GenericDataPointBinding__
```C#
	chartSeries3D.XValueBinding = new GenericDataPointBinding<MyBusinessObject, double>()
	{
		ValueSelector = x => x.MyXValue
	};
```
	
In summary, to bind data to a 3D chart series, you will need to set 4 properties - __YValueBinding, XValueBinding, ZValueBinding and ItemsSource__.

__Example 4: Setting binding properties in XAML__
```XAML
	<telerik:BarSeries3D XValueBinding="MyXValue" 
                         YValueBinding="MyYValue" 
                         ZValueBinding="MyZValue" 
                         ItemsSource="{Binding MyBusinessObjects}"/>
```

## Complete Example

This section contains a complete data binding example.

__Step 1: Create the business object for the data point__
```C#
	public class MyBusinessObject
	{
		public double XValue { get; set; }
		public string YValue { get; set; }
		public double ZValue { get; set; }
	}
```

__Step 2: Set up the chart in XAML__
```XAML
	<telerik:RadCartesianChart3D x:Name="chart">
		<telerik:RadCartesianChart3D.XAxis>
			<telerik:LinearAxis3D />
		</telerik:RadCartesianChart3D.XAxis>
		<telerik:RadCartesianChart3D.YAxis>
			<telerik:CategoricalAxis3D />
		</telerik:RadCartesianChart3D.YAxis>
		<telerik:RadCartesianChart3D.ZAxis>
			<telerik:LinearAxis3D />
		</telerik:RadCartesianChart3D.ZAxis>
		<telerik:RadCartesianChart3D.Grid>
			<telerik:CartesianChart3DGrid />
		</telerik:RadCartesianChart3D.Grid>
		
		<telerik:RadCartesianChart3D.Series>                
			<telerik:BarSeries3D XValueBinding="XValue" 
								 YValueBinding="YValue" 
								 ZValueBinding="ZValue" 
								 ItemsSource="{Binding}"/>
		</telerik:RadCartesianChart3D.Series>
	</telerik:RadCartesianChart3D>
```

__Step 3: Create a new collection and assing it to the DataContext of the chart__
```C#
	var source = new ObservableCollection<MyBusinessObject>();
	source.Add(new MyBusinessObject() { XValue = 1, YValue = "C1", ZValue = 33 });
	source.Add(new MyBusinessObject() { XValue = 2.23, YValue = "C2", ZValue = 44 });
	source.Add(new MyBusinessObject() { XValue = 3, YValue = "C3", ZValue = 40 });
	source.Add(new MyBusinessObject() { XValue = 4, YValue = "C4", ZValue = 33 });
	source.Add(new MyBusinessObject() { XValue = 4.5, YValue = "C2", ZValue = 23 });

	chart.DataContext = source;
```
	
#### __Figure 1: Data bound BarSeris3D__
![{{ site.framework_name }} RadChartView3D Data bound BarSeris3D](images/radchartview3d-populating-data-databinding-0.png)
	
## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Sampling]({%slug radchartview3d-populating-data-sampling%})
* [Chart Grid]({%slug radchartview3d-chartgrid%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
