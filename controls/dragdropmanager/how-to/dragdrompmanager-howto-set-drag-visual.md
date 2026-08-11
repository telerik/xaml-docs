---
title: Set Drag Visual
page_title: Set Drag Visual
description: Check our &quot;Set Drag Visual&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdrompmanager-howto-set-drag-visual
tags: set,drag,visual
published: True
position: 0
---

# Set Drag Visual

DragDropManager enables you to define your own custom drag cue. This can be easily done by handling the [DragInitialize]({%slug dragdropmanager-events%}) event and defining the DragVisual. 

We will demonstrate this functionality implemented within a simple ListBox. For the purpose we need to execute the following steps:

1. Create a ListBox with ItemTemplate and implicit Style for the ListBox Items:

<snippet id='dragdropmanager-how-to-dragdrompmanager-howto-set-drag-visual-block_1-xaml' />

2. Bind ListBox to simple data and subscribe to DragInitialize event:

<snippet id='dragdropmanager-how-to-dragdrompmanager-howto-set-drag-visual-block_2-cs' />
<snippet id='dragdropmanager-how-to-dragdrompmanager-howto-set-drag-visual-block_2-vb' />


3. Set suitable drag visual that will be displayed while dragging is performed:

	

<snippet id='dragdropmanager-how-to-dragdrompmanager-howto-set-drag-visual-block_3-cs' />
<snippet id='dragdropmanager-how-to-dragdrompmanager-howto-set-drag-visual-block_3-vb' />


On running the application, the following will be visualized:

![{{ site.framework_name }} Drag Drop Visual Cue](images/DragDropManger_SetVisualCue.png)
