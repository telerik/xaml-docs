---
title: First Steps With MSI/ZIP
page_title: First Steps With MSI and ZIP Installation
description: This article describes the lifecycle of a Telerik WPF application when using MSI or ZIP installation.
slug: msi-or-zip-setup-lifecycle
tags: pipeline,lifecycle
published: True
position: 2
---

# First Steps With MSI or ZIP

This article describes the lifecycle of a Telerik application. This includes creating, deploying, redistributing, and upgrading an application with referenced Telerik dlls.

The topic shows what is the lifecycle when using the __.msi__ or __.zip__ file to get the dlls. As an alternative, you can use [NuGet packages]({%slug nuget-setup-lifecycle%}) or [Telerik UI for WPF Extension]({%slug getting-started-first-steps%}).

## Creating a Project

To use the Telerik dlls, create a new WPF project using the Visual Studio project template from the __File --> New --> Project__ menu. 

![{{ site.framework_name }} Create WPF Application](images/msi-or-zip-setup-lifecyle-0.png)

Set a __Project name__ and __Location__ for the project. For this example, we will use `TelerikWPFApplication` for the project's name.

![{{ site.framework_name }} Setup Project Name and Location](images/msi-or-zip-setup-lifecyle-1.png)

This will create an empty WPF project where you can reference the Telerik dlls.

![{{ site.framework_name }} Empty Project Visual Studio](images/msi-or-zip-setup-lifecyle-2.png)

## Referencing Telerik Assemblies

[Download the .zip file]({%slug installation-installing-from-zip-wpf%}) with the Telerik assemblies in a location of your choice. Or [download the .msi]({%slug installation-installing-from-msi-wpf%}) file and install it. This tutorial will show how to reference the Telerik dlls from the default installation folder.

Use the Visual Studio's Reference Manager to browse and reference the Telerik dlls. 

![{{ site.framework_name }} Reference Manager](images/msi-or-zip-setup-lifecyle-3.png)
![{{ site.framework_name }} Reference Manager Browse Dialog](images/msi-or-zip-setup-lifecyle-4.png)
![{{ site.framework_name }} Added References](images/msi-or-zip-setup-lifecyle-5.png)

If you need to set a [Telerik theme]({%slug common-styling-appearance-available-themes%}) different than the default one check the [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%}) and the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) articles.

## Installing a License Key

To use the Telerik WPF product you will need to install a valid license key. Otherwise, you will see warning messages and banners related to the licensing. See how to activate a license in the [Installing License Key]({%slug installing-license-key%}) article.

## Adding Telerik Controls

After you create the WPF project and reference the Telerik assemblies, add any UI and related code-behind, models, and styles. This example will show a fundamental setup, including a RadTabControl with few tabs defined in XAML.

#### __[XAML] Example 1: Adding Telerik control in the UI__
{{region msi-or-zip-setup-lifecycle-0}}
	<Window x:Class="TelerikWpfApplication.MainWindow"
		xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
		xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
		xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
		xmlns:local="clr-namespace:TelerikWpfApplication" xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		mc:Ignorable="d"
		Title="MainWindow" Height="450" Width="800">
		<Grid>
			<telerik:RadTabControl>
				<telerik:RadTabItem Header="Home" />
				<telerik:RadTabItem Header="Insert" />
				<telerik:RadTabItem Header="View" />
			</telerik:RadTabControl>
		</Grid>
	</Window>
{{endregion}}

![{{ site.framework_name }} Project with Added Tab Control](images/msi-or-zip-setup-lifecyle-6.png)

## Deploying the Application

To deploy a WPF application, you can use several different approaches, like XCopy, ClickOnce, or Windows Installer deployment. Read more about this in the [Deploy a WPF Application](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/app-development/deploying-a-wpf-application-wpf?view=netframeworkdesktop-4.8) MSDN article. 

## Redistributing Telerik Application

Several rules should be kept in mind when redistributing an application with Telerik dlls. Read more about this in the [Redistributing Telerik Assemblies]({%slug protecting-telerik-radcontrols-assembly%}) article.

## Upgrading the Project

To upgrade the project, download the new version of the .msi or the .zip file and install it accordingly. Then remove the old Telerik references from the WPF project and [include the new ones](#referencing-telerik-assemblies). At this point, double-check if all the Telerik assemblies have the same version (for example, 2020.3.102) and if all or of the same type ([Xaml or NoXaml]({%slug xaml-vs-noxaml%})). To check this, right-click the .dll file (for example, Telerik.Windows.Controls.dll) and choose the __Properties__ option. 

![{{ site.framework_name }} Telerik Assembly Properties Menu Option](images/msi-or-zip-setup-lifecyle-8.png)
![{{ site.framework_name }} Telerik Assembly No Xaml File Description](images/msi-or-zip-setup-lifecyle-9.png)

Delete the __bin__ and __obj__ folders of the projects that reference Telerik dlls in the solution and then __Clean__, and __Rebuild__ them. This will ensure that no older Telerik dlls are cached and used during the compilation.

![{{ site.framework_name }} Delete bin and obj Folders](images/msi-or-zip-setup-lifecyle-7.png)
![{{ site.framework_name }} Clean and Rebuild Solution](images/msi-or-zip-setup-lifecyle-10.png)

## See Also  
* [System Requirements]({%slug installation-system-requirements-wpf%})
* [Download Product Files]({%slug download-product-files-wpf%})
* [Installing WPF Demos Application]({%slug installing-wpf-demos%})
