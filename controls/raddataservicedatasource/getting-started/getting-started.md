---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: raddataservicedatasource-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadDataServiceDataSource__  control. 

> In order to use __RadDataServiceDataSource__ in your project you need to add references to the following assemblies

>- __Telerik.Windows.Controls__

>- __Telerik.Windows.Controls.DataServices__


>tipIf you are using OData version 3 you need to add reference to  __Telerik.Windows.Controls.DataServices50__ which is built against __Microsoft.Data.Services.Client__ with version __5.6.4__.

{% if site.site_name == 'WPF' %}
>tipFor OData version 4 support, you need to add reference to __Telerik.Windows.Controls.DataServices60__ which is built against __Microsoft.OData.Client__ with __version 6.15.0__.
{% endif %}

## Adding RadDataServiceDataSource 

We will use __RadGridView__ control in order to visualize the data.

#### __[XAML] Example 1: Using RadDataServiceDataSource with RadGridView__

	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Products" AutoLoad="True">
		<telerik:RadDataServiceDataSource.DataServiceContext>
			<local:ProductsContext/>
		</telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>

	<telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}"
                     IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
                     ShowGroupPanel="False"/>

# See also

- [Overview]({%slug raddataservicedatasource-overview%})

- [CRUD]({%slug raddataservicedatasource-crud%})





