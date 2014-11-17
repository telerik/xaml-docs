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

#region chart-using-series-item-tooltips_0
DataSeries dataSeries = new DataSeries();
dataSeries.Definition = new BarSeriesDefinition();
// Enable the ToolTip functionality
dataSeries.Definition.ShowItemToolTips = true;
Random random = new Random(this.GetHashCode() | (int)(DateTime.Now.Ticks));
for (int i = 0; i < random.Next(7, 20); i++)
{
 DataPoint dataPoint = new DataPoint();
 dataPoint.YValue = random.Next(0, 100);
 dataSeries.Add(dataPoint);
} 
RadChart1.DefaultView.ChartArea.DataSeries.Add(dataSeries);
#endregion

#region chart-using-series-item-tooltips_2
DataSeries dataSeries = new DataSeries();
dataSeries.Definition = new BarSeriesDefinition();
// Enable the ToolTip functionality
dataSeries.Definition.ShowItemToolTips = true;
Random random = new Random(this.GetHashCode() | (int)(DateTime.Now.Ticks));
for (int i = 0; i < random.Next(7, 20); i++)
{
 DataPoint dataPoint = new DataPoint();
 dataPoint.YValue = random.Next(0, 100);
 dataSeries.Add(dataPoint);
} 
RadChart1.DefaultView.ChartArea.DataSeries.Add(dataSeries);
// Set the delay to 500 milliseconds
RadChart1.DefaultView.ChartArea.ItemToolTipDelay = 500;
#endregion

#region chart-using-series-item-tooltips_4
private void ExampleLoaded(object sender, System.Windows.RoutedEventArgs e)
{
 RadChart1.DefaultView.ChartTitle.Content = "Financial Overview";
 RadChart1.DefaultView.ChartArea.AxisX.Title = "Years";
 RadChart1.DefaultView.ChartArea.AxisY.DefaultFormat = "{0:C}";
 DataSeries series = new DataSeries();
 series.Definition.ShowItemToolTips = true;
 series.FillWithSampleData(10);
 RadChart1.DefaultView.ChartArea.DataSeries.Clear();
 RadChart1.DefaultView.ChartArea.DataSeries.Add(series);
 RadChart1.DefaultView.ChartArea.ItemToolTipOpening += this.ChartItemToolTipOpening;
}
private void ChartItemToolTipOpening(ItemToolTip2D tooltip, ItemToolTipEventArgs args)
{
 // format the tooltip value as currency
 tooltip.Content = args.DataPoint.YValue.ToString("{0:C}");
}
#endregion
}
