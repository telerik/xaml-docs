Public Class Default_Vb

' #region radmap_visualization_layer_map_shape_data_0
Dim ellipse As New EllipseData() With { _
	.Location = New Location(43.4457539183824, 23.2927663758679), _
	.Height = 0.5, _
	.Width = 0.5, _
	.ShapeFill = New MapShapeFill() With { _
		.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Me.visualizationLayer.Items.Add(ellipse)
' #endregion

' #region radmap_visualization_layer_map_shape_data_1
Dim line As New LineData() With { _
	.Point1 = New Location(42.6957539183824, 23.3327663758679), _
	.Point2 = New Location(42.1429369264591, 24.7498095849434), _
	.ShapeFill = New MapShapeFill() With { _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Me.visualizationLayer.Items.Add(line)
' #endregion

' #region radmap_visualization_layer_map_shape_data_2
Dim path As New PathData() With { _
	.ShapeFill = New MapShapeFill() With { _
		.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Dim geometry As New PathGeometryData()

Dim figure As New PathFigureData() With { _
	.IsClosed = True, _
	.StartPoint = New Location(44.6957539183824, 23.3327663758679) _
}

Dim segment As New LineSegmentData() With { _
	.Point = New Location(44.1429369264591, 24.7498095849434) _
}
figure.Segments.Add(segment)

segment = New LineSegmentData() With { _
	.Point = New Location(44.5131732087098, 27.4611884843576) _
}
figure.Segments.Add(segment)

segment = New LineSegmentData() With { _
	.Point = New Location(45.2073941930888, 27.9275176988258) _
}
figure.Segments.Add(segment)

segment = New LineSegmentData() With { _
	.Point = New Location(45.1957539183824, 23.5427663758679) _
}
figure.Segments.Add(segment)

geometry.Figures.Add(figure)
path.Data = geometry

Me.visualizationLayer.Items.Add(path)
' #endregion

' #region radmap_visualization_layer_map_shape_data_3
Dim polygon As New PolygonData() With { _
	.ShapeFill = New MapShapeFill() With { _
		.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Dim points As New LocationCollection()
points.Add(New Location(48, -104))
points.Add(New Location(48, -108))
points.Add(New Location(52, -108))
points.Add(New Location(52, -104))

polygon.Points = points

Me.visualizationLayer.Items.Add(polygon)
' #endregion

' #region radmap_visualization_layer_map_shape_data_4
Dim polyline As New PolylineData() With { _
	.ShapeFill = New MapShapeFill() With { _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Dim points As New LocationCollection()
points.Add(New Location(44.6957539183824, 23.3327663758679))
points.Add(New Location(44.1429369264591, 24.7498095849434))
points.Add(New Location(44.5131732087098, 27.4611884843576))
points.Add(New Location(45.2073941930888, 27.9275176988258))

polyline.Points = points

Me.visualizationLayer.Items.Add(polyline)
' #endregion

' #region radmap_visualization_layer_map_shape_data_5
Dim rect As New RectangleData() With { _
	.Location = New Location(43.4457539183824, 23.2927663758679), _
	.Height = 0.5, _
	.Width = 0.5, _
	.RadiusX = 0.05, _
	.RadiusY = 0.05, _
	.ShapeFill = New MapShapeFill() With { _
		.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 2 _
	} _
}

Me.visualizationLayer.Items.Add(rect)
' #endregion

End Class
