#region radpivotgrid-features-calculations_1
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new DifferenceFrom() { Axis = PivotAxis.Rows, Level = 0, GroupName = "Pen" };
#endregion

#region radpivotgrid-features-calculations_2
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new DifferenceFromNext() { Axis = PivotAxis.Rows, Level = 0 };
#endregion

#region radpivotgrid-features-calculations_3
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new PercentDifferenceFrom() { Axis = PivotAxis.Rows, Level = 0, GroupName = "Pen" };
#endregion

#region radpivotgrid-features-calculations_4
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new Index();
#endregion

#region radpivotgrid-features-calculations_5
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new RunningTotalsIn() { Axis = PivotAxis.Rows, Level = 0 };
#endregion

#region radpivotgrid-features-calculations_6
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new PercentRunningTotalsIn() { Axis = PivotAxis.Rows, Level = 0};
#endregion

#region radpivotgrid-features-calculations_7
PropertyAggregateDescription aggregate = new PropertyAggregateDescription();
aggregate.AggregateFunction = AggregateFunctions.Sum;
aggregate.PropertyName = "Price";
aggregate.TotalFormat = new RankTotals() { Axis = PivotAxis.Rows, Level = 0};
#endregion