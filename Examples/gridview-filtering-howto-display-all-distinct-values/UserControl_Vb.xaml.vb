Public Class Default_Vb

' #region gridview-filtering-howto-display-all-distinct-values_0
Private Sub OnRadGridViewDistinctValuesLoading(sender As System.Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
	e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, False)
End Sub
' #endregion

' #region gridview-filtering-howto-display-all-distinct-values_1
Private Sub OnRadGridViewDistinctValuesLoading(sender As System.Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
	e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, True, 15)
End Sub
    ' #endregion

    ' #region gridview-filtering-howto-display-all-distinct-values_2
    Private Sub OnRadGridViewFiltered(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs)
        For Each item As var In e.ColumnFilterDescriptor.DistinctFilter.FilterDescriptors
            item.IsCaseSensitive = False
        Next
    End Sub

    Private Sub OnRadGridViewDistinctValuesLoading(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
        e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, False).OfType(Of String)().[Select](Function(x) x.ToLower()).Distinct()
    End Sub
    ' #endregion
End Class
