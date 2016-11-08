---
title: Scroll and Zoom 
page_title: Scroll and Zoom 
description: Scroll and Zoom 
slug: radchartview-features-panzoom
tags: scroll,and,zoom,
published: True
position: 0
---

# Scroll and Zoom 

__RadChartView__ provides zoom and scroll interactivity via the __ChartPanAndZoomBehavior__ class. It is very simple to use and allows users to zoom in the chart plot area when there is a dense area of data points that can not be seen clearly at the normal chart scale. The scroll functionality allows moving the visible area of the chart. 

In order to utilize this behavior users simply have to add it to the chart's __Behaviors__ collection.

#### __[XAML] Example 1: Defining pan and zoom behavior__
{{region radchart-features-panzoom_0}}
	<telerikChart:RadCartesianChart.Behaviors>
	   <telerikChart:ChartPanAndZoomBehavior />
	</telerikChart:RadCartesianChart.Behaviors>
{{endregion}}

By default only the panning and zooming of the horizontal axis are enabled. You can alter this by setting the __ZoomMode__ and __PanMode__ properties of the __ChartPanAndZoomBehavior__. Both properties are of type __ChartPanZoomMode__ and accept the following values:

* __None__: The zooming/panning with the mouse device is disabled. You can use this value to disable the zoom functionality of the behavior.
* __Horizontal__: The zooming/panning with the mouse device is enabled only on the horizontal axis.
* __Vertical__: The zooming/panning with the mouse device is enabled only on the vertical axis.
* __Both__: The zooming/panning with the mouse device is enabled both on the horizontal and vertical axes. You can use this value to removes any restrictions, thus the chart can be zoomed in both the horizontal and vertical axes.

The __ZoomMode__ and __PanMode__ properties can be used to restrict zooming/panning.

#### __[XAML] Example 2: Setting zoom mode__
{{region radchart-features-panzoom_1}}
	<telerikChart:RadCartesianChart.Behaviors>
	   <telerikChart:ChartPanAndZoomBehavior ZoomMode="Both" />
	</telerikChart:RadCartesianChart.Behaviors>
{{endregion}}

> The __ChartPanAndZoomBehavior__ works with the default axes. If the RadCartesianChart.HorizontalAxis is null, for example, the user will not be able to zoom or scroll horizontally, even though the individual series have horizontal axis (axes) defined. 

