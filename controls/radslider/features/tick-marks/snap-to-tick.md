---
title: Snap to Tick
page_title: Snap to Tick
description: Check our &quot;Snap to Tick&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-snap-to-tick
tags: snap,to,tick
published: True
position: 3
---

# Snap to Tick



## 

When the __IsSnapToTickEnabled__ property is set to __True__ and you drag the thumb, click the handles or simply click the track, then the thumb snaps to the nearest tick.

* When the __IsSnapToTickEnabled__ property is set to __True__, draging the thumb or clicking on the track will move the thumb to the nearest tick 
        



<snippet id='radslider-features-tick-marks-snap-to-tick-block_1-xaml' />



* If the __RadSlider__ handles are displayed, clicking on them will move the thumb to the nearest tick as long as the __IsSnapToTickEnabled__ property is set to __True__



<snippet id='radslider-features-tick-marks-snap-to-tick-block_2-xaml' />



>The __IsSnapToTickEnabled__ property has a higher priority than the __IsMoveToPointEnabled__ property. This is why if you set both properties to __True__, clicking on the track will move the thumb to the nearest tick.