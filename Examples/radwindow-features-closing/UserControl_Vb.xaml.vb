Public Class Default_Vb


' #region radwindow-features-closing_1
Dim radWindow As New RadWindow()
radWindow.Show()
...
radWindow.Close()
' #endregion

' #region radwindow-features-closing_3
Dim radWindow As New RadWindow()
radWindow.CanClose = False
' #endregion
End Class
