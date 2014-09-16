---
title: Data Binding to ADO.NET Data Service
page_title: Data Binding to ADO.NET Data Service
description: Data Binding to ADO.NET Data Service
slug: radchart-populating-with-data-binding-to-adonet-service
tags: data,binding,to,ado.net,data,service
published: True
position: 10
---

# Data Binding to ADO.NET Data Service



The purpose of this tutorial is to show you how to populate a __RadChart__with data from an __ADO.NET Data Service__in two ways:

* A straight-forward way - [plain method calls](#Plain_Method_Calls).

* [Using MVVM approach](#Using_MVVM_Approach)

>This tutorial will use the __Northwind__database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

Before proceeding further with this tutorial you need to create a new application and add a __RadChart__ declaration in your XAML: 

#### __XAML__

{{region radchart-populating-with-data-binding-to-adonet-service_0}}
	<telerikChart:RadChart x:Name="radChart" Margin="8">            
	</telerikChart:RadChart>
	{{endregion}}



The chart control will be populated with the top 10 products from the Northwind database. On the __Y axis__the __UnitPrice__property will be displayed.

* Add a new __SeriesMapping__to your chart declaration and set the __LegendLabel__property to "Products UnitPrice".

* Add a new __ItemMapping__and set the following properties:

* __FieldName__to __UnitPrice__

* __DataPointMember__to __YValue__

#### __XAML__

{{region radchart-populating-with-data-binding-to-adonet-service_1}}
	<telerikChart:RadChart x:Name="radChart" Margin="8">            
	    <telerikChart:RadChart.SeriesMappings>
	        <telerikCharting:SeriesMapping LegendLabel="Products UnitPrice">
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping FieldName="UnitPrice" DataPointMember="YValue"/>
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	    </telerikChart:RadChart.SeriesMappings>
	</telerikChart:RadChart>
	{{endregion}}



* Create new __Business Object__ and name it____ProductDetail__:______

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_2}}
	public class ProductDetail
	    {
	        public decimal? UnitPrice { get; set; }
	
	        public ProductDetail(decimal? unitPrice)
	        {
	            this.UnitPrice = unitPrice;
	        }
	    }
	{{endregion}}





#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_3}}
	Public Class ProductDetail
	Public Property UnitPrice() As Decimal?
	Public Sub New(ByVal unitPrice? As Decimal)
	Me.UnitPrice = unitPrice
	End Sub
	End Class
	{{endregion}}





## Plain Method Calls

Add a reference to your ADO.NET Data Service. 

* Switch to the code-behind and add a reference to the {% if site.site_name == 'WPF' %}__NorthWindEntities__ object{% endif %}__DataServiceContext__.

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_4}}
	dbContext = new DataServiceContext  ( new Uri( "SampleAdoNetDataService.svc", UriKind.Relative ) );
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_5}}
	Dim dbContext As New DataServiceContext(New Uri("SampleAdoNetDataService.svc", UriKind.Relative))
	{{endregion}}



#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_6}}
	NorthwindEntities dbContext = new NorthwindEntities( new Uri( "Enter your service address here") );
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_7}}
	Dim dbContext As New NorthwindEntities(New Uri("Enter your service address here"))
	{{endregion}}



>tipFor more information about how to add a reference to an ADO.NET Data Service and how to create a new instance of the exposed entity, take a look at the [Consuming ADO.NET Data Service](http://www.telerik.com/help/silverlight/consuming-data-ado-net-data-service.html) topic.

Add the following code which will make the initial load of the objects.

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_8}}
	private void BeginRequest()
	{
	    DataServiceQuery<Products> query = dbContext.CreateQuery<Products>( "Products" );
	    query.BeginExecute( RequestCompleted, query );
	}
	
	private void ProductsRequestCompleted(IAsyncResult asyncResult)
	  {
	    DataServiceQuery<Product> query = asyncResult.AsyncState as DataServiceQuery<Product>;
	    products = query.EndExecute(asyncResult).ToList();
	    List<ProductDetail> result = new List<ProductDetail>();
	  foreach (Product p in products.Take(10))
	   {
	    result.Add(new ProductDetail(p.UnitPrice));
	   }
	   RadChart1.ItemsSource = result;
	 }
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_9}}
	Private Sub BeginRequest()
	    Dim query As DataServiceQuery(Of Products) = dbContext.CreateQuery(Of Products)("Products")
	    query.BeginExecute(RequestCompleted, query)
	End Sub
	Private Sub ProductsRequestCompleted(ByVal asyncResult As IAsyncResult)
	    Dim query As DataServiceQuery(Of Product) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Product))
	    products = query.EndExecute(asyncResult).ToList()
	    Dim result As New List(Of ProductDetail)()
	
	   For Each p As Product In products.Take(10)
	    result.Add(New ProductDetail(p.UnitPrice))
	      Next p
	    RadChart1.ItemsSource = result
	  End Sub
	{{endregion}}



