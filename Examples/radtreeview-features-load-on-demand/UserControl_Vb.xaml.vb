Public Class Default_Vb


' #region radtreeview-features-load-on-demand_3
Private Sub EnableLoadOnDemand(ByVal radTreeViewItem As RadTreeViewItem)
    radTreeViewItem.IsLoadOnDemandEnabled = True
End Sub
' #endregion

' #region radtreeview-features-load-on-demand_6
Private Sub RadTreeViewItem_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    ' get the clicked Item
    Dim clickedItem As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
    ' add the new items
    Dim newItem As New RadTreeViewItem()
    clickedItem.Items.Add(newItem)
End Sub
' #endregion

' #region radtreeview-features-load-on-demand_9
Private Sub radTreeView_LoadOnDemand(sender As Object, e As RadRoutedEventArgs)
 ' get the treeview
 Dim tree As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
 ' get the clicked Item
 Dim clickedItem As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
 ' add the new items
 Dim newItem As New RadTreeViewItem()
 clickedItem.Items.Add(newItem)
 clickedItem.IsLoadOnDemandEnabled = False
End Sub
' #endregion
End Class
