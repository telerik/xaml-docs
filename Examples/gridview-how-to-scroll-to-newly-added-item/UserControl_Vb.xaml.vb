Public Class Default_Vb


' #region gridview-how-to-scroll-to-newly-added-item_1
Private Sub clubsGrid_RowEditEnded(sender As Object, e As GridViewRowEditEndedEventArgs)
	If TypeOf e.Row Is GridViewNewRow Then
		Me.clubsGrid.SelectedItem = e.Row.Item
		Me.clubsGrid.ScrollIntoView(Me.clubsGrid.SelectedItem)
	End If
End Sub
' #endregion
End Class
