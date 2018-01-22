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

Along with [tooltip]({%slug radchartview-features-tooltip%}) and [pan/zoom]({%slug radchartview-features-panzoom%}) behaviors, RadChartView provides a trackball behavior through the __ChartTrackBallBehavior__ class. This behavior can display a vertical line across the chart plot area and little visual indicators (circles by default) at points where the trackball line crosses the visualization of a series object. For example, when the trackball line crosses a line series line segment, a small circle is drawn highlighting the value of the series at this point.

#### __Figure 1: RadCartesianChart with a track ball__
![Rad Chart View-chart behaviors trackball](images/radchartview-chart_behaviors_trackballinfo_00.png)

The trackball behavior can also display a small popup, similar to the tooltip, in order to provide more detailed information about the closest points to the trackball line's cross section, as can be seen in Figure 1 above.

The ChartTrackBallBehavior exposes three properties and an event. These properties are __ShowTrackInfo__, __ShowIntersectionPoints__, __SnapMode__ and the event is called __TrackInfoUpdated__. ShowTrackInfo and ShowIntersectionPoints enable and disable the popup and the intersection circles respectively. Note that the intersection points can be visually modified by the ChartSeries __TrackBallTemplate__ property and can therefore have an arbitrary visualization. The track info can also be specified as a different template using the ChartSeries' __TrackInfoTemplate__ property. Examples 1 and 2 show how to modify the trackball and track info templates. 

#### __[XAML] Example 1: Specifying a custom TrackBallTemplate__
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

#### __Figure 1: Result from Example 1__
![RadChartView-custom TrackBallTemplate](images/RadChartView-chart_behaviors_trackball.PNG)

#### __[XAML] Example 2: Specifying a custom TrackBallInfoTemplate__
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

#### __Figure 2: Result from Example 2__
![RadChartView-custom TrackBallInfoTemplate](images/radchartview-chart_features_trackballinfoupdated.png)

## SnapMode

The __SnapMode__ property of ChartTrackBallBehavior determines how the trackball line will be snapped to the chart's data points. Valid property values are __None__, __ClosestPoint__ and __AllClosestPoints__ with None disabling snapping, ClosestPoint snapping to the closest point of all data points in the chart, and AllClosestPoints snapping to the closest point from each series object in the chart. That is, AllClosestPoints snaps to multiple data points at once. A few screenshots will best describe the different values of SnapMode:

#### __Figure 3: SnapMode: None__
![RadChartView: trackball with SnapMode](images/radchartview-chart_behaviors_trackballinfo_03.png)

#### __Figure 4: SnapMode: ClosestPoint__
![RadChartView: trackball with SnapMode](images/radchartview-chart_behaviors_trackballinfo_02.png)

#### __Figure 5: SnapMode: AllClosestPoints__
![RadChartView: trackball with SnapMode](images/radchartview-chart_behaviors_trackballinfo_01.png)

## TrackInfoUpdated

ChartTrackballBehavior provides a __TrackInfoUpdated__ event that fires as the users drag their mouse across the chart plot area. On every drag event, TrackInfoUpdated's event arguments provide information related to the current position of the trackball, which is the same ChartDataContext that is provided for the tooltip. The event arguments provide the closest data point for each series in the chart as well as the absolute closest data point. Another property of the event arguments is the Header property (of type object), which allows users to directly specify a header for the track info popup. Example 3 shows how to use the TrackInfoUpdated event:

#### __[XAML] Example 3: Setting up the RadCartesianChart__
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
		<telerik:SplineSeries.DataPoints>
			<telerik:CategoricalDataPoint Value="0.2" />
			<telerik:CategoricalDataPoint Value="0.4" />
			<telerik:CategoricalDataPoint Value="0.5" />
			<telerik:CategoricalDataPoint Value="1.4" />
			<telerik:CategoricalDataPoint Value="1.0" />
			<telerik:CategoricalDataPoint Value="1.3" />
		</telerik:SplineSeries.DataPoints>
	   </telerik:SplineSeries>
	
	   <telerik:LineSeries>
		<telerik:LineSeries.DataPoints>
			<telerik:CategoricalDataPoint Value="0.1"/>
			<telerik:CategoricalDataPoint Value="0.3"/>
			<telerik:CategoricalDataPoint Value="0.3"/>
			<telerik:CategoricalDataPoint Value="0.4"/>
			<telerik:CategoricalDataPoint Value="0.2"/>
			<telerik:CategoricalDataPoint Value="0.3"/>
		</telerik:LineSeries.DataPoints>
	   </telerik:LineSeries>
	</telerik:RadCartesianChart>
{{endregion}}

#### __[C#] Example 4: Using the TrackInfoUpdated event__
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

#### __[VB.NET] Example 4: Using the TrackInfoUpdated event__
{{region radchart-features-trackball_4}}
	Private Sub ChartTrackBallBehavior_TrackInfoUpdated(ByVal sender As Object, ByVal e As TrackBallInfoEventArgs)
	   For Each info As DataPointInfo In e.Context.DataPointInfos
	      info.DisplayHeader = "Custom data point header"
	   Next
	
	   e.Header = "Sample header"
	End Sub
{{endregion}}

