---
title: Events
page_title: Events
description: Events
slug: radchartview-events
tags: events
publish: True
position: 3
---

# Events

This article lists the events exposed by the charting controls and their series.

* [Chart controls events](#chart-controls-events)
* [Series events](#series-events)
* [Axis events](#axis-events)
* [Behavior events](#behavior-events)
* [Provider events](#provider-events)

## Chart controls events

__All charting controls__ in the RadChartView suite work with the following events:

* [PlotAreaClipChanged]({%slug radchartview-chart-types%}#radchartbase): Occurs when the chart's plot area gets changed.
* [UIUpdated]({%slug radchartview-chart-types%}#radcartesianchart): Occurs when the chart's UI gets updated.

__RadCartesianChart__ exposes couple specific events:
* [PanOffsetChanged]({%slug radchartview-chart-types%}#radchartbase): Occurs when the chart pan offset gets changed.
* [ZoomChanged]({%slug radchartview-chart-types%}#radcartesianchart): Occurs when the chart zoom gets changed.

## Series events

All chart series expose the following event:

* [DataBindingComplete]({%slug radchartview-series-chartseries%}#events): Occurs when a databinding operation has been successfully completed. 

## Axis events

* __Continuous axes__ (LinearAxis, LogarithmicAxis, DateTimeContinuousAxis) - the charts continuous axes expose the following events:
	* __ActualRangeChanged__: Occurs when the actual range changes.
	* __ActualVisibleRangeChanged__: Occurs when the actual visible range changes.

* __LinearAxis__ 
	* __ActualMajorStepChanged__: Occurs when the axis major step gets changed.
	
> You can find more information about the axes events in the [Axis]({%slug radchartview-axes-axis%}#common-events) help article.
	
## Behavior events

* __ChartCrosshairBehavior__ - this behavior exposes the following event:
	* [PositionChanged]({%slug radchartview-features-crosshair%}#events): Occurs when the position of the lines that represent the crosshair change.
* __ChartTrackBallBehavior__ - this behavior exposes the following events:
	* [PositionChanging]({%slug radchartview-features-trackball%}#update-the-trackball-position): Occurs when the value of the ChartTrackBallBehavior.Position property is changing. Allows for the new position to be modified.
	* [TrackInfoUpdated]({%slug radchartview-features-trackball%}#trackinfoupdated): Occurs when a track info is updated, just before the UI that represents it is updated. Allows custom information to be displayed.
* __ChartSelectionBehavior__ - this behavior exposes the following event:
	* [SelectionChanged]({%slug radchartview-features-selection%}): Occurs when the chart selection has changed.
	
## Provider events

* __ChartSeriesProvider__ - the series provider expose the following events:
	* [SeriesCreated]({%slug radchartview-features-chartseriesprovider%}#events): Occurs when a series is created. Allows for the series to be additionally set up or completely replaced.  
	
* __ChartAnnotationsProvider__ - the annotations provider expose the following events:
	* [AnnotationCreated]({%slug radchartview-annotations-annotationsprovider%}#using-the-annotationcreated-event): Occurs when an annotation is created. Allows for the annotation to be additionally set up or completely replaced.  

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [ChartSelectionBehaviors]({%slug radchartview-features-selection%})
* [AnnotationsProvider]({%slug radchartview-annotations-annotationsprovider%})
* [Dynamic Number Of Series]({%slug radchartview-features-chartseriesprovider%})
