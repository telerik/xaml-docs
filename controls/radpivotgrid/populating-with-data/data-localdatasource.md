---
title: Using LocalDataSourceProvider
page_title: Using LocalDataSourceProvider
description: Using LocalDataSourceProvider
slug: radpivotgrid-data-localdatasource
tags: using,localdatasourceprovider
published: True
position: 0
---

# Using LocalDataSourceProvider



__LocalDataSourceProvider__ is one of the data source providers that can be used with __RadPivotGrid__ and __RadPivotFieldList__.
      		__LocalDataSourceProvider__ provides data access to local source such as an IList of instances of user defined classes. In fact any collection that implements *IEnumerable* interface
      		can be used as a __LocalDataSourceProvider__.
      	

## Defining LocalDataSourceProvider

>The __LocalDataSourceProvider__ class is part of __Telerik.Pivot.Core__ assembly, namespace: __"Telerik.Pivot.DataProviders"__.

You can define the __LocalDataSourceProvider__	as a *StaticResource* in your XAML if it will be used in more than one controls (for example if you have __RadPivotGrid__
			and __RadPivotFieldList__ controls in your application) or define it directly for any of the controls you are planning to use:
		

>importantThe __pivot__ namespace is URI namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. It is mandatory to define it if you are using the 
				__LocalDataSourceProvider__ in your XAML.
			

* Defined as a *StaticResource* and used in __RadPivotGrid__ and __RadPivotFieldList__:

#### __XAML__

{{region radpivotgrid-data-local_1}}
	<Grid>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="*"/>
	        <ColumnDefinition Width="250"/>
	    </Grid.ColumnDefinitions>
	    <Grid.Resources>
	        <pivot:LocalDataSourceProvider x:Key="LocalDataSourceProvider">
	        </pivot:LocalDataSourceProvider>
	    </Grid.Resources>
	
	    <pivot:RadPivotGrid Name="radPivotGrid1" DataProvider="{StaticResource LocalDataProvider}">
	    <pivot:RadPivotFieldList Name="radPivotFieldList1" Grid.Column="1"  DataProvider="{StaticResource LocalDataProvider}"/>
	</Grid>
	{{endregion}}



You can also create an object of type __LocalDataSourceProvider__ in the background and after that to use it for your controls:
		

#### __C#__

{{region radpivotgrid-data-local_1}}
	LocalDataSourceProvider localDataProvider = new LocalDataSourceProvider();
	this.radPivotGrid1.DataProvider = localDataProvider;
	this.radPivotFieldList1.DataProvider = localDataProvider;
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_1}}
	Dim localDataProvider As New LocalDataSourceProvider()
	Me.radPivotGrid1.DataProvider = localDataProvider
	Me.radPivotFieldList1.DataProvider = localDataProvider
	{{endregion}}



## Adding Data to LocalDataSourceProvider

The __LocalDataSourceProvider__ has *ItemsSource* and it is mandatory to set it if you want to display any data.
          *ItemsSource* is a dependency property and you are able to use binding for it, but we recommend setting it in code:
    		

#### __C#__

{{region radpivotgrid-data-local_2}}
	LocalDataSourceProvider localDataProvider = new LocalDataSourceProvider();
	localDataProvider.ItemsSource = MyCollection;
	this.radPivotGrid1.DataProvider = localDataProvider;
	this.radPivotFieldList1.DataProvider = localDataProvider;
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_2}}
	Dim localDataProvider As New LocalDataSourceProvider()
	localDataProvider.ItemsSource = MyCollection
	Me.radPivotGrid1.DataProvider = localDataProvider
	Me.radPivotFieldList1.DataProvider = localDataProvider
	{{endregion}}



>The *MyCollection* can be any collection that implements IEnumerable interface or even datatable.

## Adding Group Descriptions Collections

The __LocalDataSourceProvider__ is using four different collections for the data that it holds:
    		

* __RowGroupDescription__ - the data added to this description will be shown as rows headers in __RadPivotGrid__ and __RadPivotFieldList__.
    					The properties can be defined as PropertyGroupDescription, DateTimeGroupDescription, DoubleGroupDescription or you can create custom implementation of PropertyGroupDescriptionBase class.
    				Here's how to define the __RowGroupDescriptions__ in your application:
    				

#### __XAML__

{{region radpivotgrid-data-local_3}}
	<pivot:LocalDataSourceProvider.RowGroupDescriptions>
	    <pivot:PropertyGroupDescription PropertyName="Name" />
	    <pivot:DateTimeGroupDescription PropertyName="Date" Step="Month" />
	</pivot:LocalDataSourceProvider.RowGroupDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-local_3}}
	Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
	propertyGroupDescription.PropertyName = "Name";
	DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
	dateTimeGroupDescription.PropertyName = "Date";
	dateTimeGroupDescription.Step = DateTimeStep.Month;
	
	using (localDataProvider.DeferRefresh())
	{
	    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription);
	    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription);
	};
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_3}}
	Dim propertyGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
	propertyGroupDescription.PropertyName = "Name"
	Dim dateTimeGroupDescription As New DateTimeGroupDescription()
	dateTimeGroupDescription.PropertyName = "Date"
	dateTimeGroupDescription.Step = DateTimeStep.Month
	Using localDataProvider.DeferRefresh()
	    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription)
	    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription)
	End Using
	{{endregion}}



