'#region radpivotgrid-features-queryable-sort_1
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending

Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
freightCountryGroupDescription.PropertyName = "ShipCountry"
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending

Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
orderDateCountryGroupDescription.PropertyName = "OrderDate"
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
'#endregion

'#region radpivotgrid-features-queryable-sort_2
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
shipCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}

Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
freightCountryGroupDescription.PropertyName = "Freight"
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
freightCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}

Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
orderDateCountryGroupDescription.PropertyName = "OrderDate"
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
orderDateCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
'#endregion

'#region radpivotgrid-features-queryable-sort_3
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None

Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
freightCountryGroupDescription.PropertyName = "ShipCountry"
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None

Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
orderDateCountryGroupDescription.PropertyName = "OrderDate"
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
'#endregion