---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadTileList {{ site.framework_name }} control.
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

#### __[XAML] Example 2: Importing the Telerik schema__

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
        

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#TileList/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadTileList, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 4__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 4: Merge the ResourceDictionaries__  
{{region radtilelist-getting-started_7}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadTileList with the **Windows8** theme applied.

#### __Figure 1: RadTileList with the Windows8 theme__
![RadTileList with Windows8 theme](images/RadTileList-setting-theme.png)
        
