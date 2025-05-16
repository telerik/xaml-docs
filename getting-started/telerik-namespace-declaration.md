---
title: Telerik Namespace Declaration
page_title: Telerik Namespace Declaration
description: The following topic will show you how to manually declare a Telerik WPF schema in XAML.
slug: installation-adding-application-namespace-declaration
tags: namespace,declaration
published: True
position: 13
site_name: WPF
---

# Telerik Namespace Schema Declaration

The following topic will show you how to manually declare a namespace in XAML.

Almost all Telerik controls can be found in the `telerik` URI namespace schema. You can use only this namespace to access all controls from Telerik assemblies that you are referring in your application. You cannot access controls from assemblies that you are not referring.
        
>There are few controls which are in another namespace schema. For example, such are RadPivotGrid and RadPivotFieldList and their namespace is `xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"`. 
        	
1. Open your WPF application with the Telerik assemblies referenced in it.

2. Open the XAML file with the view where you want to add the Telerik controls.
   	
3. Go to the opening tag of the parent control (like the Window or UserControl) and type in the "telerik" namespace identifier. When you type the "equals" character in the drop down list select the `http://schemas.telerik.com/2008/xaml/presentation` item.    
	
	#### __[XAML] Telerik namespace added in XAML__
	{{region installation-adding-application-namespace-declaration-0}}
		<Window x:Class="WpfApplication1.MainWindow"
				xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
				Title="MainWindow" Height="350" Width="525">
			<Grid>
			</Grid>
		</Window>
	{{endregion}}

4. Now you can declare any controls, existing in the Telerik namespace, which are included in the assemblies added to the project.

	#### __[XAML] Using the Telerik namespace__
	{{region installation-adding-application-namespace-declaration-1}}
		<Window x:Class="WpfApplication1.MainWindow"
				xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
				Title="MainWindow" Height="350" Width="525">
			<Grid>
				<telerik:RadTreeView/>
			</Grid>
		</Window>
	{{endregion}}

>tip See the Telerik assemblies required by each control in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) article.
