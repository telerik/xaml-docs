---
title: TrackBall
page_title: TrackBall
description: ChartTrackBallBehavior can display a vertical line across the chart plot area and little visual indicators at points where the trackball line crosses the visualization of a series object.
slug: radchartview-features-trackball
tags: trackball
published: True
position: 2
---

# TrackBall

Along with [tooltip]({%slug radchartview-features-tooltip%}) and [pan/zoom]({%slug radchartview-features-panzoom%}) behaviors, RadChartView provides a trackball visualization through the __ChartTrackBallBehavior__ class. 

This behavior can display a vertical line across the chart plot area and little visual indicators (circles by default) at points where the trackball line crosses the visualization of a series object. For example, when the trackball line crosses a line series line segment, a small circle is drawn highlighting the value of the series at this point.

The behavior also displays a small popup (the trackball info), similar to the tooltip, in order to provide more detailed information about the points closest to the trackball line's cross section (see Figure 1).

## Enable the TrackBall

To enable the trackball visualization, add a new __ChartTrackBallBehavior__ instance in the __Behaviors__ collection of the RadCartesianChart control.

__Example 1: Enabling the trackball__
<snippet id='radchartview-features-behaviors-trackball-example_1_enabling_the_trackball-xaml' />


#### __Figure 1: RadCartesianChart with trackball__
![Telerik UI for WPF RadChartView with the trackball behavior enabled](images/radchartview-features-trackball-0.png)

