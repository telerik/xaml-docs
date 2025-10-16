---
title: Indicators
page_title: Indicators
description: Check our &quot;Indicators&quot; documentation article for the RadSparkLine {{ site.framework_name }} control.
slug: radsparkline-features-indicators
tags: indicators, markers, highpoint, lowpoint,
published: True
position: 2
---

# Indicators

The controls from the RadSparkline suite support several types of indicators which can be used to highlight the plotted data.

## Markers

The markers are visual indicators showing the location of each data point along the graph line. This setting is applicable to sparkline controls deriving from __RadLinearSparklineBase__ - RadLinearSparkline and RadAreaSparkline. To enable the markers set the __ShowMarkers__ property to True.

__Example 1: Show markers of RadLinearSparkline in XAML__
```XAML
	 <telerik:RadLinearSparkline ShowMarkers="True" />
```

__Example 2: Show markers of RadLinearSparkline in code__
```C#	
	this.sparklineControl.ShowMarkers = true;
```

#### __Figure 1: RadLinearSparkline and RadAreaSparkline with shown markers__
![RadLinearSparkline and RadAreaSparkline](images/radsparkline-features-indicators-0.png)

You can change the color of the marker via the __MarkersBrush__ property.

The markers can be customized via the __MarkersStyle__ property of the control.

__Example 3: Setting MarkersStyle__
```XAML	
	<telerik:RadLinearSparkline.MarkersStyle>
		<Style TargetType="telerik:IndicatorItem">                    
			<Setter Property="telerik:RadToolTipService.ToolTipContent" Value="{Binding DataItem}" />
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:IndicatorItem">
						<Rectangle Fill="{TemplateBinding Fill}" Width="10" Height="10" />
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</telerik:RadLinearSparkline.MarkersStyle>
```

#### __Figure 2: RadLinearSparkline with custom MarkersStyle__
![RadLinearSparkline with custom MarkersStyle](images/radsparkline-features-indicators-1.png)

## High Point

This is a visual indicator which highlights the single highest-value datapoint in a series. In case there is more than one high point, all such points are highlighted. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine, the bar which represents the highest value is highlighted. The highpoint is enabled by setting the __ShowHighPointIndicator__ property to True.

__Example 4: Show high point indicator of RadColumnSparkline in XAML__
```XAML
	 <telerik:RadColumnSparkline ShowHighPointIndicators="True" />
```

__Example 5: Show high point indicator of RadColumnSparkline in code__
```C#
	this.sparklineControl.ShowHighPointIndicators = true;
```

#### __Figure 3: RadColumnSparkline with shown high point indicator__
![RadColumnSparkline with shown high point indicator](images/radsparkline-features-indicators-2.png)

You can change the color of the high point indicator via the __HighPointBrush__ property.

You can customize the appearance of the data point via the __HighPointStyle__ property.

__Example 6: Setting HighPointStyle__
```XAML	
	<telerik:RadColumnSparkline.HighPointStyle>
		<Style TargetType="telerik:Column">
			<Setter Property="Opacity" Value="0.5" />
		</Style>
	</telerik:RadColumnSparkline.HighPointStyle>
```

#### __Figure 4: RadColumnSparkline with custom HighPointStyle__
![RadColumnSparkline with custom HighPointStyle](images/radsparkline-features-indicators-3.png)

## Low Point

This is a visual indicator which highlights the single lowest-value datapoint in a series. In case there is more than one such point, all similar points are highlighted. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine, the bar which represents the lowest value is highlighted. The low point is enabled by setting the __ShowLowPointIndicator__ property to True.

__Example 7: Show low point indicator of RadColumnSparkline in XAML__
```XAML
	 <telerik:RadColumnSparkline ShowLowPointIndicators="True" />
```

__Example 8: Show low point indicator of RadColumnSparkline in code__
```C#
	this.sparklineControl.ShowLowPointIndicators = true;
```

#### __Figure 5: RadColumnSparkline with shown low point indicator__
![RadColumnSparkline with shown low point indicator](images/radsparkline-features-indicators-4.png)

You can change the color of the low point indicator via the __LowPointBrush__ property.

You can customize the appearance of the data point via the __LowPointStyle__ property.

__Example 9: Setting LowPointStyle__
```XAML	
	<telerik:RadColumnSparkline.LowPointStyle>
		<Style TargetType="telerik:Column">
			<Setter Property="Opacity" Value="0.5" />
		</Style>
	</telerik:RadColumnSparkline.LowPointStyle>
```

#### __Figure 6: RadColumnSparkline with custom LowPointStyle__
![RadColumnSparkline with custom LowPointStyle](images/radsparkline-features-indicators-5.png)

