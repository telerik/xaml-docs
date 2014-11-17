Public Class Default_Vb


' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_2
Private Sub ExpandTreeViewItem()
    radTreeViewItem.IsExpanded = True
End Sub
Private Sub CollapseTreeViewItem()
    radTreeViewItem.IsExpanded = False
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_4
Private Sub ExpandAllTreeViewItems()
    radTreeView.ExpandAll()
End Sub
Private Sub CollapseAllTreeViewItems()
    radTreeView.CollapseAll()
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_7
radTreeView.IsSingleExpandPath = true
' #endregion

' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_10
Private Sub ExpandItemByPath()
    Dim path As String = "Sport Categories|Cycling|Indoor Cycling"
    radTreeView.ExpandItemByPath(path, "|")
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_12
Private Sub ExpandItemByPath()
    Dim path As String = "Sport Categories|Cycling|Indoor Cycling"
    radTreeView.PathSeparator = "|"
    radTreeView.ExpandItemByPath( path )
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_16
Private Sub ExpandOnSingleClick()
    radTreeView.IsExpandOnSingleClickEnabled = True
End Sub Private Sub ExpandOnDoubleClick()
    radTreeView.IsExpandOnDblClickEnabled = True
End Sub
' #endregion
End Class
