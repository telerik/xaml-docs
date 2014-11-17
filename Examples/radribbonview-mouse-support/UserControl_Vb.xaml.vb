Public Class Default_Vb


' #region radribbonview-mouse-support_2
radRibbonView.MouseWheel += New MouseWheelEventHandler(radRibbonView_MouseWheel)
' #endregion

' #region radribbonview-mouse-support_4
Private Sub radRibbonView_MouseWheel(sender As Object, e As MouseWheelEventArgs)
	MessageBox.Show("The mouse wheel has changed: " & Convert.ToString(e.Delta))
End Sub
' #endregion
End Class
