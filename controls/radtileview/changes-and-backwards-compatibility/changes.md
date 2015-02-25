---
title: Changes
page_title: Changes
description: Changes
slug: radtileview-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the RadTileView control.

To see the fixes and features included in our latest official release please refer to our {% if site.site_name == 'Silverlight' %} [Release History](http://www.telerik.com/support/whats-new/silverlight/release-history) {% endif %} {% if site.site_name == 'WPF' %} [Release History](http://www.telerik.com/support/whats-new/wpf/release-history) {% endif %}.


## Q1 2014
### What's Fixed

* Add AnimationStarted and AnimationEnded events to the RadTileView

>tip This fix includes one new event exposed by the __RadTileView__ - __TilesAnimationCompleted__. This event is further described in the [Events]({%slug radtileview-events%}) tutorial.				  

## Q2 2013
### What's Fixed

* Fixed: BringIntoView and Virtualization doesn't work after columnsCount change 
* Fixed: Infinite loop after ItemsSource change and selection 
* Fixed: Setting MaximizedItem before the containers have been generated results in wrong layout
* Fixed: The tileViewItem's Header disappears if you move the item from one tileView to another
* Fixed: Users can not set Visibility = Collapsed when attached properties of TileViewPanel are set 
* Fixed: Wrong arguments in TileStateChanged event

## Q1 2013
### What's Fixed

* Fixed: MaximizeMode="One" makes the designer crash
* Fixed: Mouse interactions are not possible in certain controls placed in RadTileViewItem
* Fixed: The RadTileView leaks when it's databound and you clear it's Items

## Q3 2012
### What's Fixed

* Fixed: Null Reference Exception is thrown when using the TileView along with a DataPager control
* Fixed: Problem with the maximized item after reset, add and remove of the items collection

## Q2 2012
### What's Fixed

* Fixed: Bindings are lost in some cases with RadTileView inside a TransitionControl 
* Fixed: Items start to disappear if you Maxmize/Restore an item and you have initially collapsed items
* Fixed: If the TileStateChangeTrigger is "SingleClick", after dragging a tile to a new position, the tile can be maximized with a single click on its content. 

> You can examine the Q2 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2012-version-2012-2-607.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2012-version-2012-2-607-2457892840.aspx){% endif %}.			  

## Q1 2012
### What's Fixed

* Fixed: In binding scenarios if you set a newly added item to be maximized you get wrong layout 
* Fixed: Exception is thrown in some cases when you dynamically add items
* Fixed: Unexpected behavior when you dynamically add RadTileViewItems with TileState = Maximized
* Fixed: Exception is thrown if TileView is used with RadDataPager and PageSize is changed when on last page
* Fixed: Refreshing the ItemsSource collection of virtualized TileView with auto RowHeight hides items
* Fixed: BindingExpression error is thrown in the Output in certain DataBinding scenarios

### What's New
* Feature: Add HeaderStyle property to RadTileViewItem

> You can examine the Q1 2012 release history in {% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.