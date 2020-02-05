---
title: Create Data-Bound Chart
page_title: Create Data-Bound Chart
description: Check our &quot;Create Data-Bound Chart&quot; documentation article for the RadChartView WPF control.
slug: radchartview-series-databinding
tags: create,data-bound,chart
published: True
position: 0
---

# Create Data-Bound Chart

RadChartView supports data binding and manual population with data out of the box. The data binding feature is exposed by the different series and can be utilized by assigning a value to the __ItemsSource__ property of a series object. Each series has a collection of data points, that is, a data source which it displays according to the series type. For more information on chart series, please refer to our [Chart Series]({%slug radchartview-series-chartseries%}) topic. ItemsSource is of type IEnumerable and can therefore be bound to anything. If the data source is a collection of custom objects, users will have to provide a ValueBinding which will be used by the series to determine to which property the data points of the chart will be bound to.

* [AreaSeries Data Binding]({%slug radchartview-series-areaseries%}#data-binding)
* [RangeSeries Data Binding]({%slug radchartview-series-rangeseries%}#data-binding)
* [BarSeries Data Binding]({%slug radchartview-series-barseries%}#data-binding)
* [RangeBarSeries Series Data Binding]({%slug radchartview-series-barseries-rangebarseries%}#data-binding)
* [BubbleSeries Data Binding]({%slug radchartview-series-bubbleseries%}#data-binding)
* [OhlcSeries Data Binding]({%slug radchartview-series-ohlcseries%}#data-binding)
* [PointSeries Data Binding]({%slug radchartview-series-point%}#data-binding)
* [FunnelSeries Data Binding]({%slug radchartview-series-funnelchart-funnelseries%}#data-binding)
* [PieSeries Data Binding]({%slug radchartview-series-pieseries%}#data-binding)

If the data source consists of primitive numeric types (byte, short, int, float , double, decimal) the objects in the data source will be used directly as values for the data points.
Here are two examples of how to bind RadChartView to a data source of primitive types and to a data source of custom objects.

## Binding to primitive types

For any series object the data source can be set to an enumerable of primitive numerical types. In this case the data points' values will the values in the enumerable themselves. For example for any series object the following code binds it :

#### __[C#] Example 1: Binding BarSeries to primitive types__

{{region radchartview-series-databinding_0}}
	RadCartesianChart cartChart = new RadCartesianChart();
	cartChart.HorizontalAxis = new CategoricalAxis();
	cartChart.VerticalAxis = new LinearAxis();
	BarSeries barSeries = new BarSeries() { ShowLabels = true};
	cartChart.Series.Add(barSeries);
	barSeries.ItemsSource = new double[] { 20, 30, 50, 10, 60, 40, 20, 80 };
	this.LayoutRoot.Children.Add(cartChart);
{{endregion}}

#### __[VB.NET] Example 1: Binding BarSeries to primitive types__

{{region radchartview-series-databinding_1}}
	Dim cartChart As New RadCartesianChart()
	cartChart.HorizontalAxis = New CategoricalAxis()
	cartChart.VerticalAxis = New LinearAxis()
	Dim barSeries As New BarSeries() With {.ShowLabels = True}
	cartChart.Series.Add(barSeries)
	barSeries.ItemsSource = New Double() { 20, 30, 50, 10, 60, 40, 20, 80 }
	Me.LayoutRoot.Children.Add(cartChart)
{{endregion}}



## Binding to custom objects

Let's assume that we need to visualize how many products of certain types are sold for the last month. First we will create a product class and then we can bind a bar series to a collection of our products.


#### __[C#] Example 2: Creating Product class__

{{region radchartview-series-databinding_2}}
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

#### __[VB.NET] Example 2: Creating Product class__

{{region radchartview-series-databinding_3}}
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

#### __[C#] Example 3: Binding BarSeries in code behind__

{{region radchartview-series-databinding_4}}
	List<Product> dataSource = new List<Product>();
	dataSource.Add(new Product() { Name = "Product 1", QuantitySold = 5  });
	dataSource.Add(new Product() { Name = "Product 2", QuantitySold = 50  });
	dataSource.Add(new Product() { Name = "Product 3", QuantitySold = 8 });
	barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
	barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
	barSeries.ItemsSource = dataSource;
{{endregion}}

#### __[VB.NET] Example 3: Binding BarSeries to a custom collection__

{{region radchartview-series-databinding_5}}
	Dim dataSource As List(Of Product) = New List(Of Product)()
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

If a series is bound to an observable collection, the series will update as soon as a property of a data item changes. If we needed to track the selling of our products in real-time, we can simply put the product types in an observable collection and whenever we update a product's sold quantity, the chart will be updated. For example:


#### __[C#] Example 4: Binding BarSeries to ObservableCollection__

{{region radchartview-series-databinding_6}}
	ObservableCollection<Product> products = new ObservableCollection<Product>();
	// fill collection
	barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
	barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
	barSeries.ItemsSource = products;
{{endregion}}

#### __[VB.NET] Example 4: Binding BarSeries to ObservableCollection__

{{region radchartview-series-databinding_7}}
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

## Binding in XAML

The series in a chart can also be bound through XAML assuming the DataContext of our series is the data source. First we are going to create a ViewModel class which will hold our collection of Product. We will use the Product class define in the __Example 2__.

#### __[C#] Example 5: Creating ViewModel class__

{{region radchartview-series-databinding_8}}
	public class ViewModel
	{
		public ObservableCollection<Product> Data { get; set; }
		Random rnd = new Random();
		public ViewModel()
		{
			Data = new ObservableCollection<Product>();
			GetData();
		}
		private void GetData()
		{
			for (int i = 0; i < 10; i++)
			{
				Product product = new Product();
				product.Name = "Product " + i;
				product.QuantitySold = rnd.Next(10,99) ;
				Data.Add(product);
			}
		}
	}
{{endregion}}

#### __[VB.NET] Example 5: Creating ViewModel class__

{{region radchartview-series-databinding_9}}
	Public Class ViewModel
		Public Property Data As ObservableCollection(Of Product)
		Private rnd As Random = New Random()
		Public Sub New()
			Data = New ObservableCollection(Of Product)()
			GetData()
		End Sub
		Private Sub GetData()
			For i As Integer = 0 To 10 - 1
				Dim product As Product = New Product()
				product.Name = "Product " & i
				product.QuantitySold = rnd.[Next](10, 99)
				Data.Add(product)
			Next
		End Sub
	End Class
{{endregion}}

The next step is to set the DataContext of the MainWindow to our ViewModel class.

#### __[C#] Example 6: Specifying DataContext of the MainWindow__

{{region radchartview-series-databinding_10}}
	public MainWindow()
	{
	    InitializeComponent();
	    this.DataContext = new ViewModel();
	}
{{endregion}}

#### __[VB.NET] Example 6: Specifying DataContext of the MainWindow__

{{region radchartview-series-databinding_11}}
	Public Sub New()
		InitializeComponent()
		Me.DataContext = New ViewModel()
	End Sub
{{endregion}}

#### __[XAML] Example 7: Binding BarSeries in XAML__

{{region radchartview-series-databinding_12}}
	<telerik:RadCartesianChart x:Name="chart">

		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>

		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>

		<telerik:RadCartesianChart.Series>
			<telerik:BarSeries CategoryBinding="Name" ValueBinding="QuantitySold" ItemsSource="{Binding Data}"/>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
