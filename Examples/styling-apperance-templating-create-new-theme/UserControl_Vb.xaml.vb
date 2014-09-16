Public Class Default_Vb


' #region styling-apperance-templating-create-new-theme_1
Telerik.Windows.Controls.StyleManager.ApplicationTheme = New Theme(Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative))
' #endregion

' #region styling-apperance-templating-create-new-theme_3
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region styling-apperance-templating-create-new-theme_5
<ThemeLocation(ThemeLocation.BuiltIn)> _
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region styling-apperance-templating-create-new-theme_7
Public Sub New()
    Me.Source = New Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative)
End Sub
' #endregion
End Class
