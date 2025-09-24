---
title: Default Layout
page_title: Default Layout
description: Check our &quot;Default Layout&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-default-layout
tags: default,layout
published: True
position: 8
---

# Default Layout

The default layout of the __RadMap__ is represented by the UI controls that appear in it. If you want to remove one of them you can easily set the respective property of the __RadMap__:

* __Navigation__ control - __NavigationVisibility__

* __Scale__ control - __ScaleVisibility__

* __Command__ __Bar__ control - __CommandBarVisibility__

* __Mouse__ Location control - __MouseLocationIndicatorVisibility__

* __Zoom__ __Bar__ control - __ZoomBarVisibility__

In case you want to hide all of the controls and create your own custom layout, you don't have to set each of these properties, you can simply set the __UseDefaultLayout__ property of the __RadMap__ to __False__.


```XAML
	<telerik:RadMap x:Name="radMap"
	                UseDefaultLayout="False">
	</telerik:RadMap>
```

To learn how to use each of the __RadMap__ controls independent and outside of it, read the following topics:

* [Navigation]({%slug radmap-features-navigation%})
* [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
* [Zoom Modes]({%slug radmap-features-zoom-modes%})
* [Mouse Location]({%slug radmap-features-mouse-location%})

## See Also
 * [Navigation]({%slug radmap-features-navigation%})
 * [Click Modes]({%slug radmap-features-click-modes%})
 * [Zoom Modes]({%slug radmap-features-zoom-modes%})
 * [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
 * [Mouse Location]({%slug radmap-features-mouse-location%})