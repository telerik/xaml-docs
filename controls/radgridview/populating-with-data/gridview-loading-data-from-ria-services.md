---
title: Loading Data from RIA Services
page_title: Loading Data from RIA Services
description: Loading Data from RIA Services
slug: gridview-loading-data-from-ria-services
tags: loading,data,from,ria,services
published: True
position: 4
site_name: Silverlight
---

# Loading Data from RIA Services



## 

The purpose of this tutorial is to show you how to populate a __RadGridView__with data from a __.NET RIA Service__. 

>This tutorial will use the __Northwind__database, which can be download it from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

* Add a new __RadGridView__declaration in your XAML: 

#### __XAML__

{{region gridview-loading-data-from-ria-services_0}}
	<telerik:RadGridView x:Name="radGridView" Margin="8"/>
	{{endregion}}



The __RadGridView__ will be bound to a data source object, that has a property __Customers__. When the control is loaded all customers from the Customers table in the Northwind database are loaded asynchronously.

* Create a new class named __NorthwindDataSource__. 

#### __C#__

{{region gridview-loading-data-from-ria-services_1}}
	public class NorthwindDataSource
	{
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-loading-data-from-ria-services_2}}
	Public Class NorthwindDataSource
	End Class
	{{endregion}}



* In the __NorthwindDataSource__class add a reference to an __ObservableCollection__of __Customers__. 


* In the __NorthwindDataSource__class add a reference to your RIA Service context: 

#### __C#__

{{region gridview-loading-data-from-ria-services_3}}
	public class NorthwindDataSource
	{
	    SampleRiaContext riaContext;
	    public NorthwindDataSource()
	    {
	        riaContext = new SampleRiaContext();
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

{{region gridview-loading-data-from-ria-services_4}}
	Public Class NorthwindDataSource
	    Private riaContext As SampleRiaContext
	
	    Public Sub New()
	        riaContext = New SampleRiaContext()
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



* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Customers__from the database:

#### __C#__

{{region gridview-loading-data-from-ria-services_5}}
	LoadOperation<Customers> loadOperation = riaContext.Load<Customers>( riaContext.GetCustomersQuery() );
	loadOperation.Completed += new EventHandler( loadOperation_Completed );
	{{endregion}}



#### __VB.NET__

{{region gridview-loading-data-from-ria-services_6}}
	Dim loadOperation As LoadOperation(Of Customers) = riaContext.Load(Of Customers)(riaContext.GetCustomersQuery())
	AddHandler loadOperation.Completed, AddressOf loadOperation_Completed
	{{endregion}}



And here is the code handling the __Completed__event of the load operation: 

#### __C#__

{{region gridview-loading-data-from-ria-services_7}}
	private void loadOperation_Completed( object sender, EventArgs e )
	{
	    //Consume the result
	    foreach ( Customers c in riaContext.Customers )
	    {
	        this.Customers.Add( c );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-loading-data-from-ria-services_8}}
	Private Sub loadOperation_Completed(ByVal sender As Object, ByVal e As EventArgs)
	    'Consume the result
	    For Each c As Customers In riaContext.Customers
	        Me.Customers.Add(c)
	    Next
	End Sub
	{{endregion}}



* Declare the __NorthwindDataSource__ object as a resource in your application.

#### __XAML__

{{region gridview-loading-data-from-ria-services_9}}
	<UserControl.Resources>
	   <example:NorthwindDataSource x:Key="DataSource"/>
	</UserControl.Resources>
	{{endregion}}



* Update your __RadGridView__ declaration - set the __ItemsSource__ property.

#### __XAML__

{{region gridview-loading-data-from-ria-services_10}}
	<telerik:RadGridView x:Name="radGridView" Margin="8"
	    ItemsSource="{Binding Source={StaticResource DataSource}, Path=Customers}"/>
	{{endregion}}



Run your demo, the result can be seen on the next picture:

![](images/RadGridView_PopulatingWithDataLoadFromRia_010.PNG)

>tipIf you need to define the columns manually read the topic [Defining Columns](0AE6DD74-8F95-4625-9083-A42F3F9217BD#Manual_Columns_Definition).

# See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})

 * [DomainDataSource Support]({%slug gridview-domaindatasource-support%})

 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})

 * [Loading Data from ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

 * [Loading Data from Web Services]({%slug gridview-loading-data-from-web-services%})
