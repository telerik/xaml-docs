---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radmap-getting-started
tags: getting,started
published: True
position: 4
---

# Getting Started

The __RadMap__ control allows you to display rich geographical information from various sources, including Microsoft Bing Maps, as well as to overlay the map with your own custom data. This topic will help you to quickly get started using the control. It will focus on the following:      

* [Creating a RadMap](#creating-a-radmap)

* [Specifying a Provider](#specifying-a-provider)

* [Displaying Data](#displaying-data)

## Creating a RadMap

>In order to use __RadMap__ in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Data__
>	- __Telerik.Windows.Controls.DataVisualization__  
>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).            

After adding references to the aforementioned dlls, you can declare a new __RadMap__ as any normal Silverlight/WPF control.
        

#### __XAML__
{{region radmap-getting-started_1}}
    <telerik:RadMap x:Name="radMap" />
{{endregion}}

## Specifying a Provider

The __RadMap__ control doesn't display a map on itself, it needs a map provider from which to consume the required data. Currently the __RadMap__ control supports a few providers out of the box:        

* __Bing Maps (with SOAP and Rest)__

* __OpenStreet Maps__

* __ArcGIS Online__

* __WMS__

* __Empty Provider__

* __URI Image provider__

This example will use __Bing Maps__ as its provider. In order to do that you have to set the __Provider__ property of the __RadMap__ to the built-in __BingMapProvider__ class.        

#### __XAML__
{{region radmap-getting-started_4}}
	<telerik:RadMap x:Name="radMap">
	    <telerik:RadMap.Provider>
	        <telerik:BingMapProvider ApplicationId="AqaPuZWytKRUA8Nm5nqvXHWGL8BDCXvK8onCl2PkC581Zp3T_fYAQBiwIphJbRAK"
	                                 Mode="Aerial"
	                                 IsLabelVisible="True"/>
	    </telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region radmap-getting-started_2}}
	this.radMap.Provider = new BingMapProvider( MapMode.Aerial, true, "key" );
{{endregion}}

#### __VB.NET__
{{region radmap-getting-started_3}}
	Me.radMap.Provider = New BingMapProvider(MapMode.Aerial, True, "key")
{{endregion}}

Using the third overload of the __BingMapProvider's__ constructor, allows you to pass some starting parameters:        

* the starting view mode of the map - aerial.

* the visibility of the map labels - visible.

* a __Bing Maps__ specific key.            

>In order to use the __Bing Maps__ with the __RadMap__ control, you have to provide a valid __Bing Maps Key__. To learn how to obtain such a key, read [this topic](http://msdn.microsoft.com/en-us/library/ee681900.aspx). Note that the __Bing Map won't__ __appear__ in your __RadMap__ control, without supplying the key.          

After specifying the provider, you should be able to see the respective map appear in the __RadMap__ control.

![](images/RadMap_GettingStarted_01.png)

## Displaying Data

You are able to display data on the top of the visualized map. The data may be represented by any framework element or map shape objects. This can be accomplished via the __RadMap's__ layers.        

There are two visualization engines in the RadMap package:

* The old implementation of the map objects' (points and shapes) visualization consists of three layers: __InformationLayer__, __DynamicLayer__ and __VirtualizationLayer__. This visualization engine, however, lacks certain features and has a few performance issues.            

* In the __Q2 2013__ release we introduced a new visualization engine in the RadMap. It has been designed from scratch to have better performance. The new visualization engine replaces all three layers with the new __VisualizationLayer__.            

The major goals of the new engine are:        

* Improve the performance of the data visualization.

* Allow reading map shapes from different sources (KML, ESRI, and SQL Geospatial) in the background thread.

* Integrating clustering and items virtualization into the core. This simplifies the usage of both features.

* Ability to attach/detach almost any input event available for the FrameworkElement to the map shape visualization.

* Support of items selection in the engine core.

To learn more about the layers and how to display the different types of elements in them, please read the [Visualization layer]({%slug radmap-visualization-layer-introduction%}) section.