---
title: Elevation
page_title: Elevation
description: Check our &quot;Elevation&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-bing-rest-map-provider-elevation
tags: bing,map,provider,rest,elevation
published: True
position: 5
---

# Elevation

RadMap Bing Elevation Service allows you to obtain elevation information of a location on a map. You can get the elevation information for a set of locations, polyline or area on the Earth. You can access the elevation service via __BingRestMapProvider__ provider. 

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

>The RadMap built-in elevation service wraps the [Elevation API](https://msdn.microsoft.com/en-us/library/jj158959.aspx) of the Bing Maps Rest services.

![Rad Rest Map Routing Example](images/RadMap_Features_Rest_Provider_Elevation.png)

In order to get the elevation data you can create instance of the __BingRestElevationRequest__ object. Then you can call the __CalculateElevationAsync()__ method of the __BingRestMapProvider__ which uses the request object as a parameter. Then you can subscribe to the BingRestMapProvider's __CalculateElevationCompleted__ and __CalculateElevationError__ event. You can take a look at the following steps:

* Set the __ApplicationId__ property of the __BingRestMapProvider__. This property represents a key, which allows you to use the Bing Rest Maps services.

	>Without supplying a valid key you won't be able to visualize the map inside the RadMap control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps](http://msdn.microsoft.com/en-us/library/ee681900.aspx).
	
* Create instance of the __BingRestRouteRequest__ object
* Handle __CalculateElevationCompleted__ and __CalculateElevationError__ events of the __BingRestMapProvider__
* Call __CalculateElevationAsync()__ method of the __BingRestRouteRequest__ and provide the request as a parameter

You can customize the __BingRestElevationRequest__ object by setting the following properties.
* __ElevationType__: A property of type __BingRestElevationRequestType__ that gets or sets the type of the elevation to be calculated. This mode is enumeration and it allows the following values.
	* __List__: Get elevations for latitude and longitude coordinates. Required parameters of the __BingRestElevationRequest__ object __Points__ property.
	* __Polyline__: Get elevations at equally-spaced locations along a polyline path. Required parameters of the __BingRestElevationRequest__ object __Points__ and __Samples__ properties.
	* __Bounds__: Get elevations at equally-spaced locations within an area on the Earth defined as a bounding box. Required parameters of the __BingRestElevationRequest__ object __Bounds__, __Rows__, __Columns__ properties.
	* __SeaLevel__: Get the offset of the geoid sea level Earth model from the ellipsoid Earth model at a set of latitude and longitude coordinates. Required parameters of the __BingRestElevationRequest__ object __Points__ property.
* __HeightsType__: A property of type __BingRestElevationHeightsType__ that gets or sets the elevation heights type used in the elevation service request. This mode is enumeration and it allows the following values.
	* __SeaLevel__: Use the geoid Earth model (EGM2008 2.5').
	* __Ellipsoid__: Use the ellipsoid Earth model (WGS84).
* __Points__: Gets or sets a set of coordinates on the Earth to use in elevation calculations. The exact use of these points depends on the type of elevation request.
* __Bounds__: Gets or sets the rectangular area over which to provide elevation values.
* __Rows__: Gets or sets the number of rows to use to divide the bounding box area into a grid. The rows that define the bounding box each count as two (2) of the rows. Elevation values are returned for all vertices of the grid. Integers with a value of two 2 or greater. The number of rows and columns can define a maximum of 1024 locations (rows * cols <= 1024).
* __Columns__: Gets or sets the number of columns to use to divide the bounding box area into a grid. The columns that define the bounding box each count as two (2) of the columns. Elevation values are returned for all vertices of the grid. Integers with a value of two 2 or greater. The number of rows and columns can define a maximum of 1024 locations (rows * cols <= 1024).
* __Samples__: Gets or sets the number of equally-spaced elevation values to provide along with a polyline path. A positive integer. The maximum number of samples is 1024.

## Get elevations for list of points

When the __ElevationType__ enumeration is set to __List__ the ElevationRequest gets elevations for given list of latitude and longitude coordinates. Elevations are returned for each set of coordinates.

__Example 1: Defining BingRestMapProvider in XAML__
<snippet id='radmap-features-providers-bing-rest-map-provider-elevation-block_1-xaml' />

__Example 2: Setting list of locations__
<snippet id='radmap-features-providers-bing-rest-map-provider-elevation-block_2-cs' />
<snippet id='radmap-features-providers-bing-rest-map-provider-elevation-block_2-vb' />

## See Also
 * [Providers Overview]({%slug radmap-features-providers%})
 * [ArcGIS Online Map Provider]({%slug radmap-features-providers-arcgis%})