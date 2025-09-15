---
title: How to restrict panning and zooming region in RadMap
page_title: How to restrict panning and zooming region in RadMap
description: Check how to restrict panning and zooming region in RadMap.
slug: radmap-howto-limit-panning-zooming-region
tags: how,to,restrict,panning,and,zooming,region,in,radmap
published: True
position: 6
---

# How to restrict panning and zooming region in RadMap

## Restrict zooming region in RadMap

You can restrict the zooming region in RadMap by setting the __RadMap.MinZoomLevel__ / __RadMap.MaxZoomLevel__ properties:

__Example 1: Setting MinZoomLevel and MaxZoomLevel properties__
```XAML
	<telerik:RadMap x:Name="RadMap1" 
	                ZoomLevel="13" 
	                MinZoomLevel="10" 
	                MaxZoomLevel="14" 
	                Center="42.72481708629, 23.3176519378416">
	    <telerik:RadMap.Provider>
	        <telerik:UriImageProvider GeoBounds="42.786, 23.17, 25, 14" Uri="DataSources/Geospatial/osm_{zoom}.png" />
	    </telerik:RadMap.Provider>
	</telerik:RadMap>
```

## Restrict panning region in RadMap

You can restrict the panning region in RadMap by setting the __RadMap.GeoBounds__ property that represents __LocationRect__ instance:

__Example 2: Setting GeoBounds property__
```XAML
	<telerik:RadMap x:Name="RadMap1" 
	        ZoomLevel="15"
	        MinZoomLevel="15"
	        GeoBounds="42.3683598045287, -71.0789727419614, 3.9167707221002743, 2.1883037274811104">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
```

>tip The third and fourth parameters (Width and Height) in the __LocationRect__ definition specify size of the rectangle in the distance units used on the map (kilometers or miles).

>tip __RadMap.GeoBounds__ and __MapProvider.GeoBounds__ serve different purposes in RadMap. The former restricts panning region, while the latter limit the size of the geographical region covered by the respective provider and allows creation of specific “map windows” over the map.