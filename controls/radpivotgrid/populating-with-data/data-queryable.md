---
title: Using QueryableDataProvider
page_title: Using QueryableDataProvider
description: Using QueryableDataProvider
slug: radpivotgrid-data-queryable
tags: using,queryabledataprovider
publish: True
position: 3
site_name: WPF
---

# Using QueryableDataProvider



__QueryableDataProvider__ is one of the data source providers that can be used with __RadPivotGrid__ and __RadPivotFieldList__.
        __QueryableDataProvider__ provides an easy way to use data from database with __RadPivotGrid__. In fact any collection that implements *IQueryable* interface
        can be used as a source of __QueryableDataProvider__.
      

## Defining QueryableDataProvider

You can define the __QueryableDataProvider__	as a *StaticResource* in your XAML if it will be used in more than one controls (for example if you have __RadPivotGrid__
          and __RadPivotFieldList__ controls in your application) or define it directly for any of the controls you are planning to use:
        

>importantThe __pivot__ namespace is URI namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. It is mandatory to define it if you are using the
            __QueryableDataProvider__ in your XAML.
          

* Defined as a *StaticResource* and used in __RadPivotGrid__ and __RadPivotFieldList__:
            

#### __XAML__

{{region radpivotgrid-data-queryable_1}}
	<Grid>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="*"/>
	        <ColumnDefinition Width="250"/>
	    </Grid.ColumnDefinitions>
	    <Grid.Resources>
	        <pivot:QueryableDataProvider x:Key="QueryableDataProvider">
	        </pivot:QueryableDataProvider>
	    </Grid.Resources>
	
	    <pivot:RadPivotGrid Name="radPivotGrid" DataProvider="{StaticResource QueryableDataProvider}">
	    <pivot:RadPivotFieldList Name="radPivotFieldList" Grid.Column="1"  DataProvider="{StaticResource QueryableDataProvider}"/>
	</Grid>
	{{endregion}}



You can also create an object of type __QueryableDataProvider__ in the background and after that to use it for your controls:
        

#### __C#__

{{region radpivotgrid-data-queryable_1}}
	QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
	this.radPivotGrid1.DataProvider = queryableDataProvider;
	this.radPivotFieldList1.DataProvider = queryableDataProvider;
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_1}}
	Dim queryableDataProvider As New QueryableDataProvider()
	Me.radPivotGrid1.DataProvider = queryableDataProvider
	Me.radPivotFieldList1.DataProvider = queryableDataProvider
	{{endregion}}



## Adding Data to QueryableDataProvider

The __QueryableDataProvider__ has *Source* property and it is mandatory to set it if you want to display any data.
          *Source* can be any instance of a class that implements IQueryable interface.
        

#### __C#__

{{region radpivotgrid-data-queryable_2}}
	QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
	queryableDataProvider.Source = MyCollection;
	this.radPivotGrid1.DataProvider = queryableDataProvider;
	this.radPivotFieldList1.DataProvider = queryableDataProvider;
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_2}}
	Dim queryableDataProvider As New QueryableDataProvider()
	queryableDataProvider.Source = MyCollection
	Me.radPivotGrid1.DataProvider = queryableDataProvider
	Me.radPivotFieldList1.DataProvider = queryableDataProvider
	{{endregion}}



## Adding Group Descriptions Collections

The __QueryableDataProvider__ is using four different collections for the data that it holds:
        

* __RowGroupDescription__ - the data added to this description will be shown as rows headers in __RadPivotGrid__ and __RadPivotFieldList__.
              The properties can be defined as QueryablePropertyGroupDescription, QueryableDateTimeGroupDescription, QueryableDoubleGroupDescription or you can create custom implementation of QueryableGroupDescription class.
            Here's how to define the __RowGroupDescriptions__ in your application:
            

#### __XAML__