#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_10}}
	this.radChart.ItemsSource = dbContext.Products.Execute().Take(10).ToList();
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_11}}
	Me.radChart.ItemsSource = dbContext.Products.Execute().Take(10).ToList()
	{{endregion}}



Run your demo, the result can be seen on the next image:




         
      ![](images/RadChart_PopulatingWithDataBindingToAdoNet_010.PNG)

## Using MVVM Approach

This section will show you how to populate your __RadChart__control in a MVVM manner.

* Create a new class named __NorthwindDataSource__. 

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_12}}
	public class NorthwindDataSource
	{
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_13}}
	Public Class NorthwindDataSource
	End Class
	{{endregion}}



* Add a reference to your ADO.NET Data Service.

* In the __NorthwindDataSource__class add a reference to an __ObservableCollection__of __Categories__.

* In the __NorthwindDataSource__ class add a reference to the __NorthwindEntities__object.

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_14}}
	public class NorthwindDataSource
	{
	    private static NorthwindEntities northwindEntity;
	    public NorthwindDataSource()
	    {
	        northwindEntity = new NorthwindEntities( new Uri( "SampleAdoNetDataService.svc", UriKind.Relative ) );
	        this.Products = new ObservableCollection<Products>();
	    }
	    public ObservableCollection<Products> Products
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_15}}
	Public Class NorthwindDataSource
	    Private Shared northwindEntity As NorthwindEntities
	
	    Public Sub New()
	        northwindEntity = New NorthwindEntities(New Uri("SampleAdoNetDataService.svc", UriKind.Relative))
	        Me.Products = New ObservableCollection(Of Products)()
	    End Sub
	
	Private _Products As ObservableCollection(Of Products)
	    Public Property Products() As ObservableCollection(Of Products)
	        Get
	            Return _Products
	        End Get
	        Set(ByVal value As ObservableCollection(Of Products))
	            _Products = value
	        End Set
	    End Property
	End Class
	{{endregion}}



* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Categories__from the database: 

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_16}}
	var query = ( from p in northwindEntity.Products
	              select p ).Take( 10 );
	DataServiceQuery<Products> products = ( DataServiceQuery<Products> )query;
	products.BeginExecute(
	   ( IAsyncResult result ) => EntitiesLoaded<Products>( result, this.Products ), products );
	foreach ( Products p in query.ToList() )
	{
	    this.Products.Add( p );
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-populating-with-data-binding-to-adonet-service_17}}
	Dim query = (From p In northwindEntity.Products _
	    Select p).Take(10)
	Dim products As DataServiceQuery(Of Products) = DirectCast(query, DataServiceQuery(Of Products))
	products.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, Me.Products), products)
	For Each p As Products In query.ToList()
	    Me.Products.Add(p)
	Next
	{{endregion}}

{% if site.site_name == 'Silverlight' %}

And here is the code for the __EntitiesLoaded__method: {% endif %}

#### __C#__

{{region radchart-populating-with-data-binding-to-adonet-service_18}}
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

{{region radchart-populating-with-data-binding-to-adonet-service_19}}
	Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
	    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
	    For Each entity As T In query.EndExecute(result)
	        entities.Add(entity)
	    Next
	End Sub
	{{endregion}}



* Declare the __NorthwindDataSource__ object as a resource in your application. 

#### __XAML__

{{region radchart-populating-with-data-binding-to-adonet-service_20}}
	<UserControl.Resources>
	    <example:NorthwindDataSource x:Key="DataSource"/>
	</UserControl.Resources>
	{{endregion}}



*  Update your chart declaration - set the __ItemsSource__ property. 

#### __XAML__

{{region radchart-populating-with-data-binding-to-adonet-service_21}}
	<telerikChart:RadChart x:Name="radChart" Margin="8" 
	    ItemsSource="{Binding Source={StaticResource DataSource}, Path=Products}">
	    <telerikChart:RadChart.SeriesMappings>
	        <telerikCharting:SeriesMapping LegendLabel="Products UnitPrice">
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping FieldName="UnitPrice" DataPointMember="YValue"/>
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	    </telerikChart:RadChart.SeriesMappings>
	</telerikChart:RadChart>
	{{endregion}}



Here it is shown how the final result should look like: 




         
      ![](images/RadChart_PopulatingWithDataBindingToAdoNet_010.PNG)

# See Also

 * [Populating with Data Overview]({%slug radchart-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})

 * [Data Binding to WCF Service]({%slug radchart-populating-with-data-binding-to-wcf%})

 * [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%})

 * [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%})