## Negative Points

These visual indicators highlight all negative data points in a series. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine the bars which represent negative values are highlighted. The negative points indicators are enabled by setting the __ShowNegativePointsIndicator__ to True.

__Example 10: Show negative points of RadLinearSparkline in XAML__
```XAML
	 <telerik:RadLinearSparkline ShowNegativePointIndicators="True" />
```

__Example 11: Show negative points of RadLinearSparkline in code__
```C#	
	this.sparklineControl.ShowNegativePointIndicators = true;
```

#### __Figure 7: RadLinearSparkline with shown negative point indicators__
![RadLinearSparkline with shown negative point indicators](images/radsparkline-features-indicators-6.png)

You can change the color of the negative points via the __NegativePointBrush__ property.

The negative points can be customized via the __NegativePointStyle__ property of the control.

__Example 12: Setting NegativePointStyle (see Figure 7)__
```XAML	
	<telerik:RadLinearSparkline.NegativePointStyle>
		<Style TargetType="telerik:IndicatorItem">			
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:IndicatorItem">
						<Ellipse Fill="{TemplateBinding Fill}" Width="10" Height="10" />
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</telerik:RadLinearSparkline.NegativePointStyle>
```

## First Point

This is a visual indicator, which highlights the first data point in a series. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine the bar which represents the first data point is highlighted. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine the first bar is highlighted.

The first point is enabled in the series by setting the __ShowFirstPointIndicator__ property to True.

__Example 13: Show first point of RadLinearSparkline in XAML__
```XAML
	 <telerik:RadLinearSparkline ShowFirstPointIndicator="True" />
```

__Example 14: Show first point of RadLinearSparkline in code__
```C#	
	this.sparklineControl.ShowFirstPointIndicator = true;
```

#### __Figure 8: RadLinearSparkline with shown first point indicator__
![RadLinearSparkline with shown first point indicator](images/radsparkline-features-indicators-7.png)

You can change the color of the first point via the __FirstPointBrush__ property.

The first point can be customized via the __FirstPointStyle__ property of the control.

__Example 15: Setting FirstPointStyle (see Figure 8)__
```XAML	
	<telerik:RadLinearSparkline.FirstPointStyle>
		<Style TargetType="telerik:IndicatorItem">			
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:IndicatorItem">
						<Ellipse Fill="{TemplateBinding Fill}" Width="10" Height="10" />
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</telerik:RadLinearSparkline.FirstPointStyle>
```

## Last Point 

This is a visual indicator which highlights the last data point in a series. If the spark line is of type RadColumnSparkline or RadWinLossSparkLine the bar which represents the last value is highlighted. The last point is indicated in the series, by setting the __ShowLastPointIndicator__ property to True.

__Example 16: Show last point of RadLinearSparkline in XAML__
```XAML
	 <telerik:RadLinearSparkline ShowFirstPointIndicator="True" />
```

__Example 17: Show last point of RadLinearSparkline in code__
```C#	
	this.sparklineControl.ShowFirstPointIndicator = true;
```

#### __Figure 9: RadLinearSparkline with shown last point indicator__
![RadLinearSparkline with shown last point indicator](images/radsparkline-features-indicators-8.png)

You can change the color of the last point via the __LastPointBrush__ property.

The last point can be customized via the __LastPointStyle__ property of the control.

__Example 18: Setting LastPointStyle (see Figure 9)__
```XAML	
	<telerik:RadLinearSparkline.LastPointStyle>
		<Style TargetType="telerik:IndicatorItem">			
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:IndicatorItem">
						<Ellipse Fill="{TemplateBinding Fill}" Width="10" Height="10" />
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</telerik:RadLinearSparkline.LastPointStyle>
```

## Empty Points

There are cases when the collection of data to which the Sparkline is bound may contain empty elements (null values) with no data to which the control can bind and visualize. The behavior of the control in such cases is governed by the __EmptyPointBehavior__ property of the control. There are two possible settings:

* __DropPoint__: The empty point is removed. This is the __default__ value.
* __ShowAsZero__: The empty point visualizes as though its original value was zero.

__Example 19: Setting EmptyPointBehavior__
```XAML	
	<telerik:RadColumnSparkline EmptyPointBehavior="ShowAsZero" />
```

#### __Figure 10: RadLinearSparkline and RadColumnSparkline with a single null value shown as zero__
![RadLinearSparkline and RadColumnSparkline](images/radsparkline-features-indicators-9.png)

## See Also
* [Data Binding]({%slug radsparkline_databinding%})
