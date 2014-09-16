Public Class Default_Vb


' #region gridview-multiple-column-grouping_2
Dim countryDescriptor As New GroupDescriptor()
countryDescriptor.Member = "Country"
countryDescriptor.SortDirection = ListSortDirection.Ascending
Me.radGridView.GroupDescriptors.Add(countryDescriptor)
Dim titleDescriptor As New GroupDescriptor()
titleDescriptor.Member = "Title"
titleDescriptor.SortDirection = ListSortDirection.Ascending
Me.radGridView.GroupDescriptors.Add(titleDescriptor)
' #endregion
End Class
