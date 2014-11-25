---
title: Customizing Axes by Using Implicit Styles
page_title: Customizing Axes by Using Implicit Styles
description: Customizing Axes by Using Implicit Styles
slug: radchartview-styles-and-templates-customizing-axes
tags: customizing,axes,by,using,implicit,styles
publish: True
position: 4
---

# Customizing Axes by Using Implicit Styles

RadChartView supports several types of axes. All of them are represented by the abstract Axis class that is responsible for displaying the labels and ticks.

![radchartview-styles-and-templates-customizing-axes](images/radchartview-styles-and-templates-customizing-axes.png)

This relates the UI in the following way – there is simply no separate Style for each Axis Type. Instead all axes are BasedOn one and the same style with Key AxisStyle. Each time you want to customize your axis you should inherit this style in XAML. For example:#_XAML_

#### __XAML__	
	<FrameworkElement.Resources>
		<Style TargetType="telerik:DateTimeContinuousAxis" BasedOn="{StaticResource AxisStyle}">
			<Setter Property="Foreground" Value="White" />
			<Setter Property="FontSize" Value="13" />
		</Style>
	</FrameworkElement.Resources>

# See Also
 * [Axis]({%slug radchartview-axes-axis%})
 * [Series and Axes]({%slug radchartview-series-and-axes%})