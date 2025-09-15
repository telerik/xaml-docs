---
title: Binding to WCF Service
page_title: Binding to WCF Service
description: Check our &quot;Binding to WCF Service&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-populating-with-data-binding-to-wcf
tags: binding,to,wcf,service
published: True
position: 5
---

# Binding to WCF Service

The purpose of this tutorial is to show you how to populate a __RadComboBox__ with a data from a __WCF Service__ in two ways:

* [Using plain methods call in the code-behind](#using-plain-methods-call-in-the-code-behind)

* [Using MVVM approach](#using-mvvm-approach)

>This tutorial uses the [Northwind database](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs).

Before proceeding further with this tutorial, you need to create a new application and a __RadComboBox__ declaration in your XAML.

#### __XAML__  
```XAML
	<telerik:RadComboBox x:Name="radComboBox"/>
```

## Using Plain Methods Call in the Code-Behind

1. Add a reference to your WCF Service.

2. Switch to the code-behind and create a new instance of your WCF Service client.

	#### __C#__  
	```C#
		ComboBoxWcfServiceClient serviceClient = new ComboBoxWcfServiceClient();
	```

	#### __VB.NET__  
	```VB.NET
		Dim serviceClient As New ComboBoxWcfServiceClient()
	```

	>tip For more information about how to add a reference to a WCF Service and how to create a new instance of a WCF Service client, take a look at the [Consuming WCF Service]({%slug consuming-data-wcf-service%}) topic.

3. The __ComboBox__ control will be populated with all __Products__ from the __Northwind__ database. In the drop-down list the __ProductName__ and the __UnitPrice__ properties will be displayed. Add the following code which will make the initial load of the objects.

	#### __C#__  
	```C#
		private void BeginRequest()
		{
			serviceClient.GetProductsCompleted += new EventHandler<GetProductsCompletedEventArgs>( serviceClient_GetProductsCompleted );
			serviceClient.GetProductsAsync();
		}
		private void serviceClient_GetProductsCompleted( object sender, GetProductsCompletedEventArgs e )
		{
			radComboBox.ItemsSource = e.Result;
		}
	```

	#### __VB.NET__  
	```VB.NET
		Private Sub BeginRequest()
			AddHandler serviceClient.GetProductsCompleted, AddressOf serviceClient_GetProductsCompleted
			serviceClient.GetProductsAsync()
		End Sub
		Private Sub serviceClient_GetProductsCompleted(ByVal sender As Object, ByVal e As GetProductsCompletedEventArgs)
			radComboBox.ItemsSource = e.Result
		End Sub
	```

	#### __C#__  
	```C#
		private void BeginRequest()
		{
			this.radComboBox.ItemsSource = serviceClient.GetProducts();
		}
	```

	#### __VB.NET__  
	```VB.NET
		Private Sub BeginRequest()
			Me.radComboBox.ItemsSource = serviceClient.GetProducts()
		End Sub
	```

4. You need to declare a custom __DataTemplate__ to determine how the items in the drop-down will look like. Add the following __DataTemplate__ declaration in your XAML resources.

	#### __XAML__  
	```XAML
		<UserControl.Resources>
			<DataTemplate x:Key="CustomItemTemplate">
				<StackPanel Orientation="Horizontal">
					<TextBlock Text="{Binding ProductName}"/>
					<TextBlock Text=" - "/>
					<TextBlock Text="{Binding UnitPrice}"/>
					<TextBlock Text=" $"/>
				</StackPanel>
			</DataTemplate>
		</UserControl.Resources>
	```

5. Find your __RadComboBox__ declaration and set the declared __DataTemplate__ to its __ItemTemplate__ property.

	#### __XAML__  
	```XAML
		<telerik:RadComboBox x:Name="radComboBox" ItemTemplate="{StaticResource CustomItemTemplate}"/>
	```


__The end result with the data fetched from the service__  

![{{ site.framework_name }} RadComboBox Bound to Data from WCF Service](images/RadComboBox_PopulatingWithData_BindingToWcfService_010.png)

## Using MVVM Approach

This section will show you how to populate your __RadComboBox__ control in a MVVM manner. The __RadComboBox__ will be bound to a data source object, that has a property __Products__. When the control is loaded, all products from the __Products__ table in the Northwind database are loaded asynchronously.

1. Create a new class named __NorthwindDataSource__.

	#### __C#__  
	```C#
		public class NorthwindDataSource
		{
		}
	```

	#### __VB.NET__  
	```VB.NET
		Public Class NorthwindDataSource
		End Class
	```

2. Add a reference to your WCF Service

3. In the __NorthwindDataSource__ class add a reference to an __ObservableCollection__ of __Products__.

4. In the __NorthwindDataSource__ class add a reference to your WCF Service client:

	#### __C#__  
	```C#
		public class NorthwindDataSource
		{
			private ComboBoxWcfServiceClient serviceClient;
		
			public NorthwindDataSource()
			{
				this.Products = new ObservableCollection<Products>();
				this.serviceClient = new ComboBoxWcfServiceClient();
			}
		
			public ObservableCollection<Products> Products
			{
				get;
				protected set;
			}
		}
	```

	#### __VB.NET__  
	```VB.NET
		Public Class NorthwindDataSource
			Private serviceClient As ComboBoxWcfServiceClient
		
			Public Sub New()
				Me.Products = New ObservableCollection(Of Products)()
				Me.serviceClient = New ComboBoxWcfServiceClient()
			End Sub
		
		Private _Products As ObservableCollection(Of Products)
			Public Property Products() As ObservableCollection(Of Products)
				Get
					Return _Products
				End Get
				Protected Set(ByVal value As ObservableCollection(Of Products))
					_Products = value
				End Set
			End Property
		End Class
	```

	>tip For more information about how to add a reference to a WCF Service and how to create a new instance of a WCF Service client, take a look at the [Consuming WCF Service]({%slug consuming-data-ado-net-data-service%}) topic.

5. Add the following code in the __constructor__ of the __NorthwindDataSource__. It will make the initial load of all __Products__ from the database:

	#### __C#__  
	```C#
		this.serviceClient.GetProductsCompleted += new EventHandler<GetProductsCompletedEventArgs>( serviceClient_GetProductsCompleted );
		this.serviceClient.GetProductsAsync();
	```

	#### __VB.NET__  
	```VB.NET
		AddHandler Me.serviceClient.GetProductsCompleted, AddressOf serviceClient_GetProductsCompleted
		Me.serviceClient.GetProductsAsync()
	```

	{% if site.site_name == 'Silverlight' %}
	And here is the code handling the __GetProductsCompleted__ event:
	{% endif %}

	#### __C#__  
	```C#
		private void serviceClient_GetProductsCompleted( object sender, GetProductsCompletedEventArgs e )
		{
			foreach ( Products p in e.Result )
			{
				this.Products.Add( p );
			}
		}
	```

	#### __VB.NET__  
	```VB.NET
		Private Sub serviceClient_GetProductsCompleted(ByVal sender As Object, ByVal e As GetProductsCompletedEventArgs)
			For Each p As Products In e.Result
				Me.Products.Add(p)
			Next
		End Sub
	```

	#### __C#__  
	```C#
		foreach ( Products p in serviceClient.GetProducts() )
		{
			this.Products.Add( p );
		}
	```

	#### __VB.NET__  
	```VB.NET
		For Each p As Products In serviceClient.GetProducts()
			Me.Products.Add(p)
		Next
	```

6. Declare the __NorthwindDataSource__ object as a resource in your application.

	#### __XAML__  
	```XAML
		<UserControl.Resources>
			<example:NorthwindDataSource x:Key="DataSource"/>   
		</UserControl.Resources>
	```

7. Declare a custom __DataTemplate__ to determine how the items in the drop-down will look like. Add the following __DataTemplate__ declaration in your XAML resources.

	#### __XAML__  
	```XAML
		<UserControl.Resources>
			<DataTemplate x:Key="CustomItemTemplate">
				<StackPanel Orientation="Horizontal">
					<TextBlock Text="{Binding ProductName}"/>
					<TextBlock Text=" - "/>
					<TextBlock Text="{Binding UnitPrice}"/>
					<TextBlock Text=" $"/>
				</StackPanel>
			</DataTemplate>
		
			<example:NorthwindDataSource x:Key="DataSource"/>
		</UserControl.Resources>
	```

8. Update your __RadComboBox__ declaration - set the __ItemsSource__ and __ItemTemplate__ properties.

	#### __XAML__  
	```XAML
		<telerik:RadComboBox x:Name="radComboBox"
			ItemsSource="{Binding Source={StaticResource DataSource}, Path=Products}"
			ItemTemplate="{StaticResource CustomItemTemplate}"/>
	```

__The end result produced by the code above__  

![{{ site.framework_name }} RadComboBox Bound to Data from WCF Service](images/RadComboBox_PopulatingWithData_BindingToWcfService_020.png)

## See Also  
 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})
 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})
