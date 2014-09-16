Public Class Default_Vb


' #region common-styling-apperance-setting-theme_2
StyleManager.SetTheme(radSlider, New VistaTheme())
' #endregion

' #region common-styling-apperance-setting-theme_4
Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
    Me.RootVisual = New MainPage()
End Sub
' #endregion

' #region common-styling-apperance-setting-theme_6
StyleManager.ApplicationTheme = New VistaTheme()
' #endregion

' #region common-styling-apperance-setting-theme_8
Public Partial Class MainPage
    Inherits UserControl
    Public Sub New()
        StyleManager.ApplicationTheme = New VistaTheme()
        InitializeComponent()
    End Sub
End Class
' #endregion

' #region common-styling-apperance-setting-theme_10
Public Partial Class App
    Inherits Application
    Public Sub New()
        AddHandler Startup, AddressOf Me.Application_Startup
        AddHandler [Exit], AddressOf Me.Application_Exit
        AddHandler UnhandledException, AddressOf Me.Application_UnhandledException
        StyleManager.ApplicationTheme = New VistaTheme()
        InitializeComponent()
    End Sub
End Class
' #endregion

' #region common-styling-apperance-setting-theme_12
Telerik.Windows.Controls.StyleManager.ApplicationTheme = New Theme(Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative))
' #endregion

' #region common-styling-apperance-setting-theme_14
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region common-styling-apperance-setting-theme_16
<ThemeLocation(ThemeLocation.BuiltIn)> _
Public Class CustomTheme
    Inherits Telerik.Windows.Controls.Theme
End Class
' #endregion

' #region common-styling-apperance-setting-theme_18
Public Sub New()
    Me.Source = New Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative)
End Sub
' #endregion
End Class
