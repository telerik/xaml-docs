---
title: Layout Splitter
page_title: Layout Splitter
description: Check our &quot;Layout Splitter&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-features-layout-splitter
tags: splitter, layout, separator
published: True
position: 3
---

# Layout Splitter

The __LayoutControlSplitter__ component allows you to resize the elements in the layout at runtime when __RadLayoutControl__ is not in edit mode. The following examples show you how to define a splitter.

__Example 1: Defining the splitter in XAML__ 
<snippet id='radlayoutcontrol-features-layout-splitter-example_1_defining_the_splitter_in_xaml-xaml' />

	
__Example 2: Defining the splitter in code__  
<snippet id='radlayoutcontrol-features-layout-splitter-example_2_defining_the_splitter_in_code-cs' />

<snippet id='radlayoutcontrol-features-layout-splitter-example_2_defining_the_splitter_in_code-vb' />


#### __Figure 1: LayoutControlSplitter__  
![{{ site.framework_name }} RadLayoutControl LayoutControlSplitter](images/layoutcontrol-features-layout-splitter-01.png)

>important The element that will be resized with the splitter is determined by the Orientation of its parent group. When the orientation is Horizontal, the splitter will resize its left sibling element and when Vertical - the top sibling will be resized.

As any other UIElement the __LayoutControlSplitter__ element can be moved around in the layout control when in edit mode.

#### __Figure 2: Dragging the layout splitter while the layout control is in edit mode__  
![{{ site.framework_name }} RadLayoutControl Dragging the layout splitter while the layout control is in edit mode](images/layoutcontrol-features-layout-splitter-02.png)
	
## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
