---
title: ZOrder
page_title: ZOrder
description: Check our &quot;ZOrder&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-zorder
tags: zorder
published: True
position: 6
---

# ZOrder

__RadDiagram__ gives you the ability to control the __Z-Order__ of shapes and connections by using their __ZIndex__ property. You can also use __RadDiagramCommands__ in order to increase/decrease __ZIndex__ of the selected __RadDiagramItems__ simultaneously.	  

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.

## Using the ZIndex property

Consider the following code:
		

<snippet id='raddiagram-items-manipulation-raddiagrams-features-zorder-block_1-xaml' />


We have reversed the natural ZOrder of the 3 Shapes. On the other hand, the connection on the right is on top of the shapes and connection on the left is below them: 
![Rad Diagrams-Features-ZIndex](images/RadDiagrams-Features-ZIndex.png)

## Using the RadDiagram Commands

__RadDiagram__ provides a set of predefined commands for manipulating the selected items' ZIndices. __"BringForward"__ and __"SendBackward"__ allow you to increase/decrease the Z-Indices of the selected RadDiagramItems. If you need to bring the selected item(s) on top of all other items or below them, you can use __"BringToFront"__ and __"SentToback"__:
		

<snippet id='raddiagram-items-manipulation-raddiagrams-features-zorder-block_2-xaml' />


This way configured, the two buttons are ready to bring to front or sent to back the selected items of the __RadDiagram__: 
![raddiagrams-features-zindex-bringup 1](images/raddiagrams-features-zindex-bringup1.png)

Here is the result of selecting the shape with ZIndex = 1 and clicking the left button:
![raddiagrams-features-zindex-bringup 2](images/raddiagrams-features-zindex-bringup2.png)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Editing]({%slug raddiagrams-features-edit%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [Resizing]({%slug raddiagrams-features-resizing%})
 * [Selection]({%slug raddiagrams-features-selection%})