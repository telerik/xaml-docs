Public Class Default_Vb


' #region radwindow-using-user-control-with-radwindow_2
Imports Telerik.Windows.Controls
Partial Public Class RadWindowTest
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub OnBtnOkClicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim parent As RadWindow = RadWindow.GetParentRadWindow(Me)
        parent.PromptResult = datePicker.SelectedDate.ToString()
        parent.DialogResult = True
        parent.Close()
    End Sub
    Private Sub OnBtnCancelClicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim parent As RadWindow = RadWindow.GetParentRadWindow(Me)
        parent.DialogResult = False
        parent.Close()
    End Sub
End Class
' #endregion

' #region radwindow-using-user-control-with-radwindow_5
Private Sub ShowWindow()
        AddHandler window.Closed, AddressOf OnWindowClosed
        window.Close()
    End Sub
    Private Sub OnWindowClosed(ByVal sender As Object, ByVal e As WindowClosedEventArgs)
        RadWindow.Alert(e.PromptResult)
    End Sub
' #endregion
End Class
