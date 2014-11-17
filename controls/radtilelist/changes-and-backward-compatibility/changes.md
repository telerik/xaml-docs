---
title: Changes
page_title: Changes
description: Changes
slug: radtilelist-changes
tags: changes
published: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes
{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q2 2014
	  
### What's Fixed
			

* Tile SelectedVisual Border is not clickable in Windows8, Windows8Touch and Office2013 themes
				  

## Q1 2014
      
### What's Added
            

* Enable selection on right clicking on a tile (new SelectionMouseButton property added with values Left, Right or both)
                  
### What's Fixed
            

* Elements placed in ItemTemplate are not clickable
         

* DataContext of the tile should be its corresponding data item
         

* Tile Visibility property is not respected
                

## Q3 2013
      
### What's Added
            

* RadTileList performance improvements (scrolling, reordering, selection)
                
### What's Fixed
            

* Long group header is trimmed if there is just a single tile in the group
         

* HorizotalOffset of the ScrollVieweer is not properly updated
 

* Performance is degraded when tiles count increases
 

* Scrolling tiles and resizing the window causes incorrect scrollbar and tiles arrangement
 

* ScrollViewer gets disabled when the tiles in view are removed from the items collection
 

* Items cannot be removed after changing the source
 

* Application crashes with ArgumentException when there is a tile without group
 

* NullRefException on dragging a tile over another tile list
 

* Unexpected transparent adorner appears in the selection triangle of the tile
                

## Q2 2013 SP1
      
### What's Added
            

* ItemTemplateSelector support
                
### What's Fixed
            

* Clear and add new tiles while scrolling TileList causes ArgumentNullException
 

* Groups overlap some of the tiles
 

* ArgumentNullException is thrown in TileListPanel when reordering tiles
 

* ItemTemplate is not properly applied
 

* Binding of SelectedItem is broken after unselecting an item
 

* You cannot remove item from Items collection
 

* Edit additional template for ItemsPanel causes exception
 

## Q2 2013
      
### What's Added
            

* Level 1 CodedUI Automation support
 

* Added a property TileReorderMode in order to prevent the user from reordering the tiles between groups
 

* Tile should animate on content change to facilitate display of live content
 

* Add API for RadTileList to allow developers to control group order
                
### What's Fixed
            

* System.ArgumentException is thrown when tiles are reordered between groups
 

* Tile should not be selected on TapDown if CanUserSelect is "False"
 

* SelectedIndex cannot be set when AutoGenerateTile is True
 

* Added 30px default top padding for TileListItem in order to prevent overlapping in some cases
                
