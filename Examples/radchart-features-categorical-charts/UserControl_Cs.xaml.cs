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

#region radchart-features-categorical-charts_1
DataSeries dataSeries = new DataSeries();
dataSeries.Definition = new BarSeriesDefinition();
dataSeries.Add( new DataPoint() { YValue = 41, XCategory = "Apples" } );
dataSeries.Add( new DataPoint() { YValue = 33, XCategory = "Oranges" } );
dataSeries.Add( new DataPoint() { YValue = 25, XCategory = "Grapes" } );
radChart.DefaultView.ChartArea.DataSeries.Add( dataSeries );
#endregion

#region radchart-features-categorical-charts_3
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.SeriesDefinition = new BarSeriesDefinition();
ItemMapping itemMapping = new ItemMapping();
itemMapping.DataPointMember = DataPointMember.XCategory;
itemMapping.FieldName = "Fruit";
seriesMapping.ItemMappings.Add( itemMapping );
itemMapping = new ItemMapping();
itemMapping.DataPointMember = DataPointMember.YValue;
itemMapping.FieldName = "Orders";
seriesMapping.ItemMappings.Add( itemMapping );
radChart.SeriesMappings.Add( seriesMapping );
#endregion
}
