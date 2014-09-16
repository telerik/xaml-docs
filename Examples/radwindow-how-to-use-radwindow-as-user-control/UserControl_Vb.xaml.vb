Public Class Default_Vb


' #region radwindow-how-to-use-radwindow-as-user-control_2
Public Partial Class RadWindowControl
 Inherits RadWindow
 Public Sub New()
  InitializeComponent()
 End Sub
End Class
' #endregion

' #region radwindow-how-to-use-radwindow-as-user-control_4
Dim window As New RadWindowControl()
window.Show()
' #endregion
End Class
