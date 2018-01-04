---
title: Imagery sets
page_title: Imagery sets
description: This article described the BingRestMapProvdider imagery sets.
slug: radmap-features-providers-bing-rest-map-modes
tags: bing,map,provider,rest,mode,road,birdseye,canvaslight,canvasdark,canvasgray, aerialondemand, roadondemand,ondemand
published: True
position: 4
---

# Imagery sets

The Bind Maps Rest Provider imagery service support different types of visualization. The possible imagery set which can be used are:
* [__Aerial with labels__](#aerial-mode-with-labels)
* [__Aerial without labels__] (#aerial-mode-without-labels)
* [__AerialOnDemand__](#aerialondemand-mode)
* [__Road__](#road-mode)
* [__RoadOnDemand__] (#roadondemand-mode)
* [__Birdseye__] (#birdseye-mode)
* [__CanvasLight__] (#canvaslight-mode)
* [__CanvasGray__](#canvasgray-mode)
* [__CanvasDark__] (#canvasdark-mode)

To choose a different imagery set, we can set the __Mode__ property of the __BingRestMapProvider__.

#### __[XAML] Example 1: Setting Mode property in XAML__
{{region xaml-radmap-features-providers-bing-rest-map-modes_1}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider x:Name="bingRestMapProvider" ApplicationId="Bing_Map_Key" Mode="Aerial"/>
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

The __CanvasLight, CanvasDark, CanvasGray, AerialOnDemand, RoadOnDemand__ are not added to the toolbar of the control by default. To add them to the map view mode commands bar, we can use the __RegisterSetSourceCommand()__ method of __BingRestMapProvider__.

#### __[XAML] Example 2: Adding CanvasGray mode to the view mode commands bar__
{{region xaml-radmap-features-providers-bing-rest-map-modes_2}}
	public MainWindow()
	{
		InitializeComponent();
		this.bingRestMapProvider.RegisterSetSourceCommand(MapMode.CanvasGray, LocalizationManager.GetString("MapCanvasGrayCommand"));
	}
{{endregion}}

You can remove specific imagery set from the map view mode commands bar, by removing them from the Commands collection of the __BingRestMapProvider__.

#### __[XAML] Example 3: Remove mode from the view mode commands bar__
{{region xaml-radmap-features-providers-bing-rest-map-modes_3}}
	public MainWindow()
	{
		InitializeComponent();
		this.bingRestMapProvider.Commands.RemoveAt(0);
	}
{{endregion}}

## Aerial mode with labels

This mode offers worldwide orthographic aerial and satellite imagery. The labels in this mode are enabled by default.

#### __Figure 1: Aerial mode with labels__
	
![Rad Map Features Rest Providers 01 with labels](images/RadMap_Features_Rest_Providers_AerialWithLabels.png)	

## Aerial mode without labels

You can the disable labels using the __IsLabelVisible__ property. When you set it to *False* the labels disappear. __Figure 2__ is a snapshot of the Aerial mode for Bing Map Rest Provider when the labels are not visible.

#### __Figure 2: Aerial mode without labels__
![Rad Map Features Rest Providers 01 nolabels](images/RadMap_Features_Rest_Providers_Aerial.png)

## AerialOnDemand mode

This imagery set represent Aerial imagery with on-demand road overlay.

#### __Figure 3: AerialOnDemand mode__
![Rad Map Features Rest Providers 01 with labels](images/RadMap_Features_Rest_Providers_AerialWithLabels.png)

## Road mode

The road imagery type is a set of static tile server. The tiles are generated ahead of time and then stored and served. The *Road* mode of Bing Maps ignores the __IsLabelVisible__ property. For this mode the labels are displayed always. __Figure 4__ is an example of the __Road Mode__ definition.

#### __Figure 4: Road mode__
![Rad Map Features Rest Providers 01 road](images/RadMap_Features_Rest_Providers_Road.png)	

## Birdseye mode

The __Bing Map Rest Provider__ also supports the *Birdseye* mode. This mode can be used for high resolution levels only (zoom level 19-20)        

>The __Birdseye__ mode does not provide the tile images for all regions around the world. Some regions have not images for Birdseye mode.          

Here is an example of the __Birdseye Mode__ definition:

#### __Figure 5: Birdseye mode__
![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Providers_BingMap_Birdseye.png)

## RoadOnDemand mode

The road on demand imagery type provides the same map tiles used in the latest Bing maps controls. These tiles are generated on the fly as needed and are the most up to date road maps. 

#### __Figure 6: RoadOnDemand mode__
![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Rest_Providers_RoadOnDemand.png)

## CanvasLight mode

A light version of the road maps which provides neutral background  with minimal colors, labels and features.

#### __Figure 7: CanvasLight mode__
![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Rest_Providers_CanvasLight.png)

## CanvasGray mode

A gray version of the road maps which provides neutral background with minimal colors, labels and features.

#### __Figure 8: CanvasGray mode__
![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Rest_Providers_CanvasGray.png)

## CanvasDark mode

A dark version of the road maps which provides neutral background with minimal colors, labels and features.

#### __Figure 8: CanvasDark mode__	
![Rad Map Features Providers Bing Map Birdseye](images/RadMap_Features_Rest_Providers_CanvasDark.png)

## See Also
 * [Providers Overview]({%slug radmap-features-providers%})
 * [ArcGIS Online Map Provider]({%slug radmap-features-providers-arcgis%})