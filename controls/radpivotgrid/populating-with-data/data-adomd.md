---
title: Using AdomdDataProvider
page_title: Using AdomdDataProvider
description: Check our &quot;Using AdomdDataProvider&quot; documentation article for the RadPivotGrid WPF control.
slug: radpivotgrid-data-adomd
tags: using,adomddataprovider
published: True
position: 2
site_name: WPF
---

# Using AdomdDataProvider

In this article we will show how to use `AdomdDataProvider` and use data from OLAP Cube for `RadPivotGrid`.

## ADOMD.NET

__ADOMD.NET__ is a Microsoft .NET Framework data provider that is designed to communicate with Microsoft SQL Server Analysis Services. __ADOMD.NET__ uses the XML for Analysis protocol to communicate with analytical data sources. More information about ADOMD can be found [here](http://msdn.microsoft.com/en-us/library/ms123483(v=sql.90).aspx).   

> RadPivotGrid supports both multidimensional and tabular OLAP Cubes (except the __DirectQuery__ mode of the Tabular cubes).

## AdomdDataProvider

RadPivotGrid can use AdomdDataProvider to get data from OLAP Cube.     

>With the release of the 2025 Q4, the __Telerik.Pivot.DataProviders.Adomd__ assembly requires a reference to the __Microsoft.AnalysisServices.AdomdClient__ NuGet package. The Telerik.Pivot.DataProviders.Adomd assembly is built against the __19.84.1__ version of this NuGet package.

>You have to add reference to the following Telerik assembly to be able to use AdomdDataProvider in your application:
>* Telerik.Pivot.DataProviders.Adomd 		

AdomdDataProvider has several important properties that have to be defined in order to connect to OLAP Cube:      		

* `ConnectionSettings`&mdash;this property is of type *AdomdConnectionSettings* and it exposes several properties that are mandatory when connecting to the OLAP Cube:      				

	* `Cube`&mdash;string property defining the exact name of the Cube.

	* `Database`&mdash;string property defining the exact name of the Database.

	* `ConnectionString`&mdash;string property used to open a database. It is in OLE DB connection string format.

	>The OLE DB connection string format has several keys and values connected with equal sign. The different key-value pairs are separated by semicolon characters. Some of the important properties are *Provider*, *Data Source*, *Integrated Security*, etc. Here are some examples for different OLE DB connection strings:
	>	* "Provider=MSOLAP;Data Source=myServerAddress;Initial Catalog=myDataBase;"
	>	* "Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=myDataBase;User Id=domain\user;Password=myPassword;"
	>	* "Provider=MSOLAP;Integrated Security=SSPI;Persist Security Info=False;Data Source=ServerName;Initial Catalog=myDataBase;"
	
	<!-- -->
	
	>It is mandatory to use your Database name in the Database property and in the ConnectionString as Initial Catalog. If you do not set it in one of these properties, you will not be able to get the data from the server. Correct settings are shown below:
	>	ConnectionString="Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=DatabaseName"
	>	Cube="CubeName"
	>	Database="DatabaseName"                  

* `AggregatesLevel`&mdash;set the position where groups for the aggregates should be placed.

* `AggregatesPosition`&mdash;defines whether the positon of the Aggregates will be Columns or Rows.

AdomdDataProvider uses four different collections to design the view of RadPivotGrid report and `RadPivotFieldList`: *RowGroupDescriptions, ColumnGroupDescriptions, AggregateDescriptions, FilterDescriptions.*.    		

## Defining AdomdDataProvider

You can define your AdomdDataProvider as a *StaticResource* in the XAML and then use it in both RadPivotGrid and RadPivotFieldList controls.      		

>importantThe __pivot__ namespace is URI namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. It is mandatory to define it if you are using the AdomdDataProvider in your XAML.				

```XAML
	<Grid>
	    <Grid.Resources>
	        <pivot:AdomdDataProvider x:Key="ADOMDDataProvider"/>
	    </Grid.Resources>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="2*"/>
	        <ColumnDefinition Width="*"/>
	    </Grid.ColumnDefinitions>
	    
	    <pivot:RadPivotGrid x:Name="radPivotGrid" DataProvider="{StaticResource ADOMDDataProvider}"/>
	    <pivot:RadPivotFieldList x:Name="radPivotFieldList" Grid.Column="1" DataProvider="{StaticResource ADOMDDataProvider}"/>
	</Grid>
```

You can also create an object of type AdomdDataProvider in the code behind and set it for your controls:

```C#
	AdomdDataProvider adomdDataProvider = new AdomdDataProvider();
	
	this.radPivotGrid.DataProvider = adomdDataProvider;
	this.radPivotFieldList.DataProvider = adomdDataProvider;
```
```VB.NET
	Dim adomdDataProvider As New AdomdDataProvider()
	
	Me.radPivotGrid.DataProvider = adomdDataProvider
	Me.radPivotFieldList.DataProvider = adomdDataProvider
```

## Connection to OLAP Cube

To show data in RadPivotGrid and RadPivotFieldList we have to connect to OLAP Cube. For this purpose we will set the ConnectionSettings property of the AdomdDataProvider. This can be done directly in the XAML or in the code behind:      		

```XAML
	<pivot:AdomdDataProvider x:Key="ADOMDDataProvider" >
	    <pivot:AdomdDataProvider.ConnectionSettings>
	        <pivot:AdomdConnectionSettings
	            Cube="Adventure Works"
	            Database="Adventure Works DW 2008R2"
	            ConnectionString="Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=Adventure Works DW 2008R2;User Id=domain\user;Password=myPassword;">
	        </pivot:AdomdConnectionSettings>
	    </pivot:AdomdDataProvider.ConnectionSettings>
	</pivot:AdomdDataProvider>
```

```C#
	AdomdConnectionSettings connectionSettings = new AdomdConnectionSettings();
	connectionSettings.Cube = "Adventure Works";
	connectionSettings.Database = "Adventure Works DW 2008R2";
	connectionSettings.ConnectionString = "Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=Adventure Works DW 2008R2;User Id=domain\user;Password=myPassword;";
	
	AdomdDataProvider adomdDataProvider = new AdomdDataProvider();
	adomdDataProvider.ConnectionSettings = connectionSettings;
```
```VB.NET
	Dim connectionSettings As New AdomdConnectionSettings()
	connectionSettings.Cube = "Adventure Works"
	connectionSettings.Database = "Adventure Works DW 2008R2"
	connectionSettings.ConnectionString = "Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=Adventure Works DW 2008R2;User Id=domain\user;Password=myPassword;"
	
	Dim adomdDataProvider As New AdomdDataProvider()
	adomdDataProvider.ConnectionSettings = connectionSettings
```

## Defining Group Descriptions

>caution When initializing the AdomdDataProvider in the code behind it is a good idea to wrap all modifications in __BeginInit() - EndInit()__ section. This will cause only one refresh of the DataProvider and it will be when the EndInit() is reached. If you are applying only modifications (more than one) on already initialized AdomdDataProvider you should use the DeferRefresh() method which will cause delay of the Refresh and this way all your changes will be applied simultaneously. More information for these methods is available in our [Populating with Data - Overview]({%slug radpivotgrid-populating-with-data%}) article.

The AdomdDataProvider is using four collections that are reflecting the visual representation of RadPivotGrid and RadPivotFieldList:    		

* `RowGroupDescriptions`&mdash;the data added to this collection will show as Row Headers in RadPivotGrid. There is only one type of description that can be added to this collection - `AdomdGroupDescription`.    				

* `ColumnGroupDescriptions`&mdash;the data added to this collection will show as Column Headers in RadPivotGrid. There is only one type of description that can be added to this collection - AdomdGroupDescription.    				

* `AggregateDescriptions`&mdash;the data added to this description will be aggregated and included in RadPivotGrid as Cells. There is only one type of description that can be added to this collection - `AdomdAggregateDescription`.    				

* `FilterDescriptions`&mdash;the data added to this collection will be filtered based on a particular condition. RadPivotGrid will show only items that pass the filter condition. There is only one type that can be added to this collection - AdomdFilterDescription. You can define a single filter condition or set up filtering for different levels of the selected member.            

The AdomdGroupDescription is used to define the data that will show as Rows and Columns in RadPivotGrid. When defining AdomdGroupDescription you must set the *MemberName* property. The *MemberName* property is of type string and you should define it based on your Cube.    		

The AdomdAggregateDescription is used to define data that has to be aggregated and that will show as Cells in RadPivotGrid. The data that should be aggregated is define with the *MemberName* property.    		

>The *MemberName* property must have the following syntax: 
>	* For AdomdAggregateDescription: __"[Measures].[MEASURE_NAME]"__.
>	* For AdomdGroupDescription there are two ways (based on the data that will be used): __"[DIMENSION].[HIERARCHY]"__ or __"[SET_NAME]"__.Note that the brackets are mandatory.

Here is how to define row, column group descriptions and aggregate descriptions:        

```XAML
	<pivot:AdomdDataProvider.RowGroupDescriptions>
	    <pivot:AdomdGroupDescription MemberName="[Date].[Calendar Year]"/>
	</pivot:AdomdDataProvider.RowGroupDescriptions>
	        
	<pivot:AdomdDataProvider.ColumnGroupDescriptions>
	    <pivot:AdomdGroupDescription MemberName="[Promotion].[Promotion Category]"/>
	</pivot:AdomdDataProvider.ColumnGroupDescriptions>
	        
	<pivot:AdomdDataProvider.AggregateDescriptions>
	    <pivot:AdomdAggregateDescription MemberName="[Measures].[Internet Order Quantity]" />
	</pivot:AdomdDataProvider.AggregateDescriptions>
```

```C#
	AdomdGroupDescription rowGroupDescription1 = new AdomdGroupDescription();
	rowGroupDescription1.MemberName = "[Date].[Calendar Year]";
	AdomdGroupDescription columnGropuDescription1 = new AdomdGroupDescription();
	columnGropuDescription1.MemberName = "[Promotion].[Promotion Category]";
	AdomdAggregateDescription aggregateDescription1 = new AdomdAggregateDescription();
	aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]";
	
	AdomdDataProvider adomdDataProvider = new AdomdDataProvider();
	adomdDataProvider.BeginInit();
	adomdDataProvider.RowGroupDescriptions.Add(rowGroupDescription1);
	adomdDataProvider.ColumnGroupDescriptions.Add(columnGropuDescription1);
	adomdDataProvider.AggregateDescriptions.Add(aggregateDescription1);
	adomdDataProvider.EndInit();
```
```VB.NET
	Dim rowGroupDescription1 As New AdomdGroupDescription()
	rowGroupDescription1.MemberName = "[Date].[Calendar Year]"
	Dim columnGropuDescription1 As New AdomdGroupDescription()
	columnGropuDescription1.MemberName = "[Promotion].[Promotion Category]"
	Dim aggregateDescription1 As New AdomdAggregateDescription()
	aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]"
	
	Dim adomdDataProvider As New AdomdDataProvider()
	adomdDataProvider.BeginInit()
	adomdDataProvider.RowGroupDescriptions.Add(rowGroupDescription1)
	adomdDataProvider.ColumnGroupDescriptions.Add(columnGropuDescription1)
	adomdDataProvider.AggregateDescriptions.Add(aggregateDescription1)
	adomdDataProvider.EndInit()
```

The AdomdFilterDescription is used to filter the data that will be included in the report. Filtering is applied for a specific member defined in *MemberName* property. *Condition* property defines the way to filter the items. Only the ones that pass the filter will be shown in RadPivotGrid. The filtering is based on the Unique Name of the members. For example, if you want to show only data for year 2005, you can define it like this:        

```XAML
	<pivot:AdomdDataProvider.FilterDescriptions>
	    <pivot:AdomdFilterDescription MemberName="[Date].[Calendar Year]">
	        <pivot:AdomdFilterDescription.Condition>
	            <pivot:OlapSetCondition Comparison="Includes">
	                <pivot:OlapSetCondition.Items>
	                    <sys:String>[Date].[Calendar Year].&amp;[2005]</sys:String>
	                </pivot:OlapSetCondition.Items>
	            </pivot:OlapSetCondition>
	        </pivot:AdomdFilterDescription.Condition>
	    </pivot:AdomdFilterDescription>
	</pivot:AdomdDataProvider.FilterDescriptions>
```

```C#
	OlapSetCondition condition = new OlapSetCondition();
	condition.Comparison = SetComparison.Includes;
	condition.Items.Add("[Date].[Calendar Year].&[2005]");
	AdomdFilterDescription filterDescription = new AdomdFilterDescription();
	filterDescription.MemberName = "[Date].[Calendar Year]";
	filterDescription.Condition = condition;
```
```VB.NET
	Dim condition As New OlapSetCondition()
	condition.Comparison = SetComparison.Includes
	condition.Items.Add("[Date].[Calendar Year].&[2005]")
	Dim filterDescription As New AdomdFilterDescription()
	filterDescription.MemberName = "[Date].[Calendar Year]"
	filterDescription.Condition = condition
```

As you can see, AdomdFilterDescription Condition expects object of type *OlapSetCondition*. *Items* property of the *OlapSetCondition* object is a collection of all objects that each item must match. In our case we are using string objects as the member names in OLAP Cubes are strings.        

As OLAP dimensions are hierarchical, you can use filters for each of the levels by using *"Levels"* property of AdomdFilterDescription. *Levels* is a collection of `AdomdLevelFilterDescriptions` which are members of the user-defined hierarchy of the dimension:

![Rad Pivot Grid Xmla Data Provider 01](images/RadPivotGrid_XmlaDataProvider_01.png)

In the blue rectangle are all attribute hierarchies - you can use them as a filter by adding them as a new `FilterGroupDescription`. In the red rectangle you can see the user-defined hierarchy of Date.Calendar dimension. You can filter your data by each of the members by adding it to the *Levels* property of AdomdFilterDescription:        

```XAML
	<pivot:AdomdDataProvider.FilterDescriptions>
	    <pivot:AdomdFilterDescription MemberName="[Date].[Calendar]">
	        <pivot:AdomdFilterDescription.Levels>
	            <pivot:AdomdLevelFilterDescription MemberName="[Date].[Calendar].[Calendar Year]">
	                <pivot:AdomdLevelFilterDescription.Condition>
	                    <pivot:OlapSetCondition Comparison="Includes">
	                        <pivot:OlapSetCondition.Items>
	                            <sys:String>[Date].[Calendar].[Calendar Year].&amp;[2007]</sys:String>
	                        </pivot:OlapSetCondition.Items>
	                    </pivot:OlapSetCondition>
	                </pivot:AdomdLevelFilterDescription.Condition>
	            </pivot:AdomdLevelFilterDescription>
	            <pivot:AdomdLevelFilterDescription MemberName="[Date].[Calendar].[Calendar Semester]">
	                    <pivot:AdomdLevelFilterDescription.Condition>
	                        <pivot:OlapSetCondition Comparison="Includes">
	                            <pivot:OlapSetCondition.Items>
	                                <sys:String>[Date].[Calendar].[Calendar Semester].&amp;[2007]&amp;[2]</sys:String>
	                            </pivot:OlapSetCondition.Items>
	                        </pivot:OlapSetCondition>
	                    </pivot:AdomdLevelFilterDescription.Condition>
	                </pivot:AdomdLevelFilterDescription>
	        </pivot:AdomdFilterDescription.Levels>
	    </pivot:AdomdFilterDescription>
	</pivot:AdomdDataProvider.FilterDescriptions>
```

```C#
	AdomdFilterDescription topFilterDescription = new AdomdFilterDescription();
	topFilterDescription.MemberName = "[Date].[Calendar]";
	
	OlapSetCondition condition1 = new OlapSetCondition();
	condition1.Comparison = SetComparison.Includes;
	condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]");
	AdomdLevelFilterDescription levelFilterDescription1 = new AdomdLevelFilterDescription();
	levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
	levelFilterDescription1.Condition = condition1;
	
	OlapSetCondition condition2 = new OlapSetCondition();
	condition2.Comparison = SetComparison.Includes;
	condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]");
	AdomdLevelFilterDescription levelFilterDescription2 = new AdomdLevelFilterDescription();
	levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]";
	levelFilterDescription2.Condition = condition2;
	topFilterDescription.Levels.Add(levelFilterDescription1);
	topFilterDescription.Levels.Add(levelFilterDescription2);
```
```VB.NET
	Dim topFilterDescription As New AdomdFilterDescription()
	topFilterDescription.MemberName = "[Date].[Calendar]"
	
	Dim condition1 As New OlapSetCondition()
	condition1.Comparison = SetComparison.Includes
	condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]")
	Dim levelFilterDescription1 As New AdomdLevelFilterDescription()
	levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
	levelFilterDescription1.Condition = condition1
	
	Dim condition2 As New OlapSetCondition()
	condition2.Comparison = SetComparison.Includes
	condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]")
	Dim levelFilterDescription2 As New AdomdLevelFilterDescription()
	levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]"
	levelFilterDescription2.Condition = condition2
	topFilterDescription.Levels.Add(levelFilterDescription1)
	topFilterDescription.Levels.Add(levelFilterDescription2)
```

## See Also  
 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})
 * [Adding RadPivotFieldList to your project]({%slug radpivotgrid-fieldlist%})
 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})