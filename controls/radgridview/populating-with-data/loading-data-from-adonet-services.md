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

```XAML
	<telerik:RadGridView x:Name="radGridView"/>
```

## Plain Method Calls

* Add a reference to your ADO.NET Data Service. 

* Switch to the code-behind and add a reference to the __NorthwindEntities__ object.

```C#
	NorthwindEntities dbContext = new NorthwindEntities(new Uri("GridViewDataService.svc", UriKind.Relative));
```
```VB.NET
	Private dbContext As New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
```

```C#
	NorthwindEntities dbContext2 = new NorthwindEntities(new Uri("Enter your service address here"));
```
```VB.NET
	Private dbContext2 As New NorthwindEntities(New Uri("Enter your service address here"))
```

>tip For more information about how to add a reference to an ADO.NET Data Service and how to create a new instance of the exposed entity, take a look at the [Consuming ADO.NET Data Service](http://www.telerik.com/help/wpf/consuming-data-ado-net-data-service.html) topic.The gridview control will be populated with all __Customers__ from the __Northwind__ database. Add the following code which will make the initial load of the objects. 

```C#
	private void BeginRequest()
	{
	    DataServiceQuery<Customer> query = dbContext.CreateQuery<Customer>("Customers");
	    query.BeginExecute(RequestCompleted, query);
	}
	
	private void RequestCompleted(IAsyncResult asyncResult)
	{
	    DataServiceQuery<Customer> query = asyncResult.AsyncState as DataServiceQuery<Customer>;
	    var customers = query.EndExecute(asyncResult).ToList();
	    this.radGridView.ItemsSource = customers;
	}
```
```VB.NET
	Private Sub BeginRequest()
	    Dim query As DataServiceQuery(Of Customer) = dbContext.CreateQuery(Of Customer)("Customers")
	    query.BeginExecute(AddressOf RequestCompleted, query)
	End Sub
	
	Private Sub RequestCompleted(ByVal asyncResult As IAsyncResult)
	    Dim query As DataServiceQuery(Of Customer) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Customer))
	    Dim customers = query.EndExecute(asyncResult).ToList()
	    Me.radGridView.ItemsSource = customers
	End Sub
```

```C#
	this.radGridView.ItemsSource = dbContext.Customers.Execute().ToList();
```
```VB.NET
	Me.radGridView.ItemsSource = dbContext.Customers.Execute().ToList()
	'
```

Run your demo, the result can be seen on the next image:

![Telerik {{ site.framework_name }} DataGrid PopulatingWithDataLoadFromAdoNet 010](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

## Using MVVM Approach

This section will show you how to populate your __RadGridView__ control in a MVVM manner. __RadGridView__ will be bound to a data source object, that has a property __Customers__. When the control is loaded all customers from the Customers table in the Northwind database are loaded.

* Create a new class named __NorthwindDataSource__. 

	```C#
		public class NorthwindDataSource
		{
		}
	```
	```VB.NET
		Public Class NorthwindDataSource
		End Class
	```

* Add a reference to your ADO.NET Data Service. 

* In the __NorthwindDataSource__ class add a reference to an __ObservableCollection__ of __Customers__. 

* In the __NorthwindDataSource__ class add a reference to the __NorthwindEntities__ object: 

	```C#
		public class NorthwindDataSource
		{
			private static NorthwindEntities northwindEntity;
			public NorthwindDataSource()
			{
				northwindEntity = new NorthwindEntities(new Uri("GridViewDataService.svc", UriKind.Relative));
				this.Customers = new ObservableCollection<Customer>();
			}
			public ObservableCollection<Customer> Customers
			{
				get;
				set;
			}
		}
	```
	```VB.NET
		Public Class NorthwindDataSource
			Private Shared northwindEntity As NorthwindEntities
			Public Sub New()
				northwindEntity = New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
				Me.Customers = New ObservableCollection(Of Customer)()
			End Sub
			Public Property Customers() As ObservableCollection(Of Customer)
		End Class
	```

	```C#
		public class NorthwindDataSource
		{
			private static NorthwindEntities northwindEntity;
			public NorthwindDataSource()
			{
				northwindEntity = new NorthwindEntities(new Uri("Enter your service address here"));
				this.Customers = new ObservableCollection<Customer>();
			}
			public ObservableCollection<Customer> Customers
			{
				get;
				set;
			}
		}
	```
	```VB.NET
		Public Class NorthwindDataSource
			Private Shared northwindEntity As NorthwindEntities
			Public Sub New()
				northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
				Me.Customers = New ObservableCollection(Of Customer)()
			End Sub
			Public Property Customers() As ObservableCollection(Of Customer)
		End Class
	```

* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Customers__ from the database: 

	```C#
		northwindEntity.Customers.BeginExecute(
			(IAsyncResult result) => EntitiesLoaded<Customer>(result, this.Customers),
			northwindEntity.Customers);
	```
	```VB.NET
		northwindEntity.Customers.BeginExecute(Function(result As IAsyncResult) EntitiesLoaded(Of Customer)(result, Me.Customers), northwindEntity.Customers)
	```

	```C#
		foreach (Customer c in northwindEntity.Customers.Execute())
		{
			this.Customers.Add(c);
		}
	```
	```VB.NET
		For Each c As Customer In northwindEntity.Customers.Execute()
			Me.Customers.Add(c)
		Next c
	```

	```C#
		private static void EntitiesLoaded<T>(IAsyncResult result, Collection<T> entities)
		{
			DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
			foreach (T entity in query.EndExecute(result))
			{
				entities.Add(entity);
			}
		}
	```
	```VB.NET
		Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
			Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
			For Each entity As T In query.EndExecute(result)
				entities.Add(entity)
			Next entity
		End Sub
	```

* Declare the __NorthwindDataSource__ object as a resource in your application. 

	```XAML
		<UserControl.Resources>
			<my:NorthwindDataSource x:Key="DataSource"/>
		</UserControl.Resources>
	```

* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

	```XAML
		<telerik:RadGridView ItemsSource="{Binding Source={StaticResource DataSource}, Path=Customers}"/>
	```

Run your demo, the result can be seen on the next picture: 

![Telerik {{ site.framework_name }} DataGrid PopulatingWithDataLoadFromAdoNet 010](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

>tip If you need to define the columns manually take a look at the [Defining Columns]({%slug gridview-columns-defining-columns%}) topic.

## See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})
 
 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})