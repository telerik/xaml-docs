---
title: Reordering the Tiles
page_title: Reordering the Tiles
description: Reordering the Tiles
slug: radtilelist-reordering-tiles
tags: reordering,the,tiles
publish: True
position: 2
---

# Reordering the Tiles



You can reorder a Tile by swiping it up and then dragging it to a new position.

If you are using the mouse, you can just drag it to a new position.{% if site.site_name == 'Silverlight' %}

![Rad Tile List Getting Started Reorder Tile SL](images/RadTileList_GettingStarted_ReorderTile_SL.png){% endif %}{% if site.site_name == 'WPF' %}

![Rad Tile List Getting Started Reorder Tile WPF](images/RadTileList_GettingStarted_ReorderTile_WPF.png){% endif %}

As of __Q2 2013__ we have introduced a new property of the RadTileList - TileReorderMode. It defines what kind of tile reordering the user may perform and has three options:
      

* None - Tile reordering is disabled.

* InGroup - Tile may be placed only inside the original group.

* BetweenGroups - Tile may be placed in any group.
