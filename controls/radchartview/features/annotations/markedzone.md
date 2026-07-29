---
title: MarkedZone Annotations
page_title: MarkedZone Annotations
description: Check our &quot;MarkedZone Annotations&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-annotations-markedzone
tags: markedzone,annotations
published: True
position: 5
---

# MarkedZone Annotations

The __CartesianMarkedzoneAnnotation__ is a rectangle defined by the __HorizontalFrom/To__ and __VerticalFrom/To__ properties.

 ![Rad Chart View-annotations-cartesian-markedzone-0](images/RadChartView-annotations-cartesian-markedzone-0.png)

## Properties

Besides the __HorizontalFrom/To__ and __VerticalFrom/To__ properties that are used for defining the rectangle, the __CartesianMarkedzoneAnnotation__ exposes the following properties:        

* __HorizontalAxis__ and __VerticalAxis__ Used for assosiating the annotation with the chart axes.            

>By default the annotation is associated with the __RadCartesianChart.HorizontalAxis__ and __RadCartesianChart.VerticalAxis__ axes, so it is not necessary to  specify these properties. They are usually used in a multiple axis scenarios.              

* __Fill__ Specifies the fill of the marked zone.            

* __DashArray__ A collection of System.Double values that indicate the pattern of dashes and gaps that is used to outline the border of the marked zone.            

* __Stroke__ Specifies the stroke of the marked zone.            

* __StrokeThickness__ Specifies the stroke thickness of the marked zone.            

## Examples

A __CartesianMarkedZoneAnnotation__ is defined like this:        



<snippet id='radchartview-features-annotations-markedzone-block_1-xaml' />


By default, the __Fill__ of the MarkedZone is *#598EC441* and the __Stroke__ is not set. You can see this in the first CartesianMarkedZoneAnnotation declaration.        

The second declaration shows that you can use the __DashArray__ property to create an interesting Stroke pattern.        

The last example in the above code snippet shows that you can use the __ZIndex__ property to place an annotation behind the ChartSeries (by default annotations are placed in front of the ChartSeries). 

![Rad Chart View-annotations-cartesian-markedzone-1](images/RadChartView-annotations-cartesian-markedzone-1.png)

The flexible design of the MarkedZone annotation allows the user to omit one (or more) of the four Horizontal/VerticalFrom/To properties. The following table details relationship between the specified properties and the occupied interval on the axis: 
![Rad Chart View-annotations-cartesian-markedzone-2](images/RadChartView-annotations-cartesian-markedzone-2.png)



<snippet id='radchartview-features-annotations-markedzone-block_2-xaml' />


In this example the MarkedZone takes the space between 0.5 and 1 on the vertical axis and between -infinity and 2.75 on the horizontal axis.

![Rad Chart View-annotations-cartesian-markedzone-3](images/RadChartView-annotations-cartesian-markedzone-3.png)

In addition to the possibility of not specifying one (or more) the four properties, the annotation also supports inverse axes. The combination of these factors produces 64 possible scenarios!
        



<snippet id='radchartview-features-annotations-markedzone-block_3-xaml' />


In this example last you can see that Cateogrical axes are also supported, adding to the versatile feature set of __CartesianMarkedzoneAnnotation__.
![Rad Chart View-annotations-cartesian-markedzone-4](images/RadChartView-annotations-cartesian-markedzone-4.png)  