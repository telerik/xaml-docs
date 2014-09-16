Public Class Default_Vb


' #region gridview-managing-data-updating-entry_1
Me.radGridView.BeginEdit()
' #endregion

' #region gridview-managing-data-updating-entry_4
Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Me.radGridView.BeginEdit()
End Sub
' #endregion

' #region gridview-managing-data-updating-entry_7
Private Sub radGridView_BeginningEdit(ByVal sender As Object, ByVal e As GridViewBeginningEditRoutedEventArgs)
End Sub
' #endregion

' #region gridview-managing-data-updating-entry_9
Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
End Sub
' #endregion

' #region gridview-managing-data-updating-entry_11
Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
    If e.EditAction = GridViewEditAction.Cancel Then
        Exit Sub
    End If
    If e.EditOperationType = GridViewEditOperationType.Edit Then
            'Edit the entry in the data base based on your logic.
    End If
End Sub
' #endregion
End Class
