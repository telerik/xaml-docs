Public Class Default_Vb
    ' #region gridview-styling-editors_4
    Private Sub clubsGrid_FieldFilterEditorCreated(sender As Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
        If e.Column.UniqueName = "StadiumCapacity" Then
            Dim txtBox As TextBox = TryCast(e.Editor, TextBox)
            If txtBox IsNot Nothing Then
                txtBox.Background = New SolidColorBrush(Colors.Yellow)
            End If
        End If
    End Sub
    ' #endregion
End Class
