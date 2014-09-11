#region radpivotgrid-features-aggregates_1
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.PropertyName = "Price";
aggregate.AggregateFunction = AggregateFunctions.StdDevP;
#endregion