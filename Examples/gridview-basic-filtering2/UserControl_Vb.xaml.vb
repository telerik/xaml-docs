Public Class Default_Vb


' #region gridview-basic-filtering2_4
Private Sub radGridView_Filtering(ByVal sender As Object, ByVal e As GridViewFilteringEventArgs)
    e.Cancel = True
End Sub
' #endregion

' #region gridview-basic-filtering2_6
Private Sub radGridView_Filtered(ByVal sender As Object, ByVal e As GridViewFilteredEventArgs)
    For Each descriptor As FilterDescriptor In e.Added
        Dim column As GridViewColumn = FilteringGrid.Columns( descriptor.Member )
        column.Background = New SolidColorBrush( Colors.Green )
        Next

    For Each descriptor As FilterDescriptor In e.Removed
        Dim column As GridViewColumn = FilteringGrid.Columns( descriptor.Member )
        column.Background = New SolidColorBrush( Colors.Transparent )
    Next
End Sub
    ' #endregion
    ' #region gridview-basic-filtering2_8
    Private Sub clubsGrid_FilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
        If e.AvailableOperators.Contains(FilterOperator.Contains) Then
            e.DefaultOperator = FilterOperator.Contains
        End If
    End Sub
    ' #endregion
End Class
