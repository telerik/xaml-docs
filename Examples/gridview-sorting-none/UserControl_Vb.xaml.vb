Public Class Default_Vb


' #region gridview-sorting-none_1
Private Sub clubsGrid_Sorting(sender As Object, e As GridViewSortingEventArgs)
 If e.NewSortingState = SortingState.None Then
  e.NewSortingState = SortingState.Ascending
 End If
End Sub
' #endregion
End Class
