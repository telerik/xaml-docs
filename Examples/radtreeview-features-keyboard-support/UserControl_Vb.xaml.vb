Public Class Default_Vb


' #region radtreeview-features-keyboard-support_2
Private Sub radTreeView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
    MessageBox.Show("The pressed key is: " & e.Key.ToString())
End Sub
Private Sub radTreeView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
    MessageBox.Show("The released key is: " & e.Key.ToString())
End Sub
' #endregion
End Class
