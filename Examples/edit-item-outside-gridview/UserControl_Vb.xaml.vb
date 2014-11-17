Public Class Default_Vb


' #region edit-item-outside-gridview_1
Dim selectedItem As Club = TryCast(Me.clubsGrid.SelectedItem, Club)
Me.clubsGrid.Items.EditItem(selectedItem)
' #endregion

' #region edit-item-outside-gridview_3
selectedItem.Name = "new Name of the item"
Me.clubsGrid.Items.CommitEdit()
' #endregion
End Class
