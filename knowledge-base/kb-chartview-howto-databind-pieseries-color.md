---
title: How To Data Bind PieSeries Color
description: How to data bind a model property to a PieSeries slice color.
type: how-to
page_title: How To Data Bind PieSeries Color
slug: kb-chartview-databind-pieseries-color
position: 0
tags: ChartView, PieSeries, Data binding, Styling, MVVM
ticketid: 1397704
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadChartView for WPF</td>
	</tr>
</table>

## Description

How to data bind a model property to a `PieSeries` or `DoughnutSeries` slice color.

## Solution

You can use the Series **DefaultSliceStyle** and bind the data item's `Brush` property directly to the **Fill** property of the `Path` (*see Example 1*). If the data item does not have a `Brush` property, you can use an `IValueConverter` that returns a `Brush` object (*see Example 2*).

>important When using this approach, make sure that the chart's **Palette** is not explicitly set. The `ChartPalette` value takes precedence over the **DefaultSliceStyle** and will ignore the bound value.

### Example 1 - Explicitly Setting Color

1. Define the Data Model

	
	```C#
		public class MyModel
		{
		    public string Title { get; set; }

		    public double Amount { get; set; }

		    public Brush SliceColor { get; set; }
		}
	```

	> The **SliceColor** property is of type `Brush`. This is what will be used to bind to the **Fill** property of the `Path` element in the style.*

2. Create the data items in the View Model

	
	```C#
		public class ViewModel : ViewModelBase
		{
		    public ViewModel() { }

		    public ObservableCollection<MyModel> PieData { get; set; } = new ObservableCollection<MyModel>
		    {
			new MyModel { Title = "One", Amount = 70, SliceColor = new SolidColorBrush(Colors.LightBlue) },
			new MyModel { Title = "Two", Amount = 20, SliceColor = new SolidColorBrush(Colors.LightSalmon) },
			new MyModel { Title = "Three", Amount = 10, SliceColor = new SolidColorBrush(Colors.LightCoral) },
		    };
		}
	```

	> Note that each item has an explicit **SliceColor** value.*

3. Define the **DefaultSliceStyle** and bind the **SliceColor** property of the slice's **DataContext** to the **Fill** property of the `Style`.

	
	```C#
		<telerik:RadPieChart x:Name="chartView">
		    <telerik:PieSeries ItemsSource="{Binding PieData}" ValueBinding="Amount" ShowLabels="False">
			<telerik:PieSeries.DefaultSliceStyle>
			    <Style TargetType="Path">
				<Setter Property="Fill" Value="{Binding DataItem.SliceColor}" />
			    </Style>
			</telerik:PieSeries.DefaultSliceStyle>
		    </telerik:PieSeries>
		</telerik:RadPieChart>
	```

	> The **DataContext** of the `Path` is of type `Telerik.Charting.PieDataPoint`. The instance of `MyModel` is accessed through the `PieDataPoint` **DataItem** property.*

#### Example 2 - Dynamically Setting Color

If the data model does not have a `Brush` property that can be directly bound to `Path` **Fill**, you can use an `IValueConverter` to return a `Brush` value that can use used to set the **Fill** value. 

1. Use the code from Example 1 to get started, then take the following additional steps.

2. Add a class that implements `IValueConverter` and returns an instance of `Brush`.

	
	```C#
		public class PieDataPointToBrushConverter : IValueConverter
		{
		    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		    {
			if (value is MyModel data)
			{
			    if (data.Amount <= 10)
			    {
				return new SolidColorBrush(Colors.Green);
			    }
			    else if (data.Amount <= 20)
			    {
				return new SolidColorBrush(Colors.Goldenrod);
			    }
			    else
			    {
				return new SolidColorBrush(Colors.DarkRed);
			    }
			}

			return value;
		    }

		    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		    {
			throw new NotImplementedException();
		    }
		}
	```

3. Add an instance of the Converter to the **Resources** of the `RadPieChart`

	
	```XAML
		<telerik:RadPieChart x:Name="chartView">
		    <telerik:RadPieChart.Resources>
			<local:PieDataPointToBrushConverter x:Key="MyBrushConverter"/>
		    </telerik:RadPieChart.Resources>
		    ...
		</telerik:RadPieChart>
	```

4. Use the converter on the **DefaultSliceStyle** binding

	
	```XAML
		<telerik:RadPieChart x:Name="chartView">
		    <telerik:RadPieChart.Resources>
			<local:PieDataPointToBrushConverter x:Key="MyBrushConverter"/>
		    </telerik:RadPieChart.Resources>
		    <telerik:PieSeries ItemsSource="{Binding PieData}" ValueBinding="Amount" ShowLabels="False">
			<telerik:PieSeries.DefaultSliceStyle>
			    <Style TargetType="Path">
				<Setter Property="Fill" Value="{Binding DataItem, Converter={StaticResource MyBrushConverter}}" />
			    </Style>
			</telerik:PieSeries.DefaultSliceStyle>
		    </telerik:PieSeries>
		</telerik:RadPieChart>
	```

## See Also  
* [Chart Series Overview]({%slug radchartview-series-chartseries%})
* [PieSeries]({%slug radchartview-series-pieseries%})
* [DoughnutSeries]({%slug radchartview-series-doughnutseries%})
