'#region radpivotgrid-features-local-calc-fields_1
Public Class CommissionCalculatedField
	Inherits CalculatedField

	Private extendPriceField As RequiredField

	Public Sub New()
		Me.Name = "Commission"
		Me.extendPriceField = RequiredField.ForProperty("ExtendedPrice")
	End Sub

	Protected Overrides Iterator Function RequiredFields() As IEnumerable(Of RequiredField)
		Yield Me.extendPriceField
	End Function

	Protected Overrides Function CalculateValue(ByVal aggregateValues As IAggregateValues) As AggregateValue
		Dim aggregateValue = aggregateValues.GetAggregateValue(Me.extendPriceField)
		If aggregateValue.IsError() Then
			Return aggregateValue
		End If

		Dim extendedPrice As Double = aggregateValue.ConvertOrDefault(Of Double)()
		If extendedPrice > 15000 Then
			Return New DoubleAggregateValue(extendedPrice * 0.1)
		End If

		Return Nothing
	End Function

'#endregion

'#region radpivotgrid-features-local-calc-fields_2
Dim calculatedField = New CommissionCalculatedField()
calculatedField.Name = "Commission"
dataProvider.CalculatedFields.Add(calculatedField)
'#endregion

'#region radpivotgrid-features-local-calc-fields_3
Dim calculatedAggregate = New CalculatedAggregateDescription()
calculatedAggregate.CalculatedFieldName = "Commission"
dataProvider.AggregateDescriptions.Add(calculatedAggregate)
'#endregion