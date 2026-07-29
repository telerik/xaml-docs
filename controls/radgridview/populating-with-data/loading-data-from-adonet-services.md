---
title: Loading Data from ADO.NET Services
page_title: Loading Data from ADO.NET Services
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how you can populate the grid with data from an ADO.NET Data Service.
slug: gridview-loading-data-from-adonet-services
tags: loading,data,from,ado.net,services
published: True
position: 7
---

# Loading Data from ADO.NET Services

The purpose of this tutorial is to show you how to populate a __RadGridView__ with data from an __ADO.NET Data Service__ in two ways:

* A straight-forward way - plain method calls

* Using MVVM approach.  

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](https://github.com/microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs).

Before proceeding further with this tutorial you need to create a new application and add a __RadGridView__ declaration in your XAML: 

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_1-xaml' />


## Plain Method Calls

* Add a reference to your ADO.NET Data Service. 

* Switch to the code-behind and add a reference to the __NorthwindEntities__ object.

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_2-cs' />

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_2-vb' />


<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_3-cs' />

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_3-vb' />


>tip For more information about how to add a reference to an ADO.NET Data Service and how to create a new instance of the exposed entity, take a look at the [Consuming ADO.NET Data Service](http://www.telerik.com/help/wpf/consuming-data-ado-net-data-service.html) topic.The gridview control will be populated with all __Customers__ from the __Northwind__ database. Add the following code which will make the initial load of the objects. 

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_4-cs' />

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_4-vb' />


<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_5-cs' />

<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_5-vb' />


Run your demo, the result can be seen on the next image:

![Telerik UI for {{ site.framework_name }} RadGridView populated with customer data loaded from an ADO.NET Data Service](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

## Using MVVM Approach

This section will show you how to populate your __RadGridView__ control in a MVVM manner. __RadGridView__ will be bound to a data source object, that has a property __Customers__. When the control is loaded all customers from the Customers table in the Northwind database are loaded.

* Create a new class named __NorthwindDataSource__. 

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_6-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_6-vb' />


* Add a reference to your ADO.NET Data Service. 

* In the __NorthwindDataSource__ class add a reference to an __ObservableCollection__ of __Customers__. 

* In the __NorthwindDataSource__ class add a reference to the __NorthwindEntities__ object: 

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_7-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_7-vb' />


	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_8-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_8-vb' />


* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Customers__ from the database: 

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_9-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_9-vb' />


	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_10-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_10-vb' />


	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_11-cs' />

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_11-vb' />


* Declare the __NorthwindDataSource__ object as a resource in your application. 

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_12-xaml' />


* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

	<snippet id='radgridview-populating-with-data-loading-data-from-adonet-services-block_13-xaml' />


Run your demo, the result can be seen on the next picture: 

![Telerik UI for {{ site.framework_name }} RadGridView bound through an MVVM data source that loads customers from an ADO.NET Data Service](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

>tip If you need to define the columns manually take a look at the [Defining Columns]({%slug gridview-columns-defining-columns%}) topic.

## See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})
 
 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})