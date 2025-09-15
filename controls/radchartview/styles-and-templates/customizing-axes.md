---
title: Customizing Axes by Using Implicit Styles
page_title: Customizing Axes by Using Implicit Styles
description: Check our &quot;Customizing Axes by Using Implicit Styles&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-styles-and-templates-customizing-axes
tags: customizing,axes,by,using,implicit,styles
publish: True
position: 4
---

# Customizing Axes by Using Implicit Styles

RadChartView supports several types of axes. All of them are represented by the abstract Axis class that is responsible for displaying the labels and ticks.

![radchartview-styles-and-templates-customizing-axes](images/radchartview-styles-and-templates-customizing-axes.png)

This relates the UI in the following way – there is simply no separate Style for each axis type. Instead all axes are BasedOn one and the same style with x:Key AxisStyle. Each time you want to customize your axis you should inherit this style in XAML. 

For the purpose of this tutorial, we will create a sample chart with LineSeries. Then to customize the horizontal and vertical axes we will create two implicit styles which target the axes correspondingly. __Example 1__ demonstrates the full XAML code.

__Example 1: Customizing axes by using implicit styles__	
```XAML
	<Window.Resources>
		<Style TargetType="telerik:CategoricalAxis" BasedOn="{StaticResource AxisStyle}">         
			<Setter Property="FontSize" Value="16" />
			<Setter Property="LabelStyle">
				<Setter.Value>
					<Style TargetType="TextBlock">
						<Setter Property="Foreground" Value="Red"/>
					</Style>
				</Setter.Value>
			</Setter>
		</Style>        
		<Style TargetType="telerik:LinearAxis" BasedOn="{StaticResource AxisStyle}">
			<Setter Property="FontSize" Value="18" />
			<Setter Property="LineStroke" Value="Blue" />
			<Setter Property="LineDashArray" Value="8 2" />
			<Setter Property="LabelTemplate">
				<Setter.Value>
					<DataTemplate>
						<Border BorderBrush="Blue" BorderThickness="1">
							<TextBlock Text="{Binding }"/>
						</Border>
					</DataTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</Window.Resources>
	<Grid>
		<telerik:RadCartesianChart>
			<telerik:RadCartesianChart.HorizontalAxis>
				<telerik:CategoricalAxis/>
			</telerik:RadCartesianChart.HorizontalAxis>
			<telerik:RadCartesianChart.VerticalAxis>
				<telerik:LinearAxis />
			</telerik:RadCartesianChart.VerticalAxis>
			<telerik:RadCartesianChart.Series>
				<telerik:LineSeries>
					<telerik:LineSeries.DataPoints>
						<telerik:CategoricalDataPoint Category="January" Value="2" />
						<telerik:CategoricalDataPoint Category="February" Value="5" />
						<telerik:CategoricalDataPoint Category="March" Value="3" />
						<telerik:CategoricalDataPoint Category="April" Value="10" />
						<telerik:CategoricalDataPoint Category="May" Value="9" />
						<telerik:CategoricalDataPoint Category="June" Value="7" />
						<telerik:CategoricalDataPoint Category="July" Value="1" />
					</telerik:LineSeries.DataPoints>
				</telerik:LineSeries>
			</telerik:RadCartesianChart.Series>
		</telerik:RadCartesianChart>
	</Grid>
```

#### __Figure 1: Customizing axes by using implicit styles__
![Customizing axes by using implicit styles](images/radchartview-styles-and-templates-customizing-axes-0.png)

## See Also
 * [Axis]({%slug radchartview-axes-axis%})
 * [Series and Axes]({%slug radchartview-series-and-axes%})
