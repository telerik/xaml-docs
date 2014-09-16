Public Class Default_Vb


' #region gridview-programmatic-grouping_1
Dim descriptor As New GroupDescriptor()
descriptor.Member = "Country"
descriptor.SortDirection = ListSortDirection.Ascending
' #endregion

' #region gridview-programmatic-grouping_5
Me.radGridView.GroupDescriptors.Add(descriptor)
' #endregion

' #region gridview-programmatic-grouping_8
Dim descriptor As New GroupDescriptor()
descriptor.Member = "Country"
descriptor.SortDirection = ListSortDirection.Ascending
descriptor.DisplayContent = "Country Group"
' #endregion

' #region gridview-programmatic-grouping_10
Me.clubsGrid.GroupDescriptors.Add(New ColumnGroupDescriptor() With { _
 .Column = Me.clubsGrid.Columns("Name"), _
 .SortDirection = ListSortDirection.Descending _
})
' #endregion
End Class
