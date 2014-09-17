---
title: TrackBall
page_title: TrackBall
description: TrackBall
slug: radchartview-features-trackball
tags: trackball
published: True
position: 2
---

# TrackBall



## 

__Trackball Behavior__

Along with [tooltip]({%slug radchartview-features-tooltip%}) and [pan/zoom]({%slug radchartview-features-panzoom%}) behaviors, RadChartView provides a trackball behavior through the __ChartTrackballBehavior__ class. This behavior can display a vertical line across the chart plot area and also to display little visual indicators (circles by default) at points where the trackball line crosses the visualization of a series object. For example when the trackball line crosses a line series line segment, a small circle is drawn highlighting the value of the series at this point.

The last capability of the the trackball behavior is to display a small popup, similar to the tooltip, in order to provide more detailed information about the closest points to the track ball line's cross section, as can be seen in the screenshot above.

The ChartTrackballBehavior exposes three properties and an event. These are __ShowTrackInfo__, __ShowIntersectionPoints__, __SnapMode__and the event is called __TrackInfoUpdated__. ShowTrackInfo and ShowIntersectionPoints enable and disable the popup and the intersection circles respectively. It is important to note that the intersection points can be visually modified by ChartSeries' __TrackBallTemplate__ property and can therefore have an arbitrary visualization. The track info can also be specified as a different template and this can be done with ChartSeries' __TrackInfoTemplate__ property. Below is an example of how to modify the track ball and track info templates. The color of the track ball line can be modified via RadChartView's __TrackBallLineStyle__ property. It is of type Style and it must target the PolyLine class because the trackball behavior uses a PolyLine internally.

__Specifying a custom TrackBallTemplate__

#### __XAML__

{{region radchart-features-trackball_0}}
	<telerik:RadCartesianChart>
	    <telerik:RadCartesianChart.Behaviors>
	        <telerik:ChartTrackBallBehavior ShowIntersectionPoints="True"
	                                             ShowTrackInfo="False"/>
	    </telerik:RadCartesianChart.Behaviors>
	
	    <telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:LinearAxis/>
	    </telerik:RadCartesianChart.HorizontalAxis>
	
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis/>
	    </telerik:RadCartesianChart.VerticalAxis>
	
	    <telerik:ScatterLineSeries>
	        <telerik:ScatterLineSeries.TrackBallTemplate>
	            <DataTemplate>
	                <Rectangle Width="20"
	                           Height="20"
	                           Fill="Violet"
	                           RenderTransformOrigin="0.5,0.5">
	                    <Rectangle.RenderTransform>
	                        <RotateTransform Angle="45"/>
	                    </Rectangle.RenderTransform>
	                </Rectangle>
	            </DataTemplate>
	        </telerik:ScatterLineSeries.TrackBallTemplate>
	
	        <telerik:ScatterDataPoint XValue="5"
	                                             YValue="5"/>
	        <telerik:ScatterDataPoint XValue="15"
	                                             YValue="5"/>
	        <telerik:ScatterDataPoint XValue="20"
	                                             YValue="5"/>
	    </telerik:ScatterLineSeries>
	</telerik:RadCartesianChart>
	{{endregion}}



![Rad Chart View-chart behaviors trackball](images/RadChartView-chart_behaviors_trackball.PNG)

Specifying a custom TrackBallInfoTemplate
        

#### __XAML__

{{region radchart-features-trackball_1}}
	<telerik:ScatterLineSeries>
	    <telerik:ScatterLineSeries.TrackBallInfoTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal">
	                <TextBlock Text="{Binding Path=DisplayHeader}" Foreground="Blue" FontWeight="Bold"/>
	                <TextBlock Text="{Binding Path=DisplayContent}" Foreground="Blue" Margin="4,0,0,0"/>
	            </StackPanel>
	        </DataTemplate>
	    </telerik:ScatterLineSeries.TrackBallInfoTemplate>
	</telerik:ScatterLineSeries>
	{{endregion}}



![](images/radchartview-chart_features_trackballinfoupdated.png)

__Snap Mode__

