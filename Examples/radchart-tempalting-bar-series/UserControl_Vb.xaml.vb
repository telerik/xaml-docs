Public Class Default_Vb


' #region radchart-tempalting-bar-series_1
Dim barSeries As New BarSeriesDefinition()
barSeries.ItemStyle = TryCast(Me.Resources("BarStyle"), Style)
Me.radChart.DefaultSeriesDefinition = barSeries
' #endregion
End Class
