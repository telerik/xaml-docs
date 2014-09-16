Public Class Default_Vb


' #region common-styling-apperance-setting-theme-wpf_2
StyleManager.SetTheme(radSlider, New VistaTheme())
' #endregion

' #region common-styling-apperance-setting-theme-wpf_5
StyleManager.ApplicationTheme = New VistaTheme()
' #endregion

' #region common-styling-apperance-setting-theme-wpf_7
Public Partial Class Window1
    Inherits Window
    Public Sub New()
        StyleManager.ApplicationTheme = New VistaTheme()
        InitializeComponent()
    End Sub
End Class
' #endregion
End Class
