Public Class Default_Vb


    ' #region radrichtextbox-features-formatting-api_2
    Private Sub BoldButton_Click(sender As Object, e As RoutedEventArgs)
        Me.radRichTextBox.ToggleBold()
    End Sub
    ' #endregion

    ' #region radrichtextbox-features-formatting-api_4
    Me.radRichTextBox.ActiveDocumentEditor.Insert("text")
    ' #endregion

    ' #region radrichtextbox-features-formatting-api_7
    Dim fragment As New DocumentFragment(radDocument)
    ' #endregion

    ' #region radrichtextbox-features-formatting-api_9
    Dim fragment As DocumentFragment = document.Selection.CopySelectedDocumentElements()
    ' #endregion
End Class
