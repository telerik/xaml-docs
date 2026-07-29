---
title: Labels
page_title: Labels
description: Check our &quot;Labels&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radial-scale-labels
tags: labels
published: True
position: 2
---

# Labels

Tick labels are shown for major tick marks. You can set label location around scale bar, font properties (like family, size and foreground), format of the label, or even change whole control template for label. 

For the purpose of this tutorial the code snippet in __Example 1__ will be used.

__Example 1: RadialScale example__
<snippet id='radgauge-radial-scale-labels-example_1_radialscale_example-xaml' />


## Label Location

You can change the location of the labels by using the __LabelLocation__. 

![{{ site.framework_name }} RadGauge RadRadialGauge Label Location](images/radial-scale-labels-labellocation.png)

## Label Rotation Mode

You can control the label rotation on the radial scale using __LabelRotationMode__ property. It can have the following values: __None__, 
__Automatic__, __SurroundIn__, __SurroundOut__. 

![{{ site.framework_name }} RadGauge RadRadialGauge Label Rotation Mode](images/radial-scale-labels-label_rotation-mode.png)

## Label Use Range Color

You can use the GaugeRange element on a radial scale to re-color labels automatically. The RadialScale has the boolean __LabelUseRangeColor__ property. If it is True, then each label within the range uses a color according to the specified range's LabelForeground property:

![{{ site.framework_name }} RadGauge RadRadialGauge Label Use Range Color](images/RadialScaleLabelRangeColor.png)

__Example 2: Set the LabelUseRangeColor property__
<snippet id='radgauge-radial-scale-labels-example_2_set_the_labeluserangecolor_property-xaml' />


## Label Format

To change the format of the labels, you can use the __LabelFormat__ property. __Example 3__ demonstrate how you could add a **%** symbol to the labels.

__Example 3: Set the LabelFormat property__
<snippet id='radgauge-radial-scale-labels-example_3_set_the_labelformat_property-xaml' />


![{{ site.framework_name }} RadGauge RadRadialGauge Label Format](images/radial-scale-labels-label_format.png)

## Label Offset

In a scenario where you want to offset the labels in order to avoid overlaps for example, you can set the __LabelOffset__ property.

__Example 3: Set the LabelOffset property__
<snippet id='radgauge-radial-scale-labels-example_3_set_the_labeloffset_property-xaml' />


![{{ site.framework_name }} RadGauge Label Format Label Offset](images/radial-scale-labels-label_offset.png)

## Common Properties

Other properties which can be used to further customize the labels are:

* LabelTemplate
* LabelTooltipFormat
* LabelToolTipStyle
* LabelToolTipTemplate
