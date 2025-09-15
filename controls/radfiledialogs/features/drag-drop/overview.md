---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-features-dragdrop-overview
tags: features,dragdrop
published: True
position: 0
---

# Drag and Drop Overview

The drag and drop feature of the file dialogs allows you to grab items (file and folders) and move them to a different location. The feature supports copy and move operations and it is enabled by default. 

#### __Figure 1: Drag drop files__
![{{ site.framework_name }} RadFileDialogs Drag drop files](images/filedialogs-drag-drop-overview-0.png)

The dialog gives you the ability to drag and drop in the main pane and the tree navigation pane, and also between them.

## Copy Drag vs. Move Drag

The default drag operation is move, except you drag an item to another drive. So, if you drag a file/folder and then drop it, the item will be moved to the new location. To start a copy drag you will need to press and hold the __Ctrl__ modifier key.

Dragging an item to another drive will copy it there. To change the operation you can hold the __Shift__ key while dropping.

> You can also alter between copy and move in the middle of the drag/drop operation by pressing Ctrl. In other words, you can start dragging without pressing the Ctrl key, and just before drop you can press the key, thus changing the type of the operation.

## Enable and Disable Drag and Drop

To enable or disable the feature you can use the __IsDragDropEnabled__ property of the file dialog.

__Example 1: Disabling drag and drop__ 
```C#
	RadSaveFileDialog saveFileDialog = new RadSaveFileDialog();	
	saveFileDialog.Owner = theOwnerWindow;	
	saveFileDialog.IsDragDropEnabled = false;	
	saveFileDialog.ShowDialog();	
```

## Customizing Drag and Drop

You can customize the drag drop behavior and also the drag visual element. Read more about this in the [Customizing the Drag Drop Behavior]({%slug radfiledialogs-features-dragdrop-customizing-drag-drop-behavior%}) and [Customizing the Drag Visual]({%slug radfiledialogs-features-dragdrop-customize-drag-visual%}) articles.

## See Also  
* [Getting Started]({%slug radfiledialogs-getting-started%})
