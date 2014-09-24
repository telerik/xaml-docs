Public Class Default_Vb


' #region gridview-scroll-item_1
    Me.gridView.ScrollIntoViewAsync(Me.gridView.Items(Me.gridView.Items.Count - 1), Me.gridView.Columns(Me.gridView.Columns.Count - 1), New Action(Of FrameworkElement)(AddressOf SelectRow))
   
    Private Sub SelectRow(f As FrameworkElement)
        TryCast(f, GridViewRow).IsSelected = True
    End Sub
    ' #endregion

    ' #region gridview-scroll-item_3
    Me.clubsGrid.ScrollIndexIntoViewAsync(Me.clubsGrid.Items.Count - 1, Me.clubsGrid.Columns(Me.clubsGrid.Columns.Count - 1), New Action(Of FrameworkElement)(AddressOf SelectRow), Nothing)
    
    Private Sub SelectRow(f As FrameworkElement)
	    TryCast(f, GridViewRow).IsSelected = True
    End Sub
    ' #endregion
End Class
