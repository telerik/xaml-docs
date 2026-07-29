---
title: Property Accessor
page_title: Property Accessor
description: Check our &quot;Property Accessor&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-property-accessor
tags: property,accessor
published: True
position: 2
---

# Property Accessor

As it is described in the [Data Binding]({%slug radmap-visualization-layer-data-binding%}) article the Visualization Layer uses attached properties to position and display markers on their proper places. But evaluating data bindings and accessing values of properties from UI elements takes time and slows down the visualization engine. The Visualization Layer provides a way to speed up the accessing of the map related properties from the data item without involving the UI engine.     

You can do it using the `PropertyAccessor` property of the VisualizationLayer object. There are 2 ways you can use it:      

1. Use the default property accessor.          

2. Create your own class which implements the `IMapPropertyAccessor` interface.

>important Using this feature, the properties inside the DataTemplate need to be bound explicitly, such as the `MapLayer.Location` property. However, runtime changes to these properties are not guaranteed to immediately reflect in the UI. In such scenarios, you can call the `ResetItems` or `InvalidateArrange` methods of the `VirtualizationLayer` instance.

## Using the default property accessor

The visualization engine provides a default property accessor which uses heuristics to get map related properties from the data item.        

The default property accessor uses the following set of rules:        

1. The first property which is of the `Telerik.Windows.Controls.Map.Location` type will be considered as the geographical position of the item.
2. The first property which is of the `Telerik.Windows.Controls.Map.ZoomRange` type will be considered as the zoom range of the item.
3. The first property which is of the `Telerik.Windows.Controls.HotSpot` type will be considered as the hotspot definition of the item.

> If you have more than one property of those types, the one that is defined first will be used. 

4. The property which is named `BaseZoomLevel` and is of type double type will be considered as a base zoom level definition.
5. The property which is named `MaxScale` and is of type double type will be considered as max scale of the item.
6. The property which is named `MinScale` and is of type double type will be considered as min scale of the item.
7. The property which is named `ZIndex` and is of integer type will be considered as the Z-Index of the item.
            
If your business class satisfies these requirements you can use the default property accessor without any additional set-up. For example:        


<snippet id='radmap-features-visualization-layer-property-accessor-block_1-cs' />
<snippet id='radmap-features-visualization-layer-property-accessor-block_1-vb' />

If your data item is represented by this class then the default property accessor can be used. It will use properties as following:        

1. The Location property will be used as geographical position of the item.
2. The BaseZoomLevel property will be used as base zoom level definition.
3. The ZoomRange property will be used as zoom range definition.            

Since this class does not have `MaxScale`, `MinScale`, and `ZIndex` properties, the visualization engine will use default values for them.        

## Create your own class which implements the IMapPropertyAccessor interface

Sometimes the default property accessor is not applicable because of the data source. For example, your data source items (coming from a WCF Data Service or an Entity Framework model) could have different data types or use a different naming convention. In this case you can implement your own property accessor.        

First you should create a new class which implements the IMapPropertyAccessor interface. For example:        


<snippet id='radmap-features-visualization-layer-property-accessor-block_2-cs' />
<snippet id='radmap-features-visualization-layer-property-accessor-block_2-vb' />

Now you should assign to the `PropertyAccessor` property of the VisualizationLayer to an instance of the CustomPropertyAccessor type and set the `UseDefaultPropertyAccessor` property to false:        


<snippet id='radmap-features-visualization-layer-property-accessor-block_3-cs' />
<snippet id='radmap-features-visualization-layer-property-accessor-block_3-vb' />