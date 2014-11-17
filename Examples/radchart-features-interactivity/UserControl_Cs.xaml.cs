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

#region radchart-features-interactivity_1
radChart.DefaultView.ChartArea.ItemClick += new EventHandler<ChartItemClickEventArgs>( ChartArea_ItemClick );
...
private void ChartArea_ItemClick( object sender, ChartItemClickEventArgs e )
{
    TradeData td = e.DataPoint.DataItem as TradeData;
    MessageBox.Show( string.Format( 
        "Trading details for {0:d}:\n\nOpen\t: {1:c}\nHigh\t: {2:c}\nLow\t: {3:c}\nClose\t: {4:c}\n\nVolume\t: {5}",
        td.FromDate, td.Open, td.High, td.Low, td.Close, td.Volume ), td.Emission, MessageBoxButton.OK );
}
#endregion

#region radchart-features-interactivity_3
private void Button_Click(object sender, RoutedEventArgs e)
  {
    foreach (DataPoint dataPoint1 in Chart1.DefaultView.ChartArea.DataSeries[0])
    {
      if(dataPoint1.YValue==154.0)
      Chart1.DefaultView.ChartArea.SelectItem(dataPoint1);
    } 
  }
#endregion
}
