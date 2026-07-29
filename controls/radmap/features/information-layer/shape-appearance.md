---
title: Shape Appearance
page_title: Shape Appearance
description: Check our &quot;Shape Appearance&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-shape-appearance
tags: shape,appearance
published: True
position: 5
---

# Shape Appearance

When using __MapShape__ objects there are several ways to control their appearance:

* [Using the trivial properties](#using-the-trivial-properties)

* [Using the MapShapeFill object on the control level](#using-the-mapshapefill-object-on-the-control-level)

* [Using the MapShapeFill object on the layer level](#using-the-mapshapefill-object-on-the-layer-level)

>tip Another way to define the appearance of the shapes inside a layer is to use the [Colorizer]({%slug radmap-features-colorizer%}) property of the InformationLayer.

>tip To learn more about the usage of shapes read the [Map Shapes]({%slug radmap-features-map-shapes%}) topic. The [KML Data Import]({%slug radmap-features-kml-data-import%}) and the [Shapefiles Support]({%slug radmap-features-shapefiles-support%}) topics might also be helpful to you.

## Using the trivial properties

In this approach you use the trivial properties provided by the framework such as __Fill__, __Stroke__, __StrokeThickness__.        

Here is an example:       


<snippet id='radmap-features-information-layer-shape-appearance-block_1-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap InformationLayer Ellipse Customization](images/RadMap_Features_ShapeAppearance_01.png)

## Using the MapShapeFill object on the control level

The __MapShape__ objects expose two specific properties - __ShapeFill__ and __HightlightFill__. The first one is applied to the shapes, when they are in their normal state. The __HighlightFill__ gets applied when the mouse is over the shape.

The two properties are of  type __MapShapeFill__. The __MapShapeFill__ object allows you not only to specify the Fill color, but to modify the stroke as well. Here is an example.

>These properties will take precedence over the trivial ones.


<snippet id='radmap-features-information-layer-shape-appearance-block_2-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap InformationLayer Shape with ShapeFill and HighlightFill](images/RadMap_Features_ShapeAppearance_02.png)

## Using the MapShapeFill object on the layer level

You are also able to define the appearance of the shapes on the Information Layer level. This way every shape, that doesn't have its respective properties explicitly set, will inherit the appearance specified for the layer. For this purpose use the __ShapeFill__ and __HighlightFill__ properties of the __InformationLayer__ class. The first one is applied to the shapes, when they are in their normal state. The __HighlightFill__ gets applied when the mouse is over the shape.

>These properties will __not__ take precedence over the properties set on the control level.

<!-- -->
>These values will get applied also on shapes that are created from [KML]({%slug radmap-features-kml-data-import%}) and [Shapefile]({%slug radmap-features-shapefiles-support%}) data and doesn't have their appearance explicitly set.

The two properties are of __MapShapeFill__ type. The __MapShapeFill__ object allows you not only to specify the fill color, but to modify the stroke as well. Here is an example:


<snippet id='radmap-features-information-layer-shape-appearance-block_3-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap InformationLayer with ShapeFill and HighlightFill](images/RadMap_Features_ShapeAppearance_03.png)

## See Also
 * [Colorizer]({%slug radmap-features-colorizer%})
 * [Shape Reader]({%slug radmap-features-information-layer-shape-reder%})
 * [Extended Data]({%slug radmap-features-extended-data%})