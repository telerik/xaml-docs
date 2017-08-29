---
title: Create Chart With Static Data
page_title: Create Chart With Static Data
description: Create Chart With Static Data
slug: radchartview-populating-with-data-static-data
tags: create,chart,with,static,data
published: True
position: 2
---

# Create Chart With Static Data

In this sample you are going to create and visualize your data using simple line chart. This line chart will be based on some predefined static data declared in XAML or code-behind.

First we'll declare our chart which is represented by the __RadCartesianChart__ class. See __Example 1__.        

#### __[XAML] Example 1: Declare a chart in XAML__

{{region radchart-static-data_1}}
	<telerik:RadCartesianChart x:Name="chart"/>
{{endregion}}

The next thing that needs to be done is to define the chart’s axes. We need to set a horizontal axis and a vertical axis. They can differ from each other. For example the horizontal axis might be a plain numerical axis while the vertical axis can be logarithmic or some other fancy type. See __Example 2__.        

#### __[XAML] Example 2: Define chart's axes__

{{region radchart-static-data_2}}
	<telerik:RadCartesianChart x:Name="chart">
	    <telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:CategoricalAxis/>
	    </telerik:RadCartesianChart.HorizontalAxis>
	
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis Maximum="100"/>
	    </telerik:RadCartesianChart.VerticalAxis>
	</telerik:RadCartesianChart>
{{endregion}}



Now we have a chart with two axes but no data. In order to visualize data we will need to have some visualization for it. The presentation of the data itself is achieved by declaring chart series inside our chart and filling these series with data points. Each chart series visualizes its data point collection in a different way. RadChart supports a few series out of the box the simplest of which is the line series. See __Example 3__.        

#### __[XAML] Example 3: Define LineSeries__

{{region radchart-static-data_3}}
	<telerik:RadCartesianChart x:Name="chart">
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>

		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis Maximum="100"/>
		</telerik:RadCartesianChart.VerticalAxis>

		<telerik:RadCartesianChart.Series>
			<telerik:LineSeries Stroke="Orange"
								StrokeThickness="2"/>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

Now with this XAML things don’t look exactly right. There is nothing on screen. This is normal, we have not filled the series with data points yet. In __Example 4__ you can see how we can fill the series with data points.        

#### __[XAML] Example 4: Populate the LineSeries with DataPoints__

{{region radchart-static-data_4}}
	<telerik:RadCartesianChart x:Name="chart">
	   <telerik:RadCartesianChart.HorizontalAxis>
	       <telerik:CategoricalAxis/>
	   </telerik:RadCartesianChart.HorizontalAxis>
	
	   <telerik:RadCartesianChart.VerticalAxis>
	       <telerik:LinearAxis Maximum="100"/>
	   </telerik:RadCartesianChart.VerticalAxis>
	
	   <telerik:RadCartesianChart.Series>
	       <telerik:LineSeries Stroke="Orange"
	                         StrokeThickness="2">
	          <telerik:LineSeries.DataPoints>
	              <telerik:CategoricalDataPoint Value="20"/>
	              <telerik:CategoricalDataPoint Value="40"/>
	              <telerik:CategoricalDataPoint Value="35"/>
	              <telerik:CategoricalDataPoint Value="40"/>
	              <telerik:CategoricalDataPoint Value="30"/>
	              <telerik:CategoricalDataPoint Value="50"/>
	          </telerik:LineSeries.DataPoints>
	       </telerik:LineSeries>
	   </telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

The same can be achieved in code-behind only. See __Example 5__.

#### __[C#] Example 5: Declare a chart in code-behind__

{{region radchart-static-data_5}}
		RadCartesianChart chart = new RadCartesianChart();
		chart.HorizontalAxis = new CategoricalAxis();
		chart.VerticalAxis = new LinearAxis(){ Maximum = 100 };
		LineSeries line = new LineSeries();
		line.Stroke = new SolidColorBrush(Colors.Orange);
		line.StrokeThickness = 2;
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 20 });
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 40 });
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 35 });
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 40 });
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 30 });
		line.DataPoints.Add(new CategoricalDataPoint() { Value = 50 });
		chart.Series.Add(line);
		this.LayoutRoot.Children.Add(chart);
{{endregion}}

#### __[VB.NET] Example 5: Declare a chart in code-behind__

{{region radchart-static-data_5}}
		Dim chart As New RadCartesianChart()
		chart.HorizontalAxis = New CategoricalAxis()
		chart.VerticalAxis = New LinearAxis() With {.Maximum = 100}
		Dim line As New LineSeries()
		line.Stroke = New SolidColorBrush(Colors.Orange)
		line.StrokeThickness = 2
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 20})
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 40})
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 35})
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 40})
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 30})
		line.DataPoints.Add(New CategoricalDataPoint() With {.Value = 50})
		chart.Series.Add(line)
		Me.LayoutRoot.Children.Add(chart)
	{{endregion}}

This is all we need - a chart object with axes specifically chosen to provide an intuitive coordinate system. Then we add a series object to visualize our set of data points and finally we fill the series with data. Check __Figure 1__.

#### __Figure 1: RadCharView with static data__
![Rad Charting Kit-radchart introduction](images/radchartview-chart_introduction.PNG)

The chart can be further customized. For example you may want to add a grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. This can be achieved with the __RadCartesianGrid__ and his properties __MajorLinesVisibility__ and __StripLinesVisibility__. Both properties can be set to XY, X , Y or None (the default one).
        

#### __[XAML] Example 6: Declare grid lines in chart__

{{region radchart-static-data_6}}
	<telerik:RadCartesianChart.Grid>
	   <telerik:CartesianChartGrid MajorLinesVisibility="XY" />
	</telerik:RadCartesianChart.Grid>
{{endregion}}

The example in __Figure 2__ demonstrates how the line chart will look like with its MajorLinesVisibility set to XY.

#### __Figure 2: Setting the MajorLinesVisibility property__
![Rad Chart View-chart majorlines](images/RadChartView-chart_majorlines.PNG)

To enable striplines you should set some brushes. See __Example 7__.
        
#### __[XAML] Example 7: Stylize the grid lines__

{{region radchart-static-data_7}}
	<telerik:CartesianChartGrid MajorLinesVisibility="XY" StripLinesVisibility="XY" IsTabStop="False">
	    <telerik:CartesianChartGrid.YStripeBrushes>
			<SolidColorBrush Color="#FFD7D7D7" Opacity="0.3" />
			<SolidColorBrush Color="Transparent" />
	    </telerik:CartesianChartGrid.YStripeBrushes>
	    <telerik:CartesianChartGrid.XStripeBrushes>
			<SolidColorBrush Color="#FFD7D7D7" Opacity="0.3" />
			<SolidColorBrush Color="Transparent" />
	    </telerik:CartesianChartGrid.XStripeBrushes>
	</telerik:CartesianChartGrid>
{{endregion}}

#### __Figure 3: Stylized grid lines__
![Rad Chart View-chart Stylize majorlines](images/radchartview-chart_majorlines_stylize.PNG)

## See Also
 * [Introduction] ({%slug radchartview-introduction%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
 * [ChartDataSource]({%slug radchartview-populating-with-data-chartdatasource%})
 {% if site.site_name == 'WPF' %}* [Binding to a DataTable] ({%slug radchartview-populating-with-data-binding-to-data-table%}){% endif %}
 * [Binding the Color of Series Items] ({%slug radchartview-populating-with-data-binding-the-color-of-series-items%})
