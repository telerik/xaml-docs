---
title: Create Compass
page_title: Create Compass
description: Check our &quot;Create Compass&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: chart-customize-radialgauge-layout
tags: create,compass
published: True
position: 1
---

# Create Compass

This example will demonstrate how to customize a __Radial Gauge__ to create compass.

For the purpose we'll create a Radial Gauge with the following parameters that define the radial scale range: __StartAngle__, __SweepAngle__, __Radius__ and several properties for the layout of the Minor and Major Ticks. The __StartAngle__ and __SweepAngle__ are specified in degrees (0 to 360), starting from the right side of the gauge, going clockwise (note, that positive angle direction starts from positive X and goes to the positive Y. Since the screen coordinates start from top-left, the Y axis points downwards, instead of upwards, the positive direction of the angle is clockwise instead of the mathematically accepted counter-clockwise). The scale __Radius__ and __Center__ are measured as a fraction (0.0 to 1.0) of the space available for scale in the surrounding container.
Here is the XAML code:


<snippet id='radgauge-howto-chart-customize-radialgauge-layout-block_1-xaml' />


Our gauge looks like this:

![{{ site.framework_name }} RadGauge Compass](images/gauge_customize_radialgauge.png)

To make it look more like compass we'll need to customize the labels so that they are the four cardinal directions - N(North), E(east), S(south) and W(west). To remove the default gauge labels we'll use *LabelTemplate*. We'll also need to customize the needle. All this will be done via Styles:


<snippet id='radgauge-howto-chart-customize-radialgauge-layout-block_2-xaml' />


Here's the result:

![gauge customize radialgauge compass](images/gauge_customize_radialgauge_compass.PNG)

You may additionally customize the appearance of the compass. For example we can add an outer border and some custom ticks. The full source code for our compass is shown below:


<snippet id='radgauge-howto-chart-customize-radialgauge-layout-block_3-xaml' />


![gauge customize radialgauge compass final](images/gauge_customize_radialgauge_compass_final.PNG)
