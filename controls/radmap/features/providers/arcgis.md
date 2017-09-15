---
title: ArcGIS Online Map Provider
page_title: ArcGIS Online Map Provider
description: ArcGIS Online Map Provider
slug: radmap-features-providers-arcgis
tags: arcgis,online,map,provider
published: True
position: 3
---

# ArcGIS Online Map Provider

## ArcGisMapProvider

The [ArcGIS online services](http://www.esri.com/software/arcgis/arcgisonline/maps/maps-and-map-layers) can be used via the __ArcGisMapProvider__ class. Currently the ArcGIS map provider support six modes which can be set using the __Mode__ property:        

1. Aeral
2. Physical
3. Shaded Relief
4. Street
5. Terrain
6. Topographic

The __Mode__ property specifies the appearance of the map.

The following example of the __ArcGisMapProvider__ definition uses the __Physical__ mode:

#### __XAML__
{{region radmap-features-providers-arcgis-0}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:ArcGisMapProvider Mode="Physical" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region radmap-features-providers-arcgis-1}}
	ArcGisMapProvider provider = new ArcGisMapProvider();
	provider.Mode = ArcGisMapMode.Physical;
	this.radMap.Provider = provider;
{{endregion}}

#### __VB.NET__	
{{region radmap-features-providers-arcgis-2}}
	Dim provider As New ArcGisMapProvider ()
	provider.Mode = ArcGisMapMode.Physical
	Me.radMap.Provider = provider
{{endregion}}

Here is a snapshot of the map that appears:

![Rad Map Features Providers ArcGIS](images/RadMap_Features_Providers_ArcGIS.png)

The following snapshot demonstrates the appearance of the map for the __Street__ mode:

![Rad Map Features Providers ArcGIS Street](images/RadMap_Features_Providers_ArcGIS_Street.png)

Also the __ArcGisMapProvider__ allows the user to change the map mode using the Map View button of toolbar.

![Rad Map Features Providers ArcGIS Config](images/RadMap_Features_Providers_ArcGIS_Config.png)

## See Also
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%})