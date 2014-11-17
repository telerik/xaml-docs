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

#region radchart-features-format-expressions_0
public class TradeData
{
    public string Emission
    {
        get;
        set;
    }
    public DateTime FromDate
    {
        get;
        set;
    }
    public DateTime ToDate
    {
        get;
        set;
    }
    public double Open
    {
        get;
        set;
    }
    public double High
    {
        get;
        set;
    }
    public double Low
    {
        get;
        set;
    }
    public double Close
    {
        get;
        set;
    }
    public double Volume
    {
        get;
        set;
    }
    public string Comment
    {
        get;
        set;
    }
}
#endregion

#region radchart-features-format-expressions_3
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
....
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "#VAL{C2}";
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.SeriesDefinition = new LineSeriesDefinition();
seriesMapping.SeriesDefinition.ShowItemToolTips = true;
seriesMapping.SeriesDefinition.ItemLabelFormat = "#Y{C2}";
seriesMapping.SeriesDefinition.ItemToolTipFormat = 
    "High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}\nVolume: #DATAITEM.Volume{#,###,###,##0}";
seriesMapping.ItemMappings.Add( new ItemMapping( "Close", DataPointMember.YValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "FromDate", DataPointMember.XValue ) );
radChart.SeriesMappings.Add( seriesMapping );
#endregion
}
