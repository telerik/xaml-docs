Public Class Default_Vb


' #region radtreeview-how-to-get-item-by-path_1
Private Sub GetTreeViewItemByPath()
    Dim path As String = "Sport Categories|Football|Soccer"
    Dim targetItem As RadTreeViewItem = radTreeView.GetItemByPath(path, "|")
End Sub
' #endregion

' #region radtreeview-how-to-get-item-by-path_3
Private Sub GetTreeViewItemByPath()
    Dim path As String = "Sport Categories|Football|Soccer"
    radTreeView.PathSeparator = "|"
    Dim targetItem As RadTreeViewItem = radTreeView.GetItemByPath(path)
End Sub
' #endregion
End Class
