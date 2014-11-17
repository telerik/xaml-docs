Public Class Default_Vb


' #region raddocking-theming-radpane-group_4
Public Sub New()
    InitializeComponent()
    StyleManager.SetTheme(Me.radDocking, New Theme(New Uri("/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative)))
End Sub
' #endregion
End Class
