---
title: Binding to ADO.NET Data Service
page_title: Binding to ADO.NET Data Service
description: Check our &quot;Binding to ADO.NET Data Service&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-populating-with-data-binding-adonet
tags: binding,to,ado.net,data,service
published: True
position: 6
---

# Binding to ADO.NET Data Service

The purpose of this tutorial is to show you how to populate a `RadComboBox` with data from an ADO.NET Data Service in two ways:

* [Using plain methods call in the code-behind](#using-plain-methods-call-in-the-code-behind)
* [Using MVVM approach](#using-mvvm-approach)

>This tutorial uses the [Northwind database](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs).

Before proceeding further with this tutorial you need to create a new application and a `RadComboBox` declaration in your XAML.

  
<snippet id='radcombobox-populating-with-data-binding-adonet-block_1-xaml' />


## Using Plain Methods Call in the Code-Behind

1. Add a reference to your ADO.NET Data Service. 

2. Switch to the code-behind and add a reference to the `NorthwindEntities` object.

	<snippet id='radcombobox-populating-with-data-binding-adonet-block_2-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-block_2-vb' />


	>tip For more information about how to add a reference to an ADO.NET Data Service and how to create a new instance of the exposed entity, take a look at the [Consuming ADO.NET Data Service]({%slug consuming-data-ado-net-data-service%}) topic.

3. The ComboBoxs control will be populated with all __Products__ from the __Northwind__ database. In the drop-down list the `ProductName` and the `UnitPrice` properties will be displayed. Add the following code which will make the initial load of the objects.

	<snippet id='radcombobox-populating-with-data-binding-adonet-block_3-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-block_3-vb' />


	<snippet id='radcombobox-populating-with-data-binding-adonet-block_4-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-block_4-vb' />


4. You need to declare a custom __DataTemplate__ to determine how the items in the drop-down will look like. Add the following __DataTemplate__ declaration in your XAML resources.
 
	<snippet id='radcombobox-populating-with-data-binding-adonet-block_5-xaml' />


5. Find your __RadComboBox__ declaration and set the just declared __DataTemplate__ to its __ItemTemplate__ property.

	  
	<snippet id='radcombobox-populating-with-data-binding-adonet-block_6-xaml' />


__The end result with the data fetched from the service__  

![{{ site.framework_name }} RadComboBox Bound to Data from ADO.NET Data Service](images/RadComboBox_PopulatingWithData_BindingToAdoDataService_010.png)

## Using MVVM Approach

This section will show you how to populate your `RadComboBox` control in a MVVM manner. The ComboBox will be bound to a data source object, that has a property `Products`. When the control is loaded all products from the __Products__ table in the Northwind database are loaded asynchronously.

1. Create a new class named `NorthwindDataSource`.

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-vb' />


2. Add a reference to your ADO.NET Data Service.

3. In the `NorthwindDataSource` class add a reference to an `ObservableCollection` of `Product`.

4. In the `NorthwindDataSource` class add a reference to the `NorthwindEntities` object:

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-vb' />


5. Add the following code in the constructor of the `NorthwindDataSource`. It will make the initial load of all __Products__ from the database:

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-vb' />

	
	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-vb' />


	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-cs' />

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-vb' />


6. Declare the `NorthwindDataSource` object as a resource in your application.

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-xaml' />


7. Declare a custom `DataTemplate` to determine how the items in the drop-down will look like. 

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-xaml' />


8. Update your `RadComboBox` declaration - set the `ItemsSource` and `ItemTemplate` properties.

	<snippet id='radcombobox-populating-with-data-binding-adonet-the_end_result_with_the_data_fetched_from_the_service-xaml' />


__The end result with the data fetched from the service__  

![{{ site.framework_name }} RadComboBox Bound to Data from ADO.NET Data Service](images/RadComboBox_PopulatingWithData_BindingToAdoDataService_020.png)

## See Also  
* [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})
* [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})
