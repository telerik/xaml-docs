---
title: Multi-series Charts
page_title: Multi-series Charts
description: Multi-series Charts
slug: radchart-features-multi-series-charts
tags: multi-series,charts
published: True
position: 6
---

# Multi-series Charts



## 

__RadChart__ provides support of multi-series charts. This is useful, when you want to display two or more charts bound to different data series on the same chart area. Usually these data series are semantically related and putting them together allows the user to compare the values easily.

On the snapshot below, the Turnover is represented by line chart, while the Expenses - by bar chart. As you can see, it is much easier to compare both of the values visually.




         
      ![](images/RadChart_Features_MultiseriesCharts_01.png)

Here is the sample XAML source code used to create this chart declaratively:

#### __XAML__

{{region radchart-features-multi-series-charts_0}}
	<telerikCharting:ChartArea.DataSeries>
	   <!-- Line Chart -->
	   <telerikCharting:DataSeries LegendLabel="Turnover">
	       <telerikCharting:DataSeries.Definition>
	           <telerikCharting:LineSeriesDefinition>
	           </telerikCharting:LineSeriesDefinition>
	       </telerikCharting:DataSeries.Definition>
	       <telerikCharting:DataPoint YValue="154"/>
	       <telerikCharting:DataPoint YValue="138"/>
	       <telerikCharting:DataPoint YValue="143"/>
	       <telerikCharting:DataPoint YValue="120"/>
	       <telerikCharting:DataPoint YValue="135"/>
	       <telerikCharting:DataPoint YValue="125"/>
	       <telerikCharting:DataPoint YValue="179"/>
	       <telerikCharting:DataPoint YValue="170"/>
	       <telerikCharting:DataPoint YValue="198"/>
	       <telerikCharting:DataPoint YValue="187"/>
	       <telerikCharting:DataPoint YValue="193"/>
	       <telerikCharting:DataPoint YValue="176"/>
	   </telerikCharting:DataSeries>
	
	   <!-- Bar Chart -->
	   <telerikCharting:DataSeries LegendLabel="Expenses">
	       <telerikCharting:DataSeries.Definition>
	           <telerikCharting:BarSeriesDefinition>
	           </telerikCharting:BarSeriesDefinition>
	       </telerikCharting:DataSeries.Definition>
	       <telerikCharting:DataPoint YValue="45"/>
	       <telerikCharting:DataPoint YValue="48"/>
	       <telerikCharting:DataPoint YValue="53"/>
	       <telerikCharting:DataPoint YValue="41"/>
	       <telerikCharting:DataPoint YValue="32"/>
	       <telerikCharting:DataPoint YValue="28"/>
	       <telerikCharting:DataPoint YValue="63"/>
	       <telerikCharting:DataPoint YValue="74"/>
	       <telerikCharting:DataPoint YValue="77"/>
	       <telerikCharting:DataPoint YValue="85"/>
	       <telerikCharting:DataPoint YValue="89"/>
	       <telerikCharting:DataPoint YValue="80"/>
	   </telerikCharting:DataSeries>
	</telerikCharting:ChartArea.DataSeries>
	{{endregion}}



However, if you want to create this chart in the code-behind take a look at the [Creating Chart in Code Behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%}) topic. If you prefer to use data binding, take a look at the [Data Binding with Automatic Series Mappings]({%slug radchart-populating-with-data-data-binding-with-automatic-series-binding%}) topic and the [Data Binding with Manual Series Mapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%}) topic. To learn how to create a chart with multiple chart areas read the [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%}) topic.

# See Also

 * [2D Charts]({%slug radchart-features-chart-types-2d-charts%})

 * [3D Charts]({%slug radchart-features-chart-types-3d-charts%})

 * [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%})

 * [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})

 * [Data Binding to Nested Collections]({%slug radchart-populating-with-data-data-binding-to-nested-collections%})
