---
title: How to Move Tabs Using Drag and Drop
page_title: How to Move Tabs Using Drag and Drop
description: Check our &quot;How to Move Tabs Using Drag and Drop&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-how-to-move-tab-using-drag-and-drop
tags: how,to,move,tabs,using,drag,and,drop
published: True
position: 0
---

# How to Move Tabs Using Drag and Drop

Set the __RadTabControl__'s property __AllowDragReorder__ to __True__ or __False__ to allow/disallow the user to reorder the tab items of your tab control using __Drag & Drop__.

#### __XAML__  
```XAML
	<telerik:RadTabControl x:Name="radTabControl" AllowDragReorder="True">
	    <telerik:RadTabItem Header="Calendar"/>
	    <telerik:RadTabItem Header="Colors"/>
	    <telerik:RadTabItem Header="Quote"/>
	    <telerik:RadTabItem Header="Web Sites"/>
	</telerik:RadTabControl>
```

The same behavior can be enabled/disabled in the code-behind.

#### __C#__  
```C#
	private void EnableReordering()
	{
	    radTabControl.AllowDragReorder = true;
	}
```

#### __VB.NET__  
```VB.NET
    Private Sub EnableReordering()
        radTabControl.AllowDragReorder = True
    End Sub
```

## See Also 
 * [How to Change the Tab Items Orientation]({%slug radtabcontrol-how-to-change-the-tab-items-orientation%})
