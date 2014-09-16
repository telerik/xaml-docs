using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}
	
#region radchart-series-databinding_0
RadCartesianChart cartChart = new RadCartesianChart();
cartChart.HorizontalAxis = new CategoricalAxis();
cartChart.VerticalAxis = new LinearAxis();
BarSeries barSeries = new BarSeries() { ShowLabels = true};
cartChart.Series.Add(barSeries);
barSeries.ItemsSource = new double[] { 20, 30, 50, 10, 60, 40, 20, 80 };
this.LayoutRoot.Children.Add(cartChart);
#endregion
	
#region radchart-series-databinding_2
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
#endregion

#region radchart-series-databinding_4
barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
barSeries.ItemsSource = dataSouce;
#endregion

#region radchart-series-databinding_6
ObservableCollection<Product> products = new ObservableCollection<Product>();
// fill collection
barSeries.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Name" };
barSeries.ValueBinding = new GenericDataPointBinding<Product, double>() { ValueSelector = product => product.QuantitySold };
barSeries.ItemsSource = products;
#endregion

#region radchart-series-databinding_8
public MainPage()
{
    InitializeComponent();
    ChartSeries barSeries = this.chart.Series[0];
    barSeries.DataContext = new double[] { 20, 30, 50, 10, 60, 40, 20, 80 };
}
#endregion
	
}
