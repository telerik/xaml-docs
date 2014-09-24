Public Class Default_Vb


' #region radmap_visualization_layer_input_events_0
Private Sub MapShapeVisualizationCreated(sender As Object, e As MapShapeOperationEventArgs)
	If e.Visualization IsNot Nothing Then
		' Attach mouse events to the map shape visualization.
		AddHandler e.Visualization.MouseEnter, AddressOf Me.Visualization_MouseEnter
		AddHandler e.Visualization.MouseLeave, AddressOf Me.Visualization_MouseLeave
		End If
	End Sub

Private Sub MapShapeVisualizationRemoved(sender As Object, e As MapShapeOperationEventArgs)
	If e.Visualization IsNot Nothing Then
		' Detach mouse events to the map shape visualization.
		RemoveHandler e.Visualization.MouseEnter, AddressOf Me.Visualization_MouseEnter
		RemoveHandler e.Visualization.MouseLeave, AddressOf Me.Visualization_MouseLeave
	End If
End Sub

Private Sub Visualization_MouseEnter(sender As Object, e As MouseEventArgs)
	' Highlight shape when mouse enter.
	Dim elt As FrameworkElement = TryCast(sender, FrameworkElement)
	If elt IsNot Nothing Then
		Dim data As MapShapeData = TryCast(elt.DataContext, MapShapeData)
		data.UseHighlightFill()
	End If
End Sub

Private Sub Visualization_MouseLeave(sender As Object, e As MouseEventArgs)
	' Use regular fill when mouse leave the shape.
	Dim elt As FrameworkElement = TryCast(sender, FrameworkElement)
	If elt IsNot Nothing Then
		Dim data As MapShapeData = TryCast(elt.DataContext, MapShapeData)
		data.UseRegularFill()
	End If
End Sub
' #endregion

End Class
