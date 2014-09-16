Public Class Default_Vb


' #region radwindow-using-alert_1
1. RadWindow.Alert(Dim dialogParameters As DialogParameters)
2. RadWindow.Alert(Dim content As object)
3. RadWindow.Alert(Dim content As object,Dim closed As EventHandler(Of WindowClosedEventArgs))
' #endregion

' #region radwindow-using-alert_3
Public Sub Alert()
        RadWindow.Alert(New DialogParameters _
                        With {.Header = "Alert Message", _
                              .Closed = New EventHandler(Of WindowClosedEventArgs)(AddressOf OnWindowClosed), _
                              .Opened = New EventHandler(AddressOf OnWindowOpened), _
                              .Content = "Are you sure you want to do this?", _
                              .OkButtonContent = "Yes", _
                              .CancelButtonContent = "No"})
    End Sub
    Private Sub OnWindowClosed(ByVal sender As Object, ByVal e As WindowClosedEventArgs)
        RadWindow.Alert(String.Format("DialogResult: {0}, PromptResult: {1}", e.DialogResult, e.PromptResult))
    End Sub
    Private Sub OnWindowOpened(ByVal sender As Object, ByVal e As EventArgs)
        Dim window As RadWindow = sender
        window.DialogResult = True
        window.Close()
    End Sub
' #endregion
End Class
