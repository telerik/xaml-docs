---
title: Sorting
page_title: Sorting
description: Check our &quot;Sorting&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-queryable-sorting
tags: sorting
published: True
position: 1
site_name: WPF
---

# Sorting

In this article you will find out how to sort your data based on the header names or the totals.

## Understanding Sorting Mechanism

__RadPivotGrid__ provides different sorting capabilities. You can sort your *RowGroupDescriptions* and *ColumnGroupDescriptions* ascending (from A to Z) and descending (from Z to A) based on the names of the properties they are showing or based on the aggregated description.        

With the __Q1 2014 SP1__ version of __Telerik UI for__ __RadPivotGrid__ provides an additional option. The data can be shown the way it was received from the data source using the __SortOrder__ property set to __None__.        

We will explain this with a simple __RadPivotGrid__:

![Rad Pivot Grid Features Queryable Sorting 01](images/RadPivotGrid_Features_Queryable_Sorting_01.png)

The __ColumnGroupDescription__ in this __RadPivotGrid__ is the *OrderDate*. By default the sorting of the columns is ascending (from A to Z) based on the headers: *1996*, *1997*, *1998*. You can easily change the sorting of the *OrderDate* ColumnGroupDescription and set it to descending (from Z to A). This will lead to the following result:

![Rad Pivot Grid Features Queryable Sorting 02](images/RadPivotGrid_Features_Queryable_Sorting_02.png)

The columns are reordered based on their names (check the green rectangle on the top of the image). You can apply sorting based on some of the __QueryablePropertyAggregateDescription__ you are using. In the example above you can apply sorting of the *OrderDate* ColumnGroupDescription in ascending (from A to Z) or descending (from Z to A) format based on the *Total Sum of Freight* (red rectangle) or *Total Sum of ShipVia* (blue rectangle). Here is the new view of __RadPivotGrid__ when the *OrderDate* ColumnGroupDescription is sorted in descending format based on the *Total Sum of Freight*:

![Rad Pivot Grid Features Queryable Sorting 03](images/RadPivotGrid_Features_Queryable_Sorting_03.png)

>importantThe sorting is set on the __ColumnGroupDescriptions__ or __RowGroupDescriptions__. You cannot set sorting on the __AggregateDescriptions__, but you can sort the columns or rows based on the aggregated values.          

## Sort the data

The sorting can be applied in the __XAML__, in the code behind or even at runtime with the help of __RadPivotFieldList__.

* Sorting based on the GroupName (header) can be *Ascending (from A to Z)* or *Descending (from Z to A*). The default value is *Ascending*, but you can change it by using __SortOrder__ property:            

#### __XAML__

```XAML
	<pivot:QueryablePropertyGroupDescription PropertyName="ShipCountry" SortOrder="Ascending"/>
	<pivot:QueryableDoubleGroupDescription PropertyName="Freight" SortOrder="Descending"/>
	<pivot:QueryableDateTimeGroupDescription PropertyName="OrderDate" SortOrder="Ascending"/>
```

#### __C#__

```C#
	var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
	shipCountryGroupDescription.PropertyName = "ShipCountry";
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
	
	var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
	freightCountryGroupDescription.PropertyName = "ShipCountry";
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
	
	var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
	orderDateCountryGroupDescription.PropertyName = "OrderDate";
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
```

#### __VB.NET__

```VB.NET
	Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
	shipCountryGroupDescription.PropertyName = "ShipCountry"
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
	
	Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
	freightCountryGroupDescription.PropertyName = "ShipCountry"
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
	
	Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
	orderDateCountryGroupDescription.PropertyName = "OrderDate"
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
```

* If you need to avoid the data to be sorted anyhow, you can set the __SortOrder__ property to __None__. This way the data will appear the way it is was received from the data source:            

#### __XAML__

```XAML
	<pivot:QueryablePropertyGroupDescription PropertyName="ShipCountry" SortOrder="None"/>
	<pivot:QueryableDoubleGroupDescription PropertyName="Freight" SortOrder="None"/>
	<pivot:QueryableDateTimeGroupDescription PropertyName="OrderDate" SortOrder="None"/>
```

