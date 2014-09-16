---
title: Create Multi-line Tabs
page_title: Create Multi-line Tabs
description: Create Multi-line Tabs
slug: radtabcontrol-features-multiline-tabs
tags: create,multi-line,tabs
published: True
position: 1
---

# Create Multi-line Tabs



## 

Multi-line tabs can be created using the __IsBreak__ property of the
        __RadTabItem__. The property is of __Boolean__ type and the possible values are
        __True__ or __False__. If it’s __True__, then the next tab items you
        add will be placed on a new line inserted right above the item which property __IsBreak__ is set to 
        __True__; if it’s __False__, no break is inserted.

![](images/RadTabControl_Figure_00650.png)

#### __XAML__

{{region radtabcontrol-features-multiline-tabs_0}}
	<telerik:RadTabControl x:Name="radTabControl" SelectedIndex="0">
	    <telerik:RadTabItem Header="Calendar"/>
	    <telerik:RadTabItem Header="Colors" IsBreak="True"/>
	    <telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
	{{endregion}}



In the above example the property __IsBreak__ of the tab item "Colors" is set to 
        __True__ and the next tab item "Quote" is placed on a new line above all other tab items.

# See Also

 * [Controlling Behavior]({%slug radtabcontrol-features-controlling-behavior%})

 * [How to Change the Position of the Tab Strip of RadTabControl]({%slug radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-radtabcontrol%})
