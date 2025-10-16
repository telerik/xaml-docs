---
title: Modifying TileList view
page_title: Modifying TileList view
description: Check our &quot;Modifying TileList view&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-modifying-tilelist-view
tags: modifying,tilelist,view
published: True
position: 1
---

# Modifying TileList view

* [Resizing Tile](#resizing-tile)
* [Vertical Tiles Alignment](#verticaltilesalignment)
* [GroupTemplate](#grouptemplate)
* [GroupHeaderVisibility](#groupheadervisibility)
* [GroupHeaderHeight](#groupheaderheight)

## Resizing Tile

There are three sizes for tiles:
* Single
* Double
* Quadruple

__RadTileList__ also suggests an option to further customize the size. For the purpose you can set __TilePlaceholderSide__ property to the desired value. It will update the value based on a single size - i.e. setting __TilePlaceholderSide="120"__ will result in having Single tiles sized __120x120__, Double - __120x240__, Quadruple - __240x240__. 

## VerticalTilesAlignment

__RadTileList__ exposes __VerticalTilesAlignment__ property that controls the position of the tiles independently of the group they belong to. It can be set no matter if being in a grouped state or not. Its type is of type __VerticalAlignment__ and the default value is __Center__. Modifying it will result in: 

* Top
![Vertical Tiles Alignment Top WPF](images/VerticalTilesAlignment_Top_WPF.PNG)

* Bottom  
![Vertical Tiles Alignment Bottom WPF](images/VerticalTilesAlignment_Bottom_WPF.PNG)

## GroupTemplate

__RadTileList__ has __GroupTemplate__ property that control the way the header of a groups looks.
        

For example:        

__Example 1: Defining the GroupTemplate__

```XAML
		<Grid.Resources>
		  <DataTemplate x:Key="ItemTemplate">
			<TextBlock Text="{Binding FirstName}"/>
		  </DataTemplate>
		  <DataTemplate x:Key="GroupTemplate">
			<TextBlock Text="{Binding}" FontWeight="Bold" Foreground="#FF006AC1" FontSize="20"/>
		  </DataTemplate>
		  <CollectionViewSource x:Key="GroupedItems" Source="{Binding Employees}">
			<CollectionViewSource.GroupDescriptions>
			  <PropertyGroupDescription PropertyName="Occupation" />
			</CollectionViewSource.GroupDescriptions>
		  </CollectionViewSource>
		</Grid.Resources>
		<telerik:RadTileList x:Name="RadTileList"
					  GroupMember="Occupation"
					  ItemsSource="{Binding Employees}"
					  ItemTemplate="{StaticResource ItemTemplate}"/>
```

![Group Template WPF](images/GroupTemplate_WPF.PNG)

## GroupHeaderVisibility

__RadTileList__ exposes a __GroupHeaderVisibility__ property that sets whether the headers of the groups will be visible or not. Thus, once you set it to collapse, your control will be organized in groups, but will not have any text above:
        

__Example 2: Setting the GroupHeaderVisibility property__

```XAML
	<telerik:RadTileList x:Name="RadTileList1"
						 GroupHeaderVisibility="Collapsed"/>
```

![Group Header Visibility WPF](images/GroupHeaderVisibility_WPF.PNG)

## GroupHeaderHeight

__RadTileList__ gives the opportunity to set the height of the headers with a single property __GroupHeaderHeight__.
        

__Example 3: Setting the GroupHeaderHeight property__

```XAML
	<telerik:RadTileList x:Name="RadTileList2"
					GroupHeaderHeight="100"
					GroupTemplate="{StaticResource GroupTemplate}"
					ItemsSource="{Binding Source={StaticResource GroupedItems}}"
					ItemTemplate="{StaticResource ItemTemplate}"/>
```

![Group Header Height WPF](images/GroupHeaderHeight_WPF.PNG)
