---
title: Mouse Tools
page_title: Mouse Tools
description: Mouse Tools
slug: raddiagrams-features-mouse-tools
tags: mouse,tools
published: True
position: 1
---

# Mouse Tools

__RadDiagram__ provides 3 __Mouse Tools__ that determine the actions you can perform with your mouse - __Pointer Tool__, __Connector Tool__ and __Pan Tool__.	  

## Mouse Tools

Below you can find sample descriptions of the three Mouse Tools:

* __Pointer Tool__ - this is the default(active) tool. Allows you to drag, select, resize items and etc.			

* __Connector Tool__ - it is partially active. Allows you to create connections. In order to create floating connections, you have to set the __RadDiagram.ActiveTool__ to __ConnectorTool__.			

* __Pan Tool__ - it is not active. Allows you to perform panning. You can activate it by pressing the Control Key. When active, the Pointer Tool and Connector tool are disabled.			

>Please note that you can set the active tool in XAML or code behind using the __ActiveTool__ property. But since the __PanTool__ could be activate by pressing the __Ctrl__ key, this makes sense only if you set the __ActiveTool__ to __ConnectorTool__ - which will allow you to create floating connections.		  

# See Also
 * [Text Tool]({%slug raddiagrams-tools-text-tool%})
 * [Drawing Tools]({%slug raddiagram-features-drawing%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%})
 * [Resizing]({%slug raddiagrams-features-resizing%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [Selection]({%slug raddiagrams-features-selection%})