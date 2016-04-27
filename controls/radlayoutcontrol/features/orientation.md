---
title: Orientation
page_title: Orientation
description: Orientation
slug: radlayoutcontrol-features-orientation
tags: orientation, vertical, horizontal
published: True
position: 2
---

# Orientation

__RadLayoutControl__ and __LayoutControlGroup__ are ordering their children with a horizontal orientation by default. You can change this and arrange the child items in a vertical order by setting the control's __Orientation__ property to Vertical. 

The property is an enumeration of type __System.Windows.Controls.Orientation__ and exposes the following values:
* __Horizontal__: The layout will be oriented horizontally.
* __Vertical__: The layout will be oriented vertically.

#### __[XAML] Example 1: Setting the Orientation property of RadLayoutControl__
	<telerik:RadLayoutControl Orientation="Vertical"/>
	
#### __[XAML] Example 2: Setting the Orientation property of LayoutControlGroup__
	<telerik:LayoutControlGroup Orientation="Vertical"/>

#### __Figure 1: Horizontal and Vertical orientations__  
![](images/layoutcontrol-features-orientation-01.png)
	
# See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Display Modes]({%slug radlayoutcontrol-features-display-modes%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
