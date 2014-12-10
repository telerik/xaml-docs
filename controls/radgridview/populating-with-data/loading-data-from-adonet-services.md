---
title: Loading Data from ADO.NET Services
page_title: Loading Data from ADO.NET Services
description: Loading Data from ADO.NET Services
slug: gridview-loading-data-from-adonet-services
tags: loading,data,from,ado.net,services
published: True
position: 7
---

# Loading Data from ADO.NET Services

The purpose of this tutorial is to show you how to populate a __RadGridView__ with data from an __ADO.NET Data Service__ in two ways:

* A straight-forward way - [plain method calls](#Plain_Method_Calls). 

* Using MVVM approach.  

>This tutorial will use the __Northwind__database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

Before proceeding further with this tutorial you need to create a new application and add a __RadGridView__ declaration in your XAML: 

#### __XAML__

{{region gridview-loading-data-from-adonet-services_0}}

	<telerik:RadGridView x:Name="radGridView"/>
{{endregion}}

## Plain Method Calls

* Add a reference to your ADO.NET Data Service. 

* Switch to the code-behind and add a reference to the __NorthwindEntities__ object.

#### __C#__

{{region gridview-loading-data-from-adonet-services_1}}

	NorthwindEntities dbContext = new NorthwindEntities( new Uri( "GridViewDataService.svc", UriKind.Relative ) );
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-adonet-services_2}}

	NorthwindEntities dbContext = new NorthwindEntities( new Uri( "Enter your service address here") );
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_3}}

	Dim dbContext As New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_4}}

	Dim dbContext As New NorthwindEntities(New Uri("Enter your service address here"))
{{endregion}}

>tipFor more information about how to add a reference to an ADO.NET Data Service and how to create a new instance of the exposed entity, take a look at the 
{% if site.site_name == 'Silverlight' %}[Consuming ADO.NET Data Service](http://www.telerik.com/help/silverlight/consuming-data-ado-net-data-service.html){% endif %}{% if site.site_name == 'WPF' %}[Consuming ADO.NET Data Service](http://www.telerik.com/help/wpf/consuming-data-ado-net-data-service.html){% endif %} topic.The gridview control will be populated with all __Customers__ from the __Northwind__ database. Add the following code which will make the initial load of the objects. 

#### __C#__

{{region gridview-loading-data-from-adonet-services_5}}

	private void BeginRequest()
	{
	    DataServiceQuery<Customers> query = dbContext.CreateQuery<Customers>( "Customers" );
	    query.BeginExecute( RequestCompleted, query );
	}
	
	private void RequestCompleted( IAsyncResult asyncResult )
	{
	    DataServiceQuery<Customers> query = asyncResult.AsyncState as DataServiceQuery<Customers>;
	    var customers = query.EndExecute( asyncResult ).ToList();
	    this.radGridView.ItemsSource = customers;
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_6}}

	Private Sub BeginRequest()
	    Dim query As DataServiceQuery(Of Customers) = dbContext.CreateQuery(Of Customers)("Customers")
	    query.BeginExecute(RequestCompleted, query)
	End Sub
	
	Private Sub RequestCompleted(ByVal asyncResult As IAsyncResult)
	    Dim query As DataServiceQuery(Of Customers) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Customers))
	    Dim customers = query.EndExecute(asyncResult).ToList()
	    Me.radGridView.ItemsSource = customers
	End Sub
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-adonet-services_7}}

	this.radGridView.ItemsSource = dbContext.Customers.Execute().ToList();
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_8}}

	Me.radGridView.ItemsSource = dbContext.Customers.Execute().ToList()
{{endregion}}

Run your demo, the result can be seen on the next image:

![](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

## Using MVVM Approach

This section will show you how to populate your __RadGridView__ control in a MVVM manner. __RadGridView__ will be bound to a data source object, that has a property __Customers__. When the control is loaded all customers from the Customers table in the Northwind database are loaded{% if site.site_name == 'Silverlight' %} asynchronously{% endif %}.

* Create a new class named __NorthwindDataSource__. 

#### __C#__

{{region gridview-loading-data-from-adonet-services_9}}

	public class NorthwindDataSource
	{
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_10}}

	Public Class NorthwindDataSource
	End Class
{{endregion}}

* Add a reference to your ADO.NET Data Service. 

* In the __NorthwindDataSource__ class add a reference to an __ObservableCollection__ of __Customers__. 

