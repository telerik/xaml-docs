---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtileview-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started



## Adding the RadTileView to the page{% if site.site_name == 'Silverlight' %}

>In order to use __RadTileView__ control in your projects you have to add references to the following assemblies:
						

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Navigation__You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
						{% endif %}{% if site.site_name == 'WPF' %}

>


							In order to use __RadTileView__ control in your projects you have to add references to the following assemblies:
						

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Navigation__

* __Telerik.Windows.Data__


							You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
						{% endif %}

#### __XAML__

{{region radtileview-getting-started_0}}
	<UserControl x:Class="RadTileViewHelpExamples.MainPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot">
	        <telerik:RadTileView>
	            <telerik:RadTileViewItem Header="Item1">
	                <TextBlock Text="Item1 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item2">
	                <TextBlock Text="Item2 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item3" >
	                <TextBlock Text="Item3 Content"/>
	            </telerik:RadTileViewItem>
	        </telerik:RadTileView>
	    </Grid>
	</UserControl>
	{{endregion}}



As you can see from the image below the items are in restored state by default.

##  Setting maximized item


					To set an item in maximized state you can use the __TileState__ property and set its value to __Maximized__.
				

#### __XAML__

{{region radtileview-getting-started_1}}
	<telerik:RadTileView>
	    <telerik:RadTileViewItem TileState="Maximized" Header="Item1">
	        <TextBlock Text="Item1 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item2">
	        <TextBlock Text="Item2 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item3" >
	        <TextBlock Text="Item3 Content"/>
	    </telerik:RadTileViewItem>
	</telerik:RadTileView>
	{{endregion}}



As you can see from the image below Item1 is now in maximized state.

## Setting minimized position


					To set the minimized area positions use the __MinimizedItemsPosition__ property. It is an enumeration with the following values:
				

* __Left__

* __Top__

* __Right__

* __Bottom__

#### __XAML__

{{region radtileview-getting-started_2}}
	<telerik:RadTileView MinimizedItemsPosition="Bottom">
	    <telerik:RadTileViewItem TileState="Maximized" Header="Item1">
	        <TextBlock Text="Item1 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item2">
	        <TextBlock Text="Item2 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item3" >
	        <TextBlock Text="Item3 Content"/>
	    </telerik:RadTileViewItem>
	</telerik:RadTileView>
	{{endregion}}

![Tile View - minimized items position](images/tileview_Step3.png)

# See Also

 * [Visual Structure]({%slug radtileview-visual-structure%})

 * [Minimizing And Maximizing]({%slug radtileview-minimizing-and-maximizing%})

 * [Rows and Columns]({%slug radtileview-rows-and-columns%})

 * [Fluid Content Control]({%slug radtileview-fluid-content-control%})
