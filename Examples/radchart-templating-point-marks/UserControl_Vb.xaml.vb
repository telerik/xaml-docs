Public Class Default_Vb


' #region radchart-templating-point-marks_3
Me.radChart.DefaultSeriesDefinition = New LineSeriesDefinition()
Me.radChart.DefaultSeriesDefinition.PointMarkItemStyle = TryCast(Me.Resources("PointMarkStyle"), Style)
' #endregion
End Class
