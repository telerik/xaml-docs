---
title: Creating the Data-bound Controls
page_title: Creating the Data-bound Controls
description: Creating the Data-bound Controls
slug: raddataservicedatasource-getting-started-creating-the-data-bound-controls
tags: creating,the,data-bound,controls
published: True
position: 2
---

# Creating the Data-bound Controls



## 

Now that we are ready with the service reference and the DataServiceContext, let's configure RadDataServiceDataSource, RadGridView and RadDataPager.

1. Add references to the following Telerik assemblies:
          

* Telerik.Windows.Controls (core assembly)

* Telerik.Windows.Data (core assembly)

* Telerik.Windows.Controls.DataServices (RadDataServiceDataSource)

* Telerik.Windows.Controls.GridView (RadGridView)

* Telerik.Windows.Controls.Input (required by RadGridView)

* Telerik.Windows.Controls.Data (RadDataPager)

1. Now add the RadDataServiceDataSource, RadGridView and RadDataPager controls to the MainWindow. You can add them by dragging them from the Toolbox and dropping it over the XAML or do it manually by writing the XAML code that is shown below: 

#### __XAML__

{{region raddataservicedatasource-getting-started-creating-the-data-bound-controls_0}}
	<Window x:Class="NorthwindExplorer.MainWindow"
	        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	        xmlns:local="clr-namespace:NorthwindExplorer"
	        Title="MainWindow" Height="350" Width="525">
	    <Grid>
	       <Grid.RowDefinitions>
	          <RowDefinition Height="*"/>
	          <RowDefinition Height="Auto"/>
	       </Grid.RowDefinitions>
	       <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	          <telerik:RadDataServiceDataSource.DataServiceContext>
	             <local:MyNorthwindContext/>
	          </telerik:RadDataServiceDataSource.DataServiceContext>
	       </telerik:RadDataServiceDataSource>
	       <telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}" IsBusy="{Binding IsBusy, ElementName=customersDataSource}" ShowGroupPanel="False"/>
	       <telerik:RadDataPager Grid.Row="1" Source="{Binding DataView, ElementName=customersDataSource}" PageSize="10"/>
	    </Grid>
	</Window>
	{{endregion}}



#### __XAML__

{{region raddataservicedatasource-getting-started-creating-the-data-bound-controls_1}}
	<UserControl x:Class="NorthwindExplorer.MainPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    xmlns:local="clr-namespace:NorthwindExplorer"
	    mc:Ignorable="d"
	    d:DesignHeight="300" d:DesignWidth="400">
	    <Grid x:Name="LayoutRoot" Background="White">
	       <Grid.RowDefinitions>
	          <RowDefinition Height="*"/>
	          <RowDefinition Height="Auto"/>
	       </Grid.RowDefinitions>
	       <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	          <telerik:RadDataServiceDataSource.DataServiceContext>
	             <local:MyNorthwindContext/>
	          </telerik:RadDataServiceDataSource.DataServiceContext>
	      </telerik:RadDataServiceDataSource>
	      <telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}" IsBusy="{Binding IsBusy, ElementName=customersDataSource}" ShowGroupPanel="False"/>
	      <telerik:RadDataPager Grid.Row="1" Source="{Binding DataView, ElementName=customersDataSource}" PageSize="10"/>
	    </Grid>
	</UserControl>
	{{endregion}}



There are several important things to notice here:

* The import of the Telerik schema: __xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation"__

* The import of the local namespace: __xmlns:local="clr-namespace:NorthwindExplorer"__

* The __AutoLoad__property of the __RadDataServiceDataSource__ instructs it to load data automatically the very first time and then each time something that affects the query changes.

* The __QueryName__ specifies the name of the property on the __DataServiceContext__ class that contains the entities that we will load. If you open the hidden __Reference__ file which is located below the Northwind Service Reference, then locate the __NorthwindEntities__class inside it, you can see all queries that it offers, such as Orders, Customers and so on. All of these queries are of type __DataServiceQuery<T>.__

* __DataServiceContext__– this is the __MyNorthwindContext__class that we created earlier. It derives from the __NorthwindEntities__context which was automatically generated for us. Additionaly, it specifies the Uri where the context will fetch data from. Since our class MyNorthwindContext has a parameter less constructor we can easily define it in XAML.

* __DataView__ - the data that comes from the server is stored in the __DataView__ property, so we bind RadGridView and RadDataPager to it.

* __IsBusy__ [optional] - bind the __IsBusy__ property of RadGridView to the IsBusy property of the __RadDataServiceDataSource__ so you get a loading indicator during the load operation.



3.   Click Ctrl + F5 to run the application. After a short pause RadGridView will be populated with data from the public OData service. Use RadDataPager to navigate across pages. Use RadGridView’s filtering and sorting UI to perform these actions on the server.

See Also

[Creating the Server Application]({%slug raddataservicedatasource-getting-started-creating-the-server-application%})

[Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})


