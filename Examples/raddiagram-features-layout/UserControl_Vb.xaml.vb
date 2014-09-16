#region raddiagram-features-layout-0
Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
	Dim settings As New SugiyamaSettings() With { 
		 .HorizontalDistance = 50, 
		 .VerticalDistance = 20, 
		 .Orientation = Telerik.Windows.Diagrams.Core.Orientation.Horizontal, 
		 .TotalMargin = New Size(20, 20), 
		 .ShapeMargin = New Size(10, 10) 
	}
	Me.diagram.Layout(LayoutType.Sugiyama, settings)
End Sub
#endregion

#region raddiagram-features-layout-1
Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
	Dim settings As New TreeLayoutSettings() With { 
		 .TreeLayoutType = TreeLayoutType.TreeDown, 
		 .VerticalDistance = 20 
	}
	settings.Roots.Add(Me.diagram.Shapes(0))
	Me.diagram.Layout(LayoutType.Tree, settings)
End Sub
#endregion