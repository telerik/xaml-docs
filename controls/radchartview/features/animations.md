---
title: Animations
page_title: Animations
description: Check our &quot;Animations&quot; documentation article for the RadChartView {{ site.framework_name }} control.
components: ["chartview"]
slug: radchartview-features-animations
tags: Animations
published: True
position: 1
---

# Animations

Since __R2 2018__, RadChartView supports built-in and custom animations for series and their points. Set __SeriesAnimation__, __PointAnimation__, or both to the animation you want to use. Call __PlaySeriesAnimation()__ or __PlayPointAnimations()__ to animate the corresponding elements.

* [Animation Types](#animation-types)
	* [Animation Base Class](#animation-base-class)
	* [Move Animation](#move-animation)
	* [Reveal Animation](#reveal-animation)
	* [Fade Animation](#fade-animation)
	* [Drop and Fade Animation](#drop-and-fade-animation)
	* [Scale Animation](#scale-animation)
	* [Pie Chart Angle Range Animation](#pie-chart-angle-range-animation)
	* [Pie Chart Radius Factor Animation](#pie-chart-radius-factor-animation)
* [Custom Animation](#custom-animation)
* [Events](#events)
* [Series Animations Support](#series-animations-support)
* [Notes](#notes)

<a id="figure-1-chart-animations"></a>

**Figure 1: Chart animations**

Animations change the position, visibility, size, or pie geometry of chart elements over time. The sections below describe each effect and its settings without requiring playback.

[Open the chart animation demonstration (looping GIF)](images/radchartview-features-animations-main-animations.gif). Animations on this page are linked rather than played automatically.

## Animation Types

There are several different built-in animations which can be used to animate the chart series and their points. Each animation allows you to apply duration, delay and an easing function to its animated effect. The easing functions make the animation much more realistic and smoother. There is a set of predefined easing functions in WPF and you are allowed to create custom ones, too.

>note For more information, see Microsoft's [Easing Functions documentation](https://msdn.microsoft.com/en-us/library/ee308751%28v=VS.100%29.aspx?f=255&MSPPError=-2147217396).

### Animation Base Class

The built-in animations of the chart derives from the __ChartAnimationBase__ base class. All animation expose the following properties which can be used to further customize their effect.

* __Delay:__ A property of type __TimeSpan__ that gets or sets the delay of the chart animation instance.
* __Duration:__ A property of type __TimeSpan__ that gets or sets the duration of the chart animation instance.
* __Easing:__ A property of type __IEasingFunction__ that gets or sets the easing function used in this chart animation instance.

### Move Animation

The __ChartMoveAnimation__ animates the sliding effect of the series/point from the four sides of the plot area to their places on the plot area. To modify the animation you can use the following properties:

* __MoveAnimationType:__ A property of type __MoveAnimationType__ that gets or sets from which side of the chart plot area the elements animation starts. The move animation type property is an enumeration and it allows the following values:
	* Left: Default value. When set the series or points are moved starting from the __left__ side of the plot area.
	* Top: When set series or points are moved starting from the __top__ side of the plot area.
	* Right: When set series or points are moved starting from the __right__ side of the plot area.	
	* Bottom: When set series or points are moved starting from the __left__ side of the plot area.

__Example 1: Setting move animation in XAML__
<snippet id='radchartview-features-animations-example_1_setting_move_animation_in_xaml-xaml' />


<a id="figure-2-this-animation-look-as-follows"></a>

**Figure 2: Move animation**

Series or points slide from the selected side of the plot area to their plotted positions.

[Open the move animation demonstration (looping GIF)](images/radchartview-features-animations-MoveAnimation.gif).

### Reveal Animation

The __ChartRevealAnimation__  animation animates the clipping of the series and their points. The revealing can be horizontally or vertically.

* __AnimationDirection:__ A property of type __AnimationDirection__ that gets or sets the direction of the animation. The animation direction property is an enumeration and it allows the following values:
	* __In:__ Default value. When set the animation animates an element that appears.
	* __Out:__ 	When set the animation animates an element that disappears.
* __Orientation:__ A property of type __Orientation__ that gets or sets the orientation of the animation. The orientation property is an enumeration and it allows the following values:
	* __Horizontal:__ Default value. When set the animation is horizontally oriented.
	* __Vertical:__ When set the animation is vertically oriented.

__Example 2: Setting reveal animation in XAML__
<snippet id='radchartview-features-animations-example_2_setting_reveal_animation_in_xaml-xaml' />


<a id="figure-3-this-animation-look-as-follows"></a>

**Figure 3: Reveal animation**

A horizontal or vertical clipping effect reveals or hides the series and points, according to __AnimationDirection__ and __Orientation__.

[Open the reveal animation demonstration (looping GIF)](images/radchartview-features-animations-reveal-animation.gif).

### Fade Animation

The __ChartFadeAnimation__ fades in the series and their points. The fade effect can be additionally modified by specifying the fade range using the __MinOpacity__ and __MaxOpacity__ properties.

* __MinOpacity:__ A property of type __double__ that gets or sets the initial opacity of the animation. Default value is __0.01__
* __MaxOpacity:__ A property of type __double__ that gets or sets the final opacity of the animation. Default value is __1__.

__Example 3: Setting fade animation in XAML__
<snippet id='radchartview-features-animations-example_3_setting_fade_animation_in_xaml-xaml' />


<a id="figure-4-this-animation-look-as-follows"></a>

**Figure 4: Fade animation**

Series and points become visible as their opacity changes from __MinOpacity__ to __MaxOpacity__.

[Open the fade animation demonstration (looping GIF)](images/radchartview-features-animations-fade-animation.gif).

### Drop and Fade Animation

The __ChartDropFadeAnimation__ derives from __ChartMoveAnimation__. The difference here is that this animation add additional fade in effect.

__Example 4: Setting drop and fade animation in XAML__
<snippet id='radchartview-features-animations-example_4_setting_drop_and_fade_animation_in_xaml-xaml' />


<a id="figure-5-this-animation-look-as-follows"></a>

**Figure 5: Drop and fade animation**

The move effect is combined with a fade-in effect, so chart elements move into position while becoming visible.

[Open the drop and fade animation demonstration (looping GIF)](images/radchartview-features-animations-drop-fade-animation.gif).

### Scale Animation

The __ChartScaleAnimation__ animates the size of the series and their points. You can customize this animation by setting the starting point of the animation and the scale mode.

* __MinScale:__ A property of type __double__ that gets or sets the initial scale of the animation.
* __MaxScale:__ A property of type __double__ that gets or sets the final scale of the animation.
* __RenderTransformOrigin:__ A property of type __Point__ that gets or sets the starting point of the scaling. Default value is Point(0.5,0.5).
* __ScaleMode:__ A property of type __ScaleMode__ that gets or sets the orientation of the animation. The scale mode property is an enumeration and it allows the following values:
	* __Horizontal:__ Default value. When set the scaling is performed horizontally.
	* __Vertical:__ When set the scaling is performed vertically.
	* __Both:__ When set the scaling is performed in both directions.

__Example 5: Setting scale animation in XAML__
<snippet id='radchartview-features-animations-example_5_setting_scale_animation_in_xaml-xaml' />


<a id="figure-6-this-animation-look-as-follows"></a>

**Figure 6: Scale animation**

Series and points change size from __MinScale__ to __MaxScale__, horizontally, vertically, or in both directions.

[Open the scale animation demonstration (looping GIF)](images/radchartview-features-animations-scale-animation.gif).

### Pie Chart Angle Range Animation

>important Set __PieChartAngleRangeAnimation__ on the __SeriesAnimation__ property to animate the __AngleRange__ of the PieSeries.

The __PieChartAngleRangeAnimation__ animates the __AngleRange__ property of the PieSeries. It animates simultaneously the __StartAngle__ and __SweepAngle__ properties of the __AngleRange__. The __StartAngle__ specifies the start angle from which the arc starts and the __SweepAngle__ specifies the angle that defines the length of the arc. Their default value is __(0,360)__. The first animation will animates the rotation of the pie starting from __InitialStartAngle(-90)__  to  __StartAngle(0)__  and second animation will animate the unroll of the series staring from __InitialSweepAngle(0)__  to __SweepAngle(360)__.

* __InitialStartAngle:__ A property of type __double__ that gets or sets the initial value of the start angle. Default value is __-90__.
* __InitialSweepAngle:__ A property of type __double__ that gets or sets the initial value of the sweep angle. Default value is __0__.

__Example 6: Setting pie chart angle range animation in XAML__
<snippet id='radchartview-features-animations-example_6_setting_pie_chart_angle_range_animation_in_xaml-xaml' />


<a id="figure-7-this-animation-look-as-follows"></a>

**Figure 7: Pie chart angle range animation**

The pie rotates from its initial start angle and unrolls from its initial sweep angle to the configured __AngleRange__.

[Open the pie chart angle range animation demonstration (looping GIF)](images/radchartview-features-animations-pie-angle-range-animation.gif).

### Pie Chart Radius Factor Animation

>important Set __PieChartRadiusFactorAnimation__ on the __SeriesAnimation__ property to animate the __RadiusFactor__ of the PieSeries.

The __PieChartRadiusFactorAnimation__ animates the __RadiusFactor__ property of the PieSeries. The animation stars from 0 to the value of the __RadiusFactor__ property.

__Example 7: Setting pie chart radius factor animation in XAML__
<snippet id='radchartview-features-animations-example_7_setting_pie_chart_radius_factor_animation_in_xaml-xaml' />


<a id="figure-8-this-animation-look-as-follows"></a>

**Figure 8: Pie chart radius factor animation**

The pie grows from a radius factor of zero to the configured __RadiusFactor__.

[Open the pie chart radius factor animation demonstration (looping GIF)](images/radchartview-features-animations-pie-radius-factor-animation.gif).

## Custom Animation

To create a custom animation, derive a class from __ChartAnimationBase__. Override __BuildPointAnimation()__ or __BuildSeriesAnimation()__ to define the effect. __Example 8__ demonstrates a custom point animation.

__Example 8: Custom point animation__
<snippet id='radchartview-features-animations-example_8_custom_point_animation-cs' />


Assign the custom animation in XAML as follows.

__Example 8: Setting custom animation in XAML__
<snippet id='radchartview-features-animations-example_8_setting_custom_animation_in_xaml-xaml' />


<a id="figure-9-this-custom-animation-look-as-follows"></a>

**Figure 9: Custom animation**

The custom point animation is defined in Example 8 and assigned through XAML. Use the code example to examine the animation without playing it.

[Open the custom chart animation demonstration (looping GIF)](images/radchartview-features-animations-custom-animation.gif).

## Events

This section covers the events exposed for the animation.
* __PointAnimationsCompleted:__ This event is fired when the animation for all datapoints of the series is completed.
* __SeriesAnimationCompleted:__ This event is fired when the animation of the series is completed.

## Series Animations Support

The RadChartView series supports animations for its series and data points. Depending on the type of the series, the supported animation can be SeriesAnimation or PointAnimation, or as in some series, both.

### CartesianChart Series	

| Series | Series Animation | Point Animation |
|---------|---------|---------|
| Area Series | YES | YES |
| Bar Series | NO | YES |
| Bubble Series | NO | YES |
| CandleStick Series | NO | YES |
| Line Series | YES | YES |
| OHLC Series  | NO | YES |
| Point Series  | NO | YES |
| Range Bar Series  | NO | YES |
| Range Series  | YES | NO |
| Range Spline Series | YES | NO |
| Scatter Area Series | YES | YES |
| Scatter Bubble Series | NO | YES |
| Scatter Line Series | YES | YES |
| Scatter Point Series | NO | YES |
| Scatter Spline Area Series | YES | YES |
| Scatter Spline Series | YES | YES |
| Spline Area Series | YES | YES |
| Spline Series | YES | YES |
| Step Area Series | YES | YES |
| Step Line Series | YES | YES |

### PieChart Series

| Series | Series Animation  | Point Animation |
|---------|---------|---------|
| Pie Series | YES | YES |
| Dougnat Series | YES | YES |

### PolarChart Series

| Series | Series Animation  | Point Animation |
|---------|---------|---------|
| Polar Area Series | YES | YES |
| Polar Line Series | YES | YES |
| Polar Point Series | NO | YES |
| Radar Area Series | YES | YES |
| Radar Line Series | YES | YES |
| Radar Point Series | NO | YES |

### FunnelChart Series

| Series | Series Animation  | Point Animation |
|---------|---------|---------|
| Funnel Series | NO | YES |
	

## Notes

* Internally in our code, there is Telerik.Windows.Controls.Animation.CircleEase function. When specifying __CircleEase__ function to the __Easing__ property of the animation you have to use the WPF predefined __Sysmtem.Windows.Media.Animation.CicleEase__ or exception will be thrown.

* Labels in __PointAnimation__ are not animated.

* When using __ScaleAnimation__ the __MaxScale__ property should not be set to a value bigger than 1. Value bigger than 1 will lead to potential misposition of chart elements.

## See Also
* [Chart Series Overview]({%slug radchartview-series-chartseries%})
* [Dynamic Number of Series]({%slug radchartview-features-chartseriesprovider%})
* [Customizing Series Appearance]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%})
