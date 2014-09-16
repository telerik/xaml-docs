---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: entityframework-getting-started
tags: getting,started
publish: True
position: 3
---

# Getting Started



This tutorial will walk you through the creation of a sample application that contains __RadGridView__ bound to __RadEntityFrameworkDataSource__.
      

## 

You can check the latest changes [here]({%slug entityframework-changes%}). 
        

As of version __2013 Q3 SP1__ we have added support for __EntityFramework 6.0__ (Telerik.Windows.Controls.EntityFramework60 assembly was introduced).

## Creating the WPF application

1. Note that RadEntityFrameworkDataSource is built on top of the 
          [ADO.NET Entity Framework](http://msdn.microsoft.com/en-us/library/bb399572.aspx). Basic Entity Framework experience is required for working with RadEntityFrameworkDataSource.
        

2. Start Visual Studio 2010 and create a new WPF Application.

## Creating the Model

Now that we have the application, we will add our entity model using the Northwind database. 

1. In the project add a new __ADO.NET Entity Data Model__.
        ![Rad Entity Framework Getting Started 1](images/RadEntityFramework_Getting_Started1.png)

2. Choose the data connection (for example the Northwind database).
        ![Rad Entity Framework Getting Started 2](images/RadEntityFramework_Getting_Started2.png)

3. Generate the entities from the __Orders__ table of the Northwind database.
        

4. Click Finish and rebuild the solution

## Adding RadGridView and RadEntityFrameworkDataSource

Now let's go to the client side.

1. Add References to the following Telerik assemblies:

* Telerik.Windows.Controls (mandatory for both RadGridView and RadEntityFrameworkDataSource)

* Telerik.Windows.Data (mandatory for both RadGridView and RadEntityFrameworkDataSource)

* Telerik.Windows.Controls.EntityFramework (mandatory for RadEntityFrameworkDataSource)

* Telerik.Windows.Controls.GridView (mandatory for RadGridView)

* Telerik.Windows.Controls.Input (mandatory for RadGridView)

2. Now add the __RadGridView__ and __RadEntityFrameworkDataSource__ controls to the user window. You can add them by dragging them from the Toolbox and dropping it over the XAML or do it manually by writing the XAML code that is shown below.
        

#### __XAML__

{{region entityframework-getting-started.aml_1}}
	<Window x:Class="EntityFramework_Example.MainWindow"
	        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	        xmlns:local="clr-namespace:EntityFramework_Example"
	        Title="MainWindow" Height="350" Width="525">
	    <Grid>
	        <telerik:RadEntityFrameworkDataSource Name="OrdersEntityFrameworkDataSource" QueryName="Orders">
	            <telerik:RadEntityFrameworkDataSource.ObjectContext>
	                <local:MyNorthwindEntities/>
	            </telerik:RadEntityFrameworkDataSource.ObjectContext>
	        </telerik:RadEntityFrameworkDataSource>
	        <telerik:RadGridView ItemsSource="{Binding DataView, ElementName=OrdersEntityFrameworkDataSource}"/>
	    </Grid>
	</Window>
	
	{{endregion}}



Several important things to notice:

* The import of the telerik schema: xmlns:telerik="[http://schemas.telerik.com/2008/xaml/presentation](http://schemas.telerik.com/2008/xaml/presentation)

* The __QueryName__ points to the query of the data source.
            

* __ObjectContext__ - points to the context that has been created.
            

* __DataView__ - the data that comes from the query is stored in the DataView property, so we bind the RadGridView to it.
          

* Click __Ctrl + F5__ to run the application and see the gridview populated with the data from the Orders table.
          

## RadEntityFrameworkDataSource.DbContext property.

Since Q3 SP1 2012 we have added the RadEntityFrameworkDataSource.DbContext property.

>Please note that this property is available for Entity Framework 5.0 and Entity Framework 6.0 + .NET Framework 4.5 only.
          
