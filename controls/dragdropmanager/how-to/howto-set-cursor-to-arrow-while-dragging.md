---
title: Set Cursor to Arrow while Dragging
page_title: Set Cursor to Arrow while Dragging
description: Check our &quot;Set Cursor to Arrow while Dragging&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-howto-set-cursor-to-arrow-while-dragging
tags: set,cursor,to,arrow,while,dragging
published: True
position: 1
---

# Set Cursor to Arrow while Dragging

The cursor displayed on dragging with DragDropManager is derived from the DragDropEffects set in DragInitialize event. However, you are free to override it and define it based on your specific requirements. For the purpose you may use the GiveFeedback event. 

An example for such an implementation is illustrated below:



<snippet id='dragdropmanager-how-to-howto-set-cursor-to-arrow-while-dragging-block_1-cs' />
<snippet id='dragdropmanager-how-to-howto-set-cursor-to-arrow-while-dragging-block_1-vb' />

