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

#region xamlflix_chartview_16
public class ChartDataClass
{
	public double XValue { get; set; }
	public double YValue { get; set; }
}
#endregion

#region xamlflix-chartview_17
void MainPage_Loaded(object sender, RoutedEventArgs e)
{
    var rnd = new Random();
    var ChartDatas = new List<ChartDataClass>();

    for (int i = 0; i < 20; i++)
    {
        var cdc = new ChartDataClass();
        cdc.XValue = i;
        cdc.YValue = rnd.NextDouble * 100;
        ChartDatas.Add(cdc);
    }

}
#endregion

#region xamlflix-chartview_18
xCartesianChart.Series[0].ItemsSource = ChartDatas;
#endregion

#region xamlflix-chartview_25
var chartDatas = new List<ChartDataClass>();
var chartDatas2 = new List<ChartDataClass>();
#endregion

#region xamlflix-chartview_26
for ( int i = 0; i < 200; i++ )
{
    var cdc = new ChartDataClass () ;
    cdc.XValue = i;
    cdc.YValue = rnd.NextDouble() * 100;
    chartDatas.Add( cdc );

    var cdc2 = new ChartDataClass();
    cdc2.XValue = i;
    cdc2.YValue = rnd.NextDouble() * 100;
    chartDatas2.Add(cdc2);

}
#endregion

#region xamlflix-chartview_27
xCartesianChart.Series[0].ItemsSource = chartDatas;
xCartesianChart.Series[1].ItemsSource = chartDatas2;
#endregion

#region xamlflix-chartview_34
public class ChartData
{
	public double XValue { get;set; }

	public double YValue { get;set; }
}
#endregion

#region xamlflix-chartview_35
private List<ChartData> GetData()
{
    var rand = new Random () ;
    var data = new List<ChartData> () ;

    for ( int i = 1; i < 30; i++ )
    {
        data.Add( new ChartData () { XValue = i, YValue = rand.Next( 10, 100 ) } );
    }

    return data;
}
#endregion

#region xamlflix-chartview_36
public MainPage()
{
    InitializeComponent();
    var series = RadChart1.Series[ 0 ] as ScatterPointSeries;
    series.XValueBinding = new PropertyNameDataPointBinding ( "XValue" ) ;
    series.YValueBinding = new PropertyNameDataPointBinding ( "YValue" ) ;
    series.ItemsSource = this.GetData();
}
#endregion

#region xamlflix-chartview_37
private void RadChart1_SelectionChanged(object sender, ChartSelectionChangedEventArgs e)
{
    if (e.AddedPoints.Count == 0)
        return;

    // Get the data point.
    var dataPoint = e.AddedPoints[0];

    // Get the series.
    var series = dataPoint.Presenter as ScatterPointSeries;
}
#endregion


}