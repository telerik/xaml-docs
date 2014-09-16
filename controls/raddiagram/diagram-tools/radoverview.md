---
title: Tools Overview
page_title: Tools Overview
description: Tools Overview
slug: raddiagram-tools-overview
tags: tools,overview
publish: True
position: 0
---

# Tools Overview



Essentially the diagramming tools are a way of encapsulating series of related events usually triggered by an explicit action from the user. 

## 

Let's take for example the selection of diagram items by dragging a selection rectangle. This action has three related events which always come as one and in the same chronological order - the mouse is pressed, the mouse is moved and then finally released. During this selection process you don't want to move the items or trigger any non-selection related action by the changes of the mouse. Because of this, we've designed the diagramming tools to be mutually exclusive. This means that at any moment __only one tool is active__. This logic is implemented by a __ToolService__, which manages the registered tools and switches them on or off. When a tool tells the service that it will handle the mouse events, the __ToolService__ blocks the other tools until that tool has finished its handling. 

In this section you will find:

* [Mouse Tools]({%slug raddiagrams-features-mouse-tools%})

* [Drawing Tools]({%slug raddiagram-features-drawing%})

* [Text Tool]({%slug raddiagrams-tools-text-tool%})

# See Also

 * [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%})

 * [Selection]({%slug raddiagrams-features-selection%})

 * [Align and Snap ]({%slug raddiagrams-features-snap%})

 * [Rotation]({%slug raddiagrams-features-rotation%})
