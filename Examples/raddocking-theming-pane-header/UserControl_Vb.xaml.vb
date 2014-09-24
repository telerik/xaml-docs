Public Class Default_Vb


' #region raddocking-theming-pane-header_4
Public Sub New()
    InitializeComponent()
    StyleManager.SetTheme(Me.radDocking, New Theme(New Uri("/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative)))
End Sub
' #endregion
End Class
