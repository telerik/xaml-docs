---
title: Ticks and Tick frequency
page_title: Ticks and Tick frequency
description: Check our &quot;Ticks and Tick frequency&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-ticks-and-tick-frequency
tags: ticks,and,tick,frequency
published: True
position: 0
---

# Ticks and Tick frequency



## 

The __Ticks__ property allows you to place marks(ticks) along the track in a __non-uniform__ manner, unlike the __TickFrequency__ property which places the ticks on equal intervals. The __Ticks__ property is of type __DoubleCollection__ and its default value is null. This property has to be combined with setting __TickPlacement__ to something different than __None__.
        



<snippet id='radslider-features-tick-marks-ticks-and-tick-frequency-block_1-xaml' />





<snippet id='radslider-features-tick-marks-ticks-and-tick-frequency-block_2-cs' />
<snippet id='radslider-features-tick-marks-ticks-and-tick-frequency-block_3-vb' />

![{{ site.framework_name }} RadSlider Custom Tick Collection](images/radslider_features_ticks_custom.png)

The __TickFrequency__ property on the other hand allows you to place marks(ticks) along the track in a __uniform__ manner. On the example bellow, since the __Maximum__ is 10 and the __TickFrequency__ is 2, this means that there will be tick marks at 0, 2, 4, 6, 8 and 10.



<snippet id='radslider-features-tick-marks-ticks-and-tick-frequency-block_4-xaml' />

![{{ site.framework_name }} RadSlider Tick Frequency](images/radslider_features_ticks_default.png)