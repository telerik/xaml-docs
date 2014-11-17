---
title: Binding to ADO.NET Data Service
page_title: Binding to ADO.NET Data Service
description: Binding to ADO.NET Data Service
slug: radtreeview-populating-with-data-databinding-to-adonet-service
tags: binding,to,ado.net,data,service
published: True
position: 7
---

# Binding to ADO.NET Data Service

The purpose of this tutorial is to show you how to populate a __RadTreeView__ with data from an __ADO.NET Data Service__.  

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

Here will be also examined "best practice" for using __RadTreeView__ with load on demand and ADO.NET Data Service. You can read more information about the load on demand behavior [here]({%slug radtreeview-features-load-on-demand%}). 

* Add a new __RadTreeView__ declaration in your XAML and add an event handler for __LoadOnDemand__ event. Also set the following properties to __True__:
	* __IsLoadOnDemandEnabled__
	* __IsExpandOnSingleClickEnabled__

	#### __XAML__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_0}}
		<telerik:RadTreeView x:Name="radTreeView" Margin="8"
			IsLoadOnDemandEnabled="True" IsExpandOnSingleClickEnabled="True"
			LoadOnDemand="radTreeView_LoadOnDemand"/>
		{{endregion}}

	The __RadTreeView__ will be bound to a data source object, that has a property __Categories__. When the __LoadOnDemand__ event of __RadTreeView__ is fired, the selected category asynchronously loads its related products. 

* Create a new class named __NorthwindDataSource__. 

#### __C#__

{{region radtreeview-populating-with-data-databinding-to-adonet-service_1}}
	public class NorthwindDataSource
	{
	}
	{{endregion}}

#### __VB.NET__

{{region radtreeview-populating-with-data-databinding-to-adonet-service_2}}
	Public Class NorthwindDataSource
	End Class
	{{endregion}}

* Add a reference to your ADO.NET Data Service.

* In the __NorthwindDataSource__ class add a reference to an __ObservableCollection__ of __Categories__.

* In the __NorthwindDataSource__ class add a reference to the __NorthwindEntities__ object: 

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_3}}
		private NorthwindEntities northwindEntity;
		
		public NorthwindDataSource()
		{
			this.northwindEntity = new NorthwindEntities( new Uri( "Enter your service address here" ) );
			this.Categories = new ObservableCollection<Categories>();
		}
		
		public ObservableCollection<Categories> Categories
		{
			get;
			set;
		}
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_4}}
		Private northwindEntity As NorthwindEntities
		
		Public Sub New()
			Me.northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
			Me.Categories = New ObservableCollection(Of Categories)()
		End Sub
		
		Private _Categories As ObservableCollection(Of Categories)
		
		Public Property Categories() As ObservableCollection(Of Categories)
			Get
				Return _Categories
			End Get
			Set(ByVal value As ObservableCollection(Of Categories))
				_Categories = value
			End Set
		End Property
		{{endregion}}

* Add the following code in the constructor of the __NorthwindDataSource__. It will make the initial load of all __Categories__ from the database: 

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_5}}
		northwindEntity.Categories.BeginExecute(
			( IAsyncResult result ) => EntitiesLoaded<Categories>( result, this.Categories ),
			northwindEntity.Categories );
		{{endregion}}
		
	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_6}}
		foreach ( Categories c in northwindEntity.Categories.Execute() )
		{
			this.Categories.Add( c );
		}
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_7}}
		northwindEntity.Categories.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Categories)(result, Me.Categories), northwindEntity.Categories)
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_8}}
		For Each c As Categories In northwindEntity.Categories.Execute()
			Me.Categories.Add(c)
		Next
		{{endregion}}

	{% if site.site_name == 'Silverlight' %}
	And here is the code for the __EntitiesLoaded()__ method:
	{% endif %}

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_9}}
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

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_10}}
		Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
			Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
			For Each entity As T In query.EndExecute(result)
				entities.Add(entity)
			Next
		End Sub
		{{endregion}}

	> Since the first load of the categories is also asynchronous, it takes some time to display the treeview for the first time. You may consider adding some loading animation in your application.

* Declare the __NorthwindDataSource__ object as a resource in your application. 

	#### __XAML__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_11}}
		<UserControl.Resources>
			<example:NorthwindDataSource x:Key="DataSource"/>
		</UserControl.Resources>
		{{endregion}}

