---
title: Calculated Items
page_title: Calculated Items
description: Check our &quot;Calculated Items&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-local-calc-items
tags: calculated,items
published: True
position: 9
---

# Calculated Items

A calculated item is a new item in a row or column field in which the values are the result of a custom calculation. In this case, the calculated item’s formula references one or more items in the same field. By using Calculated Items you are able to extend __RadPivotGrid__ with additional items that are not part of the data source.      

> You can check out the [LocalDataSourceCalculatedItems](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/CalculatedItems/LocalDataSourceCalculatedItems) SDK example for a runnable project demonstrating this feature.

## Defining Calculated Item

With __RadPivotGrid__ you are able to create different Groups that will be shown in Rows and Columns. But in some cases you may need to show additional items for specific group. In this case you may use Calculated Items. Calculated Items are added to a group description and they have access to different items from the same group. For example, lets say we want to calculate the average sales made by some of the salespeople, but not all of them. First we have to create a concrete class that implements the abstract *CalculatedItem* class. For this purpose the new class must implement GetValue method. In our scenario we'll show the average sales of four of the salespeople:        

#### __C#__

```C#
	public class MenAverageSales : CalculatedItem
	{
	    protected override AggregateValue GetValue(IAggregateSummaryValues aggregateSummaryValues)
	    {
	        AggregateValue[] aggregateValues = {
	            aggregateSummaryValues.GetAggregateValue("Andrew Fuller"),
	            aggregateSummaryValues.GetAggregateValue("Michael Suyama"),
	            aggregateSummaryValues.GetAggregateValue("Robert King"),
	            aggregateSummaryValues.GetAggregateValue("Steven Buchanan")
	        };
	
	        if (aggregateValues.ContainsError())
	        {
	            return AggregateValue.ErrorAggregateValue;
	        }
	
	        double average = aggregateValues.Average(av => av.ConvertOrDefault<double>());
	        return new DoubleAggregateValue(average);
	    }
	}
```

#### __VB.NET__

```VB.NET
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
```

As you can see the Calculated Item will show the average sales of four people. Now we just have to add it to the PropertyGroupDescription. In our case this will be the Salesperson group:        

#### __XAML__

```XAML
	<pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
		<pivot:PropertyGroupDescription PropertyName="Salesperson">
			<pivot:PropertyGroupDescription.CalculatedItems>
				<local:MenAverageSales GroupName="Average Sales (Men)" />
			</pivot:PropertyGroupDescription.CalculatedItems>
		</pivot:PropertyGroupDescription>
	</pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
```

#### __C#__

```C#
	var propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	propertyGroupDescription.PropertyName = "Salesperson";
	var calculatedItem = new MenAverageSales();
	calculatedItem.GroupName = "Average Sales (Men)";
	propertyGroupDescription.CalculatedItems.Add(calculatedItem);
	dataProvider.ColumnGroupDescriptions.Add(propertyGroupDescription);
```

#### __VB.NET__

```VB.NET
	Dim propertyGroupDescription = New Telerik.Pivot.Core.PropertyGroupDescription()
	propertyGroupDescription.PropertyName = "Salesperson"
	Dim calculatedItem = New MenAverageSales()
	calculatedItem.GroupName = "Average Sales (Men)"
	propertyGroupDescription.CalculatedItems.Add(calculatedItem)
	dataProvider.ColumnGroupDescriptions.Add(propertyGroupDescription)
```

![Rad Pivot Grid Features Local Calc Items 01](images/RadPivotGrid_Features_Local_Calc_Items_01.png)

>If you need to add a Calculated Item of type DateTimeGroupDescription or DoubleGroupDescription you will need to pass a specific object to the GetAggregateValue() method instead of just string with the group name. For the DateTimeGroupDescription you have to use the following types depending the step used in the description:                      
>	* SecondGroup
>	* MinuteGroup
>	* HourGroup
>	* DayGroup
>	* WeekGroup
>	* MonthGroup
>	* QuarterGroup
>	* YearGroup

>As for the DoubleGroupDescription you would need to use an object of type DoubleGroup.          

## Add Calculated Items at runtime

Calculated items can be added only to Group Descriptions. If you are using __RadPivotFieldList__ the users can remove the group for which you've added calculated items and this way the calculated items will be removed as well. Adding the same group in rows or columns will not show the calculated items anymore. In order to add them again you have to use *PrepareDescriptionForField* event of LocalDataSourceProvider and add the calculated items to the description:

#### __C#__

```C#
	private void LocalDataSourceProvider_PrepareDescriptionForField(object sender, PrepareDescriptionForFieldEventArgs e)
	{
		if (e.DescriptionType == DataProviderDescriptionType.Group && e.FieldInfo.DisplayName == "Salesperson")
		{
			var description = e.Description as Telerik.Pivot.Core.PropertyGroupDescription;
	
			if (description != null)
			{
				var calculatedItem = new MenAverageSales();
				calculatedItem.GroupName = "Average Sales (Men)";
				description.CalculatedItems.Add(calculatedItem);
			}
		}
	}
```

#### __VB.NET__

```VB.NET
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
```

## Solve Order

If you have calculated items in both rows and columns group descriptions, you have to define which of them will be used for the intersected cells. That's why each Calculated Item has *SolveOrder* property - when a cell is an intersection between two calculated items the one with higher solve order will be used.        

#### __XAML__

```XAML
	<pivot:LocalDataSourceProvider.RowGroupDescriptions>
	    <pivot:PropertyGroupDescription PropertyName="Country">
	        <pivot:PropertyGroupDescription.CalculatedItems>
	            <local:CA GroupName="CA" SolveOrder="1" />
	        </pivot:PropertyGroupDescription.CalculatedItems>
	    </pivot:PropertyGroupDescription>
	</pivot:LocalDataSourceProvider.RowGroupDescriptions>
	
	<pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
	    <pivot:PropertyGroupDescription PropertyName="Salesperson">
	        <pivot:PropertyGroupDescription.CalculatedItems>
	            <local:MenAverageSales GroupName="Average Sales (Men)" SolveOrder="2" />
	        </pivot:PropertyGroupDescription.CalculatedItems>
	    </pivot:PropertyGroupDescription>
	</pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
```

#### __C#__

```C#
	var salesPersonGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	salesPersonGroupDescription.PropertyName = "Salesperson";
	var menAvgSalesCalculatedItem = new MenAverageSales();
	menAvgSalesCalculatedItem.GroupName = "Average Sales (Men)";
	menAvgSalesCalculatedItem.SolveOrder = 1; 
	salesPersonGroupDescription.CalculatedItems.Add(menAvgSalesCalculatedItem);
	
	var countryGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	countryGroupDescription.PropertyName = "Country";
	var caCalculatedItem = new CA();
	caCalculatedItem.GroupName = "CA";
	caCalculatedItem.SolveOrder = 2;
	countryGroupDescription.CalculatedItems.Add(caCalculatedItem);
	
	dataProvider.ColumnGroupDescriptions.Add(salesPersonGroupDescription);
	dataProvider.RowGroupDescriptions.Add(countryGroupDescription);
```

#### __VB.NET__

```VB.NET
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
```

Here is the result:

![Rad Pivot Grid Features Local Calc Items 02](images/RadPivotGrid_Features_Local_Calc_Items_02.png)

As you can see the intersected cell between the two calculated items has value 500 as the CA calculated item has higher solve order. If we change the solve order of Men Average Sales to a higher value, for example 5, here is how __RadPivotGrid__ will look like:

![Rad Pivot Grid Features Local Calc Items 03](images/RadPivotGrid_Features_Local_Calc_Items_03.png)

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})
