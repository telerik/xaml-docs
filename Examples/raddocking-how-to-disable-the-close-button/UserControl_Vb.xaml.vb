Public Class Default_Vb


' #region raddocking-how-to-disable-the-close-button_3
Private Sub HideTheCloseButton()
    radPane.CanUserClose = False
End Sub
' #endregion

' #region raddocking-how-to-disable-the-close-button_6
Private Sub radDocking_PreviewClose(ByVal sender As Object, ByVal e As StateChangeEventArgs)
    e.Handled = True
End Sub
' #endregion
End Class
