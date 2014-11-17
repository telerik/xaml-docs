Public Class Default_Vb


' #region chart-customize-chart-series-appearance-visual-properties_3
Dim series As New DataSeries()
series.Definition = New BarSeriesDefinition()
series.Definition.Appearance.Fill = New SolidColorBrush(Colors.Red)
series.Definition.Appearance.Stroke = New SolidColorBrush(Colors.Yellow)
RadChart1.DefaultView.ChartArea.DataSeries.Add(series)
' #endregion

' #region chart-customize-chart-series-appearance-visual-properties_5
series.Add(New DataPoint(1, 20))
series.Add(New DataPoint(2, 30))
series.Add(New DataPoint(3, 40))
series.Add(New DataPoint(4, 50))
series.Add(New DataPoint(5, 20))
' #endregion
End Class
