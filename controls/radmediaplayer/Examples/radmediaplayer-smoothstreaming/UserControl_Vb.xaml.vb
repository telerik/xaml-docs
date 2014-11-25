Public Class Default_Vb
#Region "radmediaplayer-smoothstreaming_1"
	Private Sub RadMediaItem_StreamAttached(ByVal sender As Object, ByVal e As EventArgs)
		Dim item = TryCast(sender, RadMediaItem)
		If item IsNot Nothing Then
			Dim adaptiveSource = New AdaptiveStreamingSource()
			adaptiveSource.MediaElement = player.MediaElement
			adaptiveSource.ManifestUrl = item.Source
			adaptiveSource.StartPlayback()
		End If
	End Sub
#End Region
End Class
