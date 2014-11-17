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

#region chart-customize-chart-series-appearance-itemstyle_1
private void Page_Loaded(object sender, RoutedEventArgs e)
{
 DataSeries barSeries = new DataSeries();
 barSeries.Definition = new BarSeriesDefinition();
 barSeries.Definition.ItemStyle = this.FindResource("MyStyle") as Style;
 barSeries.Definition.ItemStyle = this.Resources["MyStyle"] as Style;
 RadChart1.DefaultView.ChartArea.AxisX.StripLinesVisibility = Visibility.Collapsed;
 RadChart1.DefaultView.ChartArea.AxisY.MajorGridLinesVisibility = Visibility.Visible;
 RadChart1.DefaultView.ChartArea.AxisY.StripLinesVisibility = Visibility.Collapsed;
 this.FillWithSampleData(barSeries, 10);
 this.RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries);
}
private void FillWithSampleData(DataSeries series, int numberOfItems)
{
 Random random = new Random((int)(series.GetHashCode() + DateTime.Now.Ticks));
 for (int i = 0; i < numberOfItems; i++)
 {
  int randomNumber = random.Next(30, 100);
  series.Add(new DataPoint { XValue = randomNumber, YValue = randomNumber });
 }
}
#endregion
}
