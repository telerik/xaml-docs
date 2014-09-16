Public Class Default_Vb


' #region radtabcontrol-features-keyboard-support_2
Private Sub tabControl_KeyDown( ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs)
    MessageBox.Show("The pressed key is: " + e.Key.ToString())
End Sub
Private Sub tabControl_KeyUp( ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs)
    MessageBox.Show("The released key is: " + e.Key.ToString())
End Sub
' #endregion
End Class
