Public Class Default_Vb

' #region radmap-how-to-set-the-best-view-for-the-informationlayer_0
Private Sub SetBestView()
	Dim rect As LocationRect = Me.informationLayer.GetBestView(Me.informationLayer.Items.Cast(Of Object)())
	rect.MapControl = Me.radMap
	Me.radMap.Center = rect.Center
	Me.radMap.ZoomLevel = rect.ZoomLevel
End Sub
' #endregion

End Class
