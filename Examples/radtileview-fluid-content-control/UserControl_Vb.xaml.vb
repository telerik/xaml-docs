Public Class Default_Vb
#Region "radtileview-fluid-content-control_3"
	Private Sub RadTileView_TileStateChanged(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
		Dim item As RadTileViewItem = TryCast(e.Source, RadTileViewItem)
		If item IsNot Nothing Then
			Dim fluidControl As RadFluidContentControl = TryCast(item.Content, RadFluidContentControl)
			If fluidControl IsNot Nothing Then
				Select Case item.TileState
					Case TileViewItemState.Maximized
						fluidControl.State = FluidContentControlState.Large
						Exit Select
					Case TileViewItemState.Minimized
						fluidControl.State = FluidContentControlState.Small
						Exit Select
					Case TileViewItemState.Restored
						fluidControl.State = FluidContentControlState.Normal
						Exit Select
				End Select
			End If
		End If
	End Sub
#End Region

End Class
