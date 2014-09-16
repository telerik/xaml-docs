Public Class UserControl_Vb


#region radchart-static-data_5
	Dim chart As New RadCartesianChart()
	chart.HorizontalAxis = New CategoricalAxis()
	chart.VerticalAxis = New LinearAxis() With {.Maximum = 100}
	Dim line As New LineSeries()
	line.Stroke = New SolidColorBrush(Colors.Orange)
	line.StrokeThickness = 2
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 20})
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 40})
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 35})
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 40})
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 30})
	line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 50})
	chart.Series.Add(line)
	Me.LayoutRoot.Children.Add(chart)
#endregion
End Class
