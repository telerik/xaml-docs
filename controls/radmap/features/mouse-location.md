---
title: Mouse Location
page_title: Mouse Location
description: Check our &quot;Mouse Location&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-mouse-location
tags: mouse,location
published: True
position: 7
---

# Mouse Location

The __RadMap__ uses an UI control to display the current mouse location on the map. It displays the latitude and the longitude of the mouse position.

The UI control is represented by the __MapMouseLocationIndicator__ control. You are able to use it outside the __RadMap__ and place it somewhere around it. In this case you have to either hide the original one by using the __MouseLocationIndicatorVisibility__ property of the __RadMap__ or the __UseDefaultLayout__ one.

>tip Setting the __UseDefaultLayout__ property to __False__ will hide all of the UI controls inside the __RadMap__. To learn more read [here]({%slug radmap-features-default-layout%}).

In order to use the __MapMouseLocationIndicator__ outside the __RadMap__ you have to set its __MapControl__ property to the respective __RadMap__ instance. Additionally you can modify its appearance and the location formatting. Here is an example:


<snippet id='radmap-features-mouse-location-block_1-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Mouse Indicator Outside](images/RadMap_Features_MouseLocation_01.png)

## See Also
 * [Navigation]({%slug radmap-features-navigation%})
 * [Click Modes]({%slug radmap-features-click-modes%})
 * [Zoom Modes]({%slug radmap-features-zoom-modes%})
 * [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
 * [Default Layout]({%slug radmap-features-default-layout%})