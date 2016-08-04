---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtilelist-getting-started
tags: getting,started
published: True
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

* Add references to the assemblies: __Telerik.Windows.Controls__ and __Telerik.Windows.Data__

* Add RadTileList as demonstrated below:
{% if site.site_name == 'Silverlight' %}

#### __[XAML] Example 1: Defining RadTileList__

{{region xaml-radtilelist-getting-started_0}}
	<telerik:RadTileList x:Name="TileList1">
	  <telerik:Tile/>
	</telerik:RadTileList>
{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __[XAML] Example 1: Defining RadTileList__

{{region xaml-radtilelist-getting-started_1}}
	<telerik:RadTileList>
	  <telerik:Tile/>
	</telerik:RadTileList>
{{endregion}}

{% endif %}

Two lines of code are important here:

* The import of the __Telerik schema__:

#### __[XAML] Example 2: Importing the Telerik Schema__

{{region xaml-radtilelist-getting-started_2}}
	<!--xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"-->
{{endregion}}



* The declaration of the __RadTileList__ control inside the Grid:

#### __[XAML] Example 3: Declaring RadTileList inside a Grid container__

{{region xaml-radtilelist-getting-started_3}}
	<Grid Background="White">
	  <telerik:RadTileList >
	    <telerik:Tile/>
	  </telerik:RadTileList>
	</Grid>
{{endregion}}



Now if you run the application, you have an empty __Tile__ {% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started image 01 SL](images/RadTileList_GettingStarted_image_01_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started image WPF](images/RadTileList_GettingStarted_image_WPF.png){% endif %}

## Select a Tile

You can select a __Tile__ by clicking or tapping on it. The selected __Tile__ will look like:{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Selected Tile 01 SL](images/RadTileList_GettingStarted_SelectedTile_01_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Selected Tile WPF](images/RadTileList_GettingStarted_SelectedTile_WPF.png){% endif %}

## RadTileList's Tile Types

You can specify the __Tile__ type through its property - __TileType__. 
        

There are three types of Tiles:

* __Single__

* __Double__

* __Quadruple__ {% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Tile Types image SL](images/RadTileList_GettingStarted_TileTypes_image_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Tile Types image WPF](images/RadTileList_GettingStarted_TileTypes_image_WPF.png){% endif %}

>The default Tile's type is - __Double__.
        

## Change the Default Theme

You can set the theme of __RadTileList__ to one of the predefined themes for the Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}.
        

Read the 	[Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})and[Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) articles for more information.
        

To see the different themes of __RadTileList__ please check our  [Theming](http://demos.telerik.com/silverlight/#TileList/Theming) online example. 
        
