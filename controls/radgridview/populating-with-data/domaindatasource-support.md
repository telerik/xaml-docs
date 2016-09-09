---
title: DomainDataSource Support
page_title: DomainDataSource Support
description: DomainDataSource Support
slug: gridview-domaindatasource-support
tags: domaindatasource,support
published: True
position: 5
site_name: Silverlight
---

# DomainDataSource Support

The purpose of this tutorial is to show you how to populate __RadGridView__ with data using __DomainDataSource__.  

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

* Add a new __RadGridView__ declaration in your XAML: 

#### __XAML__

{{region xaml-gridview-domaindatasource-support_0}}

	<telerik:RadGridView x:Name="radGridView" Margin="8"/>
{{endregion}}

The gridview will be bound to a __DomainDataSource__. When the control is loaded all customers from the Customers table in the Northwind database are loaded asynchronously.

*  Declare a new __DomainDataSource__ object in the resources of your application. Set its __DomainContext__ property to an existing __RIA Service__. 

#### __XAML__

{{region xaml-gridview-domaindatasource-support_1}}

	<ria:DomainDataSource x:Key="DomainDataSource" AutoLoad="True" QueryName="GetCustomers">
	    <ria:DomainDataSource.DomainContext>
	        <riaContext:SampleRiaContext/>
	    </ria:DomainDataSource.DomainContext>
	</ria:DomainDataSource>
{{endregion}}

* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

#### __XAML__

{{region xaml-gridview-domaindatasource-support_2}}

	<telerik:RadGridView x:Name="radGridView" Margin="8"
	    ItemsSource="{Binding Source={StaticResource DomainDataSource}, Path=Data}"/>
{{endregion}}

Run your demo, the result can be seen on the next picture: 

![](images/RadGridView_PopulatingWithDataLoadFromDomainDataSource_010.PNG)

>tipIf you need to define the columns manually read the topic [Defining Columns]({%slug gridview-columns-defining-columns%}).

# See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})

 * [Loading Data from RIA Services]({%slug gridview-loading-data-from-ria-services%})

 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})

 * [Loading Data from ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

 * [Loading Data from Web Services]({%slug gridview-loading-data-from-web-services%})
