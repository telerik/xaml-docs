#region radpivotgrid-features-local-calc-fields_1
public class CommissionCalculatedField : CalculatedField
{
    private RequiredField extendPriceField;

    public CommissionCalculatedField()
    {
        this.Name = "Commission";
        this.extendPriceField = RequiredField.ForProperty("ExtendedPrice");
    }

    protected override IEnumerable<RequiredField> RequiredFields()
    {
        yield return this.extendPriceField;
    }

    protected override AggregateValue CalculateValue(IAggregateValues aggregateValues)
    {
        var aggregateValue = aggregateValues.GetAggregateValue(this.extendPriceField);
        if (aggregateValue.IsError())
        {
            return aggregateValue;
        }

        double extendedPrice = aggregateValue.ConvertOrDefault<double>();
        if (extendedPrice > 15000)
        {
            return new DoubleAggregateValue(extendedPrice * 0.1);
        }

        return null;
    }
}
#endregion

#region radpivotgrid-features-local-calc-fields_2
var calculatedField = new CommissionCalculatedField();
calculatedField.Name = "Commission";
dataProvider.CalculatedFields.Add(calculatedField);
#endregion

#region radpivotgrid-features-local-calc-fields_3
var calculatedAggregate = new CalculatedAggregateDescription();
calculatedAggregate.CalculatedFieldName = "Commission";
dataProvider.AggregateDescriptions.Add(calculatedAggregate);
#endregion