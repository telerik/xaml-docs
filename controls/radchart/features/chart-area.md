---
title: Chart Area
page_title: Chart Area
description: Chart Area
slug: radchart-features-chart-area
tags: chart,area
published: True
position: 12
---

# Chart Area



## 

__ChartArea__ is the place, where the chart graphic is drawn. The __ChartArea__ represents a layout region of the __RadChart__ control that holds certain chart series and axis data. Additionally, the __ChartArea__ exposes events for customizing the [tooltips]({%slug radchart-features-tooltips%}) and making the chart more [interactive]({%slug radchart-features-interactivity%}).






         
      ![](images/RadChart_Features_ChartArea_01.png)

As you can see on the image above, the __ChartArea__ has two [axes]({%slug radchart-features-axes-overview%}) - X and Y. By default X- and Y-axes are shown for all chart types except for those, which do not have axes at all - Pie and Doughnut charts.

Use [ChartArea.AxisX]({%slug radchart-features-axes-x-axis%}) and [ChartArea.AxisY]({%slug radchart-features-axes-y-axis%}) to access the specific properties of the axes. You can also apply your own styles using __AxisXStyle__ and __AxisYStyle__. Take a look at the [Styling the Axes]({%slug radchart-styling-and-appearance-styling-axes-overview%}) topic for more.

Use the __AdditionalYAxes__ property to add more than one Y-Axis to your chart. To learn more about it read the [Multiple Y Axes]({%slug radchart-features-axes-multiple-y-axes%}) topic.

Use the __PlotAreaAxisXStyle__ and the __PlotAreaAxisYStyle__ properties to set styles for the axes drawn inside the plot area. Example of such axes are the axes drawn in [negative values scenarios]({%slug radchart-features-negative-values%}). 

__RadChart__ also allows you to specify how to format the labels by specifying __ChartArea.LabelFormatBehavior__. The __LabelFormatBehaviour__ enumeration has three values: __HumanReadable__(default), __Scientific__ and __None__. The table below shows how the values will be formatted for the first two options. When __None__ is used the values are converted using __ToString()__ manner:

____
<table> <tr><td><b>Value</b></td><td><b>HumanReadable</b></td><td><b>Scientific</b></td></tr><tr><td>100</td><td>100</td><td>1.0E+2</td></tr><tr><td>100,000</td><td>100 k</td><td>1.0E+5</td></tr><tr><td>100,000,000</td><td>100 mil</td><td>1.0E+8</td></tr><tr><td>100,000,000,000</td><td>100 bil</td><td>1.0E+11</td></tr><tr><td>100,000,000,000,000</td><td>100 tri</td><td>1.0E+14</td></tr><tr><td>1,000,000,000,000,000</td><td>1000 tri</td><td>1.0E+15</td></tr></table>

When you set the label format behavior, all the labels (axes, series item labels, tooltips) will be formatted using the logic shown above. However, if you set [Format Expressions]({%slug radchart-features-format-expressions%}) to an element, then this expression will override the selected __LabelFormatBehavior__. For example, set the format behavior to __Scientific__, but for __X-Axis__ set __DefaultLabelFormat__to "__MMM__":

#### __XAML__

{{region radchart-features-chart-area_0}}
	<telerikChart:radChart >
	    <telerikChart:radChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            ....
	            <telerikCharting:ChartDefaultView.ChartArea>
	                <telerikCharting:ChartArea LabelFormatBehavior="HumanReadable">
	                    <telerikCharting:ChartArea.AxisX>
	                        <telerikCharting:AxisX IsDateTime="True" DefaultLabelFormat="MMM"
	                            LayoutMode="Between" >
	                        </telerikCharting:AxisX>
	                    </telerikCharting:ChartArea.AxisX>
	                    <telerikCharting:ChartArea.DataSeries>
	                        ....
	                    </telerikCharting:ChartArea.DataSeries>
	                </telerikCharting:ChartArea>
	            </telerikCharting:ChartDefaultView.ChartArea>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:radChart.DefaultView>
	</telerikChart:radChart>
	{{endregion}}



#### __C#__

{{region radchart-features-chart-area_1}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	
	radChart.DefaultView.ChartArea.LabelFormatBehavior = LabelFormatBehavior.HumanReadable;
	radChart.DefaultView.ChartArea.AxisX.IsDateTime = true;
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "MMM";
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Between;
	...
	{{endregion}}



#### __VB.NET__

{{region radchart-features-chart-area_2}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	....
	radChart.DefaultView.ChartArea.LabelFormatBehavior = LabelFormatBehavior.HumanReadable
	radChart.DefaultView.ChartArea.AxisX.IsDateTime = True
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "MMM"
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Between
	{{endregion}}



On the image below you can see how the __Y-Axis__ and the series item labels are formatted when __LayoutFormatBehavior__ is set to __HumanReadable__, while the __X-Axis__ is formatted using custom [Format Expressions]({%slug radchart-features-format-expressions%}):




         
      ![](images/RadChart_Features_ChartArea_20.png)

# See Also

 * [Styling the Chart Area]({%slug radchart-styling-and-appearance-styling-chart-area%})

 * [Axes]({%slug radchart-features-axes-overview%})

 * [Format Expressions]({%slug radchart-features-format-expressions%})

 * [Chart Title]({%slug radchart-features-chart-title%})

 * [Chart Legend]({%slug radchart-features-chart-legend%})

 * [DefaultView]({%slug radchart-features-default-view%})

 * [RadChart Visual Structure]({%slug radchart-general-information-visual-structure%})
