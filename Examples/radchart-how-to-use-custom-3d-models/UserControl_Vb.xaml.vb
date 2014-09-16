Public Class Default_Vb


' #region radchart-how-to-use-custom-3d-models_2
Private Sub FillSampleChartData()
 Dim barSeries As New DataSeries()
 barSeries.Definition = New Bar3DSeriesDefinition()
 barSeries.Definition.ItemStyle = DirectCast(Me.FindResource("MyStyle"), Style)
 barSeries.FillWithSampleData()
 Me.RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries)
End Sub
' #endregion
End Class
