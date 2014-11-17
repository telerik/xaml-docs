Public Class UserControl_Vb

' #region radchartview_annotations_getting_started_0
cartesianChart.Annotations.Add(New CartesianGridLineAnnotation() With { _
	.Axis = cartesianChart.VerticalAxis, _
	.Value = 6, _
	.Stroke = New SolidColorBrush(Colors.Red), _
	.StrokeThickness = 1 _
})
cartesianChart.Annotations.Add(New CartesianGridLineAnnotation() With { _
	.Axis = cartesianChart.HorizontalAxis, _
	.Value = 2.8, _
	.Stroke = New SolidColorBrush(Colors.Blue), _
	.StrokeThickness = 1 _
})
' #endregion

' #region radchartview_annotations_getting_started_1
polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
	.Value = 2, _
	.Stroke = New SolidColorBrush(Colors.Red) _
})
polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
	.Value = 7, _
	.Stroke = New SolidColorBrush(Colors.LightGreen) _
})
polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
	.Value = 8, _
	.Stroke = New SolidColorBrush(Colors.LightBlue) _
})
' #endregion

End Class
