Public Class Default_Vb
#Region "radtoolbar-orientation_0"
	Imports Telerik.Windows.Controls

	Private Sub ToggleOrientation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		If Me.myToolbarTray.Orientation = Orientation.Horizontal Then
			Me.myToolbarTray.Orientation = Orientation.Vertical
			Me.myToolbarTray.VerticalAlignment = VerticalAlignment.Stretch
			Me.myToolbarTray.HorizontalAlignment = HorizontalAlignment.Left
			Me.myToolbar.Orientation = Orientation.Vertical
			Me.myToolbar.VerticalAlignment = VerticalAlignment.Stretch
			Me.myToolbar.HorizontalAlignment = HorizontalAlignment.Left
		Else
			Me.myToolbarTray.Orientation = Orientation.Horizontal
			Me.myToolbarTray.VerticalAlignment = VerticalAlignment.Top
			Me.myToolbarTray.HorizontalAlignment = HorizontalAlignment.Stretch
			Me.myToolbar.Orientation = Orientation.Horizontal
			Me.myToolbar.VerticalAlignment = VerticalAlignment.Top
			Me.myToolbar.HorizontalAlignment = HorizontalAlignment.Stretch
		End If
	End Sub
#End Region

End Class
