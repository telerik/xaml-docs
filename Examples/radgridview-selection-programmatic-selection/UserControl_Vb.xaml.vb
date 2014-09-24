Public Class Default_Vb


' #region radgridview-selection-programmatic-selection_1
Dim e As Employee = TryCast(Me.radGridView.SelectedItem, Employee)
' #endregion

' #region radgridview-selection-programmatic-selection_3
Me.radGridView.SelectedItem = (DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee))).First()
' #endregion

' #region radgridview-selection-programmatic-selection_5
Me.radGridView.CurrentItem = (DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee))).First()
' #endregion

' #region radgridview-selection-programmatic-selection_7
Public Sub DeselectItem(itemToDeselect As Object)
 Me.radGridView.SelectedItems.Remove(itemToDeselect)
End Sub
Public Sub SelectItem(itemToSelect As Object)
 Me.radGridView.SelectedItems.Add(itemToSelect)
End Sub
' #endregion

' #region radgridview-selection-programmatic-selection_9
    Private cellToSelect As New GridViewCellInfo(item, column, Me.radGridView)
    Public Sub SelectCell(cellToSelect As GridViewCellInfo)
        Me.radGridView.SelectedCells.Add(cellToSelect)
    End Sub
    Public Sub DeselectCell(cellToSelect As GridViewCellInfo)
        Me.radGridView.SelectedCells.Remove(cellToSelect)
    End Sub
' #endregion

' #region radgridview-selection-programmatic-selection_11
Me.radGridView.SelectAll()
' #endregion

' #region radgridview-selection-programmatic-selection_13
Me.radGridView.SelectedItem = Nothing
' #endregion

' #region radgridview-selection-programmatic-selection_15
Me.radGridView.SelectedItems.Clear()
' #endregion
End Class
