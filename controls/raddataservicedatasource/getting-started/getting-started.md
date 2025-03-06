---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started with {{ site.framework_name }} DataServiceDataSource

This tutorial will walk you through the creation of a sample application that contains __RadDataServiceDataSource__  control. 

## Adding Telerik Assemblies Using NuGet

To use __RadDataServiceDataSource__ when working with NuGet packages, install the `Telerik.Windows.Controls.DataServices.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataServices__

If you are using OData version 3 you need to add reference to  __Telerik.Windows.Controls.DataServices50__ which is built against __Microsoft.Data.Services.Client__ with version __5.6.4__.

For OData version 4 support, you need to add reference to __Telerik.Windows.Controls.DataServices60__ which is built against __Microsoft.OData.Client__ with __version 6.15.0__.

Since the __R2 2021__ release, you can find a __Telerik.Windows.Controls.DataServices__ dll in the __WPF60__ and __WPF70__ folders built against __Microsoft.OData.Client__ with __version 7.8.3__.

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding RadDataServiceDataSource 

We will use __RadGridView__ control in order to visualize the data.

#### __[XAML] Example 1: Using RadDataServiceDataSource with RadGridView__
{{region raddataservicedatasource-getting-started-0}}
	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Products" AutoLoad="True">
		<telerik:RadDataServiceDataSource.DataServiceContext>
			<local:ProductsContext/>
		</telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>

	<telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}"
                     IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
                     ShowGroupPanel="False"/>
{{endregion}}

## See also
- [Overview]({%slug raddataservicedatasource-overview%})
- [CRUD]({%slug raddataservicedatasource-crud%})

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DataServiceDataSource Component](https://www.telerik.com/products/wpf/dataservicedatasource.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

