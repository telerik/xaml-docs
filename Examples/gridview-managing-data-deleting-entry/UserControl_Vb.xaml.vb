Public Class Default_Vb


' #region gridview-managing-data-deleting-entry_2
Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
End Sub
' #endregion

' #region gridview-managing-data-deleting-entry_4
For Each item As Employee In Me.radGridView.SelectedItems
    itemsToRemove.Add(item)
Next
For Each item As Employee In itemsToRemove
    DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee)).Remove(item)
Next
' #endregion

' #region gridview-managing-data-deleting-entry_6
Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    If Me.radGridView.SelectedItems.Count = 0 Then
        Exit Sub
    End If
    Dim itemsToRemove As New ObservableCollection(Of Employee)()
        'Remove the items from the RadGridView
    For Each item In Me.radGridView.SelectedItems
        itemsToRemove.Add(TryCast(item, Employee))
    Next
    For Each item In itemsToRemove
        DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee)).Remove(TryCast(item, Employee))
    Next
End Sub
' #endregion
End Class
