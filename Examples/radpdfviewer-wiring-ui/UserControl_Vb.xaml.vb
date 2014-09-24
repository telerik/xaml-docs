Public Class Default_Vb


    ' #region radpdfviewer-wiring-ui_0
    Private Sub tbCurrentPage_KeyDown(sender As Object, e As System.Windows.Input.KeyEventArgs)
        If e.Key = System.Windows.Input.Key.Enter Then
            Me.tbCurrentPage.GetBindingExpression(TextBox.TextProperty).UpdateSource()
        End If
    End Sub

    Private Sub tbFind_KeyDown(sender As Object, e As System.Windows.Input.KeyEventArgs)
        If e.Key = System.Windows.Input.Key.Enter Then
            Me.pdfViewer.Commands.FindCommand.Execute(Me.tbFind.Text)
            Me.btnPrev.Visibility = System.Windows.Visibility.Visible
            Me.btnNext.Visibility = System.Windows.Visibility.Visible
        End If
    End Sub
    ' #endregion

End Class
