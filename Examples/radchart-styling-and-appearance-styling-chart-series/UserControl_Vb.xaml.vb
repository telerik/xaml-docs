Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-chart-series_1
Dim barDefinition As New BarSeriesDefinition()
barDefinition.Appearance.Fill = New SolidColorBrush(Colors.Orange )
Me.radChart.DefaultSeriesDefinition = barDefinition
' #endregion

' #region radchart-styling-and-appearance-styling-chart-series_5
Me.radChart.DefaultView.ChartArea.SeriesStyles.SplineAreaSeriesStyle = TryCast(Me.Resources("SplineAreaStyle"), Style)
' #endregion

' #region radchart-styling-and-appearance-styling-chart-series_8
Me.radChart.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = TryCast(Me.Resources("BarStyle"), Style)
' #endregion

' #region radchart-styling-and-appearance-styling-chart-series_15
RadChart1.DefaultSeriesDefinition = line
line.Appearance.Stroke = New SolidColorBrush(System.Windows.Media.Colors.Blue)
line.Appearance.Fill = New SolidColorBrush(System.Windows.Media.Colors.Blue)
line.Appearance.StrokeThickness = 1
line.ItemStyle = TryCast(Me.Resources("MyDoubleLineStyle"), Style)
' #endregion
End Class
