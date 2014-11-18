---
title: ArcGIS Online Map Provider
page_title: ArcGIS Online Map Provider
description: ArcGIS Online Map Provider
slug: radmap-features-providers-arcgis
tags: arcgis,online,map,provider
published: True
position: 2
---

# ArcGIS Online Map Provider



## ArcGisMapProvider

The [ArcGIS online services](http://www.esri.com/software/arcgis/arcgisonline/maps/maps-and-map-layers) can be used via the __ArcGisMapProvider__ class. Currently the ArcGIS map provider support six modes which can be set using the __Mode__ property:
        

1. Aeral

1. Physical

1. Shaded Relief

1. Street

1. Terrain

1. Topographic

The __Mode__ property specifies the appearance of the map.

The following example of the __ArcGisMapProvider__ definition uses the __Physical__ mode:

#### __XAML__
      <telerik:RadMap x:Name="radMap" ZoomLevel="1">
        <telerik:RadMap.Provider>
          <telerik:ArcGisMapProvider Mode="Physical" />
        </telerik:RadMap.Provider>
      </telerik:RadMap>



#### __C#__
      ArcGisMapProvider provider = new ArcGisMapProvider();
      provider.Mode = ArcGisMapMode.Physical;
      this.radMap.Provider = provider;



#### __VB.NET__	
      Dim provider As New ArcGisMapProvider ()
      provider.Mode = ArcGisMapMode.Physical
      Me.radMap.Provider = provider



Here is a snapshot of the map that appears.

![Rad Map Features Providers ArcGIS](images/RadMap_Features_Providers_ArcGIS.png)

The following snapshot demonstrates the appearance of the map for the __Street__ mode:

![Rad Map Features Providers ArcGIS Street](images/RadMap_Features_Providers_ArcGIS_Street.png)

Also the __ArcGisMapProvider__ allows the user to change the map mode using the Map View button of toolbar.

![Rad Map Features Providers ArcGIS Config](images/RadMap_Features_Providers_ArcGIS_Config.png)

# See Also

 * [Bing Map Provider]({%slug radmap-features-providers-bing-map%})
