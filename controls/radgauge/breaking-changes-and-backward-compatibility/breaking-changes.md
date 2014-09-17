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

1. We introduced several changes so that some of the gauge properties now support both absolute measurements and relative measurements.
      These properties accept XAML notation which is similar to the one used for RowDefinition.Height property of Grid. For example:
 

1. 

LabelOffset=”12” sets label offset to 12 pixels.

1. 

LabelOffset=”0.1*” sets label offset to the 0.1 of the scale relative measurements (in the current implementation it looks like LabelOffset=”0.1”)

LabalOffset=”1*” means that tick labels will be shifted from the label location to the full cell size.
 For example, if radial gauge has size 300x300 pixels then labels will be shifted to 300 pixels from their original location. 
 This change affects following properties of the gauge objects:


1. 

GaugeRangeGroup.Offset

1. 

GraphicScale.LabelOffset

1. 

GraphicScale.MajorTickOffset

1. 

GraphicScale.MiddleTickOffset

1. 

GraphicScale.MinorTickOffset

1. 

GraphicScale.RangeOffset



The next big change we made is also related to the __ScaleObject.RelativeWidth__ and __ScaleObject.RelativeHeight__ attachable properties.
 They have been changed to accept a new data type - GaugeMeasure instead of double. GaugeMeasure will have behavior similar to the one used for RowDefinition.Height property of Grid, i.e. it will support both absolute measurements and relative measurements.
 So width and height of any scale object can be set in pixels as well as in the relative units.
 This change affects following properties of the gauge objects:
 

1. 

GraphicScale.MajorTickRelativeHeight

1. 

GraphicScale.MajorTickRelativeWidth

1. 

GraphicScale.MiddleTickRelativeHeight

1. 

GraphicScale.MiddleTickRelativeWidth

1. 

GraphicScale.MinorTickRelativeHeight

1. 

GraphicScale.MinorTickRelativeWidth
For example:
 

1. 

MajorTickRelativeHeight=”12” sets major tick height to 12 pixels.

1. 

MajorTickRelativeHeight =”0.1*” sets major tick height to the 0.1 of the scale relative measurements (in the current implementation it looks like MajorTickRelativeHeight =”0.1”).

1. 


 We added 10 new classes for the scales:


1. HorizontalLinearScale

1. VerticalLinearScale

1. QuadrantNEScale

1. QuadrantNWScale

1. QuadrantSEScale

1. QuadrantSWScale

1. SemicircleEastScale

1. SemicircleNorthScale

1. SemicircleSouthScale

1. SemicircleWestScale

The #1 and #2 should be used to create correspondent horizontal and vertical linear scale. The #3-#6 should be used to create quadrant-style radial gauges. The #7-#10 should be used to create semicircle radial gauges.
 Any scale object can be used in any gauge container. For example, you can put 4 quadrant-style scales into 1 full-circle radial gauge.

## Q3 2011


          A new Gauge control was designed from scratch. Some of its features are similar to the old control’s features but they are implemented in absolutely different way (using different set of properties), while some features are completely new.
        

The most significant top level changes are presented below: 

1. 
               There is no top level RadGauge control anymore. The top level containers are represented by the following classes:
                  

1. __RadRadialGauge__

1. __RadQuadrantNEGauge__

1. __RadQuadrantNWGauge__

1. __RadQuadrantSEGauge__

1. __RadQuadrantSWGauge__

1. __RadSemicircleEastGauge__

1. __RadSemicircleWestGauge__

1. __RadSemicircleNorthGauge__

1. __RadSemicircleSouthGauge__

1. __RadHorizontalLinearGauge__

1. __RadVerticalLinearGauge__

1. 
            There is no RadialGauge control. There are 9 controls which represents 1 full circle gauge (1.a), 4 quadrant-style radial gauges (1.b - 1.e), 4 semicircle gauges (1.f – 1.i).
          

1. 
            There is no LinearGauge control. There are 2 controls: one represents horizontal linear gauge (1.j) and second represents vertical linear gauge (1.k).
          

1. 
            There is no IndicatorList control anymore. Indicators should be placed into the Indicators property of the scale object.
          

1. 
            There is no RadialRange and LinearRange controls anymore. Ranges are represented by GaugeRange class.
          

1. 
            There is no RangeList control anymore. Ranges should be placed into the Ranges property of the scale object.
          
