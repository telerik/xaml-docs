---
title: Empty provider
page_title: Empty provider
description: Empty provider
slug: radmap-features-empty-provider
tags: empty,provider
published: True
position: 3
---

# Empty provider



## 

The __Empty Provider__ is a provider which doesn't connect to any real imagery services (Virtual Earth, Google etc). It provides definitions and methods which can be used to calculate positions of the framework elements, map shapes and pin points. By using this provider you can create map-relative applications which do not require visibility of the real map data (landscapes or roads), but which require visible elements to be positioned according to the geographical coordinates.

>tipThe __Empty Provider__ can be combined together with the [KML Data Import]({%slug radmap-features-kml-data-import%}) feature of __RadMap__.

>tipThe __Empty Provider__ can be combined together with the [Shapefile Support]({%slug radmap-features-shapefiles-support%}) feature of __RadMap__. Note that if you are loading shapefiles created for OSGB36 (National Grid UK) or EPSG:900913 (Mercator, meters), you also need to set the __EmptyProvider.Projection__ property to __OSGB1936Projection__ or __EPSG900913Projection__ respectively.

Here is an example of creating an __EmptyProivder__ and setting it to the __RadMap__.

#### __XAML__

{{region radmap-features-empty-provider_0}}
	<telerik:RadMap x:Name="radMap" />
	{{endregion}}



#### __C#__

{{region radmap-features-empty-provider_1}}
	EmptyProvider provider = new EmptyProvider();
	this.radMap.Provider = provider;
	{{endregion}}



#### __VB.NET__

{{region radmap-features-empty-provider_2}}
	Dim provider As New EmptyProvider()
	Me.radMap.Provider = provider
	{{endregion}}



# See Also

 * [Providers Overview]({%slug radmap-features-providers%})

 * [Search]({%slug radmap-features-search%})

 * [Geocode]({%slug radmap-features-geocode%})

 * [Routing]({%slug radmap-features-routing%})
