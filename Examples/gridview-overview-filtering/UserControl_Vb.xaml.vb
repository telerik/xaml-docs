Public Class Default_Vb


' #region gridview-overview-filtering_3
Dim descriptor As New FilterDescriptor()
descriptor.Member = "Country"
descriptor.Operator = FilterOperator.IsEqualTo
descriptor.Value = "Germany"
Me.radGridView.FilterDescriptors.Add(descriptor)
' #endregion
End Class
