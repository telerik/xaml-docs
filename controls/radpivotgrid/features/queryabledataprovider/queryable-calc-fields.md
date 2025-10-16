---
title: Calculated Fields
page_title: Calculated Fields
description: Check our &quot;Calculated Fields&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-queryable-calc-fields
tags: calculated,fields
published: True
position: 2
---

# Calculated Fields

In this article you will find out how to extend __RadPivotGrid's__ generated report by adding Calculated Fields.      

## Calculated Fields Description

If your data analysis requires results that are not available using just the data source fields and __RadPivotGrid's__ built-in calculations, you can insert a calculated field that uses a custom formula to derive the results you need. A calculated field is a new data field in which the values are the result of a custom calculation formula. You can display the calculated field along with another data field or on its own. A calculated field is really a custom summary calculation, so in almost all cases, the calculated field references one or more fields in the source data.        

## Define Calculated Field

All Calculated Fields that you have added to your QueryableDataProvider will be visible in __RadPivotFieldList__, so the user will be able to add and remove them at runtime. In order to add a calculated field to QueryableDataProvider you have to add it to its CalculatedFields collection. So first you have to create a concrete class that implements the abstract class *CalculatedField*. This requires the implementation of two methods - CalculatedValue and RequiredFields. CalculateValue is the method in which you have to define your calculation formula and create a new AggregateValue that will be shown in __RadPivotGrid__. In common scenario a Calculated Field reference one or more fields in the data source. The RequiredFields method should return IEnumerable of the required fields. That's why we have added a new class called RequiredField. It's purpose is to describe a field, required for a calculated field. RequiredField can be created for property from the data object or for another calculated field. Name property of CalculatedField class identifies its unique name that will be shown in the UI.       

The first task is to decide what is the calculation formula that you want to use. For example, you can show the commission that will be paid to all salespeople. Commission will be paid only to those who have more sold for more than $15 000. The price of the sold items is kept by the ExtendedPrice property from the source. So the new class will look like this:        



```C#
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
```
```VB.NET
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
```

Now it is time to add a new instance of this class to the CalculatedFields collection of QueryableDataProvider:        



```XAML
	<pivot:QueryableDataProvider.CalculatedFields>
	    <local:CommissionCalculatedField Name="Commission" />
	</pivot:QueryableDataProvider.CalculatedFields>
```



```C#
	var queryableCalculatedField = new CommissionCalculatedField();
	queryableCalculatedField.Name = "Commission";
	dataProvider.CalculatedFields.Add(queryableCalculatedField);
```
```VB.NET
	Dim queryableCalculatedField = New CommissionCalculatedField()
	queryableCalculatedField.Name = "Commission"
	dataProvider.CalculatedFields.Add(queryableCalculatedField)
```

>importantIf you add caculated fields in code behind, you have to set the ItemsSource of QueryableDataProvider after you have added all calculated fields or to wrap the code between *BeginInit() - EndInit()* methods (or inside *using DeferRefresh() { ... } section* ).          

This way the Commission field will be visible in a special folder inside __RadPivotFieldList__ called Calculated Fields.

![Rad Pivot Grid Features Local Calc Fields 01](images/RadPivotGrid_Features_Local_Calc_Fields_01.png)

In order to use the calculated field in the generated report, you have to add it to QueryableDataProvider's AggregateDescriptions collection:        



```XAML
	<pivot:QueryableDataProvider.AggregateDescriptions>
	    <pivot:QueryableCalculatedAggregateDescription CalculatedFieldName="Commission" />
	</pivot:QueryableDataProvider.AggregateDescriptions>
```



```C#
	var queryableCalculatedAggregate = new QueryableCalculatedAggregateDescription();
	queryableCalculatedAggregate.CalculatedFieldName = "Commission";
	dataProvider.AggregateDescriptions.Add(queryableCalculatedAggregate);
```
```VB.NET
	Dim queryableCalculatedAggregate = New QueryableCalculatedAggregateDescription()
	queryableCalculatedAggregate.CalculatedFieldName = "Commission"
	dataProvider.AggregateDescriptions.Add(queryableCalculatedAggregate)
```

The result will look like this:

![Rad Pivot Grid Features Local Calc Fields 02](images/RadPivotGrid_Features_Local_Calc_Fields_02.png)

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [QueryableDataSourceProvider]({%slug radpivotgrid-features-queryable-overview%})

 * [Features]({%slug radpivotgrid-features%})
