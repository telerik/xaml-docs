---
title: Creating the Data-bound Controls
page_title: Creating the Data-bound Controls
description: Check our &quot;Creating the Data-bound Controls&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-getting-started-creating-the-data-bound-controls
tags: creating,the,data-bound,controls
published: True
position: 3
---

# Creating the Data-bound Controls

Now that we are ready with the service reference and the __DataServiceContext__, let's configure __RadDataServiceDataSource__, __RadGridView__ and __RadDataPager__.

**1.** Add references to the following Telerik assemblies:          

* __Telerik.Windows.Controls__ (core assembly)

* __Telerik.Windows.Data__ (core assembly)

* __Telerik.Windows.Controls.DataServices__ (RadDataServiceDataSource)

* __Telerik.Windows.Controls.GridView__ (RadGridView)

* __Telerik.Windows.Controls.Input__ (required by RadGridView)

* __Telerik.Windows.Controls.Data__ (RadDataPager)

**2.**	Now add the __RadDataServiceDataSource__, __RadGridView__ and __RadDataPager__ controls to the __MainWindow__. You can add them by dragging them from the __Toolbox__ and dropping it over the XAML or do it manually by writing the XAML code that is shown below: 

{% if site.site_name == 'WPF' %}

```XAML

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
```
{% endif %}

{% if site.site_name == 'Silverlight' %}


```XAML

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
```
{% endif %}


There are several important things to notice here:

* The import of the Telerik schema: xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation"

* The import of the local namespace: xmlns:local="clr-namespace:NorthwindExplorer"

* The __AutoLoad__ property of __RadDataServiceDataSource__ instructs it to load data automatically the very first time and then each time something that affects the query changes.

* The __QueryName__ specifies the name of the property on the __DataServiceContext__ class that contains the entities that we will load. If you open the hidden __Reference__ file which is located below the __Northwind Service Reference__, then locate the __NorthwindEntities__ class inside it, you can see all queries that it offers, such as __Orders__, __Customers__ and so on. All of these queries are of type __DataServiceQuery&lt;T&gt;.__

* __DataServiceContext__– this is the __MyNorthwindContext__ class that we created earlier. It derives from the __NorthwindEntities__ context which was automatically generated for us. Additionally, it specifies the __Uri__ where the context will fetch data from. Since our class __MyNorthwindContext__ has a parameter less constructor we can easily define it in XAML.

* __DataView__ - the data that comes from the server is stored in the __DataView__ property, so we bind __RadGridView__ and __RadDataPager__ to it.

* __IsBusy__ [optional] - bind the __IsBusy__ property of __RadGridView__ to the __IsBusy__ property of the __RadDataServiceDataSource__ so you get a loading indicator during the load operation.

**3.** Click __Ctrl + F5__ to run the application. After a short pause __RadGridView__ will be populated with data from the public __OData__ service. Use __RadDataPager__ to perform server-side paging. Use __RadGridView’s__ filtering and sorting UI to perform these actions on the server.

## See Also
* [Creating the Server Application]({%slug raddataservicedatasource-getting-started-creating-the-server-application%})
* [Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})