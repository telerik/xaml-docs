---
title: Implement custom zoom levels for MapZoomBar UI
page_title: Implement custom zoom levels for MapZoomBar UI
description: Check our &quot;Implement custom zoom levels for MapZoomBar UI&quot; documentation article for the RadMap control.
slug: radmap-howto-custom-zoom-levels
tags: implement,custom,zoom,levels,for,mapzoombar,ui
published: True
position: 2
---

# Implement custom zoom levels for MapZoomBar UI

It is now possible to customize the default preset zoom levels in the MapZoomBar UI for every map provider.

## Customization of the zoom levels in the MapZoomBar

You can add custom zoom level through the `MapZoomBar.RegisterSetZoomLevelCommand` method, which accepts the following parameters:

* zoomLevel - Specifies the zoom level to set.

* commandText - Specifies the command label in the UI (you need to bind it in the DataTemplate as demonstrated below).

* dataTemplate - Specifies the data template for command presentation in the UI.

* imageUri - Uniform resource identifier (URI) of the image that is used in the map source button data template (you need to bind it in the DataTemplate as demonstrated below).

Here is a sample code snippet that demonstrates zoom level customization:


<snippet id='radmap-how-to-howto-custom-zoom-levels-block_1-xaml' />


<snippet id='radmap-how-to-howto-custom-zoom-levels-block_2-cs' />
<snippet id='radmap-how-to-howto-custom-zoom-levels-block_2-vb' />