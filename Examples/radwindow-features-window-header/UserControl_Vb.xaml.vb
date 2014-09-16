Public Class Default_Vb


' #region radwindow-features-window-header_1
Dim radWindow As New RadWindow()
radWindow.Header = "My RadWindow"
' #endregion

' #region radwindow-features-window-header_4
Dim radWindow As New RadWindow()
radWindow.HeaderTemplate = TryCast(Me.Resources("WindowHeaderTemplate"), DataTemplate)
' #endregion
End Class
