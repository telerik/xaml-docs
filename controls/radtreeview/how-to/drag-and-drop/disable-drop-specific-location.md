---
title: Disable Drop at Specific Location
page_title: Disable Drop at Specific Location
description: Check our &quot;Disable Drop at Specific Location&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-disable-drop-specific-location
tags: disable,drop,at,specific,location
published: True
position: 4
---

# Disable Drop at Specific Location

In order to disable the drop operation on a specific treeview item, you need to set the boolean __RadTreeViewItem__ property __IsDropAllowed__ to __False__.



```XAML
	<telerik:RadTreeViewItem Header="Tennis" IsDropAllowed="False">
```



```C#
	private void DisableDropOnSpecificItem()
	{
	    radTreeViewItemTennis.IsDropAllowed = false;
	}
```



```VB.NET
	Private Sub DisableDropOnSpecificItem()
	    radTreeViewItemTennis.IsDropAllowed = False
	End Sub
```

If you want to read more about the __Drag and Drop__ behavior of the __RadTreeView__, see the main topic about [Drag and Drop]({%slug radtreeview-features-drag-and-drop%}).

## See Also

 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})
 * [Auto Expand on Drag Over]({%slug radtreeview-how-to-enable-auto-expand-drag-over%})