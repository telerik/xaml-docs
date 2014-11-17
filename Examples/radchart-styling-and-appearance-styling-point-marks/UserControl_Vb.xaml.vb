Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-point-marks_1
Dim l As New LineSeriesDefinition()
l.Appearance.PointMark.Stroke = New SolidColorBrush(Colors.White)
l.Appearance.PointMark.StrokeThickness = 1
l.Appearance.PointMark.Fill = New SolidColorBrush(Colors.Transparent)
l.Appearance.PointMark.Shape = MarkerShape.Diamond
Me.radChart.DefaultSeriesDefinition = l
' #endregion
End Class
