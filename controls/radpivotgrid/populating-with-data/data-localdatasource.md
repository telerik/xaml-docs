---
title: Using LocalDataSourceProvider
page_title: Using LocalDataSourceProvider
description: Check our &quot;Using LocalDataSourceProvider&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-data-localdatasource
tags: using,localdatasourceprovider
published: True
position: 0
---

# Using LocalDataSourceProvider

__LocalDataSourceProvider__ is one of the data source providers that can be used with __RadPivotGrid__ and __RadPivotFieldList__. __LocalDataSourceProvider__ provides data access to a local source such as an IList of instances of user defined classes. In fact, any collection that implements the *IEnumerable* interface can be used as a __LocalDataSourceProvider__.      	

## Defining LocalDataSourceProvider

>The __LocalDataSourceProvider__ class is part of __Telerik.Pivot.Core__ assembly, namespace: __"Telerik.Pivot.DataProviders"__.

You can define the __LocalDataSourceProvider__	as a *StaticResource* in your XAML if it will be used in more than one control (for example, if you have __RadPivotGrid__ and __RadPivotFieldList__ controls in your application) or define it directly for any of the controls you are planning to use:		

>important The __pivot__ namespace is the URI namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. It is mandatory to define it if you are using the __LocalDataSourceProvider__ in your XAML.			

* Defined as a *StaticResource* and used in __RadPivotGrid__ and __RadPivotFieldList__:

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_1-xaml' />

>caution If you set different DataProviders for __RadPivotGrid__ and __RadPivotFieldList__ you will not be able to see any changes in __RadPivotGrid__, even when you change something in __RadPivotFieldList__. 

You can also create an object of type __LocalDataSourceProvider__ in the background and after that, you can use it for your controls:		

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_2-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_2-vb' />

## Adding Data to LocalDataSourceProvider

The __LocalDataSourceProvider__ has an *ItemsSource* and it is mandatory to set it if you want to display any data. *ItemsSource* is a dependency property and you are able to use binding for it, but we recommend setting it in code:    		

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_3-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_3-vb' />

>The *MyCollection* can be any collection that implements the IEnumerable interface or a datatable.

## Adding Group Descriptions Collections

>caution When initializing the __LocalDataSourceProvider__ in the code-behind, it is a good idea to wrap all modifications in a __BeginInit() - EndInit()__ section. This will cause only one refresh of the DataProvider and it will be when the EndInit() is reached. If you are applying only modifications (more than one) on an already initialized LocalDataSourceProvider, you should use the DeferRefresh() method, which will cause delay of the refresh. This way, all of your changes will be applied simultaneously. You can find more information for these methods in the [Populating with Data - Overview]({%slug radpivotgrid-populating-with-data%}) article.

The __LocalDataSourceProvider__ is using four different collections for the data that it holds:    		

* __RowGroupDescription__ - The data added to this description will be shown as row headers in __RadPivotGrid__ and __RadPivotFieldList__. The properties can be defined as PropertyGroupDescription, DateTimeGroupDescription, DoubleGroupDescription or you can create custom implementation of PropertyGroupDescriptionBase class. Here's how to define the __RowGroupDescriptions__ in your application:   				

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_4-xaml' />

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_5-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_5-vb' />

* __ColumnGroupDescription__ - The data added to this description will be shown as column headers in __RadPivotGrid__ and __RadPivotFieldList__. The properties can be defined as PropertyGroupDescription, DateTimeGroupDescription, DoubleGroupDescription or you can create a custom implementation of the PropertyGroupDescriptionBase class. Here's how to define the __ColumnGroupDescriptions__ in your application:    				

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_6-xaml' />

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_7-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_7-vb' />

* __AggregateDescriptions__ - The data added to this description will be aggregated and included in a __RadPivotGrid__ as cells. The properties can be defined as PropertyAggregateDescription or you can create a custom implementation of the PropertyAggregateDescriptionBase class. 

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_8-xaml' />

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_9-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_9-vb' />

With the R2 2016 release of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, a brand new property, __IgnoreNullValues__, was introduced for the __PropertyAggregateDescription__. This property is of type bool and it is used to determine whether a specific __PropertyAggregateDescription__ should ignore the null values when calculating its result. The default value of the property is __false__, so in order to ignore the null values, you should set the property to __true__.	 				

Here's how to define the __AggregateDescriptions__ in your application with a set __IgnoreNullValues__ property:
	
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_10-xaml' />

In order to set the __IgnoreNullValues__ to __true__ for all __PropertyAggregateDescriptions__ that you want to add in the __LocalDataSourceProvider__, you should handle the __LocalDataSourceProvider.PrepareDescriptionForField__ event and set __IgnoreNullValues__ in the handler:

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_11-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_11-vb' />

* __FilterDescriptions__ - The data added to this description will be filtered and after that, included in __RadPivotGrid__. The properties can be defined as PropertyFilterDescription or you can create a custom implementation of the PropertyFilterDescriptionBase class.    				

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_12-xaml' />

<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_13-cs' />
<snippet id='radpivotgrid-populating-with-data-data-localdatasource-block_13-vb' />

## Adding Property Descriptions

All property description classes will inherit the DescriptionBase abstract class. That's why all of them have the following properties:

* __PropertyName__ - This is the most important property. It must be set to the property of the data that will be represented with this property description.

* __CustomName__ - Sets the name that will be shown instead of the property name in __RadPivotGrid__ and __RadPivotFieldList__.    				

Here is a list of the property descriptions that you can use:

* __PropertyGroupDescription__: Available for RowGroupDescriptions and ColumnGroupDescriptions.

* __DoubleGroupDescription__: Available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type Double. One of the imporant properties is *Step*, which is used to define the size of the generated groups.                    

* __DateTimeGroupDescription__: Available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type DateTime. The *Step* property is very useful; you can set it if the grouping should be on day, month or year.   

* __PropertyFilterDescription__: Available for FilterDescriptions only. The important property here is *Condition* as the filtering is done based on it. You can use four conditions: ComparisonCondition, IntervalCondition, SetCondition or TextCondition.                     

* __PropertyAggregateDescription__: Available for AggregateDescriptions only. You have to define the *AggregateFunction* that will be used. You can use various predefined functions including Average, Sum, Min, Max, etc.

## See Also

 * [Populating with data]({%slug radpivotgrid-populating-with-data%})

 * [Adding RadPivotFieldList to your project]({%slug radpivotgrid-fieldlist%})

 * [RadPivotGrid getting started]({%slug radpivotgrid-getting-started%})