---
title: UriImageProvider
page_title: UriImageProvider
description: UriImageProvider
slug: radmap-features-uriimageprovider
tags: uriimageprovider
published: True
position: 5
---

# UriImageProvider

RadMap provides support for single image provider through the __UriImageProvider__ class besides the built-in support for tiled (MultiScaleImage) providers like BingRestMapProvider and OpenStreetMapProvider.
      
Assuming that images with names osm_10.png, osm_11.png, ..., osm_14.png are embedded as resources within the application assembly, you can initialize the UriImageProvider like this:        

#### __XAML__
{{region radmap-features-uriimageprovider_0}}
	<telerik:RadMap x:Name="RadMap1" 
	                ZoomLevel="13" 
	                MinZoomLevel="10" 
	                MaxZoomLevel="14" 
	                Center="42.72481708629, 23.3176519378416"
	                NavigationVisibility="Collapsed"
	                ZoomBarVisibility="Collapsed"
	                CommandBarVisibility="Collapsed">
	    <telerik:RadMap.Provider>
	        <telerik:UriImageProvider GeoBounds="42.786, 23.17, 25, 14" Uri="/MyApplication;component/osm_{zoom}.png" />
	    </telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

The UriImageProvider provides support for the following specific properties:        

* __Uri__ - Gets or sets the uniform resource identifier (URI) for the image location.

Example:
[http://c.tile.openstreetmap.org/7/70/43.png](http://c.tile.openstreetmap.org/7/70/43.png)
(© OpenStreetMap contributors).
![](http://c.tile.openstreetmap.org/7/70/43.png)

{% if site.site_name == 'Silverlight' %}
In a Silverlight application this can either point to absolute location (like the above example)
or it can be the relative path to the image e.g. Uri="/7/70/43.png" that is combined with
the value of the __BaseAddress__ property.
{% endif %}

>tip If you have separate image for every zoom level then the URI string must contain *__{zoom}__* placeholder. This part will be replaced with the actual zoom level when the image is requested (e.g."/MyApplication;component/MapImages/image_{zoom}.png").

* __BaseAddress__ - Gets or sets the uniform resource identifier (URI) of the base address for the image location. {% if site.site_name == 'Silverlight' %}In Silverlight the default value of this property points to the root of the HTML document on which the Silverlight plug-in is hosted (i.e. the web application root) and most probably you would not need to change this value.{% endif %}

* __ZoomNumericFormat__ - Gets or sets numeric format string will be used to replace {zoom} placeholder. For example "D2" will replace {zoom} placeholder with 2 digits integer (01, 02, ..., 19). The default value is null and it produces simple integer without paddings (1, 2, ... 9, 10, ... 19).          

>tipNote that the __UriImageProvider__ cannot be used as a master provider in a multi-provider scenario and always should be restricted within geographic region (i.e. you need to set the UriImageProvider.GeoBounds property).
