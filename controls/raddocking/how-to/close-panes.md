---
title: Close RadPane Instances
page_title: Close RadPane Instances
description: Check our &quot;Close RadPane Instances&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-close-panes
tags: how,to,close,panes
published: True
position: 6
---

# Close RadPane Instances

Each __RadPane__ is closable by default via the **Close** button or the **Hide** menu item shown on the snapshots above.
        
You can also hide/show your __RadPane__ instances programmatically using the boolean __RadPane__'s property __IsHidden.__ When a __RadPane__ is closed it is actually hidden and you can always make it visible again when needed.

>When you set the **IsHidden** property of a **RadPane** to **True** or close it, it is actually removed from the visual tree.
        
__Example 1: Set IsHidden__

```XAML
	<telerik:RadPane x:Name="radPane" IsHidden="True"/>
```

__Example 1: Set IsHidden__

```C#
	radPane.IsHidden = true;
```
```VB.NET
	radPane1.IsHidden = True
```

To learn how to disable the close button or how to handle the __RadDocking__'s __PreviewClose__ event take a look at the [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%}) topic.

## CloseTabsOnMouseMiddleButtonDown

To close the panes of a **RadPaneGroup** on the click of the mouse middle button you can set the **CloseTabsOnMouseMiddleButtonDown** property of the RadPaneGroup to **True**.
        
__Example 2: Set CloseTabsOnMouseMiddleButtonDown__

```XAML
	<telerik:RadPaneGroup CloseTabsOnMouseMiddleButtonDown="True">
		<!-- ... -->
	</telerik:RadPaneGroup>
```

__Example 2: Set CloseTabsOnMouseMiddleButtonDown__

```C#
	radPaneGroup.CloseTabsOnMouseMiddleButtonDown = true;
```
```VB.NET
	radPaneGroup.CloseTabsOnMouseMiddleButtonDown = True
```

## ClosePane Command

As of **R3 2020**, you can use the new **ClosePane** command to close the currently active pane.{% if site.site_name == 'WPF' %} An example of how to use the command can be found in [this article]({%slug kb-docking-close-active-pane-command%}).{% endif %}

## See Also

 * [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%})
 * [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%})
{% if site.site_name == 'WPF' %}* [How to Close Active Pane]({%slug kb-docking-close-active-pane-command%}){% endif %}
