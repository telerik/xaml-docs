Public Class Default_Vb


' #region common-styling-apperance-themes-custom-theme-project-telerik-approach_4
Imports System
Imports Telerik.Windows.Controls
Namespace Silverlight.Help.RadCommon
 <ThemeLocation(ThemeLocation.BuiltIn)> _
 Public Class MyTheme
  Inherits Theme
  Public Sub New()
   Me.Source = New Uri("/MyTheme;component/themes/Generic.xaml", UriKind.RelativeOrAbsolute)
  End Sub
 End Class
End Namespace
' #endregion

' #region common-styling-apperance-themes-custom-theme-project-telerik-approach_6
Telerik.Windows.Controls.StyleManager.ApplicationTheme = New MyTheme.MyTheme()
' #endregion
End Class
