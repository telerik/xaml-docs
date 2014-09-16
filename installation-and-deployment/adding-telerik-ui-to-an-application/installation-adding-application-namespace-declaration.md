---
title: Namespace Declaration
page_title: Namespace Declaration
description: Namespace Declaration
slug: installation-adding-application-namespace-declaration
tags: namespace,declaration
publish: True
position: 2
site_name: Silverlight
---

# Namespace Declaration



The following topic will show you how to manually declare a namespace in XAML.

## 

Almost all Telerik controls can be found in a special URI namespace. You can use only this namespace to access all controls from Telerik assemblies that you
        	are referring in your application. You cannot access controls from assemblies that you are not referring.
        

>There are only few controls which are in another namespace. These are RadPivotGrid and RadPivotFieldList and their namespace is:
        		xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"
        	

* Create a new [Silverlight Application]({%slug installation-adding-to-application-create-application-and-adding-control%}).
          	

* Add references to the __Telerik DLLs__ in the Solution Explorer.
          	![Common Installing Namespace Declaration 011](images/Common_InstallingNamespaceDeclaration_011.png)

* Open the __MainPage.xaml__.
          	

* Go to the __UserControl__ tag and write:
          	

#### __XAML__

{{region installation-adding-application-namespace-declaration_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



Or you can select it from the IntelliSense in XAML.![Common Installing Namespace Declaration 012](images/Common_InstallingNamespaceDeclaration_012.png)

* The result should be similar to this.

#### __XAML__

{{region installation-adding-application-namespace-declaration_1}}
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



* Now you should be able to declare any controls existing in this namespace and which is in the assemblies you have added in your project. An example of __RadTreeView__ declaration is shown below.

#### __XAML__

{{region installation-adding-application-namespace-declaration_2}}
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



>If you wonder which control in which assembly belongs to, read the main topic about [Controls Dependencies]({%slug installation-installing-controls-dependencies%}).

# See Also

 * [Using IntelliSense in Visual Studio]({%slug installation-adding-application-using-intellisense-vs%})

 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license%})