{{region radpivotgrid-data-queryable_3}}
	<pivot:QueryableDataProvider.RowGroupDescriptions>
	    <pivot:QueryablePropertyGroupDescription PropertyName="ShipCountry" />
	    <pivot:QueryableDoubleGroupDescription PropertyName="Freight" />
	    <pivot:QueryableDateTimeGroupDescription PropertyName="OrderDate" />
	</pivot:QueryableDataProvider.RowGroupDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-queryable_3}}
	var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
	shipCountryGroupDescription.PropertyName = "ShipCountry";
	
	var freightCountryGroupDescription = new QueryableDoubleGroupDescription();
	freightCountryGroupDescription.PropertyName = "Freight";;
	
	var orderDateCountryGroupDescription = new QueryableDateTimeGroupDescription();
	orderDateCountryGroupDescription.PropertyName = "OrderDate";
	
	using (queryableDataProvider.DeferRefresh())
	{
	    queryableDataProvider.RowGroupDescriptions.Add(shipCountryGroupDescription);
	    queryableDataProvider.RowGroupDescriptions.Add(freightCountryGroupDescription);
	    queryableDataProvider.RowGroupDescriptions.Add(orderDateCountryGroupDescription);
	};
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_3}}
	Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
	shipCountryGroupDescription.PropertyName = "ShipCountry"
	
	Dim freightCountryGroupDescription = New QueryableDoubleGroupDescription()
	freightCountryGroupDescription.PropertyName = "Freight"
	
	Dim orderDateCountryGroupDescription = New QueryableDateTimeGroupDescription()
	orderDateCountryGroupDescription.PropertyName = "OrderDate"
	
	Using queryableDataProvider.DeferRefresh()
		queryableDataProvider.RowGroupDescriptions.Add(shipCountryGroupDescription)
		queryableDataProvider.RowGroupDescriptions.Add(freightCountryGroupDescription)
		queryableDataProvider.RowGroupDescriptions.Add(orderDateCountryGroupDescription)
	End Using
	{{endregion}}



* __ColumnGroupDescription__ - the data added to this description will be shown as columns headers in __RadPivotGrid__ and __RadPivotFieldList__.
              The properties can be defined as QueryablePropertyGroupDescription, QueryableDateTimeGroupDescription, QueryableDoubleGroupDescription or you can create custom implementation of QueryableGroupDescription class.
            Here's how to define the __ColumnGroupDescriptions__ in your application:
            

#### __XAML__

{{region radpivotgrid-data-queryable_4}}
	<pivot:QueryableDataProvider.ColumnGroupDescriptions>
	    <pivot:QueryableDoubleGroupDescription PropertyName="Freight"/>
	</pivot:QueryableDataProvider.ColumnGroupDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-queryable_4}}
	QueryableDoubleGroupDescription doubleGroupDescription = new QueryableDoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Freight";
	queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription);
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_4}}
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Freight"
	queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription)
	{{endregion}}



* __AggregateDescriptions__ - the data added to this description will be aggregated and included in __RadPivotGrid__ as Cells.
              The properties can be defined as QueryablePropertyAggregateDescription or you can create custom implementation of QueryableAggregateDescription class.
            Here's how to define the __AggregateDescriptions__ in your application:
            

#### __XAML__

