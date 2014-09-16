Public Class Default_Vb


' #region radtreeview-feautres-treeviewitem-item-editing_3
Private Sub EnableTreeViewForEdit()
    radTreeView.IsEditable = True
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-editing_5
Private Sub StartEdit()
    radTreeViewItemFutsal.IsInEditMode = True
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-editing_7
Private Sub EndEdit()
    radTreeViewItemFutsal.IsInEditMode = False
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-editing_9
Private Sub CancelEdit()
    radTreeViewItemFutsal.CancelEdit()
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-editing_12
Private Sub radTreeView_PreviewEditStarted(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
    Dim targetItem As RadTreeViewItem = TryCast(e.Source, RadTreeViewItem)
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-editing_14
Private Sub radTreeView_Edited(ByVal sender As Object, ByVal e As RadTreeViewItemEditedEventArgs)
    TryCast(e.Source, RadTreeViewItem).Background = New SolidColorBrush(Colors.Red)
End Sub
' #endregion
End Class
