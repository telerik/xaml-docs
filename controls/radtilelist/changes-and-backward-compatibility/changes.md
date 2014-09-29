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

## 
		Changes for Telerik RadTileList for SilverlightWPF Q2 2014
	  
			  What's Fixed
			

* Fixed: Tile SelectedVisual Border is not clickable in Windows8, Windows8Touch and Office2013 themes
				  

## 
        Changes for Telerik RadTileList for SilverlightWPF Q1 2014
      
              What's Added
            

* 
                    Added: Enable selection on right clicking on a tile (new SelectionMouseButton property added with values Left, Right or both)
                  
              What's Fixed
            

* 
                  Fixed: Elements placed in ItemTemplate are not clickable
                

* 
                  Fixed: DataContext of the tile should be its corresponding data item
                

* 
                  Fixed: Tile Visibility property is not respected
                

## 
        Changes for Telerik RadTileList for SilverlightWPF Q3 2013
      
              What's Added
            

* 
                  Improved: RadTileList performance (scrolling, reordering, selection)
                
              What's Fixed
            

* 
                  Fixed: Long group header is trimmed if there is just a single tile in the group
                

* 
                  Fixed: HorizotalOffset of the ScrollVieweer is not properly updated
                

* 
                  Fixed: Performance is degraded when tiles count increases
                

* 
                  Fixed: Scrolling tiles and resizing the window causes incorrect scrollbar and tiles arrangement
                

* 
                  Fixed: ScrollViewer gets disabled when the tiles in view are removed from the items collection
                

* 
                  Fixed: Items cannot be removed after changing the source
                

* 
                  Fixed: Application crashes with ArgumentException when there is a tile without group
                

* 
                  Fixed: NullRefException on dragging a tile over another tile list
                

* 
                  Fixed: Unexpected transparent adorner appears in the selection triangle of the tile
                

## 
        Changes for Telerik RadTileList for SilverlightWPF Q2 2013 SP1
      
              What's Added
            

* 
                  Added: ItemTemplateSelector support
                
              What's Fixed
            

* 
                  Fixed: Clear and add new tiles while scrolling TileList causes ArgumentNullException
                

* 
                  Fixed: Groups overlap some of the tiles
                

* 
                  Fixed: ArgumentNullException is thrown in TileListPanel when reordering tiles
                

* 
                  Fixed: ItemTemplate is not properly applied
                

* 
                  Fixed: Binding of SelectedItem is broken after unselecting an item
                

* 
                  Fixed: You cannot remove item from Items collection
                

* 
                  Fixed: Edit additional template for ItemsPanel causes exception
                

## 
        Changes for Telerik RadTileList for SilverlightWPF Q2 2013
      
              What's Added
            

* 
                  Added: Level 1 CodedUI Automation support
                

* 
                  Added: Added a property TileReorderMode in order to prevent the user from reordering the tiles between groups
                

* 
                  Added: Tile should animate on content change to fascilitate display of live content
                

* 
                  Added:  Add API for RadTileList to allow developers to control group order
                
              What's Fixed
            

* 
                  Fixed: System.ArgumentException is thrown when tiles are reordered between groups
                

* 
                  Fixed: Tile should not be selected on TapDown if CanUserSelect is "False"
                

* 
                  Fixed: SelectedIndex cannot be set when AutoGenerateTile is True
                

* 
                  Fixed: Added 30px default top padding for TileListItem in order to prevent overlapping in some cases
                
