Public Class Default_Vb
    ' #region gridview-filtering-cascading-distinct-values_1
    Private Sub radGridView_DistinctValuesLoading(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
        e.ItemsSource = DirectCast(sender, RadGridView).GetDistinctValues(e.Column, False)
    End Sub
    ' #endregion
End Class
