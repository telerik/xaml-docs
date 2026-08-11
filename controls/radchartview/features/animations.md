---
title: Animations
page_title: Animations
description: Check our &quot;Animations&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-animations
tags: Animations
published: True
position: 1
---

# Animations

With the __R2 2018__ version of our controls, you can now animate RadChartView series and their points. The series and the points can be animated using either built-in or custom animation effects. To animate the series or the points first you need to set the __SeriesAnimation__ and/or __PointAnimation__ property with your animation. Depending on which element you want to animate (Series,Points or Both) you can call the __PlaySeriesAnimation()__ and __PlayPointAnimations()__ methods. 

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

#### __Figure 1: Chart Animations__
![Telerik UI for WPF RadChartView Chart Animation Demonstration](images/radchartview-features-animations-main-animations.gif)

## Animation Types

There are several different built-in animations which can be used to animate the chart series and their points. Each animation allows you to apply duration, delay and an easing function to its animated effect. The easing functions make the animation much more realistic and smoother. There is a set of predefined easing functions in WPF and you are allowed to create custom ones, too.

>To learn more about the easing functions you can take a look at this [MSDN help article](
https://msdn.microsoft.com/en-us/library/ee308751%28v=VS.100%29.aspx?f=255&MSPPError=-2147217396).

### Animation Base Class

The build-in animations of the chart derives from the __ChartAnimationBase__ base class. All animation expose the following properties which can be used to further customize their effect.

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


#### __Figure 2: This animation look as follows__
![Telerik UI for WPF RadChartView Move Animation](images/radchartview-features-animations-MoveAnimation.gif)

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


#### __Figure 3: This animation look as follows__
![Telerik UI for WPF RadChartView Reveal Animation](images/radchartview-features-animations-reveal-animation.gif)

### Fade Animation

The __ChartFadeAnimation__ fades in the series and their points. The fade effect can be additionally modified by specifying the fade range using the __MinOpacity__ and __MaxOpacity__ properties.

* __MinOpacity:__ A property of type __double__ that gets or sets the initial opacity of the animation. Default value is __0.01__
* __MaxOpacity:__ A property of type __double__ that gets or sets the final opacity of the animation. Default value is __1__.

__Example 3: Setting fade animation in XAML__
<snippet id='radchartview-features-animations-example_3_setting_fade_animation_in_xaml-xaml' />


#### __Figure 4: This animation look as follows__
![Telerik UI for WPF RadChartView Fade Animation](images/radchartview-features-animations-fade-animation.gif)

### Drop and Fade Animation

The __ChartDropFadeAnimation__ derives from __ChartMoveAnimation__. The difference here is that this animation add additional fade in effect.

__Example 4: Setting drop and fade animation in XAML__
<snippet id='radchartview-features-animations-example_4_setting_drop_and_fade_animation_in_xaml-xaml' />


#### __Figure 5: This animation look as follows__
![Telerik UI for WPF RadChartView Drop-Fade Animation](images/radchartview-features-animations-drop-fade-animation.gif)

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


#### __Figure 6: This animation look as follows__
![Telerik UI for WPF RadChartView Scale Animation](images/radchartview-features-animations-scale-animation.gif)

### Pie Chart Angle Range Animation

> The __PieChartAngleRangeAnimation__ build-in animation will animate the __AngleRange__ property of the PieSeries and needs to be set to __SeriesAnimation__ property.

The __PieChartAngleRangeAnimation__ animates the __AngleRange__ property of the PieSeries. It animates simultaneously the __StartAngle__ and __SweepAngle__ properties of the __AngleRange__. The __StartAngle__ specifies the start angle from which the arc starts and the __SweepAngle__ specifies the angle that defines the length of the arc. Their default value is __(0,360)__. The first animation will animates the rotation of the pie starting from __InitialStartAngle(-90)__  to  __StartAngle(0)__  and second animation will animate the unroll of the series staring from __InitialSweepAngle(0)__  to __SweepAngle(360)__.

* __InitialStartAngle:__ A property of type __double__ that gets or sets the initial value of the start angle. Default value is __-90__.
* __InitialSweepAngle:__ A property of type __double__ that gets or sets the initial value of the sweep angle. Default value is __0__.

__Example 6: Setting pie chart angle range animation in XAML__
<snippet id='radchartview-features-animations-example_6_setting_pie_chart_angle_range_animation_in_xaml-xaml' />


#### __Figure 7: This animation look as follows__
![Telerik UI for WPF RadChartView Pie Chart Angle Range Animation](images/radchartview-features-animations-pie-angle-range-animation.gif)

### Pie Chart Radius Factor Animation

>The __PieChartRadiusFactorAnimation__ build-in animation will animate the __RadiusFactor__ property of the PieSeries and needs to be set to __SeriesAnimation__ property.

The __PieChartRadiusFactorAnimation__ animates the __RadiusFactor__ property of the PieSeries. The animation stars from 0 to the value of the __RadiusFactor__ property.

__Example 7: Setting pie chart radius factor animation in XAML__
<snippet id='radchartview-features-animations-example_7_setting_pie_chart_radius_factor_animation_in_xaml-xaml' />


#### __Figure 8: This animation look as follows__
![Telerik UI for WPF RadChartView Pie Chart Radius Factor Animation](images/radchartview-features-animations-pie-radius-factor-animation.gif)

## Custom Animation

All built-in animation of the chart derives from __ChartAnimationBase__. In order to create a custom animation, you need to define a custom class which derives from this base class. This class provides __BuildPointAnimation()__ and __BuildSeriesAnimation()__ methods which can be overridden so you can create your own animation. __Example 2__ demonstrate custom point animation.

__Example 8: Custom point animation__
<snippet id='radchartview-features-animations-example_8_custom_point_animation-cs' />


__Example 8: Setting custom animation in XAML__
<snippet id='radchartview-features-animations-example_8_setting_custom_animation_in_xaml-xaml' />


#### __Figure 9: This custom animation look as follows__
![Telerik UI for WPF RadChartView Custom Chart Animation](images/radchartview-features-animations-custom-animation.gif)

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
