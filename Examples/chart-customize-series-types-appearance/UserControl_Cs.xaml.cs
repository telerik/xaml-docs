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

#region chart-customize-series-types-appearance_2
public WindowPage()
{
 InitializeComponent();
 RadChart1.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = this.CustomBarStyle;
 RadChart1.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = this.LayoutRoot.Resources["CustomBarStyle"] as Style;
 RadChart1.DefaultView.ChartTitle.Content = "Financial Overview";
 RadChart1.DefaultView.ChartLegend.Header = "Revenue (Millions)";
 RadChart1.DefaultView.ChartArea.DataSeries.Add(CreateDataSeries(new BarSeriesDefinition()));
 RadChart1.DefaultView.ChartArea.DataSeries.Add(CreateDataSeries(new BarSeriesDefinition()));
}
private DataSeries CreateDataSeries(ISeriesDefinition definition)
{
 Random rand = new Random(DateTime.Now.Millisecond);
 DataSeries series = new DataSeries() { Definition = definition, LegendLabel = "Annual" };
 for (int i = 0; i < 5; i++)
 {
  series.Add(new DataPoint(rand.Next(10, 100)));
 }
 return series;
}
#endregion
}
