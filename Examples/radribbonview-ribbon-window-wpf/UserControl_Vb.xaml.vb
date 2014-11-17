Public Class Default_Vb


' #region radribbonview-ribbon-window-wpf_2
Public Partial Class MainWindow
	Inherits RadRibbonWindow
	Public Sub New()
		InitializeComponent()
	End Sub
End Class
' #endregion
End Class


#Region "radribbonview-ribbon-window-wpf_1"
Partial Public Class MainWindow
	Inherits RadRibbonWindow
	Shared Sub New()
		RadRibbonWindow.IsWindowsThemeEnabled = False
	End Sub
	Public Sub New()
		InitializeComponent()
	End Sub
End Class
#End Region
