Public Class Default_Vb


' #region gridview-grouping-aggregates_2
Dim f As New CountFunction()
f.Caption = "Entries Count: "
Dim countryDescriptor As New GroupDescriptor()
countryDescriptor.Member = "Country"
countryDescriptor.SortDirection = ListSortDirection.Ascending
countryDescriptor.AggregateFunctions.Add(f)
Me.radGridView.GroupDescriptors.Add(countryDescriptor)
' #endregion

' #region gridview-grouping-aggregates_5
Dim f As New CountFunction()
f.Caption = "Entries Count: "
Dim f1 As New FirstFunction()
f.Caption = "FirstEntry: "
Dim countryDescriptor As New GroupDescriptor()
countryDescriptor.Member = "Country"
countryDescriptor.SortDirection = ListSortDirection.Ascending
countryDescriptor.AggregateFunctions.Add(f)
countryDescriptor.AggregateFunctions.Add(f1)
Me.radGridView.GroupDescriptors.Add(countryDescriptor)
' #endregion
End Class
