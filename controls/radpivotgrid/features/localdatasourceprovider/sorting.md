---
title: Sorting
page_title: Sorting
description: Check our &quot;Sorting&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-sorting
tags: sorting
published: True
position: 2
---

# Sorting

In this article we will show how you can sort your data based on the header names or the totals.      

## Understanding Sorting Mechanism

__RadPivotGrid__ provides different sorting capabilities. You can sort your *RowGroupDescriptions* and *ColumnGroupDescriptions* ascending (from A to Z) and descending (from Z to A) based on the names of the properties they are showing or based on the aggregated description.        

With the __Q1 2014 SP1__ version of __Telerik UI for__ __RadPivotGrid__ provides an additional option. The data can be shown the way it has been received from the data source using the __SortOrder__ property set to __None__.        

We will explain this with a simple __RadPivotGrid__:

![Rad Pivot Grid Features Sorting 01](images/RadPivotGrid_Features_Sorting_01.png)

The __ColumnGroupDescription__ in this __RadPivotGrid__ is the *Name* of the __Product__. By default the sorting of the columns is ascending (from A to Z) based on the headers: *Notebook*, *Pen*, *Pencil*. You can easily change the sorting of the *Name* ColumnGroupDescription and set it to descending (from Z to A). This will lead to the following result:

![Rad Pivot Grid Features Sorting 02](images/RadPivotGrid_Features_Sorting_02.png)

The columns are reordered based on their names (check the green rectangle on the top of the image). You can apply sorting based on some of the __PropertyAggregateDescription__ you are using. In the example above you can apply sorting of the *Name* ColumnGroupDescription in ascending (from A to Z) or descending (from Z to A) format based on the *Total Average of Price* (red rectangle) or *Total Sum of Quantity* (blue rectangle). Here is the new view of __RadPivotGrid__ when the *Name* ColumnGroupDescription is sorted in descending format based on the *Total Sum of Quantity*:

![Rad Pivot Grid Features Sorting 03](images/RadPivotGrid_Features_Sorting_03.png)

>important The sorting is set on the __ColumnGroupDescriptions__ or __RowGroupDescriptions__. You cannot set sorting on the __AggregateDescriptions__, but you can sort the columns or rows based on the aggregated values.          

## Sort the data

The sorting can be applied in the __XAML__, in the code behind or even at runtime with the help of __RadPivotFieldList__.        

* Sorting based on the GroupName (header) can be *Ascending (from A to Z)* or *Descending (from Z to A*). The default value is *Ascending*, but you can change it by using __SortOrder__ property:            



```XAML
	<pivot:PropertyGroupDescription PropertyName="Name" SortOrder="Descending"/>
	<pivot:DoubleGroupDescription PropertyName="Price" SortOrder="Ascending"/>
	<pivot:DateTimeGroupDescription PropertyName="Date" SortOrder="Descending"/>
```



```C#
	Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	propGroupDescription.PropertyName = "Name";
	propGroupDescription.SortOrder = SortOrder.Descending;
	
	DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Price";
	doubleGroupDescription.SortOrder = SortOrder.Ascending;
	
	DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
	dateTimeGroupDescription.PropertyName = "Date";
	dateTimeGroupDescription.SortOrder = SortOrder.Descending;
```
```VB.NET
	Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
	propGroupDescription.PropertyName = "Name"
	propGroupDescription.SortOrder = SortOrder.Descending
	
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Price"
	doubleGroupDescription.SortOrder = SortOrder.Ascending
	
	Dim dateTimeGroupDescription As New DateTimeGroupDescription()
	dateTimeGroupDescription.PropertyName = "Date"
	dateTimeGroupDescription.SortOrder = SortOrder.Descending
```

* If you need to avoid the data to be sorted anyhow, you can set the __SortOrder__ property to __None__. This way the data will appear the way it is was received from the data source:            



```XAML
	<pivot:PropertyGroupDescription PropertyName="Name" SortOrder="None"/>
	<pivot:DoubleGroupDescription PropertyName="Price" SortOrder="None"/>
	<pivot:DateTimeGroupDescription PropertyName="Date" SortOrder="None"/>
```



