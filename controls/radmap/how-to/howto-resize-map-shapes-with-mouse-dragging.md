---
title: Resize Map Shapes With Mouse Dragging
page_title: Resize Map Shapes With Mouse Dragging
description: Check our &quot;Resize Map Shapes With Mouse Dragging&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-howto-resize-map-shapes-with-mouse-dragging
tags: resize,map,shapes,with,mouse,dragging
published: True
position: 7
---

# Resize Map Shapes With Mouse Dragging

RadMap provides a rich set of [geocoordinate-enabled shapes]({%slug radmap-features-map-shapes%}) that can be defined and displayed onto the map surface .There are scenarios, however, where you would like to do more than just position a shape onto the map. This help topic will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a point,
        and drag the selected object to another location on the map – modifying in this way the shape or the line segment.

First of all we’ll need two Information layers – one for the polyline and the other one for the points that we will use for the shape manipulation. We will disable the default pan / drag actions of the Map as we will attach our own mouse events on the pinpoints only:

<snippet id='radmap-how-to-howto-resize-map-shapes-with-mouse-dragging-block_1-xaml' />

Now we will create a sample polyline and add it to the first information layer. Note that it is better to do this after the map provider has been initialized in order to prevent your items from appearing in the upper left corner before the map is initialized and loaded:

<snippet id='radmap-how-to-howto-resize-map-shapes-with-mouse-dragging-block_2-cs' />
<snippet id='radmap-how-to-howto-resize-map-shapes-with-mouse-dragging-block_2-vb' />

And now to the essential part of our scenario – the pinpoints. Add a MapPinPoint instance for each vertex of the original polyline shape you are displaying. This is easy since the polyline itself was created from a set of predefined locations. To be able to modify the shape of our polyline on dragging the pinpoints we’ll attach the following three mouse events:

* __MouseLeftButtonDown__ - used to capture the mouse and to enable dragging

* __MouseLeftButtonUp__ - releases mouse capture and disables dragging.

* __MouseMove__ - gets the coordinates of the clicked pinpoint relative to the map control screen coordinates. Then redraw the polyline respecting the new location of its vertex.  Both actions are easily achieved via the static SetLocation() and GetLocation() methods of the MapLayer helper class:

	<snippet id='radmap-how-to-howto-resize-map-shapes-with-mouse-dragging-block_3-cs' />
	<snippet id='radmap-how-to-howto-resize-map-shapes-with-mouse-dragging-block_3-vb' />

>tip The full source code can be downloaded from our blogpost [here](http://blogs.telerik.com/xamlteam/posts/12-01-09/radmap-for-silverlight-wpf-how-to-resize-map-shapes-with-mouse-dragging.aspx).