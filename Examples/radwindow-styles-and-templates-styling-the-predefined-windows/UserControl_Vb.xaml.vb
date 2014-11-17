Public Class Default_Vb


' #region radwindow-styles-and-templates-styling-the-predefined-windows_1
Dim parameters As New DialogParameters()
parameters.ContentStyle = TryCast(Me.Resources("RadAlertStyle"), Style)
parameters.Content = "Hello"
RadWindow.Alert(parameters)
' #endregion
End Class
