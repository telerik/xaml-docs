Public Class Default_Vb


' #region radgridview-how-to-implement-selection-outside-radgridview_2
Dim source As ObservableCollection(Of Employee) = RadGridViewSampleData.GetEmployees()
Me.radGridView.ItemsSource = source
Me.listBox.ItemsSource = source
' #endregion

' #region radgridview-how-to-implement-selection-outside-radgridview_6
Private Sub listBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
End Sub
' #endregion

' #region radgridview-how-to-implement-selection-outside-radgridview_8
Private Sub listBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
 For Each item As var In e.AddedItems
  Me.radGridView.SelectedItems.Add(item)
 Next
 For Each item As var In e.RemovedItems
  Me.radGridView.SelectedItems.Remove(item)
 Next
End Sub
' #endregion
End Class
