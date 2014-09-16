---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radchartview-changes-backward-compatibility
tags: backward,compatibility
publish: True
position: 1
---

# Backward Compatibility



This article describes the __breaking changes__ introduced in __RadChartView__.
      

## 
        Q1 2014
      

__Changed__

* Telerik.Windows.Controls.ChartView.AreaSeriesStrokeMode namespace changed to Telerik.Charting.AreaSeriesStrokeMode.
            

__What to do now:__

Use the Telerik.Charting.AreaSeriesStrokeMode namespace instead.
        



__Changed__

* Telerik.Windows.Controls.ChartView.RangeSeriesStrokeMode namespace changed to Telerik.Charting.RangeSeriesStrokeMode.
            

__What to do now:__

Use the Telerik.Charting.RangeSeriesStrokeMode namespace instead.
        



__Changed__

* Telerik.Windows.Controls.ChartView.StepSeriesRisersPosition namespace changed to Telerik.Charting.StepSeriesRisersPosition
            

__What to do now:__

Use the Telerik.Charting.StepSeriesRisersPosition namespace instead.
        



__Changed__

* LineSeries.RenderMode is now marked as Obsolete. 
            

__What to do now:__

Use the LineSeries.RenderOptions property instead.
        



__Changed__

* PointSeries.RenderMode is now marked as Obsolete. 
            

__What to do now:__

Use the PointSeries.RenderOptions property instead.
        



__Changed__

* ScatterPointSeries.RenderMode is now marked as Obsolete. 
            

__What to do now:__

Use the ScatterPointSeries.RenderOptions property instead.
        

## 2012 Q3 - 2012.3.1017

* [XAML] Exposed Style properties for the visual elements of continuous series (Line, Spline, Area, etc.)
            

* Cartesian series visual elements can be customized via StrokeShapeStyle for the stroke
                  shape and AreaShapeStyle for the area shape (e.g. LineSeries exposes only StrokeShapeStyle
                  while AreaSeries exposes both style properties). The target type for all styles is Path.
                

* Polar / Radar series visual elements can be customized via single ShapeStyle property. The target type is again Path.
                

* When ChartSeriesLabelDefinition.Template or TemplateSelector is defined, the DataContext of
              the item labels data template should be the respective DataPoint and not just
              the calculated value as until now.
            

* Change the access modifier of the following interfaces from public to internal (not intended for public use):
            

* IChartSeries

* IChartView

* IFilledSeries

* IStrokedSeries

* ISupportCombineMode

* Remove unused IDataPointProcessor interface (not intended for public use).
            

* Introduced new Windows8 palette and made Metro palette obsolete.
            

# See Also

 * [Link inner text]({%slug radchartview-changes%})
