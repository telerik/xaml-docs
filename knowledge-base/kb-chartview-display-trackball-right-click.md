---
title: Display Trackball Info on Right Mouse Click
page_title: Show RadCartesianChart Trackball when Right Mouse Button is Pressed
description: How to display the ChartView trackball on right mouse button click.
type: how-to
slug: kb-chartview-display-trackball-right-click
position: 0
tags: mouse,click,press,trackball
ticketid: 1415833
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 624</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadChartView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to display the ChartView trackball on right mouse button click.

## Solution

Subscribe to the __PositionChanging__ event of the __ChartTrackBallBehavior__ and reset the last position if the mouse right button wasn't not clicked. Then subscribe to the __MouseRightButtonDown__ event of RadCartesianChart and set the __Position__ property of the behavior manually.


```XAML
	<telerik:RadCartesianChart.Behaviors>
		<telerik:ChartTrackBallBehavior PositionChanging="ChartTrackBallBehavior_PositionChanging" x:Name="trackballBehavior" />
	</telerik:RadCartesianChart.Behaviors>
```


```C#
	public partial class MainWindow : Window
    {
        private bool isManualPositionChange = false;
 
        public MainWindow()
        {
            InitializeComponent();
            this.trackballBehavior.Position = new Point(100, 321);
        }
 
        private void ChartTrackBallBehavior_PositionChanging(object sender, Telerik.Windows.Controls.ChartView.TrackBallPositionChangingEventArgs e)
        {
            if (e.NewPosition != e.PreviousPosition && !isManualPositionChange)
            {
                e.NewPosition = e.PreviousPosition;
            }           
            this.isManualPositionChange = false;
        }
 
        private void RadCartesianChart_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            isManualPositionChange = true;
            this.trackballBehavior.Position = e.GetPosition(this.chart);
        }
    }
```