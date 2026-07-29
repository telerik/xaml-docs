---
title: Implement Custom Map Provider
page_title: Implement Custom Map Provider
description: Check our &quot;Implement Custom Map Provider&quot; documentation article for the RadMap control.
slug: radmap-howto-custom-provider
tags: implement,custom,map,provider
published: True
position: 1
---

# Implement Custom Map Provider

If you need to consume a service which does not have a default provider, you can create a custom map provider and set it as the **Provider** property of the **RadMap** control.

## MapProviderBase

The **MapProviderBase** is the base class for all map providers. Two widely-used implementations of the class are the __TiledProvider__ and __ImageProvider__.

* __TiledProvider__ is a base class for map providers that show a map as a sequence of tiles (e.g. [AzureMapProvider]({%slug radmap-features-providers-azuremapprovider%}), [OpenStreetMap]({%slug radmap-features-providers%}).

* __ImageProvider__ is a base class for providers that show a map as a single image ([UriImageProvider]({%slug radmap-features-uriimageprovider%})). 

Once you know the type of provider you require, you can create a custom class to inherit from it. In most cases this will be the __TiledProvider__ class. In addition, you need to override the **SpatialReference** property - it returns the actual projection used by the provider and most often returns an instance of the __MercatorProjection__ class.

__Example 1: Create a custom TiledProvider__

<snippet id='radmap-how-to-howto-custom-provider-block_1-cs' />

>The **MyMapSource** class is defined in **Example 2**.

## MultiScaleTileSource

As seen in **Example 1**, the next requirement is to add instances of the abstract [MultiScaleTileSource](https://docs.telerik.com/devtools/{{ site.framework_name }}/api/telerik.windows.controls.map.multiscaletilesource) class to the provider's **MapSources** collection. The class exposes two useful properties:

* **RequestCredentials**: Gets or sets credentials for downloading tiles.
* **WebHeaders**: Gets or sets the headers used in the get requests made to the tile servers via System.Net.WebClient. This property was introduced with **R2 2019 SP1**.

The two default implementations of this abstract class are the __TiledMapSource__ and the __ImageMapSource__.

* __TiledMapSource__ is a base class for map sources that return map tiles (that includes all OpensStreetMap sources: Mapnik and Osmarenderer).

* __ImageMapSource__ is a base class for map sources that return a single map image.

When creating a custom map provider, you can choose one of these sources and override their methods depending on the specific map source type. Most implementations will require the following set of actions:

* Override the __Initialize__ method.

* Override the __GetTile__ method and existing custom logic should be moved here.

* Call the __RaiseInitializeCompleted__ method when the respective custom provider is initialized (in case of simple providers it is enough to call this method from the override Initialize method).

**Example 2** demonstrates a possible implementation of a custom TiledMapSource.

__Example 2: Create a custom TiledMapSource__
<snippet id='radmap-how-to-howto-custom-provider-block_2-cs' />

## Create an OpenStreetProvider Which Uses Https

A common requirement when using the RadMap control is to use the OpenStreetMap service over **https**. **Examples 3-5** demonstrate how this can be achieved by creating a custom map provider.

__Example 3: Create a custom TiledProvider and set up its commands__
<snippet id='radmap-how-to-howto-custom-provider-block_3-cs' />

__Example 4: Create a custom OsmTileMapSource which uses an https url__
<snippet id='radmap-how-to-howto-custom-provider-block_4-cs' />

__Example 5: Set the provider via RadMap's Provider property__
<snippet id='radmap-how-to-howto-custom-provider-block_5-cs' />

## See Also

* [OpenStreetMap]({%slug radmap-features-providers%}))
* [AzureMaps]({%slug radmap-features-providers-azuremapprovider%})
* [UriImageProvider]({%slug radmap-features-uriimageprovider%})