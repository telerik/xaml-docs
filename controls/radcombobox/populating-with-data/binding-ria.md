---
title: Binding to RIA Service
page_title: Binding to RIA Service
description: Binding to RIA Service
slug: radcombobox-populating-with-data-binding-ria
tags: binding,to,ria,service
published: True
position: 7
site_name: Silverlight
---

# Binding to RIA Service

The purpose of this tutorial is to show you how to populate a __RadComboBox__ with data from a __.NET RIA Service__.

>This tutorial will use the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

* Create a new application and add a __RadComboBox__ declaration in your XAML.

#### __XAML__

{{region radcombobox-populating-with-data-binding-ria_0}}
	<telerik:RadComboBox x:Name="radComboBox"/>
{{endregion}}

The __ComboBox__ will be bound to a __DomainDataSource__. When the control is loaded, all __Products__ from the __Products__ table in the Northwind database are loaded asynchronously.

* Declare a new __DomainDataSource__ object in the resources of your application. Set its __DomainContext__ property to an existing __RIA Service__.

#### __XAML__

{{region radcombobox-populating-with-data-binding-ria_1}}
	<UserControl.Resources>
	    <ria:DomainDataSource x:Key="DomainDataSource" AutoLoad="True" QueryName="GetProducts">
	        <ria:DomainDataSource.DomainContext>
	            <riaContext:SampleRiaContext/>
	        </ria:DomainDataSource.DomainContext>
	    </ria:DomainDataSource>    
	</UserControl.Resources>
{{endregion}}

* Declare a custom __DataTemplate__ to determine how the items in the drop-down will look like. Add the following __DataTemplate__ declaration in your XAML resources.

#### __XAML__

{{region radcombobox-populating-with-data-binding-ria_2}}
	<UserControl.Resources>
	    <ria:DomainDataSource x:Key="DomainDataSource" AutoLoad="True" QueryName="GetProducts">
	        <ria:DomainDataSource.DomainContext>
	            <riaContext:SampleRiaContext/>
	        </ria:DomainDataSource.DomainContext>
	    </ria:DomainDataSource>
	
	    <DataTemplate x:Key="CustomItemTemplate">
	        <StackPanel Orientation="Horizontal">
	            <TextBlock Text="{Binding ProductName}"/>
	            <TextBlock Text=" - "/>
	            <TextBlock Text="{Binding UnitPrice}"/>
	            <TextBlock Text=" $"/>
	        </StackPanel>
	    </DataTemplate>
	</UserControl.Resources>
{{endregion}}

* Update your __RadComboBox__ declaration - set the __ItemsSource__ and __ItemTemplate__ properties.

#### __XAML__

{{region radcombobox-populating-with-data-binding-ria_3}}
	<telerik:RadComboBox x:Name="radComboBox"
	    ItemTemplate="{StaticResource CustomItemTemplate}"
	    ItemsSource="{Binding Source={StaticResource DomainDataSource}, Path=Data}"/>
{{endregion}}

Run your demo, the result can be seen on the snapshot below:

 ![](images/RadComboBox_PopulatingWithData_BindingToRiaService_010.png)

## See Also

 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})

 * [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})

 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})
