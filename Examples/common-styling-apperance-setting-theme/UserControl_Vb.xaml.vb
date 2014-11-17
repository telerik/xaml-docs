Public Class Default_Vb


' #region common-styling-apperance-setting-theme_2
StyleManager.SetTheme(radSlider, New VistaTheme())
' #endregion

' #region common-styling-apperance-setting-theme_4
StyleManager.ApplicationTheme = New VistaTheme()
' #endregion

' #region common-styling-apperance-setting-theme_6
Public Partial Class MainPage
    Inherits UserControl
    Public Sub New()
        StyleManager.ApplicationTheme = New VistaTheme()
        InitializeComponent()
    End Sub
End Class
' #endregion

' #region common-styling-apperance-setting-theme_8
Telerik.Windows.Controls.StyleManager.ApplicationTheme = New Theme(Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative))
' #endregion

' #region common-styling-apperance-setting-theme_10
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region common-styling-apperance-setting-theme_12
<ThemeLocation(ThemeLocation.BuiltIn)> _
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region common-styling-apperance-setting-theme_14
Public Sub New()
    Me.Source = New Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative)
End Sub
' #endregion
End Class
