---
title: Items Virtualization
page_title: Items Virtualization
description: Check our &quot;Items Virtualization&quot; documentation article for the RadMap  control.
slug: radmap-visualization-layer-virtualization
tags: items,virtualization
published: True
position: 7
---

# Items Virtualization

There are numerous scenarios where large number of items should be visualized on the map surface. Using large data source within the visualization layer can decrease the overall performance of the map control, especially the initial loading and the performance during zooming or panning. This is why the visualization layer API supports __UI Virtualization__, which processes information only inside the current viewport of the RadMap thus boosting the initial loading and the overall performance of the control.      

## Properties

The __VisualizationLayer__ exposes the following properties:        

* __RenderWhileMotion__: А property of type bool that gets or sets a value indicating whether the layer should request and render items while the user is zooming or panning.            

* __VirtualizationSource__: А property of type __IMapVirtualizationSource__ that gets or sets the item source of the layer.            

* __ZoomLevelGridList__: А property of type __ZoomLevelGridCollection__ that gets the collection of __ZoomLevelGrids__ used to specify the map division.            

If both __VirtualizationSource__ and __ZoomLevelGridList__ properties are set then the __VisualizationLayer__ switches to use UI Virtualization. When this feature is enabled the layer doesn’t take its items from the __ItemsSource__ property. Instead, it raises an items request event when the __ZoomLevel__ or __Center__ properties of the __RadMap__ control are changed.        

## Map Division

The __VisualizationLayer__ needs the map surface to be divided into regions. The division can be defined using the __VisualizationLayer.ZoomLevelGridList__ collection. Each __ZoomLevelGrid__ should define a minimum zoom level for its division. The maximum zoom level for a grid is the minimum zoom level of the next grid in the list.        

The __ZoomLevelGrid__ exposes the following properties:        

* __CellWidth__: A property of type __int__ that gets or sets the width of the cell in pixels.            

* __CellHeight__: A property of type __int__ that gets or sets the height of the cell in pixels.            

* __MinZoom__: A property of type __int__ that gets or sets the minimum zoom.            

By default the cell has a size which equals the size of tile (256x256) which is usually used by the map providers like AzureMapProvider and OpenStreetMapProvider. Specifying the size of а cell for the zoom level affects a number of requests to a __Virtualization Source__ which is depended on the viewport size of the map.        

>important If the requests are performed slowly (for example they use a service which has low performance) you can increase the cell size to lower the number of requests.          
    
__Example 1: Virtualization Layer declaration__
<snippet id='radmap-features-visualization-layer-virtualization-block_1-xaml' />

## Virtualization Source

The data provided to the __VisualizationLayer__ should be wrapped in a class that implements the __IMapItemsVirtualizationSource__ interface. This interface contains a __MapItemsRequest__ method, which is used by the __VisualizationLayer__ to request new data whenever the __ZoomLevel__ or __Center__ properties of the __RadMap__ control are changed. The number of requests depends on the number of the grid cells visualized in the current viewport of the control. Below you can see examples of different viewports.        

If the cell size is 256x256 pixels (the default one) and there are 9 cells in the viewport of the control - 9 requests will be sent to the virtualization source whenever this geographical region comes into the view.
![Rad Map visualization layer virtualization](images/RadMap_visualization_layer_virtualization.png)

In this case only 6 requests will be sent to the virtualization source whenever this geographical region comes into the view.
![Rad Map visualization layer virtualization 2](images/RadMap_visualization_layer_virtualization_2.png)

__Example 2__ desmonstrate how to implement simple virtualization source.

__Example 2: Create custom IMapItemsVirtualizationSource__
<snippet id='radmap-features-visualization-layer-virtualization-block_2-cs' />
<snippet id='radmap-features-visualization-layer-virtualization-block_2-vb' />

Here is a sample of the __VisualizationLayer__ declaration with UI Virtualization enabled:        

__Example 3: Setting custom IMapItemsVirtualizationSource in XAML__
<snippet id='radmap-features-visualization-layer-virtualization-block_3-xaml' />

>When there are no __ZoomLevelGrids__ that satisfy the current zoom level, no request will be made. Also, when the changed value of the zoom level or the region stays in the range of a __ZoomLevelGrid__ or one of its cells, no request is made.          

In the above sample, for example, when the __ZoomLevel__ is 1 or 2, no requests will be made, because there is no grid which represents this range. When the value is bigger than 9, requests will be made only when the grid cell changes, because the grid is defined for the range from 9 to the maximum zoom level.        

In the snapshots below you can see how the above example will be displayed with different __ZoomLevel__ settings        

The result at ZoomLevel 3:
![radmap-visualization-layer-virtualization](images/radmap-visualization-layer-virtualization.png)

The result at ZoomLevel 9:
![radmap-visualization-layer-virtualization-zoomed](images/radmap-visualization-layer-virtualization-zoomed.png)

## See Also
 * [Shape Appearance]({%slug radmap-visualization-layer-shape-appearance%})
 * [Map Shape Data]({%slug radmap-visualization-layer-map-shape-data%})