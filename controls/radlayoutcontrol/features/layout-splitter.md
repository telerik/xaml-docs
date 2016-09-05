---
title: Layout Splitter
page_title: Layout Splitter
description: Layout Splitter
slug: radlayoutcontrol-features-layout-splitter
tags: splitter, layout, separator
published: True
position: 3
---

# Layout Splitter

The __LayoutControlSplitter__ component allows you to resize the elements in the layout at runtime when __RadLayoutControl__ is not in edit mode.

#### __[XAML] Example 1: Defining the splitter in XAML__ 
    <telerik:RadLayoutControl>
		<telerik:LayoutControlExpanderGroup Header="Expander group" />
		<telerik:LayoutControlSplitter />
		<Button Content="Button" />
	</telerik:RadLayoutControl>
	
#### __[C#] Example 2: Defining the splitter in code__  
	LayoutControlSplitter splitter = new LayoutControlSplitter();
	this.layoutControl.Items.Add(splitter);

#### __[VB.NET] Example 2: Defining the splitter in code__  
	Dim splitter As New LayoutControlSplitter()
	Me.layoutControl.Items.Add(splitter)

#### __Figure 1: LayoutControlSplitter__  
![](images/layoutcontrol-features-layout-splitter-01.png)

>important The element that will be resized with the splitter is determined by the Orientation of its parent group. When the orientation is Horizontal, the splitter will resize its left sibling element and when Vertical - the top sibling will be resized.

As any other UIElement the __LayoutControlSplitter__ element can be moved around in the layout control when in edit mode.

#### __Figure 2: Dragging the layout splitter while the layout control is in edit mode__  
![](images/layoutcontrol-features-layout-splitter-02.png)
	
## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
