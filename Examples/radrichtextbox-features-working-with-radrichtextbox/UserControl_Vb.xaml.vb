Public Class Default_Vb


    ' #region radrichtextbox-features-working-with-radrichtextbox_4
    Private Sub radRichTextBox_CurrentSpanStyleChanged(sender As Object, e As EventArgs)
        Dim style As StyleDefinition = Me.radRichTextBox.CurrentEditingStyle
        Dim fontWeight As FontWeight = style.SpanProperties.FontWeight
        Me.BoldButton.IsChecked = fontWeight = FontWeights.Bold
    End Sub
    ' #endregion
End Class
