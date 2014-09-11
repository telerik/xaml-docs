' #region radpivotgrid-data-queryable_1
Dim queryableDataProvider As New QueryableDataProvider()
Me.radPivotGrid1.DataProvider = queryableDataProvider
Me.radPivotFieldList1.DataProvider = queryableDataProvider
' #endregion

' #region radpivotgrid-data-queryable_2
Dim queryableDataProvider As New QueryableDataProvider()
queryableDataProvider.Source = MyCollection
Me.radPivotGrid1.DataProvider = queryableDataProvider
Me.radPivotFieldList1.DataProvider = queryableDataProvider
' #endregion

' #region radpivotgrid-data-queryable_3
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"

Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
freightCountryGroupDescription.PropertyName = "Freight"

Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
orderDateCountryGroupDescription.PropertyName = "OrderDate"

Using queryableDataProvider.DeferRefresh()
	queryableDataProvider.RowGroupDescriptions.Add(shipCountryGroupDescription)
	queryableDataProvider.RowGroupDescriptions.Add(freightCountryGroupDescription)
	queryableDataProvider.RowGroupDescriptions.Add(orderDateCountryGroupDescription)
End Using
' #endregion

' #region radpivotgrid-data-queryable_4
Dim doubleGroupDescription As New DoubleGroupDescription()
doubleGroupDescription.PropertyName = "Freight"
queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription)
' #endregion

' #region radpivotgrid-data-queryable_5
Dim freightAggregateDescription = New QueryablePropertyAggregateDescription()
freightAggregateDescription.PropertyName = "Freight"
freightAggregateDescription.StringFormat = "C"
freightAggregateDescription.AggregateFunction = QueryableAggregateFunction.Max

Dim shipViaAggregateDescription = New QueryablePropertyAggregateDescription()
freightAggregateDescription.PropertyName = "ShipVia"

Using queryableDataProvider.DeferRefresh()
	queryableDataProvider.AggregateDescriptions.Add(freightAggregateDescription)
	queryableDataProvider.AggregateDescriptions.Add(shipViaAggregateDescription)
End Using
' #endregion

'#region "radpivotgrid-data-queryable_6"
Dim freightFilterDescription = New QueryablePropertyFilterDescription()
freightFilterDescription.PropertyName = "Freight"
Dim intervalCondition = New QueryableIntervalCondition()
intervalCondition.From = 10
intervalCondition.To = 200
freightFilterDescription.Condition = intervalCondition

queryableDataProvider.FilterDescriptions.Add(freightFilterDescription)
'#endregion