Public Class Default_Vb


' #region common-styling-apperance-themes-custom-theme-project_3
Imports System
Namespace MyTheme
 Public Class MyTheme
  Inherits Telerik.Windows.Controls.Theme
  Public Sub New()
   Me.Source = New Uri("/MyTheme;component/Themes/Generic.xaml", UriKind.Relative)
  End Sub
 End Class
End Namespace
' #endregion

' #region common-styling-apperance-themes-custom-theme-project_5
Telerik.Windows.Controls.StyleManager.ApplicationTheme = New MyTheme.MyTheme()
' #endregion
End Class