The SnapMode property of ChartTrackballBehavior determines how the trackball line will be snapped to the chart's data points. Valid property values are __None__, __ClosestPoint__ and __AllClosestPoints__ with None disabling snapping, ClosestPoint snapping to the closest point of all data points in the chart and AllClosestPoints snapping to the closest point from each series object in the chart, that is, it snaps to multiple data points at once. Again, a few screenshots will best describe the different values of SnapMode:

__SnapMode: None__

__SnapMode: ClosestPoint__

__SnapMode: AllClosestPoints__

__TrackInfoUpdated__

ChartTrackballBehavior provides a TrackInfoUpdated event which fires as the users drag their finger across the chart plot area. On every drag event TrackInfoUpdated's event arguments provide information related to the current position of the trackball which is the same ChartDataContext that is provided for the tooltip. The event arguments provide the closest data point for each series in the chart as well as the absolute closest data point. Another property of the event arguments is the Header property (of type object) which allows users to directly specify a header for the track info popup. Here is an example usage of the TrackInfoUpdatedEvent:

#### __XAML__

{{region radchart-features-trackball_2}}
	<telerik:RadCartesianChart>
	   <telerik:RadCartesianChart.TrackBallInfoStyle>
	      <Style TargetType="telerik:TrackBallInfoControl">
	         <Setter Property="HeaderTemplate">
	            <Setter.Value>
	               <DataTemplate>
	                  <TextBlock Text="{Binding}" 
	                             FontSize="23"
	                             Foreground="Green"/>
	               </DataTemplate>
	            </Setter.Value>
	         </Setter>
	      </Style>
	   </telerik:RadCartesianChart.TrackBallInfoStyle>
	
	   <telerik:RadCartesianChart.Behaviors>
	      <telerik:ChartTrackBallBehavior ShowTrackInfo="True"
	                                           ShowIntersectionPoints="True"
	                                           TrackInfoUpdated="ChartTrackBallBehavior_TrackInfoUpdated"/>
	   </telerik:RadCartesianChart.Behaviors>
	
	   <telerik:RadCartesianChart.VerticalAxis>
	      <telerik:LinearAxis/>
	   </telerik:RadCartesianChart.VerticalAxis>
	
	   <telerik:RadCartesianChart.HorizontalAxis>
	      <telerik:CategoricalAxis/>
	   </telerik:RadCartesianChart.HorizontalAxis>
	
	   <telerik:SplineSeries>
	      <telerik:CategoricalDataPoint Value="0.2" />
	      <telerik:CategoricalDataPoint Value="0.4" />
	      <telerik:CategoricalDataPoint Value="0.5" />
	      <telerik:CategoricalDataPoint Value="1.4" />
	      <telerik:CategoricalDataPoint Value="1.0" />
	      <telerik:CategoricalDataPoint Value="1.3" />
	   </telerik:SplineSeries>
	
	   <telerik:LineSeries>
	      <telerik:CategoricalDataPoint Value="0.1"/>
	      <telerik:CategoricalDataPoint Value="0.3"/>
	      <telerik:CategoricalDataPoint Value="0.3"/>
	      <telerik:CategoricalDataPoint Value="0.4"/>
	      <telerik:CategoricalDataPoint Value="0.2"/>
	      <telerik:CategoricalDataPoint Value="0.3"/>
	   </telerik:LineSeries>
	</telerik:RadCartesianChart>
	{{endregion}}



#### __C#__

{{region radchart-features-trackball_3}}
	private void ChartTrackBallBehavior_TrackInfoUpdated(object sender, TrackBallInfoEventArgs e)
	{
	    foreach (DataPointInfo info in e.Context.DataPointInfos)
	    {
	        info.DisplayHeader = "Custom data point header";
	    }
	
	    e.Header = "Sample header";
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-features-trackball_4}}
	Private Sub ChartTrackBallBehavior_TrackInfoUpdated(ByVal sender As Object, ByVal e As TrackBallInfoEventArgs)
	   For Each info As DataPointInfo In e.Context.DataPointInfos
	      info.DisplayHeader = "Custom data point header"
	   Next
	
	   e.Header = "Sample header"
	End Sub
	{{endregion}}





       
            ![Rad Charting Kit-chart behaviors trackballinfoupdated](images/radchartview-chart_behaviors_trackballinfoupdated.png)
