Public Class Default_Vb

    ' #region gridview-checkbox-column-clicks_3
    Private Sub gridView_AutoGeneratingColumn(sender As Object, e As GridViewAutoGeneratingColumnEventArgs)
        Dim dataColumn = TryCast(e.Column, GridViewDataColumn)
        If dataColumn IsNot Nothing Then
            If dataColumn.UniqueName.ToString() = "IsChampion" Then
                ' create GridViewCheckBoxColumn
                Dim newColumn As New GridViewCheckBoxColumn()
                newColumn.DataMemberBinding = dataColumn.DataMemberBinding
                newColumn.Header = dataColumn.Header
                newColumn.UniqueName = dataColumn.UniqueName
                newColumn.EditTriggers = Telerik.Windows.Controls.GridView.GridViewEditTriggers.CellClick
                newColumn.AutoSelectOnEdit = True
                e.Column = newColumn
            End If
        End If
    End Sub
    ' #endregion

End Class
