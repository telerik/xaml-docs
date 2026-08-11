---
title: Search Location
page_title: Search Location
description: Check our &quot;Search Location&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-bing-rest-map-provider-search-location
tags: bing,map,provider,rest,location api, search
published: True
position: 2
---

# Search Location

The RadMap control allows the user to implement search functionality, that will let the user search for a specific place on the map.  The search is performed through an __IBingRestSearchLocationProvider__ interface, which communicates with the respective map provider's services. The __BingRestMapProvider__ implements this interface. In the following sections of this article we will demonstrate how you can implement this functionality.

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

>The RadMap search functionality wraps the [Location API](https://msdn.microsoft.com/en-us/library/ff701715.aspx) of the Bing Rest Map services.

## Find a place by given Location or Query

In the following examples, we will demonstrate how to find a specific location by given address or location. To do it you can create an instance of the __BingRestSearchLocationRequest__ object which the __SearchLocationAsync()__ method of the __BingRestMapProvider__ uses as a parameter and set its __Query__ property. Then you can subscribe to the __SearchLocationCompleted__ and __SearchLocationError__ events of the __BingRestMapProvider__. The __SearchLocationError__ event is the place for handling any kind of errors that occur during the search operation.  You can take a look at the following steps:

* Set the __ApplicationId__ property of the __BingRestMapProvider__. This property represents a key, which allows you to use the Bing Rest Maps services.
	
	>Without supplying a valid key you won't be able to visualize the map inside the RadMap control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps](http://msdn.microsoft.com/en-us/library/ee681900.aspx).

* Create instance of the __BingRestSearchLocationRequest__ object
* Handle __SearchLocationCompleted__ and __SearchLocationError__ events of the __BingRestMapProvider__
* Call __SearchLocationAsync()__ method of the __BingRestMapProvider__ and provide the request as a parameter
	
>The __SearchLocationCompleted__ returns __BingRestSearchLocationCompletedEventArgs__ argument which contains array of Telerik.Windows.Controls.DataVisualization.Map.BingRest.__Location__ objects. This is a complex __DataContract__ object given from the __Bing REST__ services and contains lots of data – address, name, geocode points, district, maneuver type etc. For better overview follow [Search](https://github.com/telerik/xaml-sdk/tree/master/Map/WPF/Search) sample project.
   
* __Find a place by Location__
	In this example we will get the location on the MapMouseClick event of the RadMap.	
	__Example 1: Defining BingRestMapProvider in XAML__
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_1-xaml' />
	
	__Example 2: Get location by mouse click__
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_2-cs' />
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_2-vb' />
	
* __Find a place by Address/String Query__

	The approach here is almost the same as the one explained above. Here we are setting a string address to the Query property of the __BingRestSearchLocationRequest__ object.

	__Example 3: Defining BingRestMapProvider in XAML__
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_3-xaml' />
	
	__Example 3: Get a location by specific address__
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_4-cs' />
	<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_4-vb' />

## Structured / Unstructured URL
	
The __Microsoft Bing Maps REST Service__ provides two URL templates which you can use to get latitude and longitude coordinates for a location by a given query. To learn more about these templates, please refer to the [Find a Location by Address](https://msdn.microsoft.com/en-us/library/ff701711.aspx)) MSDN article.

With the __R1 2018 SP2__ version of our controls, you can now change the type of URL which the BingRestMapProvider's search mechanism uses in its code. By default, the __BingRestSearchLocationRequest__ uses the __structured__ URL template. To force the search functionality to use an unstructured URL template, you can set the __UseUnstructuredQuery__ property of the __BingRestSearchLocationRequest__ to __True__. 

Setting one of these URLs depends on how you have structured your query. To search for a location you can type it in structured form, for example, '1 Microsoft way, Redmond WA 98052'. In such a scenario you can use a __Structured URL__. On the other hand, if you type an unstructured address (or free form query) you should choose the unstructured Bing URL to get better results from the service.	

__Example 4: Get a location by specific address__
<snippet id='radmap-features-providers-bing-rest-map-provider-search-location-block_5-cs' />
	
## See Also
 * [Providers Overview] ({%slug radmap-features-providers%})
 * [Bing Rest Map]({%slug radmap-features-providers-bing-rest-map%})
 * [Routing]({%slug  radmap-features-providers-bing-rest-map-provider-routing%})
 * [Elevation]({%slug  radmap-features-providers-bing-rest-map-provider-elevation%})