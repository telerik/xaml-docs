---
title: Wraparound
page_title: Wraparound
description: Wraparound
slug: radmap-features-wraparound
tags: wraparound, continuous, panning, horizontal, infinite
published: True
position: 17
---

# Wraparound

The WrapAround feature provides infinite horizontal panning to the __RadMap__ control which gives continuous experience as the user pans the viewport east or west. 

The feature is not enabled by default. To turn it on you can set the __WrapAround__ property of the RadMap to __True__.

#### __[XAML] Example 1: Setting the WrapAround property__
{{region xaml-radmap-features-wraparound-01}}
	<telerik:RadMap WrapAround="True">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}


#### __Figure 1: Wraparound functionality enabled__
![](images/RadMap_Features_WrapAround_01.png)

When the wraparound is enabled, the longitude of the map's viewport can exceed the valid geographical boundaries (from -180 to 180 degrees in the default Mercator projection) when you pan the viewport. The [Location Conversion](#location-conversion) section of this article explains how to convert shifted locations to valid geographical boundaries (-180 to 180).

>Services like __Geocode, Search, Routing__ use Longitude within the valid geographical boundaries.

## Location Conversion

RadMap exposes two methods which you can use to convert map coordinates.
	
* __GetShiftedLocation(Location standardLocation)__
	
	This method accepts a location in the standard longitude range of the Mercator projection ( from -180 to 180 degrees), and returns a shifted location based on the shift of the map's center when panned outside of the standard longitude range.
	
	#### __[C#] Example 2: GetShiftedLocation method__
	{{region cs-radmap-features-wraparound-02}}
		Location shiftedLocation = this.myRadMap.GetShiftedLocation(standardLocation);	
	{{endregion}}	

* __GetCoercedLocation(Location shiftedLocation)__

	This method accepts shifted coordinates and returns a Location object by converting shifted location's to standard location in the range from -180 to 180 degrees.

	#### __[C#] Example 3: GetCoercedLocation method__
	{{region cs-radmap-features-wraparound-03}}
		Location desiredLocation = this.myRadMap.GetCoercedLocation(shiftedLocation);
	{{endregion}}

## MiniMap Support

When the wraparound feature is enabled on the RadMap the built-in MiniMap also has this functionality turned on. But when you are using the MiniMap as a standalone control you have to explicitly set its __WrapAround__ property to __True__ in order to turn the feature on.

>The WrapAround property of the RadMap control that is linked to the MiniMap has a higher priority than the WrapAround property of the MiniMap.
	
## See Also
 * [Getting Started] ({%slug radmap-getting-started%})
 * [MiniMap] ({%slug radmap-features-mini-map%})
 * [Wraparound with Virtualization in VisualizationLayer] ({%slug radmap-howto-wraparound-virtualization-visualizationlayer%})
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%})
