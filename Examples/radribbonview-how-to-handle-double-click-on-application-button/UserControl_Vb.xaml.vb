Public Class Default_Vb


' #region radribbonview-keyboard-support_5
Private Sub KeyTipActivation_Activated(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
	MessageBox.Show("The key tip of the " & TryCast(e.OriginalSource, RadRibbonButton).Text.ToString() & "was activated.")
End Sub
Private Sub HomeButton1_Click(sender As Object, e As RoutedEventArgs)
	MessageBox.Show(TryCast(sender, RadRibbonButton).Text.ToString() & "was clicked.")
End Sub
' #endregion
End Class
