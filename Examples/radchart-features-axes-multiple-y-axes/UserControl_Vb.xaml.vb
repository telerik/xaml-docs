Public Class Default_Vb


' #region radchart-features-axes-multiple-y-axes_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
radChart.DefaultView.ChartArea.AxisY.Title = "Megawatt [MW]"
Dim axisY As New AxisY()
axisY.AxisName = "AxisY_South"
axisY.Title = "Kilowatt [kW]"
radChart.DefaultView.ChartArea.AdditionalYAxes.Add(axisY)
....
'Series mapping for the collection with index 0
Dim seriesMapping As New SeriesMapping()
seriesMapping.CollectionIndex = 0
seriesMapping.LegendLabel = "North [MW]"
seriesMapping.SeriesDefinition = New BarSeriesDefinition()
seriesMapping.SeriesDefinition.ShowItemLabels = False
seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
radChart.SeriesMappings.Add(seriesMapping)
'Series mapping for the collection with index 1
seriesMapping = New SeriesMapping()
seriesMapping.CollectionIndex = 1
seriesMapping.LegendLabel = "South [kW]"
seriesMapping.SeriesDefinition = New BarSeriesDefinition()
seriesMapping.SeriesDefinition.AxisName = "AxisY_South"
seriesMapping.SeriesDefinition.ShowItemLabels = False
seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
radChart.SeriesMappings.Add(seriesMapping)
radChart.ItemsSource = Me.DataContext
' #endregion
End Class
