Public Class Default_Vb


' #region radchart-features-annotations-custom-line_2
Dim _customLine As New CustomLine()
_customLine.Slope = 2.66
_customLine.YIntercept = -3.32
_customLine.MinX = 2
_customLine.MinY = 2
_customLine.MaxX = 5
_customLine.MaxY = 10
_customLine.Stroke = New SolidColorBrush(Colors.Red)
_customLine.StrokeThickness = 2
Me.radChart.DefaultView.ChartArea.Annotations.Add(_customLine)
' #endregion
End Class
