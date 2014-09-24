Public Class Default_Vb


' #region radchart-features-filtering_3
Dim descriptor As New ChartFilterDescriptor()
descriptor.Member = "Quantity"
descriptor.[Operator] = FilterOperator.IsLessThanOrEqualTo
descriptor.Value = 150
Me.radChart.FilterDescriptors.Add(descriptor)
' #endregion
End Class
