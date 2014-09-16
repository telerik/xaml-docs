---
title: Populating with Data
page_title: Populating with Data
description: Populating with Data
slug: radpivotgrid-populating-with-data
tags: populating,with,data
publish: True
position: 6
---

# Populating with Data



__RadPivotGrid__ and __RadFieldListControl__ are data-aware control, designed to display data in a tabular form. Both controls
      		cannot work without data source. It can be any collection implementing IEnumerable interface, bounded to a DataBase or even bound to
      		a Cube.
      

## Data Types

Both __RadPivotGrid__ and __RadPivotFieldList__ have DataProvider property that can be set in the XAML or in the background.
      		The DataProvider can be:
      	{% if site.site_name == 'WPF' %}

* [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%}) - this is a local data provider which has ItemsSource property. The __ItemsSource__ is a
      					mandatory property for this DataSource. You can use any Collection that implements IEnumerable interface as ItemsSource.
      				

* [XmlaDataProvider]({%slug radpivotgrid-data-xmla%}) - Provides Cube data access and operations using Xmla. An OLAP cube is a method of storing data in a multidimensional form, generally for reporting purposes.
      				

* [AdomdDataProvider]({%slug radpivotgrid-data-adomd%}) - this provider is designed to communicate with Microsoft SQL Server Analysis Services. 
      					ADOMD.NET uses the XML for Analysis protocol to communicate with analytical data sources by using either TCP/IP or HTTP connections 
	      				to transmit and receive SOAP requests and responses that are compliant with the XML for Analysis specification.
   		   			

* [QueryableDataProvider]({%slug radpivotgrid-data-queryable%}) - this provider is designed to work with any class that implements IQueryable interface. The main idea
                is to be used when the data is in database. It performs all calculations and aggregations in the database and only the grouped results are transferred.
              {% endif %}{% if site.site_name == 'Silverlight' %}

* [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%}) - this is a local data provider which has ItemsSource property. The __ItemsSource__ is a
      					mandatory property for this DataSource. You can use any Collection that implements IEnumerable interface as ItemsSource.
      				

* [XmlaDataProvider]({%slug radpivotgrid-data-xmla%}) - Provides Cube data access and operations using Xmla. An OLAP cube is a method of storing data in a multidimensional form, generally for reporting purposes.
      				{% endif %}

By default if you just set the DataProvider property you'll not see any visual representation of the data in __RadPivotGrid__, but you'll be able to see all of it in 
      		__RadPivotFieldList__ FieldBox. To see the data in __RadPivotGrid__ you can define your 
      		*RowGroupDescription*, *ColumnGroupDescription* and *AggregateDescription* and add some of the data properties in them.
      		Another way is to drag (or check) the items in __RadPivotFieldList__ and move them between the lists in the bottom part of __RadPivotFieldList__.
      	

## Data Provider Properties and  Group Descriptions

### Properties

All of the DataProviders have some common properties that you can set:
    				

* __AggregatesLevel__ - this property is used to set the position where groups for the aggregates should be placed.
    						

* __AggregatesPosition__ - defines whether the positon of the Aggregates will be Columns or Rows.
    						

### GroupDescriptions

Each of the DataProviders uses four collections that reflect the view of __RadPivotGrid__. The following collections are the essential part of generating 
                        __RadPivotGrid__ report.
                    

* __RowGroupDescriptions__ - the data included in the DataProvider as a part of this collection will show as Row Headers in __RadPivotGrid__.
                            

* __ColumnGroupDescriptions__ - the data included in the DataProvider as a part of this collection will show as Column Headers in __RadPivotGrid__.
                            

* __AggregateDescriptions__ - the data included in the DataProvider as a part of this collection will be aggregated based on the function we set and added as Cells in __RadPivotGrid__.
                            

* __FilterDescriptions__ - the data added to this description will be filtered based on some condition and after that added to __RadPivotGrid__.
                            

## DataProvider Refresh

Each __DataProvider__ must be refreshed to apply changes. It would also try to refresh automatically on a change. The following utilities
    			control the *Refresh* behavior in various scenarios.
    		

* __void Refresh()__ - this method unconditionally forces  *Refresh* on the DataProvider.

* __bool DeferUpdates__ - if the value is true, the automatic *Refresh* is suspended for a long time. Refreshes can still be triggered calling __Refresh()__ or automatically when some changes were made and the __DeferUpdates__ is set to false.
    				For example user interactions with __RadPivotFieldList__ can cause a lot of automatic *Refresh* calls, but when this property is set to true, all changes will be applied at the same time when the "Update" button is clicked to call 
    					__Refresh()__ or the *"Defer Layout Updates"* is unchecked to set __DeferUpdates__ to false. 
    				The default value is true for the __LocalDataSourceProvider__ and false for __XmlaDataProvider__ and __AdomdDataProvider__.
    				

* __IDisposable DeferRefresh()__ - this method is causing delay of the refresh in the current scope, for example you can use the following: *using (dataProvider.DeferRefresh()) {...};*.
    					pattern if you are about to apply multiple changes in a single method scope but want to trigger one automatic *Refresh* instead of several.
    					Refresh will be triggered automatically upon exit only if changes were made and __DeferUpdates__ is set to false.
    				

* __BeginInit() and  EndInit()__ - these methods must be used when you intialize the DataProvider in the code behind. Wrapping the initialization in __BeginInit()__ - __EndInit()__ will suspend 
    					automatic *Refreshes* until the __EndInit()__ that will unconditionally force *Refresh*.
    				

# See Also

 * [Adding RadPivotFieldList to your project]({%slug radpivotgrid-fieldlist-started%})

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})
