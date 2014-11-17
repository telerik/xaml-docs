Public Class Default_Vb


' #region radmaskedinput-features-selection_5
Private Sub radMaskedTextInput_GotFocus(sender As Object, e As RoutedEventArgs)
 radMaskedTextInput.SelectionStart = 2
 radMaskedTextInput.SelectionLength = 2
End Sub
' #endregion
End Class
