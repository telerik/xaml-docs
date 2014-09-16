Public Class Default_Vb


' #region gridview-sorting-basics_4
Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
    e.Cancel = True
End Sub
' #endregion

' #region gridview-sorting-basics_6
Private previousColumn As GridViewColumn
Private Sub radGridView_Sorted(ByVal sender As Object, ByVal e As GridViewSortedEventArgs)
    If Me.previousColumn IsNot Nothing Then
        Me.previousColumn.Background = New SolidColorBrush(Colors.Transparent)
    End If
    e.Column.Background = New SolidColorBrush(Colors.Green)
    Me.previousColumn = e.Column
End Sub
' #endregion
End Class
