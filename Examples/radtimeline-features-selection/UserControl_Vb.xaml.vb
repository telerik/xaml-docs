Public Class Default_Vb
' #region radtimeline-features-selection-0
Private Sub RadTimeline_SelectionChanged(sender As Object, e As SelectionChangeEventArgs)
	Dim selectedItem = TryCast(sender, RadTimeline).SelectedItem			
	If selectedItem IsNot Nothing Then
	'Do something with the selected item.
	End If
End Sub
' #endregion

End Class
