Public Class Default_Vb


' #region gridview-multiple-selection_2
Me.radGridView.SelectionMode = System.Windows.Controls.SelectionMode.Extended
' #endregion

' #region gridview-multiple-selection_5
listBoxSelectedItems.ItemsSource = Me.radGridView.SelectedItems
' #endregion
End Class
