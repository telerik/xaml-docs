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

#region chart-customize-chart-series-appearance-visual-properties_2
DataSeries series = new DataSeries();
series.Definition = new BarSeriesDefinition();
series.Definition.Appearance.Fill = new SolidColorBrush(Colors.Red);
series.Definition.Appearance.Stroke = new SolidColorBrush(Colors.Yellow);
RadChart1.DefaultView.ChartArea.DataSeries.Add(series);
#endregion

#region chart-customize-chart-series-appearance-visual-properties_4
series.Add(new DataPoint(1, 20));
series.Add(new DataPoint(2, 30));
series.Add(new DataPoint(3, 40));
series.Add(new DataPoint(4, 50));
series.Add(new DataPoint(5, 20));
#endregion
}
