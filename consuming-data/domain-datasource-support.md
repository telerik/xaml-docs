---
title: DomainDataSource Support
page_title: DomainDataSource Support
description: DomainDataSource Support
slug: consuming-data-domain-datasource-support
tags: domaindatasource,support
published: True
position: 6
site_name: Silverlight
---

# DomainDataSource Support



The purpose of this tutorial is to show you how to use DomainDataSource in the context of a Silverlight application. The following common tasks will be examined:

* Adding DomainDataSource control.

* Configuring DomainDataSource control.

* Loading data.

* Consuming the result.

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

## Adding DomainDataSource Control

The __DomainDataSource__ control can be found in the __System.Web.Ria.Controls__ assembly and you have to declare the property namespace in order to use it: 

#### __XAML__

{{region consuming-data-domain-datasource-support_0}}
	xmlns:ria="clr-namespace:System.Windows.Controls;assembly=System.Windows.Ria.Controls"
	{{endregion}}



Next, just add a new __DomainDataSource__ declaration to your resources: 

#### __XAML__

{{region consuming-data-domain-datasource-support_1}}
	<ria:DomainDataSource x:Key="DomainDataSource">
	</ria:DomainDataSource>
	{{endregion}}



## Configuring DomainDataSource Control

After declaring DomainDataSource control you should configure it to work with the already existing __DomainService__ class. The only thing you have to do is to set the __DomainContext__ property:

#### __XAML__

{{region consuming-data-domain-datasource-support_2}}
	<ria:DomainDataSource x:Key="DomainDataSource">
	    <ria:DomainDataSource.DomainContext>
	        <example:SampleRiaContext/>
	    </ria:DomainDataSource.DomainContext>
	</ria:DomainDataSource>
	{{endregion}}



## Loading Data

After setting the __DomainContext__ property, you should specify the __QueryName__ - this is an existing method in your __DomainService__ class which loads and returns data (in the example it is the __GetCategories()__ method, which loads all categories from the Northwind database):

#### __XAML__

{{region consuming-data-domain-datasource-support_3}}
	<ria:DomainDataSource x:Key="DomainDataSource" AutoLoad="True" QueryName="GetCategories" LoadedData="DomainDataSource_LoadedData">
	    <ria:DomainDataSource.DomainContext>
	        <example:SampleRiaContext/>
	    </ria:DomainDataSource.DomainContext>
	</ria:DomainDataSource>
	{{endregion}}



## Consuming the Result

Once the data is loaded and returned to your client application, the __LoadedData__ event is fired. Via the __LoadedDataEventArgs__ you have access to the following data:

* __AllEntities__ - gets all loaded entities.

* __Cancelled__ - gets a value indicating whether the asynchronous call has been canceled.

* __Entities__ - gets all top entities loaded.

* __Error__ - gets a value indicating which error occurred during an asynchronous operation.

* __TotalEntityCount__ - gets the total server entity count for the query.

* __UserState__ - gets the unique value for the asynchronous task.


Here is a sample code showing how to handle the LoadedData event: 

#### __C#__

{{region consuming-data-domain-datasource-support_4}}
	private void DomainDataSource_LoadedData( object sender, LoadedDataEventArgs e )
	{
	    foreach ( Categories c in e.AllEntities )
	    {
	        // Process the data
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-domain-datasource-support_5}}
	Private Sub DomainDataSource_LoadedData(ByVal sender As Object, ByVal e As LoadedDataEventArgs)
	    For Each c As Categories In e.AllEntities
	        ' Process the data'
	    Next
	End Sub
	{{endregion}}



# See Also

 * [Consuming WCF Service]({%slug consuming-data-wcf-service%})

 * [Consuming WCF Data Service]({%slug consuming-data-ado-net-data-service%})

 * [Consuming Web (asmx) Service]({%slug consuming-data-web-asmx-service%})

 * [Consuming .NET RIA Service]({%slug consuming-data-net-ria-service%})
