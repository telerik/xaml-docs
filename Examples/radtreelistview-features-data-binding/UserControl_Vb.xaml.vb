Public Class Default_Vb


' #region radtreelistview-features-data-binding_1
Me.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData()
' #endregion
End Class