* __ColumnGroupDescription__ - the data added to this description will be shown as columns headers in __RadPivotGrid__ and __RadPivotFieldList__.
    					The properties can be defined as PropertyGroupDescription, DateTimeGroupDescription, DoubleGroupDescription or you can create custom implementation of PropertyGroupDescriptionBase class.
    				Here's how to define the __ColumnGroupDescriptions__ in your application:
    				

#### __XAML__

{{region radpivotgrid-data-local_4}}
	<pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
	    <pivot:DoubleGroupDescription PropertyName="Price"/>
	</pivot:LocalDataSourceProvider.ColumnGroupDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-local_4}}
	DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
	doubleGroupDescription.PropertyName = "Price";
	localDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription);
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_4}}
	Dim doubleGroupDescription As New DoubleGroupDescription()
	doubleGroupDescription.PropertyName = "Price"
	localDataProvider.ColumnGroupDescriptions.Add(doubleGroupDescription)
	{{endregion}}



* __AggregateDescriptions__ - the data added to this description will be aggregated and included in __RadPivotGrid__ as Cells.
    					The properties can be defined as PropertyAggregateDescription or you can create custom implementation of PropertyAggregateDescriptionBase class.
    				Here's how to define the __AggregateDescriptions__ in your application:
    				

#### __XAML__

{{region radpivotgrid-data-local_5}}
	<pivot:LocalDataSourceProvider.AggregateDescriptions>
	    <pivot:PropertyAggregateDescription PropertyName="Price" StringFormat="C" AggregateFunction="Average" />
	    <pivot:PropertyAggregateDescription PropertyName="Quantity"/>
	</pivot:LocalDataSourceProvider.AggregateDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-local_5}}
	PropertyAggregateDescription propertyAggregateDescription1 = new PropertyAggregateDescription();
	propertyAggregateDescription1.PropertyName = "Price";
	propertyAggregateDescription1.StringFormat = "C";
	propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average;
	
	PropertyAggregateDescription propertyAggregateDescription2 = new PropertyAggregateDescription();
	propertyAggregateDescription2.PropertyName = "Quantity";
	
	using (localDataProvider.DeferRefresh())
	{
	    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1);
	    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2);
	};
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_5}}
	Dim propertyAggregateDescription1 As New PropertyAggregateDescription()
	propertyAggregateDescription1.PropertyName = "Price"
	propertyAggregateDescription1.StringFormat = "C"
	propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average
	
	Dim propertyAggregateDescription2 As New PropertyAggregateDescription()
	propertyAggregateDescription2.PropertyName = "Quantity"
	
	Using localDataProvider.DeferRefresh()
	    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1)
	    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2)
	End Using   
	{{endregion}}



* __FilterDescriptions__ - the data added to this description will be filtered and after that included in __RadPivotGrid__.
    					The properties can be defined as PropertyFilterDescription or you can create custom implementation of PropertyFilterDescriptionBase class.
    				

#### __XAML__

{{region radpivotgrid-data-local_6}}
	<pivot:LocalDataSourceProvider.FilterDescriptions>
	    <pivot:PropertyFilterDescription PropertyName="Name">
	        <pivot:PropertyFilterDescription.Condition>
	            <pivot:TextCondition Comparison="BeginsWith" Pattern="N" />
	        </pivot:PropertyFilterDescription.Condition>
	    </pivot:PropertyFilterDescription>
	</pivot:LocalDataSourceProvider.FilterDescriptions>
	{{endregion}}



#### __C#__

{{region radpivotgrid-data-local_6}}
	TextCondition txtCondition = new TextCondition();
	txtCondition.Comparison = TextComparison.BeginsWith;
	txtCondition.Pattern = "N";
	
	PropertyFilterDescription filterDescription = new PropertyFilterDescription();
	filterDescription.PropertyName = "Name";
	filterDescription.Condition = txtCondition;
	localDataProvider.FilterDescriptions.Add(filterDescription);
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-data-local_6}}
	Dim txtCondition As New TextCondition()
	txtCondition.Comparison = TextComparison.BeginsWith
	txtCondition.Pattern = "N"
	
	Dim filterDescription As New PropertyFilterDescription()
	filterDescription.PropertyName = "Name"
	filterDescription.Condition = txtCondition
	localDataProvider.FilterDescriptions.Add(filterDescription)
	{{endregion}}



## Adding Property Descriptions

All property description classes are inheriting the abstract class DescriptionBase. That's why all of them have the following properties:

* __PropertyName__ - this is the most important property. It must be set to the property of the data that will be represent with this property description.
    				

* __CustomName__ - sets the name that will be shown instead of the property name in __RadPivotGrid__ and __RadPivotFieldList__.
    				

Here is a list of the property descriptions that you can use:

* __PropertyGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions.

* __DoubleGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type Double. One of the imporant properties is *Step*
                    - it is used to define the size of the generated groups.
                    

* __DateTimeGroupDescription__ - available for RowGroupDescriptions and ColumnGroupDescriptions. Used when the data is of type DateTime. Very useful is *Step* property
                        where you can set if the grouping should be on day, month or year.
                    

* __PropertyFilterDescription__ - available for FilterDescriptions only. The important property here is *Condition* as the filtering is done based on it.
                        You can use four conditions: ComparisonCondition, IntervalCondition, SetCondition, TextCondition. 
                    

* __PropertyAggregateDescription__ - available for AggregateDescriptions only. You have to define the *AggregateFunction* that will be used. You have various of predefined functions like Average, Sum, Min, Max etc.

# See Also

 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})

 * [Adding RadPivotFieldList to your project]({%slug radpivotgrid-fieldlist-started%})

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})
