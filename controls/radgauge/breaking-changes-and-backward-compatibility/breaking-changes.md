---
title: Breaking Changes
page_title: Breaking Changes
description: Breaking Changes
slug: radgauge-breaking-changes
tags: breaking,changes
published: True
position: 1
---

# Breaking Changes



## Q2 2012

1. We introduced several changes so that some of the gauge properties now support both absolute measurements and relative measurements. These properties accept XAML notation which is similar to the one used for RowDefinition.Height property of Grid. For example:
    1. LabelOffset=”12” sets label offset to 12 pixels.
    2. LabelOffset=”0.1*” sets label offset to the 0.1 of the scale relative measurements (in the current implementation it looks like LabelOffset=”0.1”)

LabalOffset=”1*” means that tick labels will be shifted from the label location to the full cell size. For example, if radial gauge has size 300x300 pixels then labels will be shifted to 300 pixels from their original location. This change affects following properties of the gauge objects:

1. GaugeRangeGroup.Offset
2. GraphicScale.LabelOffset
3. GraphicScale.MajorTickOffset
4. GraphicScale.MiddleTickOffset
5. GraphicScale.MinorTickOffset
6. GraphicScale.RangeOffset

The next big change we made is also related to the __ScaleObject.RelativeWidth__ and __ScaleObject.RelativeHeight__ attachable properties. They have been changed to accept a new data type - GaugeMeasure instead of double. GaugeMeasure will have behavior similar to the one used for RowDefinition.Height property of Grid, i.e. it will support both absolute measurements and relative measurements. So width and height of any scale object can be set in pixels as well as in the relative units. This change affects following properties of the gauge objects:

1. GraphicScale.MajorTickRelativeHeight
2. GraphicScale.MajorTickRelativeWidth
3. GraphicScale.MiddleTickRelativeHeight
4. GraphicScale.MiddleTickRelativeWidth
5. GraphicScale.MinorTickRelativeHeight
6. GraphicScale.MinorTickRelativeWidth

For example:
1. MajorTickRelativeHeight=”12” sets major tick height to 12 pixels.
2. MajorTickRelativeHeight =”0.1*” sets major tick height to the 0.1 of the scale relative measurements (in the current implementation it looks like MajorTickRelativeHeight =”0.1”).

__2.__ We added 10 new classes for the scales:
1. HorizontalLinearScale
2. VerticalLinearScale
3. QuadrantNEScale
4. QuadrantNWScale
5. QuadrantSEScale
6. QuadrantSWScale
7. SemicircleEastScale
8. SemicircleNorthScale
9. SemicircleSouthScale
10. SemicircleWestScale

The #1 and #2 should be used to create correspondent horizontal and vertical linear scale. The #3-#6 should be used to create quadrant-style radial gauges. The #7-#10 should be used to create semicircle radial gauges. Any scale object can be used in any gauge container. For example, you can put 4 quadrant-style scales into 1 full-circle radial gauge.

## Q3 2011

A new Gauge control was designed from scratch. Some of its features are similar to the old control’s features but they are implemented in absolutely different way (using different set of properties), while some features are completely new.

The most significant top level changes are presented below: 

1. There is no top level RadGauge control anymore. The top level containers are represented by the following classes:
    1. __RadRadialGauge__
    2. __RadQuadrantNEGauge__
    3. __RadQuadrantNWGauge__
    4. __RadQuadrantSEGauge__
    5. __RadQuadrantSWGauge__
    6. __RadSemicircleEastGauge__
    7. __RadSemicircleWestGauge__
    8. __RadSemicircleNorthGauge__
    9. __RadSemicircleSouthGauge__
    10. __RadHorizontalLinearGauge__
    11. __RadVerticalLinearGauge__
2. There is no RadialGauge control. There are 9 controls which represents 1 full circle gauge (1.a), 4 quadrant-style radial gauges (1.b - 1.e), 4 semicircle gauges (1.f – 1.i).
3. There is no LinearGauge control. There are 2 controls: one represents horizontal linear gauge (1.j) and second represents vertical linear gauge (1.k).
4. There is no IndicatorList control anymore. Indicators should be placed into the Indicators property of the scale object.
5. There is no RadialRange and LinearRange controls anymore. Ranges are represented by GaugeRange class.
6. There is no RangeList control anymore. Ranges should be placed into the Ranges property of the scale object.
