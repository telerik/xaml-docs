---
title: QueryableDateTimeGroupDescription
page_title: QueryableDateTimeGroupDescription
description: This article will describe the QueryableDateTimeGroupDescription class.
slug: radpivotgrid-features-queryabledatetimegroupdescription
tags: queryabledatetimegroupdescription
published: True
position: 9
---

# QueryableDateTimeGroupDescription

In this article you will learn how to use a QueryableDateTimeGroupDescription with your DateTime and DateTimeOffset data.

## QueryableDateTimeGroupDescription

__QueryableDateTimeGroupDescription__ is used when you want to group your data by a property of type *DateTime* or *DateTimeOffset*. It has the following properties:      

* __PropertyName__ : defines the name of the property by which the data will be grouped. It is mandatory to set a value.            

* __Step__ : defines the grouping interval. Default value is Year, but you can change it to one of the following: Quarter, Month, Day, Week Hour, Minute, Second (The Week, Hour, Minute and Second steps are available since the __2019.2.729__ version). 

>tip If you have the following dates: 01-01-2013 and 20-02-2013 and you set Step to Year, the two values will be in one group - 2013. But if you change the step to Month, the values will be in two different groups - January and February.            

When you have a property of type DateTime (DateTimeOffset), you can create several QueryableDateTimeGroupDescription with different steps. You may also create a QueryablePropertyGroupDescription - this way the DateTime will be treated as a string and grouped as such. All of them can be used simultaneously. You can add the description in RowGroupDescriptions or ColumnGroupDescriptions collections of QueryableDataSourceProvider.

__Example 1: Adding multiple group descriptions in xaml__

<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_1-xaml' />

__Example 2: Adding multiple group descriptions in code__

<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_2-cs' />
<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_2-vb' />

## Modify FieldTree of RadPivotFieldList

By default __RadPivotFieldList__ will show the following steps in its FieldTree for each QueryableDateTimeGroupDescription: Year, Month, Quarter, Day (you will also see one additional item, which will create a QueryablePropertyGroupDescription instead of a QueryableDateTimeGroupDescription). 

That said, you can set four more steps in code or xaml - Week, Hour, Minute, Second(Those 4 steps were added with the __2019.2.729__ version). In order to add them to the FieldTree of RadPivotFieldList you have two options:

* Handle the __GetDescriptionsDataAsyncCompleted__ of the __FieldDescriptionsProvider__.

	__Examples 3 and 4__ below demonstrate how the GetDescriptionsDataAsyncCompleted event can be handled in xaml and code respectively. __Example 5__ demonstrate a sample implementation of the event handler that shows the Week, Hour, Minute and Second steps for a property named "Date".

	__Example 3: Handling the GetDescriptionsDataAsyncCompleted event in xaml__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_3-xaml' />

	__Example 4: Handling the GetDescriptionsDataAsyncCompleted event in code__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_4-cs' />
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_4-vb' />

	__Example 5: Showing the additional steps__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_5-cs' />
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_5-vb' />

* Create a custom __QueryableFieldDescriptionsProvider__.

	__Example 6__ demonstrates how to create a custom QueryableFieldDescriptionsProvider and ovveride its __GetFieldDescriptionHierarchy__ method in order to show the additional steps. __Examples 7 and 8__ demonstrate how to use the created class by setting it to the __FieldDescriptionsProvider__ property of the QueryableDataProvider.

	__Example 6: Custom QueryableFieldDescriptionsProvider__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_6-cs' />
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_6-vb' />

	__Example 7: Using the CustomQueryableFieldDescriptionsProvider in xaml__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_7-xaml' />

	__Example 8: Using the CustomQueryableFieldDescriptionsProvider in code__
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_8-cs' />
	<snippet id='radpivotgrid-features-queryabledataprovider-queryabledatetimegroupdescription-block_8-vb' />

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})