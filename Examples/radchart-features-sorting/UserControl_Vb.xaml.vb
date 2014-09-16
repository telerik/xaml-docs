Public Class Default_Vb


' #region radchart-features-sorting_3
Dim descriptor As New ChartSortDescriptor()
descriptor.Member = "Title"
descriptor.SortDirection = ListSortDirection.Ascending
Me.radChart.SortDescriptors.Add( descriptor ) )
' #endregion
End Class
