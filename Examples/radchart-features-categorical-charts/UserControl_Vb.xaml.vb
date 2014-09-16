Public Class Default_Vb


' #region radchart-features-categorical-charts_2
Dim dataSeries As New DataSeries()
dataSeries.Definition = New BarSeriesDefinition()
Dim dataPoint As New DataPoint()
dataPoint.YValue = 41
dataPoint.XCategory = "Apples"
dataSeries.Add( dataPoint )
dataPoint = New DataPoint()
dataPoint.YValue = 33
dataPoint.XCategory = "Oranges"
dataSeries.Add( dataPoint )
dataPoint = New DataPoint()
dataPoint.YValue = 25
dataPoint.XCategory = "Grapes"
dataSeries.Add( dataPoint )
radChart.DefaultView.ChartArea.DataSeries.Add( dataSeries )
' #endregion

' #region radchart-features-categorical-charts_4
Dim seriesMapping As New SeriesMapping()
seriesMapping.SeriesDefinition = New BarSeriesDefinition()
Dim itemMapping As New ItemMapping()
itemMapping.DataPointMember = DataPointMember.XCategory
itemMapping.FieldName = "Fruit"
seriesMapping.ItemMappings.Add( itemMapping )
itemMapping = New ItemMapping()
itemMapping.DataPointMember = DataPointMember.YValue
itemMapping.FieldName = "Orders"
seriesMapping.ItemMappings.Add( itemMapping )
radChart.SeriesMappings.Add( seriesMapping )
' #endregion
End Class
