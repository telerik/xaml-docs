#region radpivotgrid-data-queryable_1
QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
this.radPivotGrid1.DataProvider = queryableDataProvider;
this.radPivotFieldList1.DataProvider = queryableDataProvider;
#endregion

#region radpivotgrid-data-queryable_2
QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
queryableDataProvider.Source = MyCollection;
this.radPivotGrid1.DataProvider = queryableDataProvider;
this.radPivotFieldList1.DataProvider = queryableDataProvider;
#endregion

#region radpivotgrid-data-queryable_3
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";

var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
freightCountryGroupDescription.PropertyName = "Freight";;

var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
orderDateCountryGroupDescription.PropertyName = "OrderDate";

using (queryableDataProvider.DeferRefresh())
{
    queryableDataProvider.RowGroupDescriptions.Add(shipCountryGroupDescription);
    queryableDataProvider.RowGroupDescriptions.Add(freightCountryGroupDescription);
    queryableDataProvider.RowGroupDescriptions.Add(orderDateCountryGroupDescription);
};
#endregion

#region radpivotgrid-data-queryable_4
QueryableDoubleGroupDescription doubleGroupDescription = new QueryableDoubleGroupDescription();
doubleGroupDescription.PropertyName = "Freight";
queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription);
#endregion

#region radpivotgrid-data-queryable_5
var freightAggregateDescription = new QueryablePropertyAggregateDescription();
freightAggregateDescription.PropertyName = "Freight";
freightAggregateDescription.StringFormat = "C";
freightAggregateDescription.AggregateFunction = QueryableAggregateFunction.Max;

var shipViaAggregateDescription = new QueryablePropertyAggregateDescription();
freightAggregateDescription.PropertyName = "ShipVia";


using (queryableDataProvider.DeferRefresh())
{
    queryableDataProvider.AggregateDescriptions.Add(freightAggregateDescription);
    queryableDataProvider.AggregateDescriptions.Add(shipViaAggregateDescription);
};
#endregion

#region radpivotgrid-data-queryable_6
var freightFilterDescription = new QueryablePropertyFilterDescription();
freightFilterDescription.PropertyName = "Freight";
var intervalCondition = new QueryableIntervalCondition();
intervalCondition.From = 10;
intervalCondition.To = 200;
freightFilterDescription.Condition = intervalCondition;

queryableDataProvider.FilterDescriptions.Add(freightFilterDescription);
#endregion