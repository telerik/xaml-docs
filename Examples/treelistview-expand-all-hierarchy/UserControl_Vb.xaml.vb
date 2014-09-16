Public Class Default_Vb


' #region treelistview-expand-all-hierarchy_1
AddHandler treeListView.DataLoaded, AddressOf treeListView_DataLoaded
' #endregion

' #region treelistview-expand-all-hierarchy_3
Private Sub treeListView_DataLoaded(sender As Object, e As EventArgs)
   treeListView.DataLoaded -= treeListView_DataLoaded
   treeListView.ExpandAllHierarchyItems()
End Sub
' #endregion
End Class