```C#
	Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	propGroupDescription.PropertyName = "Name";
	propGroupDescription.SortOrder = SortOrder.None;
	
	DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Price";
	doubleGroupDescription.SortOrder = SortOrder.None;
	
	DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
	dateTimeGroupDescription.PropertyName = "Date";
	dateTimeGroupDescription.SortOrder = SortOrder.None;
```
```VB.NET
	Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
	propGroupDescription.PropertyName = "Name"
	propGroupDescription.SortOrder = SortOrder.None
	
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Price"
	doubleGroupDescription.SortOrder = SortOrder.None
	
	Dim dateTimeGroupDescription As New DateTimeGroupDescription()
	dateTimeGroupDescription.PropertyName = "Date"
	dateTimeGroupDescription.SortOrder = SortOrder.None
```

>Note that the __SortOrder None__ property is available with the __Q1 2014 SP1__ version of Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}.              

* Sorting based on the GrandTotals can be *Ascending* or *Descending*. To set such sort mechanism you have to use the __SortOrder__ and __GroupComparer__ properties:            



```XAML
	<pivot:PropertyGroupDescription PropertyName="Name" SortOrder="Ascending">
	    <pivot:PropertyGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="0"/>
	    </pivot:PropertyGroupDescription.GroupComparer>
	</pivot:PropertyGroupDescription>
	
	<pivot:DoubleGroupDescription PropertyName="Price" SortOrder="Descending">
	    <pivot:DoubleGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="1"/>
	    </pivot:DoubleGroupDescription.GroupComparer>
	</pivot:DoubleGroupDescription>
	
	<pivot:DateTimeGroupDescription PropertyName="Date" SortOrder="Descending">
	    <pivot:DateTimeGroupDescription.GroupComparer>
	        <pivot:GrandTotalComparer AggregateIndex="0"/>
	    </pivot:DateTimeGroupDescription.GroupComparer>
	</pivot:DateTimeGroupDescription>
```



```C#
	Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	propGroupDescription.PropertyName = "Name";
	propGroupDescription.SortOrder = SortOrder.Descending;
	propGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
	
	DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Price";
	doubleGroupDescription.SortOrder = SortOrder.Ascending;
	doubleGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };
	
	DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
	dateTimeGroupDescription.PropertyName = "Date";
	dateTimeGroupDescription.SortOrder = SortOrder.Descending;
	dateTimeGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
```
```VB.NET
	Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
	propGroupDescription.PropertyName = "Name"
	propGroupDescription.SortOrder = SortOrder.Descending
	propGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
	
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Price"
	doubleGroupDescription.SortOrder = SortOrder.Ascending
	doubleGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}
	
	Dim dateTimeGroupDescription As New DateTimeGroupDescription()
	dateTimeGroupDescription.PropertyName = "Date"
	dateTimeGroupDescription.SortOrder = SortOrder.Descending
	dateTimeGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
```

>The __AggregateIndex__ property is set based on the count of your aggregate descriptions. If you have two aggregates the first one will have __AggregateIndex = 0__ and the second - __AggregateIndex = 1__.              

## Changing the Sorting at runtime

__RadPivotFieldList__ gives you the ability to change the sorting of a description at runtime. When you click on RowGroupDescription or ColumnGroupDescription a new popup opens with several sorting options. If you want to save the current sorting, but only change its order (for example the above RadPivotGrid is sorted based on the Total Sum of Quantity in Descending order, and you want to change it to Ascending) you can use the first two options which are doing exactly this - just changing the __SortOrder__:

![Rad Pivot Grid Features Queryable Sorting 04](images/RadPivotGrid_Features_Queryable_Sorting_04.png)

If you want to change the property based on which the sort is applied, then you can use the third option - More Sorting Options. A new RadWindow will be opened in which you can choose Ascending or Descending order of the sort. When you click the dropdown button you'll see a full list of the possible sorting basis:

![Rad Pivot Grid Features Queryable Sorting 06](images/RadPivotGrid_Features_Queryable_Sorting_06.png)

## See Also

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})

 * [Filtering]({%slug radpivotgrid-features-filtering%})
