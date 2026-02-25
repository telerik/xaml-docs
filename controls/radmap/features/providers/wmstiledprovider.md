---
title: Wms Tile Provider
page_title: Wms Tile Provider
description: Check our &quot;Wms Tile Provider&quot; documentation article for the RadMap WPF control.
slug: radmap-features-providers-wms
tags: wms,tile,provider
published: True
position: 21
---

# Wms Tile Provider

The `RadMap` control allows you to display map tiles from a Web Map Service (WMS) server. WMS is a standard protocol for serving georeferenced map images over the internet. The `WmsTiledProvider` provider enables you to connect to a WMS server and display the map tiles it provides.

The WmsTiledProvider provides the following properties:

* `BaseUrl` - Gets or sets the URL of the WMS server.
* `Layers` - Gets or sets the __Layers__ tag of the downloaded map tiles.
* `Version` - Gets or sets the __VERSION__ tag of the downloaded map tiles.
* `ImageFormat` - Gets or sets the __FORMAT__ tag of the downloaded map tiles (e.g., "image/png").

The following example showcases how to use the `WmsTiledProvider` to display map tiles from a WMS server, via [GeoServer](https://geoserver.org/):

```XAML
    <telerik:RadMap>
    	<telerik:RadMap.Provider>
    		<telerik:WmsTiledProvider BaseUri="http://localhost:8080/geoserver/wms"
    								  Layers="topp:states"
    								  Version="1.1.0"
    								  ImageFormat="image/jpeg"/>
    	</telerik:RadMap.Provider>
    </telerik:RadMap>
```

__RadMap displaying map tiles from a WMS server__

![RadMap displaying map tiles from a WMS server](images/wms-tiled-provider.png)

## See Also

 * [Providers Overview]({%slug radmap-features-providers%})
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%}) 
 * [OpenStreetMapProvider]({%slug radmap-features-providers-osm-provider%})
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})
 * [ArcGisMapProvider]({%slug radmap-features-providers-arcgis%})
 * [AzureMapProvider]({%slug radmap-features-providers-azuremapprovider%})
 * [MapBoxProvider]({%slug radmap-features-mapboxprovider%})