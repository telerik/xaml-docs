#region radpivotgrid-features-queryable-sort_1
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;

var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
freightCountryGroupDescription.PropertyName = "ShipCountry";
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;

var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
orderDateCountryGroupDescription.PropertyName = "OrderDate";
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
#endregion

#region radpivotgrid-features-queryable-sort_2
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
shipCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };

var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
freightCountryGroupDescription.PropertyName = "Freight";
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
freightCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };

var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
orderDateCountryGroupDescription.PropertyName = "OrderDate";
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
orderDateCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
#endregion

#region radpivotgrid-features-queryable-sort_3
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;

var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
freightCountryGroupDescription.PropertyName = "ShipCountry";
freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;

var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
orderDateCountryGroupDescription.PropertyName = "OrderDate";
orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
#endregion