* Declare [HierarchicalDataTemplates]({%slug radtreeview-populating-with-data-hierarchical-data-templates%}) which will describe the __RadTreeView__ structure. 

	{% if site.site_name == 'Silverlight' %}
	#### __XAML__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_12}}
		<DataTemplate x:Key="ProductTemplate">
			<TextBlock Text="{Binding ProductName}" />
		</DataTemplate>
		<telerik:HierarchicalDataTemplate x:Key="CategoryTemplate" ItemsSource="{Binding Products}"
		  ItemTemplate="{StaticResource ProductTemplate}">
			<TextBlock Text="{Binding CategoryName}" />
		</telerik:HierarchicalDataTemplate>
		{{endregion}}

	{% endif %}
	{% if site.site_name == 'WPF' %}
	#### __XAML__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_13}}
		<DataTemplate x:Key="ProductTemplate">
			<TextBlock Text="{Binding ProductName}" />
		</DataTemplate>
		<HierarchicalDataTemplate x:Key="CategoryTemplate" ItemsSource="{Binding Products}"
			ItemTemplate="{StaticResource ProductTemplate}">
			<TextBlock Text="{Binding CategoryName}" />
		</HierarchicalDataTemplate>
		{{endregion}}

	{% endif %}

* Update your RadTreeView declaration - set the ItemsSource and __ItemTemplate__ properties. 

	#### __XAML__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_14}}
		<telerik:RadTreeView x:Name="radTreeView" Margin="8"
			IsLoadOnDemandEnabled="True" IsExpandOnSingleClickEnabled="True"
			LoadOnDemand="radTreeView_LoadOnDemand"
			ItemTemplate="{StaticResource CategoryTemplate}"
			ItemsSource="{Binding Source={StaticResource DataSource}, Path=Categories}"/>
		{{endregion}}
		
	Run your demo, the result can be seen on the next picture:
	![](images/RadTreeView_PopulatingWithBindingToAdoNetService_010.PNG)

	If you try to expand any of the loaded categories, the default load on demand animation will be started: 
	![](images/RadTreeView_PopulatingWithBindingToAdoNetService_020.PNG)

The next step is to handle the load on demand event. 

* Add the following method to the __NorthwindDataSource__ class, which aims to load the products for the expanded category: 

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_15}}
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
		{{endregion}}

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_16}}
		public static void LoadProducts( Categories category )
		{
			DataServiceQuery<Products> categoryProducts = northwindEntity
				.CreateQuery<Products>( string.Format( "Categories({0})/Products", category.CategoryID ) )
				.Expand( "Suppliers" )
				.Expand( "Categories" );
			category.Products = new ObservableCollection<Products>();
			foreach ( Products p in categoryProducts.Execute() )
			{
				category.Products.Add( p );
			}
		}
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_17}}
		Public Shared Sub BeginLoadingProducts(ByVal category As Categories)
			Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
		
			categoryProducts.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, category.Products), categoryProducts)
		End Sub
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_18}}
		Public Shared Sub LoadProducts(ByVal category As Categories)
			Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
		
			category.Products = New ObservableCollection(Of Products)()
			For Each p As Products In categoryProducts.Execute()
				category.Products.Add(p)
			Next
		End Sub
		{{endregion}}

* Add the following code to the load on demand event handler, which you declared on step 1. 

	#### __C#__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_19}}
		private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
		{
			RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
			Categories category = item.Item as Categories;
			if ( category != null )
			{
				NorthwindDataSource.BeginLoadingProducts( category );
			}
			else
			{
				item.IsLoadOnDemandEnabled = false;
			}
		}
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-populating-with-data-databinding-to-adonet-service_21}}
		Private Sub radTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
		
			Dim category As Categories = TryCast(item.Item, Categories)
			If category IsNot Nothing Then
				NorthwindDataSource.BeginLoadingProducts(category)
			Else
				item.IsLoadOnDemandEnabled = False
			End If
		End Sub
		{{endregion}}

	> When there are no items to add, and you want to prevent the __LoadOnDemand__ event to fire again, set the __IsLoadOnDemandEnabled__ property to __False__ to the __RadTreeViewItem__ that has fired the __LoadOnDemand__ event.

And here is the result:
![](images/RadTreeView_PopulatingWithBindingToAdoNetService_030.PNG)

# See Also
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})
 * [Populating with Data - In Code-Behind]({%slug radtreeview-populating-with-data-in-code-behind%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})