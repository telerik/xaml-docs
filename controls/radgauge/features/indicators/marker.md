---
title: Marker
page_title: Marker
description: Check our &quot;Marker&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-features-indicators-marker
tags: marker
published: True
position: 1
---

# Marker

The __Marker__ is one of the indicator types that the __RadGauge__ control introduces. It directly inherits the __InteractiveIndicator__ class and doesn't introduce any specific features.

>tip To learn more about the base features of the indicators read [this topic]({%slug radgauge-features-indicators-basics%}).

The __Marker__ control is represented by a triangle shape. The appearance and the shape can be easily modified.

>tip You can change the background and the border color of the Marker via its __Background__ and __BorderBrush__ properties.

>The __Marker__ indicator can be used in both linear and radial scales.

<!-- -->
>Indicators should always be placed inside a __Indicators__ property of the scale object.

Here is an example of a __Marker__ definition:


<snippet id='radgauge-features-indicators-marker-block_1-xaml' />


Here is a snapshot of the result:

![{{ site.framework_name }} RadGauge Marker](images/RadGauge_Features_Indicators_Marker_01.png)