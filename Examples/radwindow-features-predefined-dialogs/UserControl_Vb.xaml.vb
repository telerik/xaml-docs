Public Class Default_Vb


' #region radwindow-features-predefined-dialogs_1
Dim parameters As New DialogParameters()
parameters.Content = "Hello"
RadWindow.Alert(parameters)
' #endregion

' #region radwindow-features-predefined-dialogs_3
RadWindow.Alert( "Hello" )
' #endregion

' #region radwindow-features-predefined-dialogs_5
Public Sub ShowAlert()
		RadWindow.Alert("Hello", AddressOf Me.OnClosed)
End Sub
Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
End Sub
' #endregion

' #region radwindow-features-predefined-dialogs_7
Dim parameters As New DialogParameters()
parameters.Content = "Enter your name:"
RadWindow.Prompt(parameters)
' #endregion

' #region radwindow-features-predefined-dialogs_9
Public Sub ShowPrompt()
		RadWindow.Prompt("Enter your name:", AddressOf Me.OnClosed)
End Sub
Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
End Sub
' #endregion

' #region radwindow-features-predefined-dialogs_11
Public Sub SHowPrompt()
		RadWindow.Prompt("Enter your name:", AddressOf Me.OnClosed, "John Doe")
End Sub
Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
End Sub
' #endregion

' #region radwindow-features-predefined-dialogs_13
Dim parameters As New DialogParameters()
parameters.Content = "Are you sure?"
RadWindow.Confirm(parameters)
' #endregion

' #region radwindow-features-predefined-dialogs_15
Public Sub ShowConfirm()
		RadWindow.Confirm("Are you sure?", AddressOf Me.OnClosed)
End Sub
Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
End Sub
' #endregion
End Class