> By default the trackball shows the preview line that follows the data points closest to the mouse position and also the track info control (the information tooltip). The ellipses that snap to the data points are not displayed until explicitly enabled. Read more in the [Toggle the TrackBall Visual Elements](#toggle-the-trackball-visual-elements) section of this article.

## Snap Mode

The __SnapMode__ property of ChartTrackBallBehavior determines how the trackball __line__ will be snapped to the data points found by the trackball behavior. The property is enum accepting the following values:

* __None__: This mode disables the snapping of the line.
	
	#### __Figure 2: SnapMode: None__
	![Telerik UI for WPF RadChartView trackball with SnapMode set to None](images/radchartview-features-trackball-1.png)

* __ClosestPoint__ (default): This mode snaps the trackball line to the closest point of all data points in the chart.

	#### __Figure 3: SnapMode: ClosestPoint__
	![Telerik UI for WPF RadChartView trackball snapped to the closest point](images/radchartview-features-trackball-2.png)
	
* __AllClosestPoints__: This mode snaps the trackball line to the closest point from each series object in the chart.

	#### __Figure 4: SnapMode: AllClosestPoints__
	![Telerik UI for WPF RadChartView trackball snapped to the closest point in each series](images/radchartview-features-trackball-3.png)

__Example 2: Setting the SnapMode__
<snippet id='radchartview-features-behaviors-trackball-example_2_setting_the_snapmode-xaml' />

	
## Snap Multiple Points Per Series

By default the trackball will display information only for a single data point per series. To change this set the __SnapSinglePointPerSeries__ property to False. This way if you have multiple points in a single series, that are considered close to the mouse, all of them will be shown by the trackball.

__Example 3: Setting the SnapSinglePointPerSeries property__
<snippet id='radchartview-features-behaviors-trackball-example_3_setting_the_snapsinglepointperseries_property-xaml' />


#### __Figure 5: Snap to multiple points series__
![Telerik UI for WPF RadChartView trackball snapped to multiple series points](images/radchartview-features-trackball-4.png)

## Toggle the TrackBall Visual Elements

The trackball consists of three main visuals - line, info tooltip and intersection points. You can toggle their visibility via few properties.

To show/hide the info tooltip (the trackball info control), set the __ShowTrackInfo__ property.

To show/hide the intersection points, set the __ShowIntersectionPoints__ property.

To show/hide the line set its Visibility via the __TrackBallLineStyle__ property of the RadCartesianChart.

__Example 4: Toggle the trackball visuals__
<snippet id='radchartview-features-behaviors-trackball-example_4_toggle_the_trackball_visuals-xaml' />


#### __Figure 6: TrackBall with only intersection points shown__
![Telerik UI for WPF RadChartView trackball showing only intersection points](images/radchartview-features-trackball-5.png)

## Customize the TrackBall Visual Elements

The chart provides several properties that allows customizing the trackball.

To customize the trackball line, set the __TrackBallLineStyle__ property. The property accepts a Style object with its TargetType set to __Polyline__.

To customize the trackball info, set the __TrackBallInfoStyle__ property. The property accepts a Style object with its TargetType set to __TrackBallInfoControl__.

__Example 5: Setting the line and trackball info styles__
<snippet id='radchartview-features-behaviors-trackball-example_5_setting_the_line_and_trackball_info_styles-xaml' />


#### __Figure 7: Customized line and trackball info__
![Telerik UI for WPF RadChartView trackball showing the preview line and information tooltip](images/radchartview-features-trackball-6.png)

The trackball intersection points can be customized per series via the __TrackBallTemplate__ property of the corresponding chart series.

Additionally, you can customize the information for each series via the __TrackBallInfoTemplate__ property of the corresponding chart series.

__Example 6: Setting the line and trackball templates__
<snippet id='radchartview-features-behaviors-trackball-example_6_setting_the_line_and_trackball_templates-xaml' />


#### __Figure 8: Customized line and trackball templates__
![Telerik UI for WPF RadChartView trackball with customized visual elements](images/radchartview-features-trackball-7.png)

## Update the TrackBall Position

ChartTrackBallBehavior exposes a __Position__ property that can be used to manually change the position of the trackball. The property accepts a value of type __Sytem.Windows.Point__. Setting the Position will display and snap the trackball to the data points that are plotted closest to the set position. The position is defined in pixels relative to the chart. 

For example, if the chart is 500px wide and 300px high, and the Position property is set to new Point(250, 150) the trackball will be placed at the data points plotted closest to the 250th horizontal and 150th vertical pixels of the chart.

__Example 7: Updating the trackball position__
<snippet id='radchartview-features-behaviors-trackball-example_7_updating_the_trackball_position-cs' />

<snippet id='radchartview-features-behaviors-trackball-example_7_updating_the_trackball_position-vb' />


This behavior also provides the __PositionChanging__ event, which is called on each change of the Position property. The event arguments expose a couple of helpful properties:
* __PreviousPosition__: Gets the previous position of the trackball.
* __NewPosition__: Gets or sets the new position of the trackball.

>The PositionChanging event will be called only if the old and the new positions are different.

<!-- -->

> You can find a runnable project that demonstrates manipulating the position of the trackball in the {% if site.site_name == 'WPF' %}[TrackBallSyncedCharts](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/TrackBallSyncedCharts)
{% else %}[TrackBallSyncedCharts](https://github.com/telerik/xaml-sdk/tree/master/ChartView/SL/TrackBallSyncedCharts){% endif %} SDK example.

## Events

The behavior exposes the __TrackInfoUpdated__ event that is useful if you want to modify the trackball info that is displayed in the tooltip. The __TrackBallInfoEventArgs__ contain information about the data points near the mouse position.

__Example 8: Subscribing to the TrackInfoUpdated event__
<snippet id='radchartview-features-behaviors-trackball-example_8_subscribing_to_the_trackinfoupdated_event-xaml' />


__Example 9: Canceling the trackball showing when the mouse is close to a specific category__
<snippet id='radchartview-features-behaviors-trackball-example_9_canceling_the_trackball_showing_when_the_mouse_is_close_to_a_specific_category-cs' />

<snippet id='radchartview-features-behaviors-trackball-example_9_canceling_the_trackball_showing_when_the_mouse_is_close_to_a_specific_category-vb' />


## See Also

* [Tooltip]({%slug radchartview-features-tooltip%})
* [Scroll and Zoom]({%slug radchartview-features-panzoom%})
