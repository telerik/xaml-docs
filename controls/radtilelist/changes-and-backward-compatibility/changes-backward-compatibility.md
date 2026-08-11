---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-changes-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



## Q3 2014
      

* Panel of __RadTileList__ is __TileListGroupPanel__ rather than __TileListPanel__
          

* Each group is represented by __TileGroupContainer__ rather than __ContentControl__
          

* Group property of Tile is now a __TileGroup__ type rather than just an object
          

* __Group__ property of Tile is __not settable__ and you can only read its value
          

Before:

__Example 1: RadTileList before Q3 2014__

<snippet id='radtilelist-changes-and-backward-compatibility-changes-backward-compatibility-block_1-xaml' />



After __Q3 2014__

__Example 2: RadTileList after Q3 2014__

<snippet id='radtilelist-changes-and-backward-compatibility-changes-backward-compatibility-block_2-xaml' />



*  __Group__ property of __Tile__ cannot be set through __Style__ since it can be only read. Since __Tile__ belongs to a group you need to add it in its __Items__ collection when they are manually generated or set __GroupMember__ property of __TileList__ when bound to data source.
          

*  Since each group is now represented of __TileGroupContainer__, if you have custom theme, you need to copy the style for this control in the template of RadTileList:
          

__Example 3: Setting a Style for TileGroupContainer__

<snippet id='radtilelist-changes-and-backward-compatibility-changes-backward-compatibility-block_3-xaml' />



* If you have custom theme, you need to update the panel of RadTileList and it should be:
          

__Example 4: Updating the panel of RadTileList__

<snippet id='radtilelist-changes-and-backward-compatibility-changes-backward-compatibility-block_4-xaml' />



* __HorizontalScrollBarVisibility__ property of __ScrollViewer__ is set to __Auto__ and there is no need to set it explicitly in the definition of __RadTileList__
          

* There is __GroupTemplate__ by default and it is not necessary to declare it explicitly in order to see the groups
          

* Default value of __TileListPanel__ property Padding is changed to new Thickness(0, 0, 0, 0) rather than Thickness(0, 30, 0, 0)
          