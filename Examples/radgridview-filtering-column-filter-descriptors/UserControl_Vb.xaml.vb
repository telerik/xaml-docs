Public Class Default_Vb


' #region radgridview-filtering-column-filter-descriptors_1
Dim columnDescriptor As New ColumnFilterDescriptor(DirectCast(Me.radGridView.Columns("CityColumn"), IDataFieldDescriptor))
columnDescriptor.DistinctFilter.DistinctValues.Add("Berlin")
columnDescriptor.DistinctFilter.DistinctValues.Add("Aachen")
Me.radGridView.FilterDescriptors.Add(columnDescriptor)
' #endregion

' #region radgridview-filtering-column-filter-descriptors_3
Dim columnDescriptor As New ColumnFilterDescriptor(DirectCast(Me.radGridView.Columns("CityColumn"), IDataFieldDescriptor))
columnDescriptor.FieldFilter.Filter1.[Operator] = FilterOperator.IsEqualTo
columnDescriptor.FieldFilter.Filter1.Value = "Berlin"
columnDescriptor.FieldFilter.LogicalOperator = FilterCompositionLogicalOperator.Or
columnDescriptor.FieldFilter.Filter2.[Operator] = FilterOperator.IsEqualTo
columnDescriptor.FieldFilter.Filter2.Value = "Aachen"
Me.radGridView.FilterDescriptors.Add(columnDescriptor)
' #endregion

' #region radgridview-filtering-column-filter-descriptors_5
Dim citiesDescriptor As New ColumnFilterDescriptor(DirectCast(Me.radGridView.Columns("CityColumn"), IDataFieldDescriptor))
citiesDescriptor.DistinctFilter.DistinctValues.Add("Berlin")
citiesDescriptor.DistinctFilter.DistinctValues.Add("Aachen")
Me.radGridView.FilterDescriptors.Add(citiesDescriptor)
Dim countryDescriptor As New ColumnFilterDescriptor(DirectCast(Me.radGridView.Columns("CountryColumn"), IDataFieldDescriptor))
countryDescriptor.DistinctFilter.DistinctValues.Add("Germany")
Me.radGridView.FilterDescriptors.Add(countryDescriptor
' #endregion
End Class
