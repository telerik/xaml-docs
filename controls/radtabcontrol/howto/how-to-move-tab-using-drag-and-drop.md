---
title: How to Move Tabs Using Drag and Drop
page_title: How to Move Tabs Using Drag and Drop
description: How to Move Tabs Using Drag and Drop
slug: radtabcontrol-how-to-move-tab-using-drag-and-drop
tags: how,to,move,tabs,using,drag,and,drop
published: True
position: 0
---

# How to Move Tabs Using Drag and Drop



## 

Set the __RadTabControl__'s property __AllowDragReorder__ to __True__ or __False__ to allow/disallow the user to reorder the tab items of your tab control using __Drag & Drop__.

#### __XAML__

{{region radtabcontrol-how-to-move-tab-using-drag-and-drop_0}}
	<telerik:RadTabControl x:Name="radTabControl" AllowDragReorder="True">
	    <telerik:RadTabItem Header="Calendar"/>
	    <telerik:RadTabItem Header="Colors"/>
	    <telerik:RadTabItem Header="Quote"/>
	    <telerik:RadTabItem Header="Web Sites"/>
	</telerik:RadTabControl>
	{{endregion}}



The same behavior can be enabled/disabled in the code-behind.

#### __C#__

{{region radtabcontrol-how-to-move-tab-using-drag-and-drop_1}}
	private void EnableReordering()
	{
	    radTabControl.AllowDragReorder = true;
	}
	{{endregion}}



#### __VB.NET__

{{region radtabcontrol-how-to-move-tab-using-drag-and-drop_2}}
    Private Sub EnableReordering()
        radTabControl.AllowDragReorder = True
    End Sub
	{{endregion}}



## See Also

 * [How to Take Advantage of the Tag Property]({%slug radtabcontrol-how-to-take-advantage-of-the-tag-property%})

 * [How to Add New Tab Item]({%slug radtabcontrol-how-to-add-new-tab-item%})

 * [How to Change the Tab Items Orientation]({%slug radtabcontrol-how-to-change-the-tab-items-orientation%})
