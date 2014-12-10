---
title: Loading Data from Web Services
page_title: Loading Data from Web Services
description: Loading Data from Web Services
slug: gridview-loading-data-from-web-services
tags: loading,data,from,web,services
published: True
position: 8
site_name: Silverlight
---

# Loading Data from Web Services

The purpose of this tutorial is to show you how to populate a __RadGridView__ with data from a __Web (asmx) Service__ in two ways:

* A straight-forward way - [plain method calls](#Plain_Method_Calls). 

* [Using MVVM approach](#Using_MVVM_Approach)

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

Before proceeding further with this tutorial you need to create a new application and add a __RadGridView__ declaration in your XAML:

#### __XAML__

{{region gridview-loading-data-from-web-services_0}}

	<telerik:RadGridView x:Name="radGridView"/>
{{endregion}}

## Plain Method Calls

* Add a reference to your Web Service. 
* Switch to the code-behind and create a new instance of your Web Service Soap client.

#### __C#__

{{region gridview-loading-data-from-web-services_1}}

	SampleWebServiceSoapClient serviceClient = new SampleWebServiceSoapClient();
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_2}}

	Dim serviceClient As New SampleWebServiceSoapClient()
{{endregion}}

>tipFor more information about how to add a reference to a Web Service and how to create a new instance of a Web Service client,  take a look at the [Consuming Web Service](http://www.telerik.com/help/silverlight/consuming-data-web-asmx-service.html)[Consuming Web Service](http://www.telerik.com/help/wpf/consuming-data-web-asmx-service.html) topic.

The gridview control will be populated with all __Customers__ from the __Northwind__ database. Add the following code which will make the initial load of the objects.

#### __C#__

{{region gridview-loading-data-from-web-services_3}}

	serviceClient.LoadCustomersCompleted += new EventHandler<LoadCustomersCompletedEventArgs>( serviceClient_LoadCustomersCompleted );
	serviceClient.LoadCustomersAsync();
	
	private void serviceClient_LoadCustomersCompleted( object sender, LoadCustomersCompletedEventArgs e )
	{
	    var customers = e.Result;
	    this.radGridView.ItemsSource = customers;
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_4}}

	AddHandler serviceClient.LoadCustomersCompleted, AddressOf serviceClient_LoadCustomersCompleted
	serviceClient.LoadCustomersAsync()
	
	Private Sub serviceClient_LoadCustomersCompleted(ByVal sender As Object, ByVal e As LoadCustomersCompletedEventArgs)
	    Dim customers = e.Result
	    Me.radGridView.ItemsSource = customers
	End Sub
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-web-services_5}}

	SampleWebServiceSoapClient serviceClient = new SampleWebServiceSoapClient();
	this.radGridView.ItemsSource = serviceClient.LoadCustomers();
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_6}}

	Dim serviceClient As New SampleWebServiceSoapClient()
	Me.radGridView.ItemsSource = serviceClient.LoadCustomers()
{{endregion}}

Run your demo, the result can be seen on the next image:

![](images/RadGridView_PopulatingWithDataLoadFromWeb_010.PNG)

## Using MVVM Approach

This section will show you how to populate your __RadGridView__ control in a MVVM manner. The __RadGridView__ will be bound to a data source object, that has a property __Customers__. When the control is loaded all customers from the Customers table in the Northwind database are loaded asynchronously.

* Create a new class named __NorthwindDataSource__.

#### __C#__

{{region gridview-loading-data-from-web-services_7}}

	public class NorthwindDataSource
	{
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_8}}

	Public Class NorthwindDataSource
	End Class
{{endregion}}

* Add a reference to your Web Service. 

* In the __NorthwindDataSource__ class add a reference to an __ObservableCollection of Customers__. 

* In the __NorthwindDataSource__ class add a reference to your Web Service Soap client:

#### __C#__

{{region gridview-loading-data-from-web-services_9}}

	public class NorthwindDataSource
	{
	    private SampleWebServiceSoapClient serviceClient;
	    public NorthwindDataSource()
	    {
	        serviceClient = new SampleWebServiceSoapClient();
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

{{region gridview-loading-data-from-web-services_10}}

	Public Class NorthwindDataSource
	    Private serviceClient As SampleWebServiceSoapClient
	
	    Public Sub New()
	        serviceClient = New SampleWebServiceSoapClient()
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

>tipFor more information about how to add a reference to a Web Service and how to create a new instance of a Web Service client, take a look at the [Consuming Web Service](http://www.telerik.com/help/silverlight/consuming-data-web-asmx-service.html)[Consuming Web Service](http://www.telerik.com/help/wpf/consuming-data-web-asmx-service.html)   topic.

* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Customers__ from the database:

#### __C#__

{{region gridview-loading-data-from-web-services_11}}

	serviceClient.LoadCustomersCompleted += new EventHandler<LoadCustomersCompletedEventArgs>( serviceClient_LoadCustomersCompleted );
	serviceClient.LoadCustomersAsync();
{{endregion}}

#### __C#__

{{region gridview-loading-data-from-web-services_12}}

	foreach ( Customers c in serviceClient.LoadCustomers() )
	{
	    this.Customers.Add( c );
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_13}}

	AddHandler serviceClient.LoadCustomersCompleted, AddressOf serviceClient_LoadCustomersCompleted
	serviceClient.LoadCustomersAsync()
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_14}}

	For Each c As Customers In serviceClient.LoadCustomers()
	    Me.Customers.Add(c)
	Next
{{endregion}}

{% if site.site_name == 'Silverlight' %}

And here is the code handling the __LoadCustomersCompleted__ event:{% endif %}

#### __C#__

{{region gridview-loading-data-from-web-services_15}}
	private void serviceClient_LoadCustomersCompleted( object sender, LoadCustomersCompletedEventArgs e )
	{
	    if ( e.Error == null && e.Result != null )
	    {
	        foreach ( Customers c in e.Result )
	        {
	            this.Customers.Add( c );
	        }
	    }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-loading-data-from-web-services_16}}

	Private Sub serviceClient_LoadCustomersCompleted(ByVal sender As Object, ByVal e As LoadCustomersCompletedEventArgs)
	    If e.[Error] Is Nothing AndAlso e.Result IsNot Nothing Then
	        For Each c As Customers In e.Result
	            Me.Customers.Add(c)
	        Next
	    End If
	End Sub
{{endregion}}

* Declare the __NorthwindDataSource__ object as a resource in your application. 

#### __XAML__

{{region gridview-loading-data-from-web-services_17}}

	<UserControl.Resources>
	   <example:NorthwindDataSource x:Key="DataSource"/>
	</UserControl.Resources>
{{endregion}}

* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

#### __XAML__

{{region gridview-loading-data-from-web-services_18}}

	<telerik:RadGridView x:Name="radGridView" Margin="8"
	    ItemsSource="{Binding Source={StaticResource DataSource}, Path=Customers}"/>
{{endregion}}

Run your demo, the result can be seen on the next picture: 

![](images/RadGridView_PopulatingWithDataLoadFromWeb_010.PNG)

>tipIf you need to define the columns manually take a look at the [Defining Columns]({%slug gridview-columns-defining-columns%}) topic.

# See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})

 * [Loading Data from ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})
 
{% if site.site_name == 'Silverlight' %}
 * [Loading Data from RIA Services]({%slug gridview-loading-data-from-ria-services%})

 * [DomainDataSource Support]({%slug gridview-domaindatasource-support%})
 {% endif %}