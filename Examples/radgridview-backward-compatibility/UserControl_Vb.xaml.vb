Public Class Default_Vb

#Region "radgridview-backward-compatibility_1"
    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
    Dim ageColumnFilter As New ColumnFilterDescriptor(ageColumn)
    ' ...
    ageColumnFilter.DistinctFilter.DistinctValues.Add(5)
    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
    ageColumnFilter.FieldFilter.Filter1.Value = 10
    ' ...
    Me.radGridView.FilterDescriptors.Add(ageColumnFilter)
#End Region

#Region "radgridview-backward-compatibility_3"
    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
    ' Getting it from the property will create it and associate it with its column automatically.
    Dim ageColumnFilter As IColumnFilterDescriptor = ageColumn.ColumnFilterDescriptor
    ageColumnFilter.SuspendNotifications()
    ' ...
    ageColumnFilter.DistinctFilter.AddDistinctValue(5)
    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
    ageColumnFilter.FieldFilter.Filter1.Value = 10
    ' ...
    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
    ageColumnFilter.ResumeNotifications()
#End Region

#Region "radgridview-backward-compatibility_5"
    Me.radGridView.FilterDescriptors.Remove(columnFilterDescriptor)
#End Region

#Region "radgridview-backward-compatibility_7"
    ' Calling ClearFilter will automatically remove filter descriptor from the grid.
    myColumn.ClearFilters()
#End Region

#Region "radgridview-backward-compatibility_9"
    Me.radGridView.FilterDescriptors.Clear()
#End Region

#Region "radgridview-backward-compatibility_11"
    Me.radGridView.FilterDescriptors.SuspendNotifications()
    For Each column As var In Me.radGridView.Columns
	    column.ClearFilters()
    Next
    Me.radGridView.FilterDescriptors.ResumeNotifications()
    End Class
#End Region
