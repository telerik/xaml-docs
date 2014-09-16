#region radpivotgrid-data-local_1
LocalDataSourceProvider localDataProvider = new LocalDataSourceProvider();
this.radPivotGrid1.DataProvider = localDataProvider;
this.radPivotFieldList1.DataProvider = localDataProvider;
#endregion

#region radpivotgrid-data-local_2
LocalDataSourceProvider localDataProvider = new LocalDataSourceProvider();
localDataProvider.ItemsSource = MyCollection;
this.radPivotGrid1.DataProvider = localDataProvider;
this.radPivotFieldList1.DataProvider = localDataProvider;
#endregion

#region radpivotgrid-data-local_3
Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propertyGroupDescription.PropertyName = "Name";
DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.Step = DateTimeStep.Month;

using (localDataProvider.DeferRefresh())
{
    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription);
    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription);
};
#endregion

#region radpivotgrid-data-local_4
DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
doubleGroupDescription.PropertyName = "Price";
localDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription);
#endregion

#region radpivotgrid-data-local_5
PropertyAggregateDescription propertyAggregateDescription1 = new PropertyAggregateDescription();
propertyAggregateDescription1.PropertyName = "Price";
propertyAggregateDescription1.StringFormat = "C";
propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average;

PropertyAggregateDescription propertyAggregateDescription2 = new PropertyAggregateDescription();
propertyAggregateDescription2.PropertyName = "Quantity";

using (localDataProvider.DeferRefresh())
{
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1);
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2);
};
#endregion

#region radpivotgrid-data-local_6
TextCondition txtCondition = new TextCondition();
txtCondition.Comparison = TextComparison.BeginsWith;
txtCondition.Pattern = "N";

PropertyFilterDescription filterDescription = new PropertyFilterDescription();
filterDescription.PropertyName = "Name";
filterDescription.Condition = txtCondition;
localDataProvider.FilterDescriptions.Add(filterDescription);
#endregion