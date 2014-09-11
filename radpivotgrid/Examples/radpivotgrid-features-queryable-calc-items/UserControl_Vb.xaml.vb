'#region radpivotgrid-features-queryable-calc-items_1
Public Class MenAverageSales
    Inherits CalculatedItem

    Protected Overrides Function GetValue(ByVal aggregateSummaryValues As IAggregateSummaryValues) As AggregateValue
        Dim aggregateValues() As AggregateValue =
            {aggregateSummaryValues.GetAggregateValue("Andrew Fuller"), aggregateSummaryValues.GetAggregateValue("Michael Suyama"),
            aggregateSummaryValues.GetAggregateValue("Robert King"), aggregateSummaryValues.GetAggregateValue("Steven Buchanan")}

        If aggregateValues.ContainsError() Then
            Return AggregateValue.ErrorAggregateValue
        End If

        Dim average As Double = aggregateValues.Average(Function(av) av.ConvertOrDefault(Of Double)())
        Return New DoubleAggregateValue(average)
    End Function
End Class
'#endregion

'#region radpivotgrid-features-queryable-calc-items_2
Dim propertyGroupDescription = New QueryablePropertyGroupDescription()
propertyGroupDescription.PropertyName = "Salesperson"
Dim calculatedItem = New MenAverageSales()
calculatedItem.GroupName = "Average Sales (Men)"
propertyGroupDescription.CalculatedItems.Add(calculatedItem)
dataProvider.ColumnGroupDescriptions.Add(propertyGroupDescription)
'#endregion

'#region radpivotgrid-features-queryable-calc-items_3
Private Sub QueryableDataProvider_PrepareDescriptionForField(ByVal sender As Object, ByVal e As PrepareDescriptionForFieldEventArgs)
    If e.DescriptionType = DataProviderDescriptionType.Group AndAlso e.FieldInfo.DisplayName = "Salesperson" Then
        Dim description = TryCast(e.Description, QueryablePropertyGroupDescription)

        If description IsNot Nothing Then
            Dim calculatedItem = New MenAverageSales()
            calculatedItem.GroupName = "Average Sales (Men)"
            description.CalculatedItems.Add(calculatedItem)
        End If
    End If
End Sub
'#endregion

'#region radpivotgrid-features-queryable-calc-items_4
Dim salesPersonGroupDescription = New QueryablePropertyGroupDescription()
salesPersonGroupDescription.PropertyName = "Salesperson"
Dim menAvgSalesCalculatedItem = New MenAverageSales()
menAvgSalesCalculatedItem.GroupName = "Average Sales (Men)"
menAvgSalesCalculatedItem.SolveOrder = 1
salesPersonGroupDescription.CalculatedItems.Add(menAvgSalesCalculatedItem)

Dim countryGroupDescription = New QueryablePropertyGroupDescription()
countryGroupDescription.PropertyName = "Country"
Dim caCalculatedItem = New CA()
caCalculatedItem.GroupName = "CA"
caCalculatedItem.SolveOrder = 2
countryGroupDescription.CalculatedItems.Add(caCalculatedItem)

dataProvider.ColumnGroupDescriptions.Add(salesPersonGroupDescription)
dataProvider.RowGroupDescriptions.Add(countryGroupDescription)
'#endregion