* [Drag to zoom/scroll](#drag-to-zoomscroll)
* [Manual scroll and zoom](#manual-scroll-and-zoom)
* [Mouse wheel mode](#mouse-wheel-mode)

## Drag to zoom/scroll

The pan and zoom behavior enables drag-to-zoom and drag-to-pan functionality. By default when the ChartPanAndZoomBehavior is activated and you start dragging on the plot area, a zoom rectangle will be created and when the mouse is released the visible area will fit into the rectangle. 

#### __Figure 1: Drag to zoom__
![](images/radchart-features-scrollandzoom-1.png)

You can alter the drag action using the __DragMode__ property of the behavior. Setting it to __Pan__ will start panning, instead of zooming when you drag the mouse over the plot area. To forbid any drag actions you can set the DragMode to __None__.

#### __[XAML] Example 3: Setting minimum drag-to-zoom distance__
{{region radchart-features-panzoom_2}}
	<telerik:ChartPanAndZoomBehavior DragMode="Pan" />
{{endregion}}

You can also specify the minimum distance between the start and end points of the drag operation that will allow the drag-to-zoom/pan action to be activated. This is controlled by the __DragToZoomThreshold__ property.

#### __[XAML] Example 4: Setting minimum drag-to-zoom distance__
{{region radchart-features-panzoom_3}}
	<telerik:ChartPanAndZoomBehavior DragToZoomThreshold="100" />
{{endregion}}
	
The __ChartPanAndZoomBehavior__ allows you to define custom key combinations that activate the panning and zooming. You can do this using the __DragToZoomKeyCombinations__ and __DragToPanKeyCombinations__ collections.

#### __[C#] Example 5: Setting the left Ctrl key + mouse right button down as a combination that activates the zooming__
{{region radchart-features-panzoom_4}}
	var keyCombo = new ChartKeyCombination();
	keyCombo.Keys.Add(Key.LeftCtrl);
	keyCombo.MouseButtons.Add(MouseButton.Right);
	
	panAndZoomBehavior.DragToZoomKeyCombinations.Add(keyCombo);
{{endregion}}
	
#### __[C#] Example 6: Setting the mouse right button down as a trigger that activates the panning__
{{region radchart-features-panzoom_5}}
	var keyCombo = new ChartKeyCombination();
	keyCombo.MouseButtons.Add(MouseButton.Right);
	
	panAndZoomBehavior.DragToPanKeyCombinations.Add(keyCombo);
{{endregion}}

> The __DragToZoomKeyCombinations__ and __DragToPanKeyCombinations__ properties has a higher priority than the __DragMode__ property and if any combination is satisfied, a drag/pan-to-zoom operation is started.
	
To cancel the drag to zoom operation you can use the __CancelDragToZoom()__ method of the behavior.	

#### __[C#] Example 7: Canceling drag to zoom__
{{region radchart-features-panzoom_6}}
	panAndZoomBehavior.CancelDragToZoom();
{{endregion}}

## Manual scroll and zoom

The chart control has several properties which can be used to manually control the panning and zooming. 

The __Zoom__ property allows you to set the scale level for both axes. For example a `Zoom=new Size(10,1)` setting specifies that the data will be zoomed 10 times according to the horizontal axis and won't be zoomed by the vertical axis. 

With the __PanOffset__ you can specify the visible area of the chart. Note that PanOffset works with negative absolute values. For example, `PanOffset=new Point(-500,0)` will offset the visible area at 500px.

#### __[XAML] Example 8: Setting zoom__
{{region radchart-features-scrollandzoom_7}}
	<telerik:RadCartesianChart Zoom="10,1">
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>	
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>	
		<telerik:RadCartesianChart.Behaviors>
			<telerik:ChartPanAndZoomBehavior ZoomMode="Both">
			</telerik:ChartPanAndZoomBehavior>
		</telerik:RadCartesianChart.Behaviors>           	
		<telerik:RadCartesianChart.Series>
			<telerik:BarSeries>
				<telerik:BarSeries.DataPoints>
					<telerik:CategoricalDataPoint Category="1" Value="10" />
					<telerik:CategoricalDataPoint Category="2" Value="4" />
					<telerik:CategoricalDataPoint Category="3" Value="7" />
					<telerik:CategoricalDataPoint Category="4" Value="11" />
					<telerik:CategoricalDataPoint Category="5" Value="15" />
					<telerik:CategoricalDataPoint Category="6" Value="10" />
					<telerik:CategoricalDataPoint Category="7" Value="4" />
					<telerik:CategoricalDataPoint Category="8" Value="7" />
					<telerik:CategoricalDataPoint Category="9" Value="11" />
					<telerik:CategoricalDataPoint Category="10" Value="15" />
				</telerik:BarSeries.DataPoints>
			</telerik:BarSeries>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

#### __Figure 2: Zoom-in chart__
![](images/radchart-features-scrollandzoom-2.png)

Note that the setting the __PanOffset__ in XAML or the constructor of the view that holds the chart won't be respected. This is because the property uses the chart's size which is not yet calculated at this point. In order to apply the offset you can set it after the chart is loaded.

#### __[C#] Example 9: Setting pan offset in code__
{{region radchart-features-scrollandzoom_8}}
	private void RadCartesianChart_Loaded(object sender, RoutedEventArgs e)
	{
		var chart = (RadCartesianChart)sender;
		chart.PanOffset = new Point(-500, 0);            
	} 
{{endregion}}
   
#### __Figure 3: Offset visible area__
![](images/radchart-features-scrollandzoom-3.png)

The chart also provides few properties that combines the behaviors of Zoom and PanOffset.

* __HorizontalZoomRangeStart__ and __HorizontalZoomRangeEnd__
* __VerticalZoomRangeStart__ and __VerticalZoomRangeEnd__

Those properties controls the visible are of the chart by defining the start and end positions of the scrollbar of the corresponding axis. The properties work in __relative units between 0 and 1__. So if the start of the plot area is at 0, the end it will be at 1, and the center at 0.5. Having this in mind we can construct the same view as the one demonstrated in __Figure 3__ but using the zoom range properties.

#### __[XAML] Example 10: Using zoom range properties__
{{region radchart-features-scrollandzoom_9}}
	<telerik:RadCartesianChart HorizontalZoomRangeStart="0.1" HorizontalZoomRangeEnd="0.2">
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.Behaviors>
			<telerik:ChartPanAndZoomBehavior ZoomMode="Both">
			</telerik:ChartPanAndZoomBehavior>
		</telerik:RadCartesianChart.Behaviors>
		<telerik:RadCartesianChart.Series>
			<telerik:BarSeries>
				<telerik:BarSeries.DataPoints>
					<telerik:CategoricalDataPoint Category="1" Value="10" />
					<telerik:CategoricalDataPoint Category="2" Value="4" />
					<telerik:CategoricalDataPoint Category="3" Value="7" />
					<telerik:CategoricalDataPoint Category="4" Value="11" />
					<telerik:CategoricalDataPoint Category="5" Value="15" />
					<telerik:CategoricalDataPoint Category="6" Value="10" />
					<telerik:CategoricalDataPoint Category="7" Value="4" />
					<telerik:CategoricalDataPoint Category="8" Value="7" />
					<telerik:CategoricalDataPoint Category="9" Value="11" />
					<telerik:CategoricalDataPoint Category="10" Value="15" />
				</telerik:BarSeries.DataPoints>
			</telerik:BarSeries>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

## Mouse wheel mode

You can use the __MouseWheelMode__ property of __ChartPanAndZoomBehavior__ to specify how the chart will respond to mouse wheel. The property value is an enumeration that accepts the following values:

* __Default__: The mouse wheel action will zoom the chart in respect to the __ZoomMode__ property.
* __None__: The mouse wheel action won't be respected. Nothing will happen.
* __Zoom__: The mouse wheel action will zoom the chart both horizontally and vertically.
* __ZoomHorizontally__ and __ZoomVertically__: The mouse wheel action will zoom the chart horizontally/vertically.
* __PanHorizontally__ and __PanVertically__: The mouse wheel action will pan the chart horizontally/vertically.

#### __[XAML] Example 11: Settings mouse wheel mode__
{{region radchart-features-scrollandzoom_10}}
	<telerik:ChartPanAndZoomBehavior MouseWheelMode="Zoom" />
{{endregion}}

## See Also 

* [Getting Started]({%slug radchartview-introduction%})
* [Series and Axes]({%slug radchartview-series-and-axes%})
* [Selection Behavior]({%slug radchartview-features-selection%})
