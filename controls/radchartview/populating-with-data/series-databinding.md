---
title: Create Data-Bound Chart
page_title: Create Data-Bound Chart
description: Create Data-Bound Chart
slug: radchartview-series-databinding
tags: create,data-bound,chart
published: True
position: 0
---

# Create Data-Bound Chart

__Populating RadChart with Data__


RadChartView supports data binding and manual population with data out of the box. The data binding feature is exposed by the different series and can be utilized by assigning a value to the __ItemsSource__ property of a series object.
Each series has a collection of data points, that is, a data source which it displays according to the series type. For more information on chart series, please refer to our [Chart Series]({%slug radchartview-series-chartseries%}) topic.
ItemsSource is of type IEnumerable and can therefore be bound to anything. If the data source is a collection of custom objects, users will have to provide a ValueBinding which will be used by the series to determine to which property the data points of the chart will be bound to.
If the data source consists of primitive numeric types (byte, short, int, float , double, decimal) the objects in the data source will be used directly as values for the data points.
Here are two examples of how to bind RadChartView to a data source of primitive types and to a data source of custom objects:


__Binding to primitive types__

For any series object the data source can be set to an enumerable of primitive numerical types.
In this case the data points' values will the values in the enumerable themselves. For example for any series object the following code binds it :

#### __C#__

{{region radchart-series-databinding_0}}
	RadCartesianChart cartChart = new RadCartesianChart();
	cartChart.HorizontalAxis = new CategoricalAxis();
	cartChart.VerticalAxis = new LinearAxis();
	BarSeries barSeries = new BarSeries() { ShowLabels = true};
	cartChart.Series.Add(barSeries);
	barSeries.ItemsSource = new double[] { 20, 30, 50, 10, 60, 40, 20, 80 };
	this.LayoutRoot.Children.Add(cartChart);
	{{endregion}}



#### __VB.NET__

{{region radchart-series-databinding_1}}
	Dim cartChart As New RadCartesianChart()
	cartChart.HorizontalAxis = New CategoricalAxis()
	cartChart.VerticalAxis = New LinearAxis()
	Dim barSeries As New BarSeries() With {.ShowLabels = True}
	cartChart.Series.Add(barSeries)
	barSeries.ItemsSource = New Double() { 20, 30, 50, 10, 60, 40, 20, 80 }
	Me.LayoutRoot.Children.Add(cartChart)
	{{endregion}}



__Binding to custom objects__

Let's assume that we need to visualize how many products of certain types are sold for the last month.
If we have a product class


#### __C#__

{{region radchart-series-databinding_2}}
	public class Product
	{
	    public string Name
	    {
	        get;
	        set;
	    }
	    public double QuantitySold
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-series-databinding_3}}
	Public Class Product
	    Private _name As String
	    Private _quantitySold As Double
	
	    Public Property Name As String
	        Get
	            Return Me._name
	        End Get
	        Set(value As String)
	            Me._name = value
	        End Set
	    End Property
	    Public Property QuantitySold As Double
	        Get
	            Return Me._quantitySold
	        End Get
	        Set(value As Double)
	            Me._quantitySold = value
	        End Set
	    End Property
	End Class
	{{endregion}}



we can bind a bar series object to a collection of our products like so:

#### __C#__

{{region radchart-series-databinding_4}}
	barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
	barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
	barSeries.ItemsSource = dataSouce;
	{{endregion}}



#### __VB.NET__

{{region radchart-series-databinding_5}}
	Dim nameBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
	nameBinding.PropertyName = "Name"
	Dim genericBinding As GenericDataPointBinding(Of Product, Double) = New GenericDataPointBinding(Of Product, Double)
	genericBinding.ValueSelector = Function(product) product.QuantitySold
	barSeries.CategoryBinding = nameBinding
	barSeries.ValueBinding = genericBinding
	barSeries.ItemsSource = dataSource
	{{endregion}}



