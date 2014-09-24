Public Class Default_Vb


    ' #region radgridview-filtering-icolumn-filter-descriptors_1
    Dim cityColumn As GridViewColumn = Me.playersGrid.Columns("City")
    ' Getting it from the property will create it and associate it with its column automatically.
    Dim columnDescriptor As IColumnFilterDescriptor = cityColumn.ColumnFilterDescriptor
    columnDescriptor.SuspendNotifications()
    columnDescriptor.DistinctFilter.AddDistinctValue("Berlin")
    columnDescriptor.DistinctFilter.AddDistinctValue("Aachen")
    columnDescriptor.ResumeNotifications()
    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
    ' #endregion

    ' #region radgridview-filtering-icolumn-filter-descriptors_3
    Dim cityColumn As GridViewColumn = Me.playersGrid.Columns("City")
    ' Getting it from the property will create it and associate it with its column automatically.
    Dim columnDescriptor As IColumnFilterDescriptor = cityColumn.ColumnFilterDescriptor
    columnDescriptor.SuspendNotifications()
    columnDescriptor.FieldFilter.Filter1.[Operator] = FilterOperator.IsEqualTo
    columnDescriptor.FieldFilter.Filter1.Value = "Berlin"
    columnDescriptor.FieldFilter.LogicalOperator = FilterCompositionLogicalOperator.[Or]
    columnDescriptor.FieldFilter.Filter2.[Operator] = FilterOperator.IsEqualTo
    columnDescriptor.FieldFilter.Filter2.Value = "Aachen"
    columnDescriptor.ResumeNotifications()
    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
    ' #endregion

    ' #region radgridview-filtering-icolumn-filter-descriptors_5
    Dim cityColumn As GridViewColumn = Me.playersGrid.Columns("City")
    ' Getting it from the property will create it and associate it with its column automatically
    Dim cityDescriptor As IColumnFilterDescriptor = cityColumn.ColumnFilterDescriptor
    cityDescriptor.SuspendNotifications()
    cityDescriptor.DistinctFilter.AddDistinctValue("Berlin")
    cityDescriptor.DistinctFilter.AddDistinctValue("Aachen")
    cityDescriptor.ResumeNotifications()

    Dim countryColumn As GridViewColumn = Me.playersGrid.Columns("Country")
    Dim columnDescriptor As IColumnFilterDescriptor = countryColumn.ColumnFilterDescriptor
    columnDescriptor.SuspendNotifications()
    columnDescriptor.DistinctFilter.AddDistinctValue("Germany")
    columnDescriptor.ResumeNotifications()
    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
    ' #endregion
End Class
