#region raddiagram-features-grouping-0
Private Sub RadButton_Click_1(sender As Object, e As RoutedEventArgs)
	For i As Integer = 1 To 20
		Dim shape As New RadDiagramShape() With { 
			 .Width = 30, 
			 .Height = 30, 
			 .Content = i 
			}
		shape.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape)
		shape.Position = New Point(random.[Next](0, 900), random.[Next](0, 200))
		Me.diagram.Items.Add(shape)
	Next
End Sub
#endregion
#region raddiagram-features-grouping-1
Private Sub RadButton_Click_3(sender As Object, e As RoutedEventArgs)
	Dim evenShapes As IShape() = Me.diagram.Shapes.Where(Function(x) Integer.Parse(x.Content.ToString()) Mod 2 = 0).ToArray(Of IShape)()
	Dim oddShapes As IShape() = Me.diagram.Shapes.Where(Function(x) Integer.Parse(x.Content.ToString()) Mod 2 = 1).ToArray(Of IShape)()
	Me.diagram.Group("Even", evenShapes)
	Me.diagram.Group("Odd", oddShapes)
End Sub
#endregion