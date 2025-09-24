---
title: Using QueryableDataProvider
page_title: Using QueryableDataProvider
description: Check our &quot;Using QueryableDataProvider&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-data-queryable
tags: using,queryabledataprovider
published: True
position: 3
site_name: WPF
---

# Using QueryableDataProvider

__QueryableDataProvider__ is one of the data source providers that can be used with __RadPivotGrid__ and __RadPivotFieldList__. __QueryableDataProvider__ provides an easy way to use data from database with __RadPivotGrid__. In fact any collection that implements *IQueryable* interface can be used as a source of __QueryableDataProvider__.      

## Defining QueryableDataProvider

> You have to add reference to the following __Telerik__ assembly to be able to use __QueryableDataProvider__ in your application:
>	* __Telerik.Pivot.DataProviders.Queryable__

You can define the __QueryableDataProvider__ as a *StaticResource* in your XAML if it will be used in more than one controls (for example if you have __RadPivotGrid__ and __RadPivotFieldList__ controls in your application) or define it directly for any of the controls you are planning to use:        

>importantThe __pivot__ namespace is URI namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. It is mandatory to define it if you are using the __QueryableDataProvider__ in your XAML.          

* Defined as a *StaticResource* and used in __RadPivotGrid__ and __RadPivotFieldList__:            



```XAML
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
```

>cautionIf you set different DataProviders for __RadPivotGrid__ and __RadPivotFieldList__ you will not be able to see any changes in __RadPivotGrid__ even when you change something in __RadPivotFieldList__. 

You can also create an object of type __QueryableDataProvider__ in the background and after that to use it for your controls:        



```C#
	QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
	this.radPivotGrid1.DataProvider = queryableDataProvider;
	this.radPivotFieldList1.DataProvider = queryableDataProvider;
```
```VB.NET
	Dim queryableDataProvider As New QueryableDataProvider()
	Me.radPivotGrid1.DataProvider = queryableDataProvider
	Me.radPivotFieldList1.DataProvider = queryableDataProvider
```

## Adding Data to QueryableDataProvider

The __QueryableDataProvider__ has *Source* property and it is mandatory to set it if you want to display any data. *Source* can be any instance of a class that implements IQueryable interface.        



```C#
	QueryableDataProvider queryableDataProvider = new QueryableDataProvider();
	queryableDataProvider.Source = MyCollection;
	this.radPivotGrid1.DataProvider = queryableDataProvider;
	this.radPivotFieldList1.DataProvider = queryableDataProvider;
```
```VB.NET
	Dim queryableDataProvider As New QueryableDataProvider()
	queryableDataProvider.Source = MyCollection
	Me.radPivotGrid1.DataProvider = queryableDataProvider
	Me.radPivotFieldList1.DataProvider = queryableDataProvider
```

## Adding Group Descriptions Collections

>caution When initializing the __QueryableDataProvider__ in the code behind it is a good idea to wrap all modifications in __BeginInit() - EndInit()__ section. This will cause only one refresh of the DataProvider and it will be when the EndInit() is reached. If you are applying only modifications (more than one) on already initialized __QueryableDataProvider__ you should use the DeferRefresh() method which will cause delay of the Refresh and this way all your changes will be applied simultaneously. More information for these methods is available in our [Populating with Data - Overview]({%slug radpivotgrid-populating-with-data%}) article.

The __QueryableDataProvider__ is using four different collections for the data that it holds:        

* __RowGroupDescription__ - the data added to this description will be shown as rows headers in __RadPivotGrid__ and __RadPivotFieldList__. The properties can be defined as QueryablePropertyGroupDescription, QueryableDateTimeGroupDescription, QueryableDoubleGroupDescription or you can create custom implementation of QueryableGroupDescription class. 

Here's how to define the __RowGroupDescriptions__ in your application:            



```XAML
	<pivot:QueryableDataProvider.RowGroupDescriptions>
	    <pivot:QueryablePropertyGroupDescription PropertyName="ShipCountry" />
	    <pivot:QueryableDoubleGroupDescription PropertyName="Freight" />
	    <pivot:QueryableDateTimeGroupDescription PropertyName="OrderDate" />
	</pivot:QueryableDataProvider.RowGroupDescriptions>
```



```C#
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
```
```VB.NET
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
```

* __ColumnGroupDescription__ - the data added to this description will be shown as columns headers in __RadPivotGrid__ and __RadPivotFieldList__. The properties can be defined as QueryablePropertyGroupDescription, QueryableDateTimeGroupDescription, QueryableDoubleGroupDescription or you can create custom implementation of QueryableGroupDescription class. 

Here's how to define the __ColumnGroupDescriptions__ in your application:            



```XAML
	<pivot:QueryableDataProvider.ColumnGroupDescriptions>
	    <pivot:QueryableDoubleGroupDescription PropertyName="Freight"/>
	</pivot:QueryableDataProvider.ColumnGroupDescriptions>
```



```C#
	QueryableDoubleGroupDescription doubleGroupDescription = new QueryableDoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Freight";
	queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription);
```
```VB.NET
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Freight"
	queryableDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription)
```

