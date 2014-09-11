'#region radpivotgrid-features-calculations_1
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New DifferenceFrom() With {.Axis = PivotAxis.Rows, .Level = 0, .GroupName = "Pen"}
'#endregion

'#region radpivotgrid-features-calculations_2
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New DifferenceFromNext() With {.Axis = PivotAxis.Rows, .Level = 0}
'#endregion

'#region radpivotgrid-features-calculations_3
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New PercentDifferenceFrom() With {.Axis = PivotAxis.Rows, .Level = 0, .GroupName = "Pen"}
'#endregion

'#region radpivotgrid-features-calculations_4
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New Index()
'#endregion

'#region radpivotgrid-features-calculations_5
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New RunningTotalsIn() With {.Axis = PivotAxis.Rows, .Level = 0}
'#endregion

'#region radpivotgrid-features-calculations_6
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New PercentRunningTotalsIn() With {.Axis = PivotAxis.Rows, .Level = 0}
'#endregion

'#region radpivotgrid-features-calculations_7
Dim aggregate As New PropertyAggregateDescription()
aggregate.AggregateFunction = AggregateFunctions.Sum
aggregate.PropertyName = "Price"
aggregate.TotalFormat = New RankTotals() With {.Axis = PivotAxis.Rows, .Level = 0}
'#endregion