using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
#region radchart-introduction_5
	using Telerik.Charting;
	using Telerik.Windows.Controls;
	using Telerik.Windows.Controls.ChartView;
#endregion
namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radchart-introduction_4
				RadCartesianChart chart = new RadCartesianChart();
				CategoricalAxis catAxis = new CategoricalAxis();
				LinearAxis lineAxis = new LinearAxis();
				chart.HorizontalAxis = catAxis;
				chart.VerticalAxis = lineAxis;

				BarSeries barSeries = new BarSeries();
				barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Apples", Value = 20 });
				barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Bananas", Value = 28 });
				barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Oranges", Value = 17 });
				barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Strawberries", Value = 30 });
				chart.Series.Add(barSeries);

				this.LayoutRoot.Children.Add(chart);
			#endregion
}
