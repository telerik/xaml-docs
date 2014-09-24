' #region radpivotgrid-data-local_1
Dim localDataProvider As New LocalDataSourceProvider()
Me.radPivotGrid1.DataProvider = localDataProvider
Me.radPivotFieldList1.DataProvider = localDataProvider
' #endregion

' #region radpivotgrid-data-local_2
Dim localDataProvider As New LocalDataSourceProvider()
localDataProvider.ItemsSource = MyCollection
Me.radPivotGrid1.DataProvider = localDataProvider
Me.radPivotFieldList1.DataProvider = localDataProvider
' #endregion

' #region radpivotgrid-data-local_3
Dim propertyGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propertyGroupDescription.PropertyName = "Name"
Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.Step = DateTimeStep.Month
Using localDataProvider.DeferRefresh()
    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription)
    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription)
End Using
' #endregion

' #region radpivotgrid-data-local_4
Dim doubleGroupDescription As New DoubleGroupDescription()
doubleGroupDescription.PropertyName = "Price"
localDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription)
' #endregion

' #region radpivotgrid-data-local_5
Dim propertyAggregateDescription1 As New PropertyAggregateDescription()
propertyAggregateDescription1.PropertyName = "Price"
propertyAggregateDescription1.StringFormat = "C"
propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average

Dim propertyAggregateDescription2 As New PropertyAggregateDescription()
propertyAggregateDescription2.PropertyName = "Quantity"

Using localDataProvider.DeferRefresh()
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1)
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2)
End Using   
' #endregion

'#region "radpivotgrid-data-local_6"
Dim txtCondition As New TextCondition()
txtCondition.Comparison = TextComparison.BeginsWith
txtCondition.Pattern = "N"

Dim filterDescription As New PropertyFilterDescription()
filterDescription.PropertyName = "Name"
filterDescription.Condition = txtCondition
localDataProvider.FilterDescriptions.Add(filterDescription)
'#endregion