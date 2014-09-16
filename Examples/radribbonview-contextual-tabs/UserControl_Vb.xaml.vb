Public Class Default_Vb


' #region radribbonview-contextual-tabs_4
Private Sub Group1Button_Click(sender As Object, e As RoutedEventArgs)
	If Not Me.ContextualGroup1.IsActive Then
		Me.ContextualGroup1.IsActive = True
	End If
	If Me.ContextualGroup2.IsActive Then
		Me.ContextualGroup2.IsActive = False
	End If
End Sub
Private Sub Group2Button_Click(sender As Object, e As RoutedEventArgs)
	If Not Me.ContextualGroup2.IsActive Then
		Me.ContextualGroup2.IsActive = True
	End If
	If Me.ContextualGroup1.IsActive Then
		Me.ContextualGroup1.IsActive = False
	End If
End Sub
' #endregion
End Class