{{region radpivotgrid-data-queryable_5}}
	<pivot:QueryableDataProvider.AggregateDescriptions>
	    <pivot:QueryablePropertyAggregateDescription AggregateFunction="Count" StringFormat="C" PropertyName="Freight"/>
	    <pivot:QueryablePropertyAggregateDescription PropertyName="ShipVia"/>
	</pivot:QueryableDataProvider.AggregateDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-queryable_5}}
	var freightAggregateDescription = new QueryablePropertyAggregateDescription();
	freightAggregateDescription.PropertyName = "Freight";
	freightAggregateDescription.StringFormat = "C";
	freightAggregateDescription.AggregateFunction = QueryableAggregateFunction.Max;
	
	var shipViaAggregateDescription = new QueryablePropertyAggregateDescription();
	freightAggregateDescription.PropertyName = "ShipVia";
	
	
	using (queryableDataProvider.DeferRefresh())
	{
	    queryableDataProvider.AggregateDescriptions.Add(freightAggregateDescription);
	    queryableDataProvider.AggregateDescriptions.Add(shipViaAggregateDescription);
	};
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_5}}
	Dim freightAggregateDescription = New QueryablePropertyAggregateDescription()
	freightAggregateDescription.PropertyName = "Freight"
	freightAggregateDescription.StringFormat = "C"
	freightAggregateDescription.AggregateFunction = QueryableAggregateFunction.Max
	
	Dim shipViaAggregateDescription = New QueryablePropertyAggregateDescription()
	freightAggregateDescription.PropertyName = "ShipVia"
	
	Using queryableDataProvider.DeferRefresh()
		queryableDataProvider.AggregateDescriptions.Add(freightAggregateDescription)
		queryableDataProvider.AggregateDescriptions.Add(shipViaAggregateDescription)
	End Using
	{{endregion}}



* __FilterDescriptions__ - the data added to this description will be filtered and after that included in __RadPivotGrid__.
              The properties can be defined as QueryablePropertyFilterDescription or you can create custom implementation of QueryableFilterDescription class.
            

#### __XAML__

{{region radpivotgrid-data-queryable_6}}
	<pivot:QueryableDataProvider.FilterDescriptions>
	    <pivot:QueryablePropertyFilterDescription PropertyName="Freight">
	        <pivot:QueryablePropertyFilterDescription.Condition>
	            <queryableFilters:QueryableIntervalCondition From="10" To="200"/>
	        </pivot:QueryablePropertyFilterDescription.Condition>
	    </pivot:QueryablePropertyFilterDescription>
	</pivot:QueryableDataProvider.FilterDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-queryable_6}}
	var freightFilterDescription = new QueryablePropertyFilterDescription();
	freightFilterDescription.PropertyName = "Freight";
	var intervalCondition = new QueryableIntervalCondition();
	intervalCondition.From = 10;
	intervalCondition.To = 200;
	freightFilterDescription.Condition = intervalCondition;
	
	queryableDataProvider.FilterDescriptions.Add(freightFilterDescription);
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-queryable_6}}
	Dim freightFilterDescription = New QueryablePropertyFilterDescription()
	freightFilterDescription.PropertyName = "Freight"
	Dim intervalCondition = New QueryableIntervalCondition()
	intervalCondition.From = 10
	intervalCondition.To = 200
	freightFilterDescription.Condition = intervalCondition
	
	queryableDataProvider.FilterDescriptions.Add(freightFilterDescription)
	{{endregion}}



## Adding Property Descriptions

All property description classes are inheriting the abstract class DescriptionBase. That's why all of them have the following properties:

* __PropertyName__ - this is the most important property. It must be set to the property of the data that will be represent with this property description.
            

* __CustomName__ - sets the name that will be shown instead of the property name in __RadPivotGrid__ and __RadPivotFieldList__.
            

Here is a list of the property descriptions that you can use:

* __QueryablePropertyGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions.
            

* __QueryableDoubleGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of numeric type. One of the imporant properties is *Step*
              - it is used to define the size of the generated groups.
            

* __QueryableDateTimeGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type DateTime. Very useful is *Step* property
              where you can set if the grouping should be on year, quarter, month or day.
            

* __QueryablePropertyFilterDescription__ - available for FilterDescriptions only. The important property here is *Condition* as the filtering is done based on it.
              You can use four conditions: QueryableComparisonCondition, QueryableIntervalCondition, QueryableSetCondition, QueryableTextCondition, QueryableItemsFilterCondition.
            

* __QueryablePropertyAggregateDescription__ - available for AggregateDescriptions only. You have to define the *AggregateFunction* that will be used. You have five predefined functions - Average, Count, Min, Max and Sum.
            