The two binding classes, __ValueBinding__ and __CategoryBinding__ are set so that the series knows which property to bind to the value of a data point and which property to bind
to the category of a data point. RadChart supports two types of binding objects out of the box and these are __PropertyNameDataPointBinding__ and __GenericDataPointBinding__.
The two binding classes do the same thing but they have different performance characteristics. PropertyNameDataPointBinding uses reflection internally to lookup values which can be slow and is not recommended for real-time charts where the items in the data source are updated frequently. For static charts it is preferred because they are very easy to use.
Also if binding is done through XAML, the PropertyNameDataPointBinding is the only approach. GenericDataPointBinding on the other hand has to be setup through code and is a lot faster because the user typically knows which property needs to be bound to the category or the value of the data points and can do the binding with a simple variable assignment, avoiding the slower reflection based approach.

If a series is bound to an observable collection, the series will update as soon as a property of a data item changes.
If we needed to track the selling of our products in real-time, we can simply put the product types in an observable collection
and whenever we update a product's sold quantity, the chart will be updated. For example:


#### __C#__

{{region radchart-series-databinding_6}}
	ObservableCollection<Product> products = new ObservableCollection<Product>();
	// fill collection
	barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
	barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
	barSeries.ItemsSource = products;
	{{endregion}}

#### __VB.NET__

{{region radchart-series-databinding_7}}
	Dim products As ObservableCollection(Of Product) = New ObservableCollection(Of Product)
	' fill collection '
	Dim nameBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
	nameBinding.PropertyName = "Name"
	Dim genericBinding As GenericDataPointBinding(Of Product, Double) = New GenericDataPointBinding(Of Product, Double)
	genericBinding.ValueSelector = Function(product) product.QuantitySold
	barSeries.CategoryBinding = nameBinding
	barSeries.ValueBinding = genericBinding
	barSeries.ItemsSource = dataSource
	{{endregion}}
	
 The only requirement left for the code above to work is that our Product class needs to implement __INotifyPropertyChanged__ and raise the PropertyChanged event when its QuantitySold property changes.

__Binding in XAML__

The series in a chart can also be bound through XAML* assuming the DataContext of our series is the data source:
For example:

#### __C#__

{{region radchart-series-databinding_8}}
	public MainPage()
	{
	    InitializeComponent();
	    ChartSeries barSeries = this.chart.Series[0];
	    barSeries.DataContext = new double[] { 20, 30, 50, 10, 60, 40, 20, 80 };
	}
{{endregion}}

#### __VB.NET__

{{region radchart-series-databinding_9}}
	Dim dataSource(8) As Double
	dataSource(0) = 20
	dataSource(1) = 30
	dataSource(2) = 50
	dataSource(3) = 10
	dataSource(4) = 60
	dataSource(5) = 40
	dataSource(6) = 20
	dataSource(7) = 80
	Dim barSeries As ChartSeries = Me.chart.Series(0)
	barSeries.DataContext = dataSource
{{endregion}}

#### __XAML__

{{region radchart-series-databinding_10}}
	<telerik:RadCartesianChart x:Name="chart">
	   <telerik:RadCartesianChart.HorizontalAxis>
	      <telerik:CategoricalAxis/>
	   </telerik:RadCartesianChart.HorizontalAxis>
	
	   <telerik:RadCartesianChart.VerticalAxis>
	      <telerik:LinearAxis/>
	   </telerik:RadCartesianChart.VerticalAxis>
	
	   <telerik:RadCartesianChart.Series>
	      <telerik:BarSeries CategoryBinding="Name"
	                       ValueBinding="QuantitySold"
	                       ItemsSource="{Binding}">
	         <telerik:BarSeries.PointTemplates>
	            <DataTemplate>
	               <Rectangle Fill="{StaticResource PhoneForegroundBrush}"/>
	            </DataTemplate>
	         </telerik:BarSeries.PointTemplates>
	      </telerik:BarSeries>
	   </telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}