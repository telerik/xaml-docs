---
title: Items Events
page_title: Items Events
description: This article describes the events of the items inside the RadDiagram framework.
slug: raddiagrams-events-item
tags: items,events
published: True
position: 1
---

# Items Events

This topic covers the specific events exposed by the __RadDiagramItem__. The events are grouped by their general purpose.	  

## Edit Events

* __PreviewBeginEdit__: Occurs when item is about to be edited.			

* __BeginEdit__: Occurs when item has entered edit mode.			

* __PreviewEndEdit__: Occurs when item is about to exit the edit mode.			

* __EndEdit__ - occurs when item is edited (exited the edit mode).			

## Shape Specific Events

* __GeometryChanged__: Occurs when the geometry of the shape is changed.			

## Container Shape Specific Events

* __IsCollapsedChanged__: Occurs when the container IsCollapsed property has changed.

## Connection Specific Events

* __ManipulationPointActivated__: Occurs when a connector of the connection is activated.			

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Clipboard Operations]({%slug raddiagrams-features-clipboard%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Undo and Redo]({%slug raddiagrams-features-undo-redo%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})