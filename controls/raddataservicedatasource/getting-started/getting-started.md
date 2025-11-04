---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDataServiceDataSource WPF control.
slug: raddataservicedatasource-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started with WPF DataServiceDataSource

This tutorial will walk you through the creation of a sample application that contains `RadDataServiceDataSource` control. 

## Adding Telerik Assemblies Using NuGet

To use RadDataServiceDataSource when working with NuGet packages, install the `Telerik.Windows.Controls.DataServices.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataServices__

>With the release of the 2025 Q4, the __Telerik.Windows.Controls.DataServices50__ and __Telerik.Windows.Controls.DataServices60__ assemblies have been removed. Instead, use the __Telerik.Windows.Controls.DataServices__ assembly, which is built against the __Microsoft.OData.Client__ NuGet package with version __7.8.3__.

You can find the required assemblies for each control from the suite in the[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Adding RadDataServiceDataSource 

We will use `RadGridView` control in order to visualize the data.

__Using RadDataServiceDataSource with RadGridView__
```XAML
	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Products" AutoLoad="True">
		<telerik:RadDataServiceDataSource.DataServiceContext>
			<local:ProductsContext/>
		</telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>

	<telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}"
                     IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
                     ShowGroupPanel="False"/>
```

## See also
- [Overview]({%slug raddataservicedatasource-overview%})
- [CRUD]({%slug raddataservicedatasource-crud%})

## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DataServiceDataSource Component](https://www.telerik.com/products/wpf/dataservicedatasource.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)