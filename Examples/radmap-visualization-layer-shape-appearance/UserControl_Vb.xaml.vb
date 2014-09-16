Public Class Default_Vb

' #region radmap_visualization_layer_shape_appearance_0
Partial Public Class HighlightShapeOnMouseClick
	Inherits UserControl

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub MapShapeVisualizationCreated(sender As Object, e As MapShapeOperationEventArgs)
		If e.Visualization IsNot Nothing Then
			' Attach mouse events to the map shape visualization.
			AddHandler e.Visualization.MouseLeftButtonDown, AddressOf Me.Visualization_MouseLeftButtonDown
		End If
	End Sub

	Private Sub MapShapeVisualizationRemoved(sender As Object, e As MapShapeOperationEventArgs)
		If e.Visualization IsNot Nothing Then
			' Detach mouse events to the map shape visualization.
			RemoveHandler e.Visualization.MouseLeftButtonDown, AddressOf Me.Visualization_MouseLeftButtonDown
		End If
	End Sub

	Private Sub Visualization_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
		Dim elt As FrameworkElement = TryCast(sender, FrameworkElement)
		If elt IsNot Nothing Then
			Dim data As MapShapeData = TryCast(elt.DataContext, MapShapeData)
			If data.IsHighlighted Then
				data.UseRegularFill()
			Else
				data.UseHighlightFill()
			End If
		End If

		e.Handled = True
	End Sub
End Class
' #endregion

' #region radmap_visualization_layer_shape_appearance_1

' #endregion

End Class
