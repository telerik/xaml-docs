---
title: Tick marks
page_title: Tick marks
description: Check our &quot;Tick marks&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radial-scale-tick-marks
tags: tick,marks
published: True
position: 1
---

# Tick marks

Tick marks allow displaying value intervals along the gauge scale. There are 3 types of the tick marks:

1. __Major__ - specify primary value intervals. MajorTicks or MajorTickStep property of the scale specifies the number of the value intervals along the entire length of the scale bar. Major tick marks can have a label. You can specify common properties and appearance for the major tick marks using MajorTick property of the scale.

2. __Middle__ - specify secondary value intervals. MiddleTicks property of the scale specifies the number of the secondary value intervals inside the primary value interval. Middle tick marks can't have labels. You can specify common properties and appearance of the middle tick mark using MiddleTick property of the scale.

3. __Minor__ - specify third level of the value intervals. MinorTicks scale's property specifies number of the third level value intervals inside the secondary value interval. Minor tick marks can't have labels. You can specify common properties and appearance of the minor tick mark using MinorTick property of the scale.

![{{ site.framework_name }} RadGauge RadialScale Types of Tick Marks](images/RadialScaleTickMarks_Desc.png)

There are 2 alternative ways to set number of the major ticks along the scale. This first one is using MajorTicks property. It sets number of the of the value intervals along the entire length of the scale bar:


<snippet id='radgauge-radial-scale-tick-marks-block_1-xaml' />


![{{ site.framework_name }} RadGauge RadialScale Number of Ticks](images/RadialScale10MajorTicks.png)

The second one uses MajorTickStep property. It sets length of the single tick interval in the scale units:


<snippet id='radgauge-radial-scale-tick-marks-block_2-xaml' />


![{{ site.framework_name }} RadGauge RadialScale Tick Step](images/RadialScale20MajorTickStep.png)

Sometimes desirable length of the major tick (MajorTickStep) creates situations when major tick mark at the end point of scale is shown very close to the last regular one:

![{{ site.framework_name }} RadGauge RadialScale Overlapping Ticks](images/RadialScaleCloseTickMarks.png)

In this situation we can use ShowLastLabel property to indicate whether the tick mark at the end position should be shown:


<snippet id='radgauge-radial-scale-tick-marks-block_3-xaml' />


![{{ site.framework_name }} RadGauge RadialScale Hide Last Tick](images/RadialScaleNoEndTickMark.png)

By default, the major tick marks start from the minimum scale value and move clock-wise to the maximum value. But you can shift first and last major tick marks along scale using StartTickOffset and EndTickOffset properties:

To change the layout of the tick marks you may use their correspondent properties:


<snippet id='radgauge-radial-scale-tick-marks-block_4-xaml' />


![{{ site.framework_name }} RadGauge RadialScale Tick Mark Offset](images/RadiaScaleTickMarkOffset.png)

The Major, Middle and Minor ticks have the boolean UseRangeColor property. If it is True, then each tick mark within the specified range uses a color according to the range's TickBackground property:

![{{ site.framework_name }} RadGauge RadialScale Use Range Color](images/RadialScaleTickRangeColor.png)


<snippet id='radgauge-radial-scale-tick-marks-block_5-xaml' />


## Custom Tick Marks

The RadGauge control provides very flexible standard tick marks and labels, but sometimes it is necessary to show additional tick marks and labels in particular scale position. Custom tick marks allow you to do it. Custom tick marks can be placed at a specific value (shown at value 25 in the images below) by setting the Value property. Just like the major and minor tick marks, the look of the custom tick marks can be fully customized.

The additional tick marks are defined in the CustomItems collection of the RadialScale:


<snippet id='radgauge-radial-scale-tick-marks-block_6-xaml' />


![Radial Scale Custom Tick Marks.png](images/RadialScaleCustomTickMarks.png)

## Off position

Some gauge applications require that indicator clearly show when there is not valid data currently available. The special "Off Position" tick mark can be created using CustomTickMark control. When double.NaN value is passed to the scale indicator it looks for "Off position" and points to it if found. You can decorate it on your own using styling and templating ability. To force a particular tick mark to behave like "Off position" you should change its "Type" property to be "OffPosition". You can precisely set position of this tick mark by setting its "Value" property. It can be located outside the scale Max and Min values.
