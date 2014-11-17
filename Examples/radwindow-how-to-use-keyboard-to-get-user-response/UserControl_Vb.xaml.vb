Public Class Default_Vb


' #region radwindow-how-to-use-keyboard-to-get-user-response_2
Private Sub OnButtonAcceptClicked(sender As Object, e As RoutedEventArgs)
 Me.DialogResult = True
 Me.Close()
End Sub
Private Sub OnButtonCancelClicked(sender As Object, e As RoutedEventArgs)
 Me.DialogResult = False
 Me.Close()
End Sub
' #endregion
End Class
