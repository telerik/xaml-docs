---
title: Changes
page_title: Changes
description: Changes
slug: radchartview-changes
tags: changes
publish: True
position: 0
---

# Changes



This article lists the __new features__ added to __RadChartView__

## Q1 2014

### What's Fixed

* BarSeries with Stack CombineMode are rendered incorrectly when all DataPoints have zero Value

* DateTimeContinuousAxis produces too many labels when zoom in to the max and then zoomed out with double clicking the slider

* Stroke property of LineSeries does not override palette color when set in style

* Light renderer sometimes leaves an empty pixel between two adjacent lines

* GetDataPointVisual method returns recycled containers.

* Doughnut slices don't explode on mouse click

* ScatterPoint visual elements are doubled when PointSize is changed

* Bar width is not recalculated on zoom with DateTimeContinuousAxis axis

* Annotations are positioned incorrectly when zooming on a DateTimeContinuousAxis

### What's New

* Introduce Direct2D Rendering for ChartView

* Introduce light rendering for all series

* Introduce DefaultVisualStyleSelector

* Implement TickOrigin for LinearAxis

## Q3 2012

* Added LineSeries.RenderMode property

* SeriesRenderMode.Full (default) - the current rendering mechanism is used
                

* SeriesRenderMode.Light - a new, faster rendering is used, which allows instant rendering of tens of thousands of points
                

* Added [annotations](#216ade21-083f-49ce-8d99-2b1f6bb0b405) support for RadCartesianChart and RadPolarChart
            

* CartesianGridLineAnnotation – allows you to place custom gridline associated with a specific axis in RadCartesianChart
                

* CartesianPlotBandAnnotation – allows you to place custom plot band (marked zone, stripe) associated with a specific axis in RadCartesianChart
                

* CartesianCustomAnnotation – allows you to place custom content associated with specific horizontal and vertical axes in RadCartesianChart
                

* PolarAxisGridLineAnnotation – allows you to place custom gridline associated with the polar axis in RadPolarChart
                

* PolarAxisPlotBandAnnotation – allows you to place custom plot band (marked zone, stripe) associated with the polar axis in RadPolarChart
                

* RadialAxisGridLineAnnotation – allows you to place custom gridline associated with the radial axis in RadPolarChart
                

* RadialAxisPlotBandAnnotation – allows you to place custom plot band (marked zone, stripe) associated with the radial axis in RadPolarChart
                

* PolarCustomAnnotation – allows you to place custom content in RadPolarChart.
                

* Added touch support

* Exposed public API  for conversion from physical to data units for RadCartesianChart and RadPolarChart 
              (i.e. point physically located at [x,y] coordinates in the drawing canvas, represents data value 400)
            

* RadCartesianChart.ConvertPointToData(point)
                

* RadCartesianChart.ConvertPointToData(point, horizontalAxis, verticalAxis)
                

* RadPolarChart.ConvertPointToData(point)
                

* Added DoughnutSeries type
            

* Added RangeBarSeries type
            

* Added RangeSeries type
            

# See Also

 * [Backward Compatibility]({%slug radchartview-changes%})
