Public Class Default_Vb


' #region radchart-features-annotations-custom-gridline_2
Dim gridline As New CustomGridLine()
gridline.YIntercept = 150
gridline.Stroke = New SolidColorBrush(Colors.Red)
gridline.StrokeThickness = 2
Me.radChart.DefaultView.ChartArea.Annotations.Add(gridline)
' #endregion
End Class
