---
title: Events
page_title: Events
description: This article lists the events exposed by the controls in the RadChartView suite.
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

## Chart Controls Events

__All charting controls__ in the RadChartView suite work with the following events:

* __PlotAreaClipChanged__: Occurs when the chart's plot area gets changed.
* __UIUpdated__: Occurs when the chart's UI gets updated.

The following events will be fired only for __RadCartesianChart__:
* __PanOffsetChanged__: Occurs when the chart pan offset gets changed.
	__Example 1: PanOffsetChanged event arguments__
	```C#	
		private void RadCartesianChart_PanOffsetChanged(object sender, ChartPanOffsetChangedEventArgs e)
		{
			Point previousPanOffset = e.PreviousPanOffset;
			Point newPanOffset = e.NewPanOffset;
		}
	```
	
* __ZoomChanged__: Occurs when the chart zoom gets changed.
	__Example 2: ZoomChanged event arguments__
	```C#	
		private void RadCartesianChart_ZoomChanged(object sender, ChartZoomChangedEventArgs e)
		{
			Size previousZoom = e.PreviousZoom;
			Size newZoom = e.NewZoom;
		}
	```
	
## Series Events

All chart series expose the following events:

* __DataBindingComplete__: Occurs when a databinding operation has been successfully completed. 
* __SeriesAnimationCompleted__:  This event is fired when the animation for all datapoints of the series is completed.
* __PointAnimationCompleted__: This event is fired when the animation of the series is completed.

## Axis Events

The __LinearAxis, LogarithmicAxis, DateTimeContinuousAxis__ continuous axes of the charts expose the following events
* __ActualRangeChanged__: Occurs when the actual range changes.
	__Example 3: ActualRangeChanged event arguments__
	```C#	
		private void DateTimeContinuousAxis_ActualRangeChanged(object sender, Telerik.Charting.DateTimeRangeChangedEventArgs e)
		{
			Telerik.Charting.ValueRange<System.DateTime> previousRange = e.PreviousRange;
			Telerik.Charting.ValueRange<System.DateTime> newRange = e.NewRange;
		}
	```
	
* __ActualVisibleRangeChanged__: Occurs when the actual visible range changes.
	__Example 4: ActualVisibleRangeChanged event arguments__
	```C#	
		private void DateTimeContinuousAxis_ActualVisibleRangeChanged(object sender, Telerik.Charting.DateTimeRangeChangedEventArgs e)
		{
			Telerik.Charting.ValueRange<System.DateTime> previousRange = e.PreviousRange;
			Telerik.Charting.ValueRange<System.DateTime> newRange = e.NewRange;
		}
	```

The __LinearAxis__ has an additional event which will be fired when the MajorStep property is changed.

* __ActualMajorStepChanged__: Occurs when the major step of the axis gets changed.
	
> You can find more information about the axes events in the [Axis]({%slug radchartview-axes-axis%}#common-events) help article.
	
## Behavior Events

* __ChartCrosshairBehavior__: This behavior exposes the following event:

	* __PositionChanged__: Occurs when the position of the lines that represent the crosshair change.
	__Example 5: PositionChanged event arguments__
	```C#	
		private void ChartCrosshairBehavior_PositionChanged(object sender, ChartCrosshairPositionChangedEventArgs e)
		{
			Telerik.Charting.DataTuple data = e.Data;
			Point newPosition = e.Position;
		}
	```
	
* __ChartTrackBallBehavior__: This behavior exposes the following events:

	* __PositionChanging__: Occurs when the value of the ChartTrackBallBehavior.Position property is changing. Allows for the new position to be modified.
	__Example 6: PositionChanging event arguments__
	```C#	
		private void ChartTrackBallBehavior_PositionChanging(object sender, TrackBallPositionChangingEventArgs e)
		{
			var previousPosition = e.PreviousPosition;
			var newPosition = e.NewPosition;
		}
	```
	
	* __TrackInfoUpdated__: Occurs when a track info is updated, just before the UI that represents it is updated. Allows custom information to be displayed.	
	__Example 6: TrackInfoUpdated event arguments__
	```C#	
		private void ChartTrackBallBehavior_TrackInfoUpdated(object sender, TrackBallInfoEventArgs e)
		{
			ChartDataContext context = e.Context;
			object test = e.Header;            
		}
	```
	
* __ChartSelectionBehavior__: This behavior exposes the following event:

	* __SelectionChanged__: Occurs when the chart selection has changed.
	__Example 7: SelectionChanged event arguments__
	```C#	
		private void ChartSelectionBehavior_SelectionChanged(object sender, ChartSelectionChangedEventArgs e)
		{
			var selectedPoints = e.AddedPoints;
			var unSelectedPoints = e.RemovedPoints;
		}
	```  

## Provider Events

* __ChartSeriesProvider__: The series provider exposes the following events:

	* __SeriesCreated__: Occurs when a series is created. Allows for the series to be additionally set up or completely replaced.  	
	__Example 8: SeriesCreated event arguments__
	```C#	
		private void ChartSeriesProvider_SeriesCreated(object sender, ChartSeriesCreatedEventArgs e)
		{
			object test = e.Context;
			ChartSeries createdSeries = e.Series;
		}
	```
	
* __ChartAnnotationsProvider__: The annotations provider exposes the following events:
	* __AnnotationCreated__: Occurs when an annotation is created. Allows for the annotation to be additionally set up or completely replaced.  
	__Example 9: AnnotationCreated event arguments__
	```C#	
		private void ChartAnnotationsProvider_AnnotationCreated(object sender, ChartAnnotationCreatedEventArgs e)
		{
			object test = e.Context;
			ChartAnnotation createdAnnotation = e.Annotation;
		}
	```	  
	  
## See Also  
* [Getting Started]({%slug radchartview-introduction%})
* [ChartSelectionBehaviors]({%slug radchartview-features-selection%})
* [AnnotationsProvider]({%slug radchartview-annotations-annotationsprovider%})
* [Dynamic Number Of Series]({%slug radchartview-features-chartseriesprovider%})
