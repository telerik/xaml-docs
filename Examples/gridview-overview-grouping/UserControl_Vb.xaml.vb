Public Class Default_Vb


' #region gridview-overview-grouping_3
Dim descriptor As New GroupDescriptor()
descriptor.Member = "Country"
descriptor.SortDirection = ListSortDirection.Ascending
descriptor.DisplayContent = "Country Group"
Me.radGridView.GroupDescriptors.Add( descriptor )
'You can create and add more descriptors here
' #endregion
End Class
