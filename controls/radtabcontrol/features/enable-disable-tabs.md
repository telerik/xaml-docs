---
title: Enable and Disable Tabs
page_title: Enable and Disable Tabs
description: Check our &quot;Enable and Disable Tabs&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-enable-disable-tabs
tags: enable,and,disable,tabs
published: True
position: 3
---

# {{ site.framework_name }} RadTabControl Enable and Disable Tabs



## 

If you want to enable or disable specific tab item(s) you have to use the __Boolean__ property __IsEnabled__ of the class __RadTabItem__. You can set it from your code-behind, XAML or in Blend.

#### __XAML__

{{region radtabcontrol-enable-disable-tabs_0}}
	<telerik:RadTabControl x:Name="radTabControl">
	    <telerik:RadTabItem Header="Calendar" IsEnabled="False"/>
	</telerik:RadTabControl>
	{{endregion}}



#### __C#__

{{region radtabcontrol-enable-disable-tabs_1}}
	RadTabItem newTabItem = new RadTabItem();
	newTabItem.Header = "Disabled Item";
	// Add the newly created tab item to
	// an existing tab control “tabControl”
	radTabControl.Items.Add( newTabItem );
	// Disable the newly created tab item
	newTabItem.IsEnabled = false;
	{{endregion}}



#### __VB.NET__

{{region radtabcontrol-enable-disable-tabs_2}}
	Dim newTabItem As New RadTabItem()
	newTabItem.Header = "Disabled Item"
	' Add the newly created tab item to'
	' some existing tab control “TabControl”'
	radTabControl.Items.Add(newTabItem)
	' Disable the newly created tab item'
	newTabItem.IsEnabled = False
	{{endregion}}



## See Also

 * [Controlling Appearance]({%slug radtabcontrol-appearance-customizing-tab-items%})

 * [Controlling Behavior]({%slug radtabcontrol-features-controlling-behavior%})
