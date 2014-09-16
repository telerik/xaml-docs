Public Class Default_Vb

' #region common-ui-automation_0
 Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim extension As String = "png"
	Dim dialog As New SaveFileDialog() With {.DefaultExt = extension, .Filter = "Png (*.png)|*.png"}

	If dialog.ShowDialog() = True Then
		Using stream As Stream = dialog.OpenFile()
			Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream, New System.Windows.Media.Imaging.PngBitmapEncoder())
		End Using
	End If
 End Sub
' #endregion
End Class
