---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-data-binding
tags: data,binding
published: True
position: 1
---

# Data Binding

When displaying a map, you might also want to overlay some additional information. As we've previously seen (in the [Introduction]({%slug radmap-visualization-layer-introduction%}) help topic) we can define this information statically in XAML. However, it would be much more practical to use the `VisualizationLayer`'s data binding capabilities to dynamically load and display map markers.

The `VisualizationLayer` simulates functionality of the `ItemsControl` class so in order to display your map data dynamically you just have to treat the layer as a typical items control. This means you have to use its `ItemsSource` and `ItemTemplate` properties. You can also make a use of the `ItemTemplateSelector` property, in order to implement advanced visualization depending on the data item.        

When using a custom visual in the `ItemTemplate` of the layer, there are several attached properties that can be used to position and display the marker on its proper place:

* `MapLayer.Location`&mdash;Represents the latitude and the longitude of the map point.            

* `MapLayer.BaseZoomLevel`&mdash;Represents the zoom level, for which the element should have its scale transformation equal to 1.            

* `MapLayer.ZoomRange`&mdash;Represents the range of zoom levels for which the element should be visible.            
  
* `MapLayer.MinScale`&mdash;Represents minimum scale factor which will be applied to the framework element when it has `BaseZoomLevel` property set and we zoom out map control.            
  
* `MapLayer.MaxScale`&mdash;Represents maximum scale factor which will be applied to the framework element when it has `BaseZoomLevel` property set and we zoom in map control.            

In order to provide the needed data to the visualization layer, you have to create a collection of business objects, which represent the desired data. The following example shows how to do this.        

__Defining the item model__
<snippet id='radmap-features-visualization-layer-data-binding-block_1-cs' />
<snippet id='radmap-features-visualization-layer-data-binding-block_1-vb' />

>important You can notice that the business class implements the `INotifyLocationChanged` interface. This is necessary in order to properly support runtime changes of the `Location` property.

__Defining the ItemTemplate and binding the attached properties__
<snippet id='radmap-features-visualization-layer-data-binding-block_2-xaml' />

__Setting up the items source__
<snippet id='radmap-features-visualization-layer-data-binding-block_3-cs' />
<snippet id='radmap-features-visualization-layer-data-binding-block_3-vb' />