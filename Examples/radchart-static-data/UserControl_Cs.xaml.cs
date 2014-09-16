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

#region radchart-static-data_5
	RadCartesianChart chart = new RadCartesianChart();
	chart.HorizontalAxis = new CategoricalAxis();
	chart.VerticalAxis = new LinearAxis(){ Maximum = 100 };
	LineSeries line = new LineSeries();
	line.Stroke = new SolidColorBrush(Colors.Orange);
	line.StrokeThickness = 2;
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 20 });
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 40 });
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 35 });
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 40 });
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 30 });
	line.DataPoints.Add(new CategoricalDataPoint() { Value = 50 });
	chart.Series.Add(line);
	this.LayoutRoot.Children.Add(chart);
#endregion
}
