Public Class Default_Vb


' #region radchart-features-axes-labels_1
Dim lineSeries As New DataSeries()
lineSeries.LegendLabel = "Monthly Sales"
lineSeries.Definition = New LineSeriesDefinition()
Dim r As New Random()
For i As Integer = 0 To 11
 lineSeries.Add(New DataPoint() With { _
  .YValue = i + r.[Next](0, 20) _
 })
Next
radChart.DefaultView.ChartArea.DataSeries.Add(lineSeries)
Dim months As String() = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", _
 "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
For i As Integer = 0 To months.Length - 1
 radChart.DefaultView.ChartArea.AxisX.TickPoints(i).Label = months(i)
Next
' #endregion
End Class
