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

#region radchart-features-datetime-support_0
public class TradeData
{
    ...
    public DateTime FromDate { get; set; }
    public double Close { get; set; }
    ...
}
#endregion

#region radchart-features-datetime-support_3
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.LegendLabel = "MSFT";
seriesMapping.SeriesDefinition = new LineSeriesDefinition();
seriesMapping.ItemMappings.Add( new ItemMapping( "FromDate", DataPointMember.XValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Close", DataPointMember.YValue ) );
radChart.SeriesMappings.Add( seriesMapping );
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
#endregion

#region radchart-features-datetime-support_6
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
....
radChart.DefaultView.ChartArea.AxisX.IsDateTime = true;
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
....
DataSeries lineSeries = new DataSeries();
lineSeries.Definition = new LineSeriesDefinition();
lineSeries.Add( new DataPoint() { YValue = 154, XValue = new DateTime( 2009, 1, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 138, XValue = new DateTime( 2009, 2, 28 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 143, XValue = new DateTime( 2009, 3, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 120, XValue = new DateTime( 2009, 4, 30 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 135, XValue = new DateTime( 2009, 5, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 125, XValue = new DateTime( 2009, 6, 30 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 179, XValue = new DateTime( 2009, 7, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 170, XValue = new DateTime( 2009, 8, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 198, XValue = new DateTime( 2009, 9, 30 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 187, XValue = new DateTime( 2009, 10, 31 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 193, XValue = new DateTime( 2009, 11, 30 ).ToOADate() } );
lineSeries.Add( new DataPoint() { YValue = 176, XValue = new DateTime( 2009, 12, 31 ).ToOADate() } );
radChart.DefaultView.ChartArea.DataSeries.Add( lineSeries );
#endregion
}