#### __C#__

```C#
	var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
	shipCountryGroupDescription.PropertyName = "ShipCountry";
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
	
	var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
	freightCountryGroupDescription.PropertyName = "ShipCountry";
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
	
	var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
	orderDateCountryGroupDescription.PropertyName = "OrderDate";
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
```

#### __VB.NET__

```VB.NET
	Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
	shipCountryGroupDescription.PropertyName = "ShipCountry"
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
	
	Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
	freightCountryGroupDescription.PropertyName = "ShipCountry"
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
	
	Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
	orderDateCountryGroupDescription.PropertyName = "OrderDate"
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
```

>Note that the __SortOrder None__ property is available with the __Q1 2014 SP1__ version of Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}.              

* Sorting based on the GrandTotals can be *Ascending* or *Descending*. To set such sort mechanism you have to use the __SortOrder__ and __GroupComparer__ properties:            

#### __XAML__

```XAML
	<pivot:QueryablePropertyGroupDescription PropertyName="ShipCountry" SortOrder="Ascending">
	    <pivot:QueryablePropertyGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="0"/>
	    </pivot:QueryablePropertyGroupDescription.GroupComparer>
	</pivot:QueryablePropertyGroupDescription>
	<pivot:QueryableDoubleGroupDescription PropertyName="Freight" SortOrder="Descending">
	    <pivot:QueryablePropertyGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="1"/>
	    </pivot:QueryablePropertyGroupDescription.GroupComparer>
	</pivot:QueryableDoubleGroupDescription>
	<pivot:QueryableDateTimeGroupDescription PropertyName="OrderDate" SortOrder="Ascending">
	    <pivot:QueryablePropertyGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="0"/>
	    </pivot:QueryablePropertyGroupDescription.GroupComparer>
	</pivot:QueryableDateTimeGroupDescription>
```

#### __C#__

```C#
	var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
	shipCountryGroupDescription.PropertyName = "ShipCountry";
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
	shipCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
	
	var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
	freightCountryGroupDescription.PropertyName = "Freight";
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
	freightCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };
	
	var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
	orderDateCountryGroupDescription.PropertyName = "OrderDate";
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
	orderDateCountryGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
```

#### __VB.NET__

```VB.NET
	Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
	shipCountryGroupDescription.PropertyName = "ShipCountry"
	shipCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
	shipCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
	
	Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
	freightCountryGroupDescription.PropertyName = "Freight"
	freightCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
	freightCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}
	
	Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
	orderDateCountryGroupDescription.PropertyName = "OrderDate"
	orderDateCountryGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
	orderDateCountryGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
```

>The __AggregateIndex__ property is set based on the count of your aggregate descriptions. If you have two aggregates the first one will have __AggregateIndex = 0__ and the second - __AggregateIndex = 1__.

## Changing the Sorting at runtime

__RadPivotFieldList__ gives you the ability to change the sorting of a description at runtime. When you click on RowGroupDescription or ColumnGroupDescription a new popup opens with several sorting options. If you want to save the current sorting, but only change its order (for example the above __RadPivotGrid__ is sorted based on the Total Sum of Quantity in Descending order, and you want to change it to Ascending) you can use the first two options which are doing exactly this - just changing the __SortOrder__:

![Rad Pivot Grid Features Sorting 04](images/RadPivotGrid_Features_Sorting_04.png)

If you want to change the property based on which the sort is applied, then you can use the third option - More Sorting Options. A new RadWindow will be opened in which you can choose Ascending or Descending order of the sort. When you click the dropdown button you'll see a full list of the possible sorting basis:

![Rad Pivot Grid Features Queryable Sorting 06](images/RadPivotGrid_Features_Queryable_Sorting_06.png)

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [QueryableDataProvider]({%slug radpivotgrid-data-queryable%})

 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})

 * [QueryableDataProvider Overview]({%slug radpivotgrid-features-queryable-overview%})
