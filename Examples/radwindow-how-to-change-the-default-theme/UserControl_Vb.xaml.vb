Public Class Default_Vb


    ' #region radwindow-how-to-change-the-default-theme_4
Dim newWindow As New RadWindow() With { _
	Key .Width = 300, _
	Key .Height = 300 _
}
newWindow.Show()
' #endregion
End Class
