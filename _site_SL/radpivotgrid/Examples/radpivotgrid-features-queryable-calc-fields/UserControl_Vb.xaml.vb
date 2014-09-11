'#region radpivotgrid-features-queryable-calc-fields_1
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

'#region radpivotgrid-features-queryable-calc-fields_2
Dim queryableCalculatedField = New CommissionCalculatedField()
queryableCalculatedField.Name = "Commission"
dataProvider.CalculatedFields.Add(queryableCalculatedField)
'#endregion

'#region radpivotgrid-features-queryable-calc-fields_3
Dim queryableCalculatedAggregate = New QueryableCalculatedAggregateDescription()
queryableCalculatedAggregate.CalculatedFieldName = "Commission"
dataProvider.AggregateDescriptions.Add(queryableCalculatedAggregate)
'#endregion