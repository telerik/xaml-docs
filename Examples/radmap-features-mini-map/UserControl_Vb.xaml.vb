Public Class Default_Vb

' #region radmap-features-mini-map_2
Private Const MiniMapWidthScaleFactor As Double = 0.15
Private Const MiniMapHeightScaleFactor As Double = 0.2

Private Sub MapSizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
	Me.MiniMap1.Width = e.NewSize.Width * MiniMapWidthScaleFactor
	Me.MiniMap1.Height = e.NewSize.Height * MiniMapHeightScaleFactor
End Sub
' #endregion

End Class
