---
title: Logarithmic Axis
page_title: Logarithmic Axis
description: Logarithmic Axis
slug: radchartview-axes-logarithmicaxis
tags: logarithmic,axis
publish: True
position: 1
---

# Logarithmic Axis



## 

You can specify the logarithmic base via the* LogarithmBase * property

Below is a XAML snippet that demonstrates how to create a logarithmic axis:

#### __XAML__

{{region radchart-axes-logarithmicaxis_0}}
	<telerik:RadCartesianChart x:Name="chart">
	   <telerik:RadCartesianChart.HorizontalAxis>
	      <telerik:LogarithmicAxis LogarithmBase="2"/>
	   </telerik:RadCartesianChart.HorizontalAxis>
	</telerik:RadCartesianChart>
	{{endregion}}


