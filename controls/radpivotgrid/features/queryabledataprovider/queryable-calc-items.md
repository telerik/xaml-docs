---
title: Calculated Items
page_title: Calculated Items
description: Check our &quot;Calculated Items&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-queryable-calc-items
tags: calculated,items
published: True
position: 3
---

# Calculated Items

A calculated item is a new item in a row or column field in which the values are the result of a custom calculation. In this case, the calculated item’s formula references one or more items in the same field. By using Calculated Items you are able to extend __RadPivotGrid__ with additional items that are not part of the data source.      

## Defining Calculated Item

With __RadPivotGrid__ you are able to create different Groups that will be shown in Rows and Columns. But in some cases you may need to show additional items for specific group. In this case you may use Calculated Items. Calculated Items are added to a group description and they have access to different items from the same group. For example, lets say we want to calculate the average sales made by some of the salespeople, but not all of them. First we have to create a concrete class that implements the abstract *CalculatedItem* class. For this purpose the new class must implement GetValue method. In our scenario we'll show the average sales of four of the salespeople:       



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_1-cs' />
<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_1-vb' />

As you can see the Calculated Item will show the average sales of four people. Now we just have to add it to the QueryablePropertyGroupDescription. In our case this will be the Salesperson group:       



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_2-xaml' />



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_3-cs' />
<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_3-vb' />

![Rad Pivot Grid Features Local Calc Items 01](images/RadPivotGrid_Features_Local_Calc_Items_01.png)

>If you need to add a Calculated Item of type QueryableDateTimeGroupDescription or QueryableDoubleGroupDescription you will need to pass a specific object to the GetAggregateValue() method instead of just string with the group name. For the QueryableDateTimeGroupDescription you have to use the following types depending the step used in the description:
>	* SecondGroup
>	* MinuteGroup
>	* HourGroup
>	* DayGroup
>	* WeekGroup
>	* MonthGroup
>	* QuarterGroup
>	* YearGroup

>As for the QueryableDoubleGroupDescription you would need to use an object of type DoubleGroup.          

## Add Calculated Items at runtime

Calculated items can be added only to Group Descriptions. If you are using __RadPivotFieldList__ the users can remove the group for which you've added calculated items and this way the calculated items will be removed as well. Adding the same group in rows or columns will not show the calculated items anymore. In order to add them again you have to use *PrepareDescriptionForField* event of QueryableDataProvider and add the calculated items to the description:        



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_4-cs' />
<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_4-vb' />

## Solve Order

If you have calculated items in both rows and columns group descriptions, you have to define which of them will be used for the intersected cells. That's why each Calculated Item has *SolveOrder* property - when a cell is an intersection between two calculated items the one with higher solve order will be used.        



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_5-xaml' />



<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_6-cs' />
<snippet id='radpivotgrid-features-queryabledataprovider-queryable-calc-items-block_6-vb' />

Here is the result:

![Rad Pivot Grid Features Local Calc Items 02](images/RadPivotGrid_Features_Local_Calc_Items_02.png)

As you can see the intersected cell between the two calculated items has value 500 as the CA calculated item has higher solve order. If we change the solve order of Men Average Sales to a higher value, for example 5, here is how __RadPivotGrid__ will look like:

![Rad Pivot Grid Features Local Calc Items 03](images/RadPivotGrid_Features_Local_Calc_Items_03.png)

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [QueryableDataSourceProvider]({%slug radpivotgrid-features-queryable-overview%})

 * [Features]({%slug radpivotgrid-features%})