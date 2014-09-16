Public Class Default_Vb


' #region gridview-how-to-get-data-from-row_1
Private Sub Button2_Click(sender As Object, e As RoutedEventArgs)
 Dim club As Club = TryCast(Me.clubsGrid.SelectedItem, Club)
 Dim message As String = String.Format("Name: {0} " & vbLf & " Established: {1} " & vbLf & " Capacity: {2}", club.Name, club.Established, club.StadiumCapacity)
 MessageBox.Show(message)
End Sub
' #endregion

' #region gridview-how-to-get-data-from-row_3
Private Sub clubsGrid_RowActivated(sender As Object, e As Telerik.Windows.Controls.GridView.RowEventArgs)
 Dim row = TryCast(e.Row, GridViewRow)
 Dim club As Club = TryCast(row.Item, Club)
 Dim message As String = String.Format("Name: {0} " & vbLf & " Established: {1} " & vbLf & " Capacity: {2}", club.Name, club.Established, club.StadiumCapacity)
 MessageBox.Show(message)
End Sub
' #endregion
End Class
