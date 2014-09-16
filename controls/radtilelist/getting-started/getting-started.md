---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtilelist-getting-started
tags: getting,started
publish: True
position: 0
---

# Getting Started



This tutorial will walk your through the creation of a sample application that contains __RadTileList__ and will show you how:
      

* Add RadTileList to your project

* Select RadTileList's Tile

* Reorder RadTileList's Tile

For the purpose of this example, you will need to create an empty {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} Application project and open it in Visual Studio.
      

## Creating RadTileList

* Create a new {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} project

* 
            Add references to the assemblies: __Telerik.Windows.Controls__ and __Telerik.Windows.Data__

* 
            Add RadTileList as demonstrated below:
          {% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radtilelist-getting-started_0}}
	<UserControl x:Class="RadTileList_SL.MainPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    mc:Ignorable="d"
	    d:DesignHeight="300" d:DesignWidth="400">
	 <Grid x:Name="LayoutRoot" Background="White">
	  <telerik:RadTileList x:Name="TileList1">
	       <telerik:Tile/>
	  </telerik:RadTileList>
	 </Grid>
	</UserControl>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radtilelist-getting-started_1}}
	<Window x:Class="RadTileList_WPF.MainWindow"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    mc:Ignorable="d"
	    d:DesignHeight="300" d:DesignWidth="400">
	 <Grid x:Name="LayoutRoot" Background="White">
	  <telerik:RadTileList x:Name="TileList1">
	       <telerik:Tile/>
	  </telerik:RadTileList>
	 </Grid>
	</UserControl>
	{{endregion}}

{% endif %}

Two lines of code are important here:

* The import of the Telerik schema:

#### __XAML__

{{region radtilelist-getting-started_2}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



* The declaration of the RadTileList control inside the Grid:

#### __XAML__

{{region radtilelist-getting-started_3}}
	<Grid x:Name="LayoutRoot" Background="White">
	  <telerik:RadTileList x:Name="TileList1">
	       <telerik:Tile/>
	  </telerik:RadTileList>
	</Grid>
	{{endregion}}



Now if you run the application, you have an empty Tile{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started image 01 SL](images/RadTileList_GettingStarted_image_01_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started image WPF](images/RadTileList_GettingStarted_image_WPF.png){% endif %}

## Select a Tile

You can select a Tile by clicking or tapping on it. The selected Tile will look like:{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Selected Tile 01 SL](images/RadTileList_GettingStarted_SelectedTile_01_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Selected Tile WPF](images/RadTileList_GettingStarted_SelectedTile_WPF.png){% endif %}

## RadTileList's Tile Types

You can specify the __Tile__ type through its property - __TileType__. 
        

There are three types of Tiles:

* Single

* Double

* Quadruple{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Tile Types image SL](images/RadTileList_GettingStarted_TileTypes_image_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Tile Types image WPF](images/RadTileList_GettingStarted_TileTypes_image_WPF.png){% endif %}

>
          The default Tile's type is - __Double__.
        

## Change the Default Theme

You can set the theme of the RadTileList to one of the predefined themes for the RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}.
        

Read the 
			[
			  Setting a Theme (Using Implicit Styles)
			]({%slug styling-apperance-implicit-styles-overview%})
          and
			[
			  Editing Control Templates
			]({%slug styling-apperance-editing-control-templates%})          
          articles for more information.
        

To see the different themes of RadTileList please check our  
       [Theming](http://demos.telerik.com/silverlight/#TileList/Theming) online example. 
        
