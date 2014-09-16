Public Class Default_Vb


' #region gridview-managing-data-add-new-entries_1
Me.AddingNewRowsGrid.BeginInsert()
' #endregion

' #region gridview-managing-data-add-new-entries_4
Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Me.radGridView.BeginInsert()
End Sub
' #endregion

' #region gridview-managing-data-add-new-entries_7
Private Sub radGridView_AddingNewDataItem(ByVal sender As Object, ByVal e As GridViewAddingNewEventArgs)
    e.NewObject = New Employee()
End Sub
' #endregion

' #region gridview-managing-data-add-new-entries_9
Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
End Sub
' #endregion

' #region gridview-managing-data-add-new-entries_11
Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
    If e.EditAction = GridViewEditAction.Cancel Then
        Exit Sub
    End If
    If e.EditOperationType = GridViewEditOperationType.Insert Then
        'Add the new entry to the data base.
    End If
End Sub
    ' #endregion

    '#Region gridview-managing-data-add-new-entries_13
    Private Sub New(sender As Object, e As GridViewAddingNewEventArgs)
        e.Cancel = True
        Dim newRow = Me.dataSource.DefaultView.AddNew()
        newRow("FirstName") = "John"
        newRow("LastName") = "Doe"
        e.NewObject = newRow
    End Sub
    '#End Region
End Class
