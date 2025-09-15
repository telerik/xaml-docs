---
title: Bar Indicator
page_title: Bar Indicator
description: Check our &quot;Bar Indicator&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: linear-scale-bar-indicator
tags: bar,indicator
published: True
position: 3
---

# Bar Indicator

The Bar indicator is a colored bar that is drawn around scale bar. One of ends of this bar points to the scale value. To add bar indicator to the scale you have to include LinearBar element to the list of the scale indicators:

#### __XAML__
```XAML
	<telerik:RadVerticalLinearGauge Width="100" Height="250" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0" Max="100">
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:BarIndicator Value="50" />
	        </telerik:VerticalLinearScale.Indicators>
	        <telerik:VerticalLinearScale.CustomItems>
	            <Border BorderBrush="#FF606060"
	                    BorderThickness="1,0"
	                    telerik:ScaleObject.Value="50"
	                    telerik:ScaleObject.Location="OverCenter"
	                    telerik:ScaleObject.RelativeHeight="0.8*"
	                    telerik:ScaleObject.RelativeWidth="0.14*"/>
	        </telerik:VerticalLinearScale.CustomItems>
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

![Linear Scale Bar Indicator](images/LinearScaleBarIndicator.PNG)

The Bar indicator supports the following features:

1. Layout 

2. Appearance 

3. Brush is used for the filled part is controlled by Background property.

4. Brush is used for the empty part is controlled by EmptyFill property.

5. You can set stroke thickness (StrokeThickness property) and stroke brush (BorderBrush property).

6. The Bar indicator can be snapped along to scale ticks or to specified interval.

7. Movement animation allows the Bar indicator to smooth its movement when it shows next value.

8. The refresh rate allows calculating the displayed value using values which are assigned during the specified interval according to the specified method.

By default you can set specific color to the bar indicator through the exposed __Background__ property. But sometimes it is useful to change its color depending on the value it points to.

This can be achieved by having several gauge ranges in the linear scale - every range with a specific color set as background. The __UseRangeColor__ property of the bar indicator should be true:

There are several modes which can be used to colorize the bar indicator. Here is the default one:

#### __XAML__
```XAML
	<telerik:RadVerticalLinearGauge Width="100" Height="250" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale IsInteractive="True"
	                         RangeLocation="Outside"
	                         RangeOffset="-0.02*">
	        <telerik:VerticalLinearScale.Ranges>
	            <telerik:GaugeRange Min="0" Max="50"
	                                StartWidth="0.02"
	                                EndWidth="0.02"
	                                Background="#FF23568F"
	                                TickBackground="#FF23568F"
	                                LabelForeground="#FF23568F"
	                                IndicatorBackground="#FF23568F" />
	            <telerik:GaugeRange Min="50" Max="100"
	                                StartWidth="0.02"
	                                EndWidth="0.02"
	                                Background="#FFA0CCFF"
	                                TickBackground="#FFA0CCFF"
	                                LabelForeground="#FFA0CCFF"
	                                IndicatorBackground="#FFA0CCFF" />
	        </telerik:VerticalLinearScale.Ranges>
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:BarIndicator UseRangeColor="True" 
	                                  RangeColorMode="Default"
	                                  Value="60"
	                                  StartWidth="0.06"/>
	        </telerik:VerticalLinearScale.Indicators>
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

If you'd like to have a bar indicator with background that has all range colors, then you should set the __RangeColorMode__ property to "ProportionalBrush":

#### __XAML__
```XAML
	<telerik:RadVerticalLinearGauge Width="100" Height="250" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale IsInteractive="True"
	                         RangeLocation="Outside"
	                         RangeOffset="-0.02*">
	        <telerik:VerticalLinearScale.Ranges>
	            <telerik:GaugeRange Min="0" Max="50"
	                                StartWidth="0.02"
	                                EndWidth="0.02"
	                                Background="#FF23568F"
	                                TickBackground="#FF23568F"
	                                LabelForeground="#FF23568F"
	                                IndicatorBackground="#FF23568F" />
	            <telerik:GaugeRange Min="50" Max="100"
	                                StartWidth="0.02"
	                                EndWidth="0.02"
	                                Background="#FFA0CCFF"
	                                TickBackground="#FFA0CCFF"
	                                LabelForeground="#FFA0CCFF"
	                                IndicatorBackground="#FFA0CCFF" />
	        </telerik:VerticalLinearScale.Ranges>
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:BarIndicator UseRangeColor="True" 
	                                  RangeColorMode="ProportionalBrush"
	                                  Value="60"
	                                  StartWidth="0.06"/>
	        </telerik:VerticalLinearScale.Indicators>
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

Here are the Default and the ProportionalBrush modes:

![{{ site.framework_name }} RadGauge Default and the ProportionalBrush RangeColorMode](images/LinearBarRange.png)

If you need smooth gradients between the colors then use the __GradientBrush__ mode and set the __RangeColorSmoothing__ property:

#### __XAML__
```XAML
	<telerik:VerticalLinearScale.Indicators>
	    <telerik:BarIndicator UseRangeColor="True" 
	                            RangeColorSmoothing="0.5"
	                            RangeColorMode="ProportionalGradient"
	                            Value="60"
	                            StartWidth="0.06"/>
	</telerik:VerticalLinearScale.Indicators>
```

![{{ site.framework_name }} RadGauge BarIndicator GradientBrush and RangeColorSmoothing](images/LinearBarGradientBrush.png)