#### __Figure 6: Result from Example 4__
![Rad Charting Kit-chart behaviors trackballinfoupdated](images/radchartview-chart_behaviors_trackballinfoupdated.png)

## Update the TrackBall Position

ChartTrackBallBehavior exposes a __Position__ property that can be used to manually change the position of the trackball. The property accepts a value of type __Sytem.Windows.Point__. Setting the Position will display and snap the trackball to the data points that are plotted closest to the set position. The position is defined in pixels relative to the chart. 

For example, if the chart is 500px wide and 300px high, and the Position property is set to new Point(250, 150) the trackball will be placed at the data points plotted closest to the 250th horizontal and 150th vertical pixels of the chart.

#### __[C#] Example 5: Updating the trackball position__
{{region radchart-features-trackball_5}}
	trackballBehavior.Position = new Point(250, 150);
{{endregion}}

#### __[VB.NET] Example 5: Updating the trackball position__	
{{region radchart-features-trackball_6}}
	trackballBehavior.Position = New Point(250, 150)
{{endregion}}

This behavior also provides the __PositionChanging__ event, which is called on each change of the Position property. The event arguments expose a couple of helpful properties:
* __PreviousPosition__: Gets the previous position of the trackball.
* __NewPosition__: Gets or sets the new position of the trackball.

>The PositionChanging event will be called only if the old and the new positions are different.

<!-- -->

> You can find a runnable project that demonstrates manipulating the position of the trackball in the {% if site.site_name == 'WPF' %}[TrackBallSyncedCharts](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/TrackBallSyncedCharts)
{% endif %}{% if site.site_name == 'Silverlight' %}[TrackBallSyncedCharts](https://github.com/telerik/xaml-sdk/tree/master/ChartView/SL/TrackBallSyncedCharts){% endif %} SDK example.

## Styling the TrackBall Line and TrackBallInfoControl

You can style the trackball line using RadChartView's __TrackBallLineStyle__ property. It is of type Style and must target the __PolyLine__ class because the trackball behavior uses a PolyLine internally. Additionally, you can style the TrackBallInfoControl using RadChartView's __TrackBallInfoStyle__ property. It is also of type Style and must target the __TrackBallInfoControl__. Examples 6 and 7 show how you can style both elements.

#### __[XAML] Example 6: Styling the trackball line__
{{region radchart-features-trackball_7}}
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.Behaviors>
			<telerik:ChartTrackBallBehavior ShowIntersectionPoints="True" />
		</telerik:RadCartesianChart.Behaviors>

		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>

		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>

		<telerik:RadCartesianChart.TrackBallLineStyle>
			<Style TargetType="Polyline">
				<Setter Property="Stroke" Value="Red" />
				<Setter Property="StrokeThickness" Value="5" />
			</Style>
		</telerik:RadCartesianChart.TrackBallLineStyle>
		<telerik:ScatterLineSeries>

		<telerik:ScatterLineSeries.DataPoints>
				<telerik:ScatterDataPoint XValue="5" YValue="5"/>
				<telerik:ScatterDataPoint XValue="15" YValue="5"/>
				<telerik:ScatterDataPoint XValue="20" YValue="5"/>
			</telerik:ScatterLineSeries.DataPoints>
		</telerik:ScatterLineSeries>
	</telerik:RadCartesianChart>
{{endregion}}

#### __Figure 7: Result from Example 6__
![RadChartView-TrackBallLineStyle](images/radchartview-features_behaviors_trackballlinestyle.png)

#### __[XAML] Example 7: Styling the TrackBallInfoControl__
{{region radchart-features-trackball_8}}
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.Behaviors>
			<telerik:ChartTrackBallBehavior ShowIntersectionPoints="True" />
		</telerik:RadCartesianChart.Behaviors>

		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>

		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>
		
		<telerik:RadCartesianChart.TrackBallInfoStyle>
			<Style TargetType="telerik:TrackBallInfoControl">
				<Setter Property="Background" Value="Black" />
				<Setter Property="Foreground" Value="Yellow" />
			</Style>
		</telerik:RadCartesianChart.TrackBallInfoStyle>

		<telerik:ScatterLineSeries>
			<telerik:ScatterLineSeries.DataPoints>
					<telerik:ScatterDataPoint XValue="5" YValue="5"/>
					<telerik:ScatterDataPoint XValue="15" YValue="5"/>
					<telerik:ScatterDataPoint XValue="20" YValue="5"/>
			</telerik:ScatterLineSeries.DataPoints>
		</telerik:ScatterLineSeries>
	</telerik:RadCartesianChart>
{{endregion}}

#### __Figure 8: Result from Example 7__
![RadChartView-TrackBallInfoStyle](images/chartview_features_behaviors_trackballinfostyle.png)