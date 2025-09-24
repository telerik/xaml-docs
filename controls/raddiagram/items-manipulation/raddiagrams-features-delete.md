---
title: Removing Items
page_title: Removing Items
description: Check our &quot;Removing Items&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-delete
tags: removing,items
published: True
position: 4
---

# Removing Items

__RadDiagram__ gives you the ability to remove __RadDiagramItems__ interactively, programmatically or with DiagramCommands.	  

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		

## Removing Items Interactively

You can remove the selected RadDiagramItems by pressing the Delete Key.

Below you can see the result of delete operation over the selected RadDiagramItems:![radiagrams-removingitems](images/radiagrams-removingitems.png)

## Removing Items in Code Behind

You can remove RadDiagramItems in code behind by using the __RadDiagram.Items__ collection and its __Remove()__ or __RemoveAt()__ methods:


```C#
	this.diagram.Items.RemoveAt(3);
	this.diagram.Items.Remove(this.diagram.SelectedItems);
```
```VB.NET
	Me.diagram.Items.RemoveAt(3)
	Me.diagram.Items.Remove(Me.diagram.SelectedItems)
```

## Delete with DiagramCommands

You can use the __DiagramCommand__ "__Delete__" in order to remove the selected RadDiagramItems.		

For more information on this, please check out the [Commands article]({%slug raddiagrams-features-commands%}).		

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Virtualization]({%slug raddiagrams-features-virtualization%})
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})