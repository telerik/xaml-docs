---
title: Empty Provider
page_title: Empty Provider
description: Check our &quot;Empty provider&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-empty-provider
tags: empty,provider
published: True
position: 6
---

# Empty provider

The __Empty Provider__ is a provider which doesn't connect to any real imagery services (Virtual Earth, Google etc). It provides definitions and methods which can be used to calculate positions of the framework elements, map shapes and pin points. By using this provider you can create map-relative applications which do not require visibility of the real map data (landscapes or roads), but which require visible elements to be positioned according to the geographical coordinates.

>tip The __Empty Provider__ can be combined together with the [KML Data Import]({%slug radmap-features-kml-data-import%}) feature of __RadMap__.

>tip The __Empty Provider__ can be combined together with the [Shapefile Support]({%slug radmap-features-shapefiles-support%}) feature of __RadMap__. Note that if you are loading shapefiles created for OSGB36 (National Grid UK) or EPSG:900913 (Mercator, meters), you also need to set the __EmptyProvider.Projection__ property to __OSGB1936Projection__ or __EPSG900913Projection__ respectively.

Here is an example of creating an __EmptyProivder__ and setting it to the __RadMap__:


```XAML
	<telerik:RadMap x:Name="radMap" />
```


```C#
	EmptyProvider provider = new EmptyProvider();
	this.radMap.Provider = provider;
```


```VB.NET
	Dim provider As New EmptyProvider()
	Me.radMap.Provider = provider
```

## See Also
 * [Providers Overview]({%slug radmap-features-providers%})