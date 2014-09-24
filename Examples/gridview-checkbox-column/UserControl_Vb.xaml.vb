Public Class Default_Vb
    ' #region gridview-checkbox-column_5
    Private Sub RadGridView_PreparingCellForEdit(sender As Object, e As Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs)
        If e.Column.UniqueName = "GridViewCheckBoxColumn" Then
            Dim checkBox = TryCast(e.EditingElement, CheckBox)
            checkBox.Margin = New Thickness(4, 0, -3, 0)
        End If
    End Sub
    ' #endregion

End Class
