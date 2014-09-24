Public Class Default_Vb


' #region radwindow-features-window-icon_1
Dim radWindow As New RadWindow()
Dim image As New Image()
image.Source = New BitmapImage(New Uri("../../Images/WindowIcon.png", UriKind.Relative))
radWindow.Icon = image
' #endregion

' #region radwindow-features-window-icon_4
Dim radWindow As New RadWindow()
radWindow.IconTemplate = TryCast(Me.Resources("WindowIconTemplate"), DataTemplate)
' #endregion
End Class
