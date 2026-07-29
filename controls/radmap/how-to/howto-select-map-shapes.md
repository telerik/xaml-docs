---
title: Select Map Shapes
page_title: Select Map Shapes
description: Check our &quot;Select Map Shapes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-howto-select-map-shapes
tags: select,map,shapes
published: True
position: 8
---

# Select Map Shapes

RadMap provides a rich set of [geocoordinate-enabled shapes]({%slug radmap-features-map-shapes%}) that can be defined and displayed onto the map surface. There are scenarios, however, where you would like to do more than just position a shape onto the map. This help topic will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a Line segment of the Polyline and set a green color for it. The Polyline itself will be colored blue and on click it will become red. All these customizations will be made through styles:


<snippet id='radmap-how-to-howto-select-map-shapes-block_1-xaml' />

First of all we’ll need two Information layers – one for the polyline and the other one for the points that we will use for the shape manipulation.


<snippet id='radmap-how-to-howto-select-map-shapes-block_2-xaml' />

Now we will create a sample polyline and add it to the first information layer. Note that it is better to do this after the map provider has been initialized in order to prevent your items from appearing in the upper left corner before the map is initialized and loaded:


<snippet id='radmap-how-to-howto-select-map-shapes-block_3-cs' />
<snippet id='radmap-how-to-howto-select-map-shapes-block_3-vb' />

And now to the essential part of our scenario. Add a Line over each segment of the polyline. This is easy since the polyline itself was created from a set of predefined points(locations). To be able to change the appearance of the polyline or its segments on click we’ll attach a __MouseLeftButtonDown__ event on the line:


<snippet id='radmap-how-to-howto-select-map-shapes-block_4-cs' />
<snippet id='radmap-how-to-howto-select-map-shapes-block_4-vb' />

In event's body you check whether the selected shape is line or the whole polyline and apply the style for it.


<snippet id='radmap-how-to-howto-select-map-shapes-block_5-cs' />
<snippet id='radmap-how-to-howto-select-map-shapes-block_5-vb' />

## See Also
 * [Resize Map Shapes With Mouse Dragging]({%slug radmap-howto-resize-map-shapes-with-mouse-dragging%})
 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})
 * [Bring a Location into View]({%slug radmap-how-to-bring-a-location-into-view%})