---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadEntityFrameworkDataSource {{ site.framework_name }} control.
slug: entityframework-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started with {{ site.framework_name }} EntityFrameworkDataSource

This tutorial will walk you through the creation of a sample application that contains __RadGridView__ bound to __RadEntityFrameworkDataSource__.

* [Creating the WPF Application](#creating-the-wpf-application)
* [Creating the Model](#creating-the-model)
* [Adding RadGridView and RadEntityFrameworkDataSource](#adding-radgridview-and-radentityframeworkdatasource)

As of version __2013 Q3 SP1__ we have added support for __EntityFramework 6.0__. You will need to reference the __Telerik.Windows.Controls.EntityFramework60__ assembly, rather than the __Telerik.Windows.Controls.EntityFramework__ one in order for this to work.

## Creating the WPF Application

1. Note that __RadEntityFrameworkDataSource__ is built on top of the [ADO.NET Entity Framework](https://docs.microsoft.com/en-us/ef/ef6/). Basic Entity Framework experience is required for working with __RadEntityFrameworkDataSource__.

2. Start Visual Studio and create a new WPF Application.

## Creating the Model

Now that we have the application, we will add our entity model using the AdventureWorks database. 

1. In the project add a new __ADO.NET Entity Data Model__. You need to make sure that **Data** is selected from the left menu.
![Rad Entity Framework Getting Started 1](images/RadEntityFramework_Getting_Started1.png)

2. Choose to create a model using the code first approach from an existing database.
![Rad Entity Framework Getting Started 2](images/RadEntityFramework_Getting_Started2.png)

3. Choose the data connection (for example the __AdventureWorks__ database). In order to learn how to add the AdventureWorks database, check out the [AdventureWorks Readme](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/adventure-works) article.

4. Generate the entities from all of the tables in the __AdventureWorks__ database.

5. Click __Finish__ and __rebuild the solution__.

## Adding RadGridView and RadEntityFrameworkDataSource

Now let's go to the client side.

**1.** Add References to the following __Telerik__ assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__ (mandatory for both __RadGridView__ and __RadEntityFrameworkDataSource__)

* __Telerik.Windows.Controls.EntityFramework__ (mandatory for __RadEntityFrameworkDataSource__ with EF **5.0** or previous)

	or

* __Telerik.Windows.Controls.EntityFramework60__ (mandatory for __RadEntityFrameworkDataSource__ with EF **6.0** or later)

* __Telerik.Windows.Controls.GridView__ (mandatory for __RadGridView__)

* __Telerik.Windows.Controls.Input__ (mandatory for __RadGridView__)

* __Telerik.Windows.Data__ (mandatory for both __RadGridView__ and __RadEntityFrameworkDataSource__)

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadEntityFrameworkDataSource__ when working with NuGet packages, install the `Telerik.Windows.Controls.EntityFramework.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

**2.** Now add the __RadGridView__ and __RadEntityFrameworkDataSource__ controls to the main window. **Example 1** demonstrates how you can do that.

#### __[XAML] Example 1: Adding RadGridView and RadEntityFrameworkDataSource__

{{region xaml-entityframework-getting-started-1}}
	<Window x:Class="EntityFrameworkGettingStarted.MainWindow"
			xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
			xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
			xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
			xmlns:local="clr-namespace:EntityFrameworkGettingStarted"
			xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
			mc:Ignorable="d"
			Title="MainWindow" Height="450" Width="800">
		<Grid>
			<telerik:RadEntityFrameworkDataSource Name="EntityFrameworkDataSource" QueryName="Customers">
				<telerik:RadEntityFrameworkDataSource.DbContext>
					<local:MyEntityModel/>
				</telerik:RadEntityFrameworkDataSource.DbContext>
			</telerik:RadEntityFrameworkDataSource>
			<telerik:RadGridView ItemsSource="{Binding DataView, ElementName=EntityFrameworkDataSource}"/>
		</Grid>
	</Window>
{{endregion}}

>importantSince __Q3 SP1 2012__ we have added the __RadEntityFrameworkDataSource.DbContext__ property which should be set instead of the **ObjectContext** property for versions of Entity Framework newer than version **5.0**. If you are using an older version of Entity Framework, you can set the **RadEntityFrameworkDataSource.ObjectContext** property.

Several important things to notice:

* The import of the telerik schema: __xmlns:telerik="[http://schemas.telerik.com/2008/xaml/presentation](http://schemas.telerik.com/2008/xaml/presentation)__

* The __QueryName__ points to the query of the data source.

* __DbContext__ - points to the context that has been created.

* __DataView__ - the data that comes from the query is stored in the __DataView__ property, so we bind the __RadGridView__ to it.

## RelatedObjects

The __RelatedObjects__ property of the RadEntityFrameworkDataSource allows you to specify the names of the related entities that need to be retrieved. For example, if your main entity set is called "Customers", you might want to retrieve the "Orders" collection in case you want to get the related Orders for each Customer from the database.

#### __[XAML] Example 2: Using the RelatedObjects__
{{region xaml-entityframework-getting-started-1}}
    <telerik:RadEntityFrameworkDataSource Name="EntityFrameworkDataSource" QueryName="Customers">
        <telerik:RadEntityFrameworkDataSource.RelatedObjects>
            <sys:String>Orders</sys:String>
        </telerik:RadEntityFrameworkDataSource.RelatedObjects>
        <telerik:RadEntityFrameworkDataSource.DbContext>
			<local:MyEntityModel/>
		</telerik:RadEntityFrameworkDataSource.DbContext>
    </telerik:RadEntityFrameworkDataSource>
{{endregion}}

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF EntityFrameworkDataSource Component](https://www.telerik.com/products/wpf/entity-framework-data-source.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See also

* [Create a simple data application with WPF and Entity Framework 6](https://docs.microsoft.com/en-us/visualstudio/data-tools/create-a-simple-data-application-with-wpf-and-entity-framework-6)
