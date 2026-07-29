---
title: Colorizer
page_title: Colorizer
description: Check our &quot;Colorizer&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-colorizer
tags: colorizer
published: True
position: 9
---

# Colorizer

The __Colorizer__ feature of the __InformationLayer__ allows you to colorize the __MapShape__ objects inside it on the basis of a condition. This allows you to create maps that display shapes for each country with fill color depending on the population of the country.

In order to allow you to color the shapes depending on a condition, the __InformationLayer__ class exposes the __Colorizer__ property, which is of type __ColorMeasureScale__. This section will explain the usage of this object and its main features:

* [Using the ColorMeasureScale object](#using-the-colormeasurescale-object)

* [Extended Data Property](#extended-data-property)

* [Mode](#mode)

* [Colors](#colors)

* [Ranges](#ranges)

## Using the ColorMeasureScale object

To use the __ColorMeasureScale__ object in a layer, just set the __Colorizer__ property of the respective layer to a new instance of it. Here is an example:


<snippet id='radmap-features-information-layer-colorizer-block_1-xaml' />

## Extended Data Property

The __ColorMeasureScale__ object colors the __MapShape__ objects inside a layer on the basis of a value. This value should be specified through the __Extended Data__ for the __MapShape__ object. 

>tip The __Extended Data__ represents a set of properties and their respective values.

In order to specify the desired property from the __Extended Data__, you have to use the __ExtendedPropertyName__ property of the __ColorMeasureScale__ object. 

>The property specified through the __ExtendedPropertyName__ should be of type __double__.

Here is an example, in which the __MapShapes__ get colored depending on the value of their area:


<snippet id='radmap-features-information-layer-colorizer-block_2-xaml' />

## Mode

The __ColorMeasureScale__ splits the values passed through its __ExtendedPropertyName__ property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the __ColorMeasureScale__ object. It can have the following values:

* __Auto__

* __Count__ - specifies that the data will get split into __N__ equally sized ranges. The __N__ is equal to the value of the __TickMarkCount__ property of the __ColorMeasureScale__.

* __Step__ - specifies that the data will get split in ranges with step between them equal to __X__. The __X__ is equal to the value of the __TickMarkStep__ property of the __ColorMeasureScale__ object.

* __Ranges__ - specifies that the filling of the ranges will be calculated automatically by the __ColorMeasureScale__ colorizer.

* __RangesPredefinedColors__ - specifies that the __ColorMeasureScale__ colorizer will use filling settings which are set in the MapRange definition.

>tip When using the __InformationLayer__ object together with a __MapShapeReader__ object, the latter one automatically pass information about the __Min__ and __Max Values__ of the __ColorMeasureScale__. In this case you have to only use the __Mode__ and one of the two additional properties. When you are using manually generated shapes, you have to create the ranges manually. To learn more read the [Ranges](#ranges) section in this topic.

Here is an example of a __ColorMeasureScale__ with __7__ ranges:


<snippet id='radmap-features-information-layer-colorizer-block_3-xaml' />

When you are using the __Count__ mode you can extend the __ColorMeasureScale__ with the ability to specify the value ranges distribution. For the purpose the __RangeDistribution__ property is provided. You can choose between:

* __ExponentialRangeDistribution__ - creates exponential range distribution

* __LogarithmicRangeDistribution__ - creates logarithmic range distribution

The following example shows how to use the __ColorMeasureScale__ with __Ranges__ mode:


<snippet id='radmap-features-information-layer-colorizer-block_4-xaml' />

And the following demonstrates the __ColorMeasureScale__ with __RangesPredefinedColors__ mode:


<snippet id='radmap-features-information-layer-colorizer-block_5-xaml' />

## Colors

The __ColorMeasureScale__ can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the __ShapeFillCollection__ and __HighlightFillCollection__ properties. They are collections of __MapShapeFill__ objects.

>If you are creating the ranges manually, you can pass the __MapShapeFill__ object directly to the __MapRange__ object. To learn more read the [Ranges](#ranges) section.

Add the desired colors inside the collections and they will be applied in their respective order.

>The first color will get applied to the lowest layer. 

In case you have more ranges than colors, after reaching the last color in the collection, the others will get reused starting from the beginning. For example if you want to have the same highlight color for all of the ranges, you just define one entry in the __HighlightFillCollection__ property.

<snippet id='radmap-features-information-layer-colorizer-block_6-xaml' />

>important With the approach shown above any 2 shapes (even if they are neighbours) may be colored equally. To avoid this you should use the [GraphColorizer]({%slug radmap-features-graph-colorizer%})

## Ranges

The ranges for the __ColorMeasureScale__ can be defined in several different ways. The first one is by only using the __Mode__ and the __TickMarkCount__ or __TickMarkStep__ property. This approach is applicable when using the __InformationLayer__ object together with a __MapShapeReader__ object. Here is an example:

>tip To learn more about the __Mode__ property read the [Mode](#mode) section.


<snippet id='radmap-features-information-layer-colorizer-block_7-xaml' />

Another approach that extends the previous one is to handle the __PrepareCompleted__ event of the __ColorMeasureScale__ object in addition. This will allow you to modify the collection containing the ranges after the __ColorMeasureScale__ object has been prepared. In the event handler you can modify the __Min and Max Values__ of the existing ranges. Here is an example:


<snippet id='radmap-features-information-layer-colorizer-block_8-xaml' />


<snippet id='radmap-features-information-layer-colorizer-block_9-cs' />
<snippet id='radmap-features-information-layer-colorizer-block_9-vb' />

The next approach is to manually define the __Min__ and __Max Values__ of the __ColorMeasureScale__ object and to use the __Mode__ property together with the __TickMarkCount__ or __TickMarkStep__ property. This approach is useful, when having __InformationLayer__ that displays manually generated shapes. 

>Note that setting the __Min__ and __Max Values__ will make the __ColorMeasureScale__ behave as if it works with __MapShapeReader__. This means that you can still use the __HightlightFillCollection__ and __ShapeFillCollection__ properties.


<snippet id='radmap-features-information-layer-colorizer-block_10-xaml' />

In addition to the previous approach you can again use the __PrepareCompleted__ event. Additionally with the __Min__ and __Max Values__ defined you can directly define the desired ranges at design-time via the __RangeCollection__ property of the __ColorMeasureScale__ object. In this case you shouldn't use the __HighlightFillCollection__ and __ShapeFillCollection__ properties, as they are used only when the ranges are automatically generated. You have to specify the desired colors via the __HighlightFill__ and __ShapeFill__ properties of the __MapRange__ object. Here is an example.


<snippet id='radmap-features-information-layer-colorizer-block_11-xaml' />

## See Also
 * [Map Legend]({%slug radmap-features-map-legend%})
 * [Shape Appearance]({%slug radmap-features-shape-appearance%})
 * [Extended Data]({%slug radmap-features-extended-data%})