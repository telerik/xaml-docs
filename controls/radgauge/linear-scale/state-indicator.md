---
title: State Indicator
page_title: State Indicator
description: Check our &quot;State Indicator&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: linear-scale-state-indicator
tags: state,indicator
published: True
position: 5
---

# State Indicator

The State Indicator is a shape with arbitrary size located anywhere in the scale. If state indicator's value put into one of the scale ranges then shape is filled with brush of this range. To add state indicator to the scale you have to include StateIndicator element to the list of the scale indicators:


<snippet id='radgauge-linear-scale-state-indicator-block_1-xaml' />


![{{ site.framework_name }} RadGauge State Indicator](images/LinearScaleStateIndicator.png)

The State indicator supports the following features:

1. Layout

2. The 'RelativeX' property specifies the position of Numeric Indicator left side relative to a scale width. 

3. The 'RelativeY' property specifies the position of Numeric Indicator top side relative to a scale height. 

4. The 'RelativeHeight' property specifies height of the Numeric Indicator relative to a scale height. 

5. The 'RelativeWidth' property specifies width of the Numeric Indicator relative to a scale height. 

6. Appearance

7. The default State Indicator template exposes the Background, BorderBrush and StrokeThickness properties for easy customizations.

8. You can change the State Indicator's template to setup specific appearance.
