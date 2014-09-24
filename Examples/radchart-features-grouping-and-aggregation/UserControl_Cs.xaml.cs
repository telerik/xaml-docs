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

#region radchart-features-grouping-and-aggregation_2
RadChart radChart = new RadChart();
....
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.SeriesDefinition = new BarSeriesDefinition();
seriesMapping.GroupingSettings.GroupDescriptors.Add( new ChartGroupDescriptor( "Year" ) );
seriesMapping.GroupingSettings.GroupDescriptors.Add( new ChartGroupDescriptor( "Region" ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Description", DataPointMember.XCategory ) );
....
radChart.SeriesMappings.Add( seriesMapping );
#endregion

#region radchart-features-grouping-and-aggregation_5
RadChart radChart = new RadChart();
....
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.SeriesDefinition = new HorizontalBarSeriesDefinition();
seriesMapping.GroupingSettings.GroupDescriptors.Add( new ChartGroupDescriptor( "Year" ) );
seriesMapping.GroupingSettings.GroupDescriptors.Add( new ChartGroupDescriptor( "Region" ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue, ChartAggregateFunction.Sum ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Region", DataPointMember.XCategory ) );
....
radChart.SeriesMappings.Add( seriesMapping );
#endregion
}