* __AggregateDescriptions__ - the data added to this description will be aggregated and included in __RadPivotGrid__ as Cells. The properties can be defined as QueryablePropertyAggregateDescription or you can create custom implementation of QueryableAggregateDescription class.

Here's how to define the __AggregateDescriptions__ in your application:            



```XAML
	<pivot:QueryableDataProvider.AggregateDescriptions>
	    <pivot:QueryablePropertyAggregateDescription AggregateFunction="Count" StringFormat="C" PropertyName="Freight"/>
	    <pivot:QueryablePropertyAggregateDescription PropertyName="ShipVia"/>
	</pivot:QueryableDataProvider.AggregateDescriptions>
```



```C#
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
```
```VB.NET
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
```

With R2 2016 of UI for WPF a brand new property __IgnoreNullValues__ was introduced for the __PropertyAggregateDescription__. This property is of type bool and it is used to determine whether a specific __PropertyAggregateDescription__ should ignore the null values when calculating its result. The default value of the property is false, so in order to ignore the null values, you should set the property to __true__.	  	

Here's how to define the __AggregateDescriptions__ in your application with a set __IgnoreNullValues__ property::            



```XAML
	<pivot:QueryableDataProvider.AggregateDescriptions>
	    <pivot:QueryablePropertyAggregateDescription AggregateFunction="Count" StringFormat="C" PropertyName="Freight" IgnoreNullValues="true"/>
	    <pivot:QueryablePropertyAggregateDescription PropertyName="ShipVia"/>
	</pivot:QueryableDataProvider.AggregateDescriptions>
```


In order to set the __IgnoreNullValues__ to true for all __PropertyAggregateDescriptions__ you would add in the __LocalDataSourceProvider__ you should handle the __LocalDataSourceProvider.PrepareDescriptionForField__ event and set IgnoreNullValues in the handler:



```C#
	private void QueryableDataProvider_PrepareDescriptionForField(object sender, Telerik.Pivot.Core.PrepareDescriptionForFieldEventArgs e)
	{
		var description = e.Description as QueryablePropertyAggregateDescription;
		if (description != null)
		{
			description.IgnoreNullValues = true;
		}
	}
```
```VB.NET
	Private Sub QueryableDataProvider_PrepareDescriptionForField(sender As Object, e As Telerik.Pivot.Core.PrepareDescriptionForFieldEventArgs)
		Dim description = TryCast(e.Description, QueryablePropertyAggregateDescription)
		If description IsNot Nothing Then
			description.IgnoreNullValues = True
		End If
	End Sub
```

* __FilterDescriptions__ - the data added to this description will be filtered and after that included in __RadPivotGrid__. The properties can be defined as QueryablePropertyFilterDescription or you can create custom implementation of QueryableFilterDescription class.            



```XAML
	<pivot:QueryableDataProvider.FilterDescriptions>
	    <pivot:QueryablePropertyFilterDescription PropertyName="Freight">
	        <pivot:QueryablePropertyFilterDescription.Condition>
	            <queryableFilters:QueryableIntervalCondition From="10" To="200"/>
	        </pivot:QueryablePropertyFilterDescription.Condition>
	    </pivot:QueryablePropertyFilterDescription>
	</pivot:QueryableDataProvider.FilterDescriptions>
```



```C#
	var freightFilterDescription = new QueryablePropertyFilterDescription();
	freightFilterDescription.PropertyName = "Freight";
	var intervalCondition = new QueryableIntervalCondition();
	intervalCondition.From = 10;
	intervalCondition.To = 200;
	freightFilterDescription.Condition = intervalCondition;
	
	queryableDataProvider.FilterDescriptions.Add(freightFilterDescription);
```
```VB.NET
	Dim freightFilterDescription = New QueryablePropertyFilterDescription()
	freightFilterDescription.PropertyName = "Freight"
	Dim intervalCondition = New QueryableIntervalCondition()
	intervalCondition.From = 10
	intervalCondition.To = 200
	freightFilterDescription.Condition = intervalCondition
	
	queryableDataProvider.FilterDescriptions.Add(freightFilterDescription)
```

## Adding Property Descriptions

All property description classes are inheriting the abstract class DescriptionBase. That's why all of them have the following properties:

* __PropertyName__ - this is the most important property. It must be set to the property of the data that will be represent with this property description.            

* __CustomName__ - sets the name that will be shown instead of the property name in __RadPivotGrid__ and __RadPivotFieldList__.            

Here is a list of the property descriptions that you can use:

* __QueryablePropertyGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions.            

* __QueryableDoubleGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of numeric type. One of the imporant properties is *Step* - it is used to define the size of the generated groups.           

* __QueryableDateTimeGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type DateTime. Very useful is *Step* property where you can set if the grouping should be on year, quarter, month or day.            

* __QueryablePropertyFilterDescription__ - available for FilterDescriptions only. The important property here is *Condition* as the filtering is done based on it. You can use four conditions: QueryableComparisonCondition, QueryableIntervalCondition, QueryableSetCondition, QueryableTextCondition, QueryableItemsFilterCondition.            

* __QueryablePropertyAggregateDescription__ - available for AggregateDescriptions only. You have to define the *AggregateFunction* that will be used. You have five predefined functions - Average, Count, Min, Max and Sum.            
