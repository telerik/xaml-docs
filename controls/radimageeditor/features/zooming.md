---
title: Zooming
page_title: Zooming
description: This article demonstrates the zooming capabilities of the RadImageEditor control.
slug: radimageeditor-features-zooming
tags: zooming
published: True
position: 4
---

# Zooming

The RadImageEditor control provides out of the box zooming functionality. You can zoom in the opened image by holding **Ctrl** and spinning the **mouse wheel** or by using the slider and dropdown of the **ZoomController** provided by the [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%}).

#### Figure 1: Default zoom capabilities

![Default zoom capabilities](images/default-zoom.gif)

## Zoom to Mouse Cursor

As can be seen in **Figure 1**, the default zooming mechanism does not take into account the position of the mouse cursor.

As of version **2018.2.716**, both RadImageEditor and RadImageEditorUI controls expose a **ZoomToCursor** property. By setting this property to **True**, holding **Ctrl** and spinning the **mouse wheel** will zoom towards the position of the mouse cursor. The result can be observed in **Figure 2**.

#### Figure 2: Zooming to the mouse cursor

![Zooming to the mouse cursor](images/zoom-to-cursor.gif)

## See Also

* [History]({%slug radimageeditor-features-history%})

* [Panning]({%slug radimageeditor-tools-panning%})
