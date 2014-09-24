Public Class Default_Vb


' #region radgridview-filtering-composite-filter-descriptors_2
Dim compositeDescriptor As New CompositeFilterDescriptor()
compositeDescriptor.LogicalOperator = FilterCompositionLogicalOperator.[Or]
compositeDescriptor.FilterDescriptors.Add(New FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin", False))
compositeDescriptor.FilterDescriptors.Add(New FilterDescriptor("City", FilterOperator.IsEqualTo, "Aachen", False))
Me.radGridView.FilterDescriptors.Add(compositeDescriptor)
' #endregion

' #region radgridview-filtering-composite-filter-descriptors_5
Dim compositeDescriptor As New CompositeFilterDescriptor()
compositeDescriptor.LogicalOperator = FilterCompositionLogicalOperator.[And]
Dim citiesDescriptor As New CompositeFilterDescriptor()
citiesDescriptor.LogicalOperator = FilterCompositionLogicalOperator.[Or]
citiesDescriptor.FilterDescriptors.Add(New FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin", False))
citiesDescriptor.FilterDescriptors.Add(New FilterDescriptor("City", FilterOperator.IsEqualTo, "Aachen", False))
Dim descriptor As New FilterDescriptor()
descriptor.Member = "Country"
descriptor.[Operator] = FilterOperator.IsEqualTo
descriptor.Value = "Germany"
compositeDescriptor.FilterDescriptors.Add(citiesDescriptor)
compositeDescriptor.FilterDescriptors.Add(descriptor)
Me.radGridView.FilterDescriptors.Add(compositeDescriptor)
' #endregion
End Class
