Public Class Default_Vb


' #region radwindow-using-prompt_1
1. RadWindow.Prompt(Dim dialogParameters As DialogParameters)
2. RadWindow.Prompt(Dim content As object,Dim closed As EventHandler(Of WindowClosedEventArgs))
3. RadWindow.Prompt(Dim content As object,Dim closed As EventHandler(Of WindowClosedEventArgs),Dim defaultPromptResult As String)
' #endregion

' #region radwindow-using-prompt_3
Public Sub Prompt()
        RadWindow.Confirm(New DialogParameters _
                        With {.Header = "Prompt Message", _
                              .Closed = New EventHandler(Of WindowClosedEventArgs)(AddressOf OnWindowClosed), _
                              .Opened = New EventHandler(AddressOf OnWindowOpened), _
                              .Content = "How many items do you need?", _
                              .DefaultPromptResultValue = "5", _
                              .OkButtonContent = "Accept", _
                              .CancelButtonContent = "Reject"})
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