* In the __NorthwindDataSource__ class add a reference to the __NorthwindEntities__ object: 

#### __C#__

{{region gridview-loading-data-from-adonet-services_11}}

	public class NorthwindDataSource
	{
	    private static NorthwindEntities northwindEntity;
	    public NorthwindDataSource()
	    {
	        northwindEntity = new NorthwindEntities( new Uri( "GridViewDataService.svc", UriKind.Relative ) );
	        this.Customers = new ObservableCollection<Customers>();
	    }
	    public ObservableCollection<Customers> Customers
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_12}}

	Public Class NorthwindDataSource
	    Private Shared northwindEntity As NorthwindEntities
	
	    Public Sub New()
	        northwindEntity = New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
	        Me.Customers = New ObservableCollection(Of Customers)()
	    End Sub
	
	Private _Customers As ObservableCollection(Of Customers)
	    Public Property Customers() As ObservableCollection(Of Customers)
	        Get
	            Return _Customers
	        End Get
	        Set(ByVal value As ObservableCollection(Of Customers))
	            _Customers = value
	        End Set
	    End Property
	End Class
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-adonet-services_13}}

	public class NorthwindDataSource
	{
	    private static NorthwindEntities northwindEntity;
	    public NorthwindDataSource()
	    {
	        northwindEntity = new NorthwindEntities( new Uri( "Enter your service address here"));
	        this.Customers = new ObservableCollection<Customers>();
	    }
	    public ObservableCollection<Customers> Customers
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_14}}

	Public Class NorthwindDataSource
	    Private Shared northwindEntity As NorthwindEntities
	
	    Public Sub New()
	        northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
	        Me.Customers = New ObservableCollection(Of Customers)()
	    End Sub
	
	Private _Customers As ObservableCollection(Of Customers)
	    Public Property Customers() As ObservableCollection(Of Customers)
	        Get
	            Return _Customers
	        End Get
	        Set(ByVal value As ObservableCollection(Of Customers))
	            _Customers = value
	        End Set
	    End Property
	End Class
{{endregion}}

* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Customers__ from the database: 

#### __C#__

{{region gridview-loading-data-from-adonet-services_15}}

	northwindEntity.Customers.BeginExecute(
	    ( IAsyncResult result ) => EntitiesLoaded<Customers>( result, this.Customers ),
	    northwindEntity.Customers );
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-adonet-services_16}}

	foreach ( Customers c in northwindEntity.Customers.Execute() )
	{
	    this.Customers.Add( c );
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_17}}

	northwindEntity.Customers.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Customers)(result, Me.Customers), northwindEntity.Customers)
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-adonet-services_18}}

	For Each c As Customers In northwindEntity.Customers.Execute()
	    Me.Customers.Add(c)
	Next
{{endregion}}

{% if site.site_name == 'Silverlight' %}

And here is the code for the __EntitiesLoaded__method:{% endif %}

#### __C#__

{{region gridview-loading-data-from-adonet-services_19}}

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

{{region gridview-loading-data-from-adonet-services_20}}

	Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
	    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
	    For Each entity As T In query.EndExecute(result)
	        entities.Add(entity)
	    Next
	End Sub
{{endregion}}

* Declare the __NorthwindDataSource__ object as a resource in your application. 

#### __XAML__

{{region gridview-loading-data-from-adonet-services_21}}

	<UserControl.Resources>
	   <example:NorthwindDataSource x:Key="DataSource"/>
	</UserControl.Resources>
{{endregion}}

* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

#### __XAML__

{{region gridview-loading-data-from-adonet-services_22}}

	<telerik:RadGridView x:Name="radGridView" Margin="8"
	    ItemsSource="{Binding Source={StaticResource DataSource}, Path=Customers}"/>
{{endregion}}

Run your demo, the result can be seen on the next picture: 

![](images/RadGridView_PopulatingWithDataLoadFromAdoNet_010.PNG)

>tipIf you need to define the columns manually take a look at the [Defining Columns]({%slug gridview-columns-defining-columns%}) topic.

# See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})
 
 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})
{% if site.site_name == 'Silverlight' %}

 * [Loading Data from RIA Services]({%slug gridview-loading-data-from-ria-services%})

 * [DomainDataSource Support]({%slug gridview-domaindatasource-support%})

 * [Loading Data from Web Services]({%slug gridview-loading-data-from-web-services%})
{% endif %}
