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

#region chart-animation-settings-api_2
private void Page_Loaded(object sender, RoutedEventArgs e)
{
 AnimationSettings settings = new AnimationSettings();
 settings.ItemDelay = TimeSpan.FromSeconds(.5);
 settings.ItemAnimationDuration = TimeSpan.FromSeconds(1);
 //This DataSeries uses animation settings of its own.
 DataSeries barSeries1 = new DataSeries();
 barSeries1.Definition = new BarSeriesDefinition();
 barSeries1.Definition.AnimationSettings = settings;
 barSeries1.Label = "Bar Series 1";
 this.FillWithSampleData(barSeries1, 10);
 //This DataSeries relies on the animation settings of RadChart or          
 //the default animation settings.
 DataSeries barSeries2 = new DataSeries();
 barSeries2.Definition = new BarSeriesDefinition();
 barSeries2.Label = "Bar Series 2";
 this.FillWithSampleData(barSeries2, 10);
 RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries1);
 RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries2);
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
