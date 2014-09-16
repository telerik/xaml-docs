Public Class Default_Vb


' #region radtabcontrol-using-themes_3
Dim theme As New VistaTheme()
Dim radTabControlAs New RadTabControl()
StyleManager.SetTheme(radTabControl, theme)
' #endregion

' #region radtabcontrol-using-themes_5
StyleManager.ApplicationTheme = New VistaTheme()
' #endregion

' #region radtabcontrol-using-themes_7
Dim theme As New VistaTheme()
theme.IsApplicationTheme = True
' #endregion

' #region radtabcontrol-using-themes_10
Dim theme As New Theme(New Uri("PathToMyTheme.xaml", UriKind.RelativeOrAbsolute))
Dim radTabControlAs New RadTabControl()
StyleManager.SetTheme(radTabControl, theme)
' #endregion
End Class
