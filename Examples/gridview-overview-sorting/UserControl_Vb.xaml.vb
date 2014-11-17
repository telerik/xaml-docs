Public Class Default_Vb


' #region gridview-overview-sorting_3
Dim descriptor As New SortDescriptor()
descriptor.Member = "EmployeeID"
descriptor.SortDirection = ListSortDirection.Ascending
Me.radGridView.SortDescriptors.Add(descriptor)
' #endregion
End Class
