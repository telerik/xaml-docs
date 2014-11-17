Public Class Default_Vb


' #region gridview-how-to-focus-first-cell-insert_1
Private Sub clubsGrid_AddingNewDataItem(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs)
   Dim grid = e.OwnerGridViewItemsControl
   grid.CurrentColumn = grid.Columns(0)
End Sub
' #endregion
End Class
