Public Class Default_Vb


' #region raddataservicedatasource-filtering-programmatic-filtering_1
Dim fd As New FilterDescriptor("PostalCode", FilterOperator.IsEqualTo, 1010)
Me.radDataServiceDataSource.FilterDescriptors.Add(fd)
' #endregion

' #region raddataservicedatasource-filtering-programmatic-filtering_3
Dim cfd As New CompositeFilterDescriptor()
cfd.LogicalOperator = FilterCompositionLogicalOperator.[Or]
Dim f1 As New FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin")
cfd.FilterDescriptors.Add(f1)
Dim f2 As New FilterDescriptor("City", FilterOperator.IsEqualTo, "Madrid")
cfd.FilterDescriptors.Add(f2)
Me.radDataServiceDataSource.FilterDescriptors.Add(cfd)
' #endregion
End Class
