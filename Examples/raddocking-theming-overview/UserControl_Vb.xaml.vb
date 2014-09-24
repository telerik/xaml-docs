Public Class Default_Vb


' #region raddocking-theming-overview_1
Public Sub New()
    InitializeComponent()
    StyleManager.SetTheme(Me.radDocking, New Theme(New Uri("/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative)))
End Sub
' #endregion

' #region raddocking-theming-overview_4
Public Sub New()
    InitializeComponent()
    StyleManager.SetTheme(Me.radDocking, New RadDockingTheme())
End Sub
' #endregion
End Class
