Public Class Default_Vb


' #region radchart-features-grouping-and-aggregation_3
Dim radChart As New RadChart()
....
Dim seriesMapping As New SeriesMapping()
seriesMapping.SeriesDefinition = new BarSeriesDefinition()
seriesMapping.GroupingSettings.GroupDescriptors.Add( New ChartGroupDescriptor( "Year" ) )
seriesMapping.GroupingSettings.GroupDescriptors.Add( New ChartGroupDescriptor( "Region" ) )
seriesMapping.ItemMappings.Add( New ItemMapping( "Value", DataPointMember.YValue ) )
seriesMapping.ItemMappings.Add( New ItemMapping( "Description", DataPointMember.XCategory ) )
....
radChart.SeriesMappings.Add( seriesMapping )
' #endregion

' #region radchart-features-grouping-and-aggregation_6
Dim radChart As New RadChart()
....
Dim seriesMapping As New SeriesMapping()
seriesMapping.SeriesDefinition = new HorizontalBarSeriesDefinition()
seriesMapping.GroupingSettings.GroupDescriptors.Add( New ChartGroupDescriptor( "Year" ) )
seriesMapping.GroupingSettings.GroupDescriptors.Add( New ChartGroupDescriptor( "Region" ) )
seriesMapping.ItemMappings.Add( New ItemMapping( "Value", DataPointMember.YValue, ChartAggregateFunction.Sum ) )
seriesMapping.ItemMappings.Add( New ItemMapping( "Region", DataPointMember.XCategory ) )
....
radChart.SeriesMappings.Add( seriesMapping )
' #endregion
End Class
