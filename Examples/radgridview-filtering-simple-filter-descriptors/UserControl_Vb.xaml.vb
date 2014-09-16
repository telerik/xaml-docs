Public Class Default_Vb


' #region radgridview-filtering-simple-filter-descriptors_3
Dim descriptor As New FilterDescriptor()
descriptor.Member = "Country"
descriptor.Operator = FilterOperator.IsEqualTo
descriptor.Value = "Germany"
descriptor.IsCaseSensitive = True
' #endregion

' #region radgridview-filtering-simple-filter-descriptors_6
Me.radGridView.FilterDescriptors.Add(descriptor)
' #endregion
End Class
