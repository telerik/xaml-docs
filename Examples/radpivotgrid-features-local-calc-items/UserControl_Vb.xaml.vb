'#region radpivotgrid-features-local-calc-items_1
Public Class MenAverageSales
	Inherits CalculatedItem

	Protected Overrides Function GetValue(ByVal aggregateSummaryValues As IAggregateSummaryValues) As AggregateValue
		Dim aggregateValues() As AggregateValue = 
			{ aggregateSummaryValues.GetAggregateValue("Andrew Fuller"), aggregateSummaryValues.GetAggregateValue("Michael Suyama"), 
			aggregateSummaryValues.GetAggregateValue("Robert King"), aggregateSummaryValues.GetAggregateValue("Steven Buchanan") }

		If aggregateValues.ContainsError() Then
			Return AggregateValue.ErrorAggregateValue
		End If

		Dim average As Double = aggregateValues.Average(Function(av) av.ConvertOrDefault(Of Double)())
		Return New DoubleAggregateValue(average)
	End Function
End Class
'#endregion

'#region radpivotgrid-features-local-calc-items_2
Dim propertyGroupDescription = New Telerik.Pivot.Core.PropertyGroupDescription()
propertyGroupDescription.PropertyName = "Salesperson"
Dim calculatedItem = New MenAverageSales()
calculatedItem.GroupName = "Average Sales (Men)"
propertyGroupDescription.CalculatedItems.Add(calculatedItem)
dataProvider.ColumnGroupDescriptions.Add(propertyGroupDescription)
'#endregion

'#region radpivotgrid-features-local-calc-items_3
Private Sub LocalDataSourceProvider_PrepareDescriptionForField(ByVal sender As Object, ByVal e As PrepareDescriptionForFieldEventArgs)
	If e.DescriptionType = DataProviderDescriptionType.Group AndAlso e.FieldInfo.DisplayName = "Salesperson" Then
		Dim description = TryCast(e.Description, Telerik.Pivot.Core.PropertyGroupDescription)

		If description IsNot Nothing Then
			Dim calculatedItem = New MenAverageSales()
			calculatedItem.GroupName = "Average Sales (Men)"
			description.CalculatedItems.Add(calculatedItem)
		End If
	End If
End Sub
'#endregion

'#region radpivotgrid-features-local-calc-items_4
Dim salesPersonGroupDescription = New Telerik.Pivot.Core.PropertyGroupDescription()
salesPersonGroupDescription.PropertyName = "Salesperson"
Dim menAvgSalesCalculatedItem = New MenAverageSales()
menAvgSalesCalculatedItem.GroupName = "Average Sales (Men)"
menAvgSalesCalculatedItem.SolveOrder = 1
salesPersonGroupDescription.CalculatedItems.Add(menAvgSalesCalculatedItem)

Dim countryGroupDescription = New Telerik.Pivot.Core.PropertyGroupDescription()
countryGroupDescription.PropertyName = "Country"
Dim caCalculatedItem = New CA()
caCalculatedItem.GroupName = "CA"
caCalculatedItem.SolveOrder = 2
countryGroupDescription.CalculatedItems.Add(caCalculatedItem)

dataProvider.ColumnGroupDescriptions.Add(salesPersonGroupDescription)
dataProvider.RowGroupDescriptions.Add(countryGroupDescription)
'#endregion