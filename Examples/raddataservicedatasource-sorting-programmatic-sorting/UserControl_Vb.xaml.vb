Public Class Default_Vb


' #region raddataservicedatasource-sorting-programmatic-sorting_1
Dim sd As New SortDescriptor()
sd.Member = "ContactTitle"
sd.SortDirection = ListSortDirection.Descending
Me.customersDataSource.SortDescriptors.Add(sd)
' #endregion
End Class
