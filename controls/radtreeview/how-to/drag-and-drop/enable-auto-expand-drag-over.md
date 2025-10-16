---
title: Auto Expand on Drag Over
page_title: Auto Expand on Drag Over
description: Check our &quot;Auto Expand on Drag Over&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-enable-auto-expand-drag-over
tags: auto,expand,on,drag,over
published: True
position: 6
---

# Auto Expand on Drag Over

__RadTreeView__ offers you the ability to automatically expand a treeview node when dragging items over the node. In order to do that you need to perform the following action:

* When dragging items over your treeview, move the mouse cursor over the treeview expander. The result will be an automatically expanded node. 
![{{ site.framework_name }} RadTreeView Auto Expand on Drag Over](images/RadTreeView_HowEnableAutoExpandOnDragOver_010.png)

The __RadTreeView__ exposes a property __DropExpandDelay__, which sets the delay for the expand behavior. The property is of type __TimeSpan__. Here is a sample code showing you how to set it:		


```C#
	radTreeView.DropExpandDelay = TimeSpan.FromSeconds(5);
```
```VB.NET
	radTreeView.DropExpandDelay = TimeSpan.FromSeconds(5)
```

## Disable Auto Expand on DragOver

The __RadTreeView__ doesn't actually allow you to disable the auto-expand feature, however you can set the value of the __DropExpandDelay__ property to represent a long period of time. This way your users won't trigger the auto-expand at all while dragging over an item. For instance you can set the __DropExpandDelay__ to an hour:		

	
```XAML
	<telerik:RadTreeView IsDragDropEnabled="True" DropExpandDelay="1:0:0"/>
```

You can also set the value from code-behind:
	

```C#
	radTreeView.DropExpandDelay = TimeSpan.FromMinutes(60);		
```
```VB.NET
	radTreeView.DropExpandDelay = TimeSpan.FromMinutes(60)
```

## See Also
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})