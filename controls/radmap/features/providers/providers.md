---
title: Providers Overview
page_title: Providers Overview
description: Providers Overview
slug: radmap-features-providers
tags: providers,overview
published: True
position: 0
---

# Providers Overview

The __RadMap__ control doesn't display a map on itself, it needs a map provider from which to consume the required data. Currently the __RadMap__ control supports a few providers:      

* [Bing Maps](#bing-maps)

* [ArcGIS](#arcgis-online-services)

* [OpenStreet Maps](#openstreet-maps)

* [Empty Provider](#empty-provider)

* [UriImageProvider](#uriimageprovider)

>tip It is now possible to specify multiple map providers that will be displayed one over another through the __RadMap.Providers__ property. Note that in multiple providers scenario the first (master) provider should be tiled provider without geographic limits set. Also, providers that have geographic limits and use tiled map sources should be limited with the __MapLayer.ZoomRange__ attached property. Zoom range should be set into the reasonable value, so the size of the “map window” does not get excessive on the maximum allowed zoom level; otherwise loading of the tiles into the window will dramatically decrease performance of the application.        

Here is a list of the most important common properties shared by all map providers:

* __GeoBounds__ - Gets or sets region covered by map image (the region represented by map provider can be limited by geographic bounds now).          

* __Opacity__ - Gets or sets the opacity factor for the respective provider imagery data.          

* __Commands__ - Gets the collection of the commands supported by the respective provider. This is useful if you want to customize the default command list (i.e. add / remove commands). You can find more information [here]({%slug radmap-howto-customize-commands%}).          

* __CommandBindingCollection__ - Gets collection of the command bindings.          

* __SupportedSources__ - Gets the IDs of the supported sources. This property can be used in scenarios where it is necessary to get the list of supported sources and execute some action based on them (e.g. enable or disable source specific commands in the command bar).

## Bing Maps

The [Bing Maps](http://www.bing.com/maps/) can be used via the __BingRestMapProvider__ (RESTful imagery service) class. In order to create an instance of the __BingRestMapProvider__ you can use the third overload of its constructor. This way you can easily pass the required parameters - map mode, labels visibility and __Bing Maps Key__. The most important of them is the __Bing Maps Key__. Without supplying a valid key you won't be able to visualize the map inside the __RadMap__ control. In order to learn how to obtain one, please read the [Accessing the Control Using a Bing Maps Key](http://msdn.microsoft.com/en-us/library/ee681900.aspx) MSDN article.

Here is an example of a __BingMapProvider__ definition:        

#### __XAML__
{{region radmap-features-providers-0}}	
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider ApplicationId="Bing_Map_Key" Mode="Aerial" IsLabelVisible="True"/>
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region radmap-features-providers-1}}	
	BingRestMapProvider bingMap = new BingRestMapProvider( MapMode.Aerial, true, "key" );
	this.radMap.Provider = bingMap;
{{endregion}}

#### __VB__
{{region radmap-features-providers-2}}
	Dim bingMap As New BingRestMapProvider(MapMode.Aerial, True, "key")
	Me.radMap.Provider = bingMap
{{endregion}}

Here is a snapshot of the map that appears:

![Rad Map Features Providers 01](images/RadMap_Features_Providers_01.png)

## OpenStreet Maps

The [Open Street Maps](http://www.openstreetmap.org/) can be used via the __OpenStreetMapProvider__ class.         

#### __XAML__
{{region radmap-features-providers-3}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region radmap-features-providers-4}}
	OpenStreetMapProvider openStreetMap = new OpenStreetMapProvider();
	this.radMap.Provider = openStreetMap;
{{endregion}}
	
#### __VB__
{{region radmap-features-providers-5}}
	Dim openStreetMap As New OpenStreetMapProvider()
	Me.radMap.Provider = openStreetMap
{{endregion}}

Here is a snapshot of the map that appears:

![Rad Map Features Providers 02](images/RadMap_Features_Providers_02.png)

## Empty Provider

Empty provider is a provider which doesn't connect to any real imagery services (Virtual Earth, Google etc). It provides definitions and methods which can be used to calculate positions of the framework elements, map shapes and pin points. By using this provider you can create map-relative applications which do not require visibility of the real map data (landscapes or roads), but which require visible elements to be positioned according to the geographical coordinates.

>tip To learn more about the empty provider [read here]({%slug radmap-features-empty-provider%}).        

## UriImageProvider

RadMap provides support for single image provider through the __UriImageProvider__ class besides the built-in support for tiled (MultiScaleImage) providers like BingRestMapProvider and OpenStreetMapProvider. You can either use it with single image for all zoom levels, or you can specify an image for every distinct zoom level.        

>tip To learn more about the UriImageProvider [read here]({%slug radmap-features-uriimageprovider%}).   

## ArcGIS online services

The [ArcGIS online services](http://www.esri.com/software/arcgis/arcgisonline/maps/maps-and-map-layers) can be used via the __ArcGisMapProvider__ class. Currently the ArcGIS map provider support 6 modes which can be set using Mode property:        

* Aerial
* Physical
* Shaded Relief
* Street
* Terrain
* Topographic

#### __XAML__
{{region radmap-features-providers-6}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:ArcGisMapProvider Mode="Physical" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region radmap-features-providers-7}}
	ArcGisMapProvider provider = new ArcGisMapProvider();
	provider.Mode = ArcGisMapMode.Physical;
	this.radMap.Provider = provider;
{{endregion}}

#### __VB__
{{region radmap-features-providers-8}}
	Dim provider As New ArcGisMapProvider ()
	provider.Mode = ArcGisMapMode.Physical
	Me.radMap.Provider = provider
{{endregion}}

Here is a snapshot of the map that appears:

![Rad Map Features Providers 04](images/RadMap_Features_Providers_04.png)

## See Also
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%}) 
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})
