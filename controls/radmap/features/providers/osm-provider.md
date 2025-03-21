---
title: Open Street Maps Provider
page_title: Open Street Maps Provider
description: This article describes the support Open Street Maps services support in RadMap.
slug: radmap-features-providers-osm-provider
tags: providers,osm, openstreetmapprovider
published: True
position: 20
---

# Open Street Maps Provider

`RadMap` supports displaying tile data from the [Open Street Map](https://www.openstreetmap.org/) services via the `OpenStreetMapProvider` class. You have the option of passing an API key to it. This key is needed for the Transport and Cycle maps, which come from [ThunderForest](https://www.thunderforest.com/). You can check the [following page](https://www.thunderforest.com/docs/apikeys/) in order to learn how to obtain an API key.

#### __[XAML] OpenStreetMapProvider with API key in Xaml__
{{region radmap-features-providers-3}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider APIKey="your-api-key" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __[C#] OpenStreetMapProvider set in code__
{{region radmap-features-providers-4}}
	OpenStreetMapProvider openStreetMap = new OpenStreetMapProvider("your-api-key");
	this.radMap.Provider = openStreetMap;
{{endregion}}
	
#### __[VB] OpenStreetMapProvider set in code__
{{region radmap-features-providers-5}}
	Dim openStreetMap As New OpenStreetMapProvider("your-api-key")
	Me.radMap.Provider = openStreetMap
{{endregion}}

### Setting a User-Agent

The OpenStreetMapProvider class provides the option of passing a User-Agent header, which will be used in the web request for downloading the tiles from the Standard tile layer. This allows for compliance with the [OpenStreetMaps Tile Usage Policy](https://operations.osmfoundation.org/policies/tiles/). 

>important If a User-Agent is not provided, the Standard layer tiles will not be downloaded.

The following two examples demonstrate how you can pass such a User-Agent.

#### __[XAML] Setting StandardModeUserAgent in Xaml__
{{region radmap-features-providers-6}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider APIKey="your-api-key" StandardModeUserAgent="your custom user agent string" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __[C#] Setting StandardModeUserAgent in code__
{{region radmap-features-providers-7}}
	OpenStreetMapProvider openStreeMapProvider = new OpenStreetMapProvider("your-api-key")
	{
		StandardModeUserAgent = "your custom user agent string"
	};
{{endregion}}
	
#### __[VB] Setting StandardModeUserAgent in code__
{{region radmap-features-providers-7}}
	Dim openStreeMapProvider As New OpenStreetMapProvider("your-api-key") With {.StandardModeUserAgent = "your custom user agent string"}
{{endregion}}