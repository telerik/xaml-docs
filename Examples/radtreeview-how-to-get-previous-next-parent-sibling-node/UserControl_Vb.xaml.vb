Public Class Default_Vb


' #region radtreeview-how-to-get-previous-next-parent-sibling-node_3
Private Sub radTreeView_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
    ' Get a reference to the treeview
    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
    ' Get the currently selected items
    Dim selectedItems As ObservableCollection(Of [Object]) = treeView.SelectedItems
    Dim item As RadTreeViewItem = TryCast(selectedItems(0), RadTreeViewItem)
End Sub
' #endregion

' #region radtreeview-how-to-get-previous-next-parent-sibling-node_5
Private Sub radTreeView_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
    ' Get a reference to the treeview
    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
    ' Get the currently selected items
    Dim selectedItems As ObservableCollection(Of [Object]) = treeView.SelectedItems
    Dim item As RadTreeViewItem = TryCast(selectedItems(0), RadTreeViewItem)
    ' Get the previous item and the previous sibling item
    Dim previousItem As RadTreeViewItem = item.PreviousItem
    Dim previousSiblingItem As RadTreeViewItem = item.PreviousSiblingItem
End Sub
' #endregion

' #region radtreeview-how-to-get-previous-next-parent-sibling-node_9
Private Sub radTreeView_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
    ' Get a reference to the treeview
    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
    ' Get the currently selected items
    Dim selectedItems As ObservableCollection(Of [Object]) = treeView.SelectedItems
    Dim item As RadTreeViewItem = TryCast(selectedItems(0), RadTreeViewItem)
    ' Get the previous item and the previous sibling item
    Dim previousItem As RadTreeViewItem = item.PreviousItem
    Dim previousSiblingItem As RadTreeViewItem = item.PreviousSiblingItem
    ' Get the next item and the next sibling item
    Dim nextItem As RadTreeViewItem = item.NextItem
    Dim nextSiblingItem As RadTreeViewItem = item.NextSiblingItem
    ' Get the parent item and the root item
    Dim parentItem As RadTreeViewItem = item.ParentItem
    Dim rootItem As RadTreeViewItem = item.RootItem
End Sub
' #endregion
End Class
