Public Class Default_Vb


' #region radtreeview-feautres-treeviewitem-enable-disable-items_4
Private Sub DisableTreeViewItem()
    radTreeViewItemSoccer.IsEnabled = False
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-enable-disable-items_6
Private Sub DisableTreeView()
    radTreeView.IsEnabled = False
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-enable-disable-items_9
AddHandler Me.radTreeViewItemSoccer.IsEnabledChanged, AddressOf radTreeViewItemSoccer_IsEnabledChanged
' #endregion
End Class
