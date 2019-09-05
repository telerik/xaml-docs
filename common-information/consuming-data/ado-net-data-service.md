---
title: Consuming WCF Data Service
page_title: Consuming WCF Data Service
description: This article will demonstrate how to consume data from a WCF Data Service
slug: consuming-data-ado-net-data-service
tags: consuming,wcf,data,service
published: True
position: 2
---

# Consuming WCF Data Service

The purpose of this tutorial is to show you how to make a call to an ADO.NET Data Service in the context of a {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application. The following common tasks will be examined:

>tipYou can check our [RadDataServiceDataSource]({%slug %}) which provides seamless integration between an user interface and data coming from a WCF Data Service.

* Adding a reference.

* Creating a new instance of the exposed entity.

* Making {% if site.site_name == 'Silverlight' %}asynchronous{% endif %} call to the service and consuming the service result.

>The process of developing an ADO.NET Data Service is beyond the scope of this tutorial. For more information read [here](http://msdn.microsoft.com/en-us/library/cc907912.aspx).

>This tutorial will use the __Northwind__ database, which can be downloaded from [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc)

>tipThe Telerik __OpenAccess__ ORM also supports excellent integration with ADO.NET Data Services.

## Adding Reference

The first step is to add a new connected service to your application. In order to add the needed connected service, you will need to add the [OData Connected Service](https://marketplace.visualstudio.com/items?itemName=laylaliu.ODataConnectedService) Visual Studio extension. After adding this extension you can follow the steps below.

>tipThe __OData Connected Service__ tool works only with __Visual Studio 2017__.

#### __Figure 1: Select the "__References__" folder, right click with your mouse button and choose "__Add Connected Service__"__ 
![Common Consuming Data Wcf Service 010](images/Common_ConsumingDataWcfService_010.png)

#### __Figure 2: A new tab will be opened with the available conntected services. Click on the OData Connected Service. __
![Common Consuming Data Wcf Service 020](images/Common_ConsumingDataWcfService_020.png)

#### __Figure 3: A popup window will appear. In the __Address__ TextBox, type the Northwind URL address and click on the Finish button below. __
![Common Consuming Data Wcf Service 030](images/Common_ConsumingDataWcfService_030.png)

When a service reference is added to a project, any types defined in the service are generated in the local project. 

Once the ADO.NET data service is added all needed assemblies will be included in your project automatically.

## Creating New Instance of the exposed Entities

#### __[C#] Example 1: Create new instance of the NorthwindEntities__

{{region consuming-data-ado-net-data-service_0}}
	public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NorthwindEntities serviceClient = new NorthwindEntities(new Uri("http://services.odata.org/Northwind/Northwind.svc"));
        }
    }
{{endregion}}
	
#### __[VB.NET] Example 1: Create new instance of the NorthwindEntities__
{{region consuming-data-ado-net-data-service_1}}
	Public Partial Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim serviceClient As NorthwindEntities = New NorthwindEntities(New Uri("http://services.odata.org/Northwind/Northwind.svc"))
		End Sub
	End Class
{{endregion}}

__NorthwindEntities__ represents the runtime context of a given data service. While data services themselves are stateless, the context is not, so state on the client is maintained between interactions in order to support features such as identity resolution and optimistic concurrency.  

## Making Asynchronous Call to the Service and Consuming the Result{% if site.site_name == 'Silverlight' %}

In Silverlight all service calls are performed asynchronously. In order to make an asynchronous call to your service you need to do the following steps:

* Create a new __DataServiceQuery.__

* Execute the __DataServiceQuery__ asynchronously.

Here is a sample code showing how this can be achieved:

#### __C#__

{{region consuming-data-ado-net-data-service_2}}
	public static void BeginLoadingProducts( Categories category )
	{
	    DataServiceQuery<Products> categoryProducts = northwindEntity
	        .CreateQuery<Products>( string.Format( "Categories({0})/Products", category.CategoryID ) )
	        .Expand( "Suppliers" )
	        .Expand( "Categories" );
	    categoryProducts.BeginExecute(
	        ( IAsyncResult result ) => EntitiesLoaded<Products>( result, category.Products ),
	        categoryProducts );
	}
	private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
	{
	    DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
	    foreach ( T entity in query.EndExecute( result ) )
	    {
	        entities.Add( entity );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-ado-net-data-service_3}}
	Public Shared Sub BeginLoadingProducts(ByVal category As Categories)
	    Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
	
	    categoryProducts.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, category.Products), categoryProducts)
	End Sub
	Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
	    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
	    For Each entity As T In query.EndExecute(result)
	        entities.Add(entity)
	    Next
	End Sub
	{{endregion}}


 
Practically all the work about the consuming the result is done in the __EntitesLoaded<T>__ method.{% endif %}{% if site.site_name == 'WPF' %}

Making a call to an ADO.NET Data Service is a simple process. Here is a sample code, demonstrating how to load all categories from the Categories table in the Northwind database: 

#### __C#__

{{region consuming-data-ado-net-data-service_4}}
	public partial class MainWindow : Window
	{
		public ObservableCollection<Category> Categories { get; set; }
		public MainWindow()
		{
			InitializeComponent();
			NorthwindEntities serviceClient = new NorthwindEntities(new Uri("http://services.odata.org/Northwind/Northwind.svc"));				
			foreach (Category c in serviceClient.Categories.Execute())
			{
				this.Categories.Add(c);
			}
		}
	}
{{endregion}}

#### __VB.NET__

{{region consuming-data-ado-net-data-service_5}}
	Public Partial Class MainWindow
		Inherits Window

		Public Property Categories As ObservableCollection(Of Category)

		Public Sub New()
			InitializeComponent()
			Dim serviceClient As NorthwindEntities = New NorthwindEntities(New Uri("http://services.odata.org/Northwind/Northwind.svc"))

			For Each c As Category In serviceClient.Categories.Execute()
				Me.Categories.Add(c)
			Next
		End Sub
	End Class
{{endregion}}

{% endif %}
