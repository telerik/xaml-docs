---
title: Customizing Items Layout
page_title: Customizing Items Layout
description: Check our &quot;Customizing Items Layout&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-appearance-customizing-items-layout
tags: overview
published: True
position: 2
---

# Customizing Items Layout

RadTabControl allows you to customize the items placement and lines ordering.

To change the placement of the tabstrip area where the items are placed, set the __TabStripPlacement__ property of RadTabControl. The placement can be __Top__ (default), __Bottom__, __Left__ or __Right__.

__Example 1: Setting TabStripPlacement__
```C#
	<telerik:RadTabControl TabStripPlacement="Bottom">          
		<telerik:RadTabItem Header="Home" />
		<telerik:RadTabItem Header="View" />
		<telerik:RadTabItem Header="Insert" />
		<telerik:RadTabItem Header="Settings" />
	</telerik:RadTabControl>
```

#### Figure 1: All tabstrip placements
![{{ site.framework_name }} RadTabControl All tabstrip placements](images/radtabcontrol-appearance-customizing-items-layout-0.png)

The tab items can be separated in two different lines (rows). To create a new line, set the __IsBreak__ property of the RadTabItem which should start the line. Read more about this feature in the [Create Multi-Line Tabs]({%slug radtabcontrol-features-multiline-tabs%}) article.

__Example 2: Setting IsBreak__
```C#
	<telerik:RadTabControl>          
		<telerik:RadTabItem Header="Home" />
		<telerik:RadTabItem Header="View" />
		<telerik:RadTabItem Header="Insert" IsBreak="True" />
		<telerik:RadTabItem Header="Settings" />
	</telerik:RadTabControl>
```

#### Figure 2: Tab items on multiple rows
![{{ site.framework_name }} RadTabControl Tab items on multiple rows](images/radtabcontrol-appearance-customizing-items-layout-1.png)

>tip The line with the selected tab will be moved on the bottom row.

To __align the tabs__ in the tabstrip area, set the __Align__ property of RadTabControl. The available alignments are __Left__ (default), __Right__, __Center__, __Justify__.

__Example 3: Setting alignments__
```C#
	<telerik:RadTabControl Align="Justify">          
		<telerik:RadTabItem Header="Home" />
		<telerik:RadTabItem Header="View" />
		<telerik:RadTabItem Header="Insert" />
		<telerik:RadTabItem Header="Settings" />
	</telerik:RadTabControl>
```

#### Figure 3: All tabstrip alignments
![{{ site.framework_name }} RadTabControl All tabstrip alignments](images/radtabcontrol-appearance-customizing-items-layout-2.png)
