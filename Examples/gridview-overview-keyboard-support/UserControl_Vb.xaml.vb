Public Class Default_Vb


' #region gridview-overview-keyboard-support_2
Private Sub radGridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
    MessageBox.Show("The pressed key is: " & e.Key.ToString())
End Sub
Private Sub radGridView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
    MessageBox.Show("The released key is: " & e.Key.ToString())
End Sub
' #endregion
End Class
