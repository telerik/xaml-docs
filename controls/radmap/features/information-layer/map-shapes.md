---
title: Map Shapes
page_title: Map Shapes
description: Check our &quot;Map Shapes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-map-shapes
tags: map,shapes
published: True
position: 3
---

# Map Shapes

The __RadMap__ control provides you with a set of shape objects, which are specifically designed to work with the __RadMap__. You will be able to find equivalents to most of the __Shapes__ introduced in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}.

>tip To learn the different ways of specifying the appearance colors of a shape read the [Shape Appearance]({%slug radmap-features-shape-appearance%}) topic.

>tip The __MapShape__ objects allow you to attach additional data to them. This is done via their __ExtendedData__ property. To learn more about it read [this topic]({%slug radmap-features-extended-data%}).

As the shapes are used identical to their counterparts, this topic will focus briefly on showing you how to use the most important of them:

* [MapLine](#mapline)

* [MapRectangle](#maprectangle)

* [MapEllipse](#mapellipse)

* [MapPolyline](#mappolyline)

* [MapPolygon](#mappolygon)

* [MapPath](#mappath)

The __MapShape__ class gives you the ability to specify caption for your Shapes using the __CaptionLocation__ and __CaptionTemplate__ properties. For example see __MapPolygon__ below. 

## MapLine

The most important things when using the __MapLine__ object are the __Point1__ and __Point2__ properties, which are of type __Location__. They define the start and the end points of the line. Here is an example.


<snippet id='radmap-features-information-layer-map-shapes-block_1-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Line](images/RadMap_Features_MapShapes_01.png)

## MapRectangle

To use the __MapRectangle__ in your __RadMap__ you have to set the following of its properties:

* __Location__ - represents the location on the map, to which the rectangle is bound.

* __Width__ - represents the width of the rectangle in the current distance unite (mile or kilometer), e.g. 1 is equal to 1km.

* __Height__ - represents the height of the rectangle in the current distance unite (mile or kilometer), e.g. 1 is equal to 1km.

>tip In order to change the distance unit, you have to set the __DistanceUnit__ property of the __RadMap__ to the desired value - __Mile__ or __Kilometer__.

Additionally you can use the following properties:

* __RadiusX__, __RadiusY__ - represent the radius of the rectangle corners. Just like the __Width__ and __Height__ properties, these are also measured in the current distance unit.

>Note that the top left coner coincides with the given location. In order to position the rectangle otherwise you might want to use the [HotSpot]({%slug radmap-features-hot-spots%}) feature.

Here is an example:


<snippet id='radmap-features-information-layer-map-shapes-block_2-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Rectangle](images/RadMap_Features_MapShapes_02.png)

## MapEllipse

To use the __MapEllipse__ in your __RadMap__ you have to set the following of its properties:

* __Location__ - represents the location on the map, to which the rectangle is bound.

* __Width__ - represents the width of the ellipse in the current distance unite (mile or kilometer), e.g. 1 is equal to 1km.

* __Height__ - represents the height of the ellipse in the current distance unite (mile or kilometer), e.g. 1 is equal to 1km.

>tip In order to change the distance unit, you have to set the __DistanceUnit__ property of the __RadMap__ to the desired value - __Mile__ or __Kilometer__.

>Note that the top left coner coincides with the given location. In order to position the rectangle otherwise you might want to use the [HotSpot]({%slug radmap-features-hot-spots%}) feature.

Here is an example:


<snippet id='radmap-features-information-layer-map-shapes-block_3-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Ellipse](images/RadMap_Features_MapShapes_03.png)

## MapPolyline

The only difference between the standard __Polyline__ and the __MapPolyline__ is that the __Points__ property of the __MapPolyline__ is a set of __Locations__. Here is an example:


<snippet id='radmap-features-information-layer-map-shapes-block_4-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Polyline](images/RadMap_Features_MapShapes_04.png)

## MapPolygon

The only difference between the standard __Polygon__ and the __MapPolygon__ is that the __Points__ property of the __MapPolygon__ is a set of __Locations__. Here is an example:


<snippet id='radmap-features-information-layer-map-shapes-block_5-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Polygon](images/RadMap_Features_MapShapes_05.png)

## MapPath

Except the __MapPath__ class you also have an analog for each standard __Geometry__ or __Segment__ class. Here is an example of an __MapPath__ that uses __MapArcSegments.__


<snippet id='radmap-features-information-layer-map-shapes-block_6-xaml' />

![{{ site.framework_name }} RadMap InformationLayer Map Path](images/RadMap_Features_MapShapes_06.png)

## See Also
 * [Information Layer]({%slug radmap-features-information-layer%})
 * [Framework Elements]({%slug radmap-features-information-layer-framework-elements%})
 * [Pin Points]({%slug radmap-features-information-layer-pin-points%})
 * [Hot Spots]({%slug radmap-features-hot-spots%})