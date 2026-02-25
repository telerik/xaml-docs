---
title: Overview
page_title: Providers Overview
description: This article describes the supported by the RadMap providers.
slug: radmap-features-providers
tags: providers,overview
published: True
position: 0
---

# Providers Overview

The `RadMap` control doesn't display a map on itself, it needs a map provider from which to consume the required data. Currently the control supports a few providers:      

* [Bing Maps](#bing-maps-provider)
* [OpenStreet Maps](#openstreet-maps-provider)
* [Empty Provider](#empty-provider)
* [UriImageProvider](#uriimage-provider)
* [ArcGIS](#arcgis-provider)
* [Azure Maps](#azure-maps-provider)
* [MapBox](#mapbox-provider)

>tip It is now possible to specify multiple map providers that will be displayed one over another through the `Providers` property of RadMap. Note that in multiple providers scenario the first (master) provider should be tiled provider without geographic limits set. Also, providers that have geographic limits and use tiled map sources should be limited with the `MapLayer.ZoomRange` attached property. Zoom range should be set into the reasonable value, so the size of the “map window” does not get excessive on the maximum allowed zoom level; otherwise loading of the tiles into the window will dramatically decrease performance of the application.        

## Attribution Copyright Label

Each provider of the RadMap control that displays third-party imagery data must display an attribution copyright label. For more information about the accurate copyright label's content, please refer to the attribution article of each of the third-party vendor.

>tip To learn how to customize the RadMap to allocate space for displaying an element containing a sample attribution copyright label, check this [article]({%slug kb-map-copyright-label%}).

## Common Providers API

Here is a list of the most important common properties shared by all map providers:

* `GeoBounds`&mdash;Gets or sets region covered by map image (the region represented by map provider can be limited by geographic bounds now).          
* `Opacity`&mdash;Gets or sets the opacity factor for the respective provider imagery data.          
* `Commands`&mdash;Gets the collection of the commands supported by the respective provider. This is useful if you want to customize the default command list (i.e. add / remove commands). You can find more information [here]({%slug radmap-howto-customize-commands%}).          
* `CommandBindingCollection`&mdash;Gets collection of the command bindings.          
* `SupportedSources`&mdash;Gets the IDs of the supported sources. This property can be used in scenarios where it is necessary to get the list of supported sources and execute some action based on them (e.g. enable or disable source specific commands in the command bar).

## Bing Maps Provider

The RadMap control provides the support to visual [Bing Maps](http://www.bing.com/maps/) tile data via the `BingRestMapProvider` (RESTful imagery service) class. 

For more information about the Bing Maps support, check the [Bing Map Rest Provider]({%slug radmap-features-providers-bing-rest-map%}) article.

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

## OpenStreet Maps Provider

RadMap supports displaying tile data from the [Open Street Map](https://www.openstreetmap.org/) services via the `OpenStreetMapProvider` class.

To learn more about the Open Street Map services support, check the [Open Street Map Provider]({%slug radmap-features-providers-osm-provider%}) article.

## Empty Provider

The `EmptyProvider` is a provider which doesn't connect to any real imagery services (Virtual Earth, Google etc). It provides definitions and methods which can be used to calculate positions of the framework elements, map shapes and pin points. By using this provider you can create map-relative applications which do not require visibility of the real map data (landscapes or roads), but which require visible elements to be positioned according to the geographical coordinates.

To learn more about the EmptyProvider, check the [Empty Provider]({%slug radmap-features-empty-provider%}) article.        

## UriImage Provider

RadMap provides support for single image provider through the `UriImageProvider` class besides the built-in support for tiled (MultiScaleImage) providers like BingRestMapProvider and OpenStreetMapProvider. You can either use it with single image for all zoom levels, or you can specify an image for every distinct zoom level.        

To learn more about the UriImageProvider, check the [UriImageProvider]({%slug radmap-features-uriimageprovider%}) article.   

## ArcGIS Provider

RadMap exposes the functionality to display the [ArcGIS online services](http://www.esri.com/software/arcgis/arcgisonline/maps/maps-and-map-layers) via the `ArcGisMapProvider` class. 

To learn more about the ArcGisMapProvider, check the [ArcGIS Online Map Provider]({%slug radmap-features-providers-arcgis%}) article.

## Azure Maps Provider

The RadMap control supports displaying tile data using the [Azure Map services](https://azure.microsoft.com/en-us/products/azure-maps/). This is done via the `AzureMapProvider` class and it provides support for both raster and vector sources.

For more information about the Azure Map services support, check the [Azure Map Provider]({%slug radmap-features-providers-azuremapprovider%}) article. 

## MapBox Provider

RadMap provides support for the [MapBox vector tile services](https://docs.mapbox.com/data/tilesets/guides/vector-tiles-introduction/) via the `MapBoxProvider` class.

To learn more about how to use the MapBoxProvider, check the [MapBox Provider]({%slug radmap-features-mapboxprovider%}) article.

## See Also

 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%}) 
 * [OpenStreetMapProvider]({%slug radmap-features-providers-osm-provider%})
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})
 * [ArcGisMapProvider]({%slug radmap-features-providers-arcgis%})
 * [AzureMapProvider]({%slug radmap-features-providers-azuremapprovider%})
 * [MapBoxProvider]({%slug radmap-features-mapboxprovider%})