---
title: Bing Rest Map Provider
page_title: Bing Rest Map Provider
description: Bing Rest Map Provider
slug: radmap-features-providers-bing-rest-map
tags: bing,map,provider,rest
published: True
position: 1
---

# Bing Map Rest Provider

The RadMap control supports visualizing tile data using the Bind Maps Rest imagery service. In order to create an instance of the __BingRestMapProvider__ you have to use the third overload of its constructor. This way you can easily pass the required parameters - map mode, labels visibility and a __Bing Maps Key__. The most important of them is the __Bing Maps Key__ parameter. Without supplying a valid key you will not be able to visualize the map inside the __RadMap__ control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps Key](http://msdn.microsoft.com/en-us/library/ee681900.aspx).        

>The RadMap BingRestMapProvdider is based on the Bing Maps [Imagery API](https://msdn.microsoft.com/en-us/library/ff701721.aspx?f=255&MSPPError=-2147217396).

Here is a list of the key properties which are used by __BingRestMapProvider__:        

* __ApplicationId__: Gets or sets __Bing Maps Key__.            

* __IsLabelVisible__: Gets or sets value which indicates whether labels should be visible on the map.            

* __Mode__: Gets or sets the mode defining how the map looks. You can choose between *Road*, *Aerial* and *Birdseye* options.            

* __UseSession__: Gets or sets value which indicates whether Bing session should be used.           

>If the provider’s initialization fails, the BingRestMapProvider will raise its InitializationFaulted event. The event can be fired for example, when the internet connection is lost or when the service is unavailable. The event arguments are of type __InitializationFaultEventArgs__ type. The arguments provides an __Error__ property which contains the exception which is thrown while initialization.          

#### __[XAML] Example 1: Setting BingRestMapProvider in XAML__
{{region xaml-radmap-features-providers-bing-rest-map_0}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider ApplicationId="Bing_Map_Key" Mode="Aerial" IsLabelVisible="True"/>
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __[C#] Example 2: Defining BingRestMapProvider programmaticaly__
{{region cs-radmap-features-providers-bing-rest-map_1}}
	BingRestMapProvider bingMap = new BingRestMapProvider( MapMode.Aerial, true, "Bing_Map_Key" );
	this.radMap.Provider = bingMap;
{{endregion}}

#### __[VB.NET] Example 3: Defining BingRestMapProvider programmaticaly__
{{region vb-radmap-features-providers-bing-rest-map_2}}
	Dim bingMap As New BingRestMapProvider(MapMode.Aerial, True, "Bing_Map_Key")
	Me.radMap.Provider = bingMap
{{endregion}}
Here is a snapshot of the map that appears:
![Rad Map Features Rest Providers 01](images/RadMap_Features_Rest_Providers_01.png)

You can the disable labels using the __IsLabelVisible__ property. When you set it to *False* the labels disappear. Here is a snapshot of the Aerial mode for Bing Map Rest Provider when the labels are not visible:


![Rad Map Features Rest Providers 01 nolabels](images/RadMap_Features_Rest_Providers_02_nolabels.png)	

## Road Mode

The *Road* mode of Bing Maps ignores the __IsLabelVisible__ property. For this mode the labels are displayed always.        

Here is an example of the __Road Mode__ definition:        

#### __[XAML] Example 4: Setting Road mode in XAML__
{{region xaml-radmap-features-providers-bing-rest-map-provider-search-location_1}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider ApplicationId="Bing_Map_Key" Mode="Road" IsLabelVisible="True"/>
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}
#### __[C#] Example 5: Setting Road mode programmaticaly__
{{region xaml-radmap-features-providers-bing-rest-map_3}}
	BingRestMapProvider bingMap = new BingRestMapProvider( MapMode.Road, true, "key" );
	this.radMap.Provider = bingMap;
{{endregion}}
#### __[VB.NET] Example 5: Setting Road mode programmaticaly__
{{region xaml-radmap-features-providers-bing-rest-map_4}}
	Dim bingMap As New BingRestMapProvider(MapMode.Road, True, "key")
	Me.radMap.Provider = bingMap
{{endregion}}
Here is a snapshot of the __Road__ mode for __Bing Map Rest Provider__:

![Rad Map Features Providers Bing Map Road](images/RadMap_Features_Providers_BingMap_Road.png)

## Birdseye Mode

The __Bing Map Rest Provider__ also supports the *Birdseye* mode. This mode can be used for high resolution levels only (zoom level 19-20)        

>The __Birdseye__ mode does not provide the tile images for all regions around the world. Some regions have not images for Birdseye mode.          

Here is an example of the __Birdseye Mode__ definition:

#### __[XAML] Example 6: Setting Birdseye mode in XAML__
{{region xaml-radmap-features-providers-bing-rest-map_5}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider ApplicationId="Bing_Map_Key" Mode="Birdseye" IsLabelVisible="True"/>
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}
#### __[C#] Example 7: Setting Birdseye mode programmaticaly__
{{region cs-radmap-features-providers-bing-rest-map_6}}
	BingRestMapProvider bingMap = new BingRestMapProvider( MapMode.Birdseye, true, "key" );
	this.radMap.Provider = bingMap;
{{endregion}}
#### __[VB.NET] Example 7: Setting Birdseye mode programmaticaly__
{{region vb-radmap-features-providers-bing-rest-map_7}}
	Dim bingMap As New BingRestMapProvider(MapMode.Birdseye, True, "key")
	Me.radMap.Provider = bingMap
{{endregion}}
Here is a snapshot of the __Birdseye__ mode for __Bing Map Rest Provider__:

![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Providers_BingMap_Birdseye.png)
	
# See Also
 * [Providers Overview]({%slug radmap-features-providers%})
 * [ArcGIS Online Map Provider]({%slug radmap-features-providers-arcgis%})