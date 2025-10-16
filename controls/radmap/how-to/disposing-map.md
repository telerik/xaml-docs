---
title: Disposing RadMap
page_title: Disposing RadMap
description: Check our &quot;Disposing RadMap&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-how-to-dispose-radmap
tags: dispose,release,memory,clear,resources
published: True
position: 11
---

# Disposing RadMap

The RadMap control usually needs to be disposed when you no longer use it. This will release all resources used by the map. To do this you can manually call the __Dispose__ method of the RadMap control.

> The map is not disposed by default. You need to do this manually.

__Example 1: Disposing RadMap__
```C#
	radMap.Dispose();
```

The [providers]({%slug radmap-features-providers%}) and the [VisualizationLayer]({%slug radmap-visualization-layer-introduction%}) also expose a Dispose method. This is useful if you want to change the layer or provider instances at run-time and release their resources.

## See Also
 * [Getting Started]({%slug radmap-getting-started%})
 * [SDK Examples]({%slug radmap-sdk-examples%})