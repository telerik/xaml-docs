Public Class Default_Vb


' #region gridview-sorting-programmatic_1
Dim descriptor As New SortDescriptor()
descriptor.Member = "Title"
descriptor.SortDirection = ListSortDirection.Ascending
' #endregion

' #region gridview-sorting-programmatic_3
Dim csd As New ColumnSortDescriptor() With { _
 .Column = Me.clubsGrid.Columns("Name"), _
 .SortDirection = ListSortDirection.Descending _
}
Me.clubsGrid.SortDescriptors.Add(csd)
' #endregion

' #region gridview-sorting-programmatic_6
Me.radGridView.SortDescriptors.Add(descriptor)
' #endregion
End Class
