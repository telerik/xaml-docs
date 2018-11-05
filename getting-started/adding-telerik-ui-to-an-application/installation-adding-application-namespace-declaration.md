---
title: Namespace Declaration
page_title: Namespace Declaration
description: Namespace Declaration
slug: installation-adding-application-namespace-declaration
tags: namespace,declaration
published: True
position: 3
site_name: WPF
---

# Namespace Declaration

The following topic will show you how to manually declare a namespace in XAML.

Almost all Telerik controls can be found in the 'telerik' URI namespace schema (see Example 1). You can use only this namespace to access all controls from Telerik assemblies that you are referring in your application. You cannot access controls from assemblies that you are not referring.
        
>There are few controls which are in another namespace. For example, such are RadPivotGrid and RadPivotFieldList and their namespace is: xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot". 
        	
1. Create a new [Application]({%slug installation-adding-to-application-create-application-and-adding-control%}).
    	
2. Add references to the __Telerik DLLs__ in the Solution Explorer.
	{% if site.site_name == 'WPF' %}
	![Common Installing Namespace Declaration 0](images/installation-adding-application-namespace-declaration-0.png)
	{% else %}
	![Common Installing Namespace Declaration 1](images/installation-adding-application-namespace-declaration-1.png)
	{% endif %}

* Open the {% if site.site_name == 'WPF' %}__MainWindow.xaml__{% else %}__MainPage.xaml__{% endif %}.
   	
* Go to the {% if site.site_name == 'WPF' %}__Window__{% else %}__UserControl__{% endif %} tag and add the following namespace.
          	
	#### __[XAML] Example 1: Telerik namespace definition__ 
	{{region installation-adding-application-namespace-declaration-0}}
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}

	Or select it from the IntelliSense in XAML.

	{% if site.site_name == 'WPF' %}
	![Common Installing Namespace Declaration 1](images/installation-adding-application-using-intellisense-vs-wpf-0.png)
	{% else %}
	![Common Installing Namespace Declaration 2](images/installation-adding-application-using-intellisense-vs-wpf-1.png)
	{% endif %}

* The result should be similar to this.

	{% if site.site_name == 'WPF' %}
	#### __[XAML] Example 2: Telerik namespace added in XAML__
	{{region installation-adding-application-namespace-declaration-1}}
		<Window x:Class="WpfApplication1.MainWindow"
				xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
				Title="MainWindow" Height="350" Width="525">
			<Grid>
			</Grid>
		</Window>
	{{endregion}}
	{% else %}
	#### __[XAML] Example 2: Telerik namespace added in XAML__
	{{region installation-adding-application-namespace-declaration-2}}
	<UserControl x:Class="SilverlightApplication1.MainPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    mc:Ignorable="d"
	    d:DesignHeight="300" d:DesignWidth="400">	
	    <Grid x:Name="LayoutRoot" Background="White">	        
	    </Grid>
	</UserControl>
	{{endregion}}
	{% endif %}

* Now you should be able to declare any controls - existing in the Telerik namespace - which are included in the assemblies you have added to the project. An example of RadTreeView declaration is shown below.

	{% if site.site_name == 'WPF' %}
	#### __[XAML] Example 3: Using the Telerik namespace__
	{{region installation-adding-application-namespace-declaration-3}}
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
	{% else %}
	#### __[XAML] Example 3: Using the Telerik namespace__
	{{region installation-adding-application-namespace-declaration-4}}
	<UserControl x:Class="SilverlightApplication1.MainPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    mc:Ignorable="d"
	    d:DesignHeight="300" d:DesignWidth="400">
	    
	    <Grid x:Name="LayoutRoot" Background="White">
	        <telerik:RadTreeView/>
	    </Grid>
	</UserControl>
	{{endregion}}
	{% endif %}

>tip See the Telerik assemblies required by each control in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} article.

## See Also  
 * [Using IntelliSense in Visual Studio]({%slug installation-adding-application-using-intellisense-vs%})
 {% if site.site_name == 'WPF' %}
 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license-wpf%}) 
 {% else %}
 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license%}) 
 {% endif %}
