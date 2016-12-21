---
title: Reordering the Tiles
page_title: Reordering the Tiles
description: Reordering the Tiles
slug: radtilelist-reordering-tiles
tags: reordering,the,tiles
published: True
position: 2
---

# Reordering the Tiles



You can reorder a __Tile__ by swiping it up and then dragging it to a new position.

If you are using the mouse, you can just drag it to a new position.{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Reorder Tile SL](images/RadTileList_GettingStarted_ReorderTile_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Reorder Tile WPF](images/RadTileList_GettingStarted_ReorderTile_WPF.png){% endif %}

As of __Q2 2013__ a new property of RadTileList is introduced - __TileReorderMode__. It defines what kind of tile reordering the user may perform and has three options:
      

* __None__ - Tile reordering is disabled.

* __InGroup__ - Tile may be placed only inside the original group.

* __BetweenGroups__ - Tile may be placed in any group.
