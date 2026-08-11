---
title: LayoutControlTabGroup
page_title: LayoutControlTabGroup
description: Check our &quot;LayoutControlTabGroup&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup
tags: feature, displaymode, display, mode, layoutcontroltabgroup, layoutcontroltabgroupitem, tab 
published: True
position: 2
---

# LayoutControlTabGroup

__LayoutControlTabGroup__ is one of the few layout groups supported by the __RadLayoutControl__. __LayoutControlTabGroup__ behaves a little differently than the other types of groups. Basically, it its children are displayed in a __tab control__ and each tab item is represented by a __LayoutControlTabGroupItem__ element.

__Example 1: Setting up LayoutControlTabGroup__
<snippet id='radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup-example_1_setting_up_layoutcontroltabgroup-xaml' />

	
#### __Figure 1: LayoutControlTabGroup__
![{{ site.framework_name }} RadLayoutControl LayoutControlTabGroup](images/layoutcontrol-features-layoutcontroltabgroup-01.png)

> If a UIElement is added as a direct child of a tab group, it will be automatically wrapped into a __LayoutControlTabGroupItem__.

The header of the tab group item can be set through its __Header__ property. The property is of type __Object__ which allows you to place any visual (or not) element in it.

__Example 2:  Setting up the header of LayoutControlTabGroupItem__
<snippet id='radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup-example_2_setting_up_the_header_of_layoutcontroltabgroupitem-xaml' />


#### __Figure 2: LayoutControlExpanderGroup with UIElements in its header__
![{{ site.framework_name }} RadLayoutControl LayoutControlExpanderGroup with UIElements in its header](images/layoutcontrol-features-layoutcontroltabgroup-02.png)

> __LayoutControlTabGroupItem__ is also a layout group control which means that you can move and arrange it in the layout. In other words the item can be dragged outside of the tab control group. Also, you can drag an element from the layout and place it in the tab strip area which will automatically wrap it into a LayoutControlTabGroupItem.

## Selection

The tab group allows you to select its child tab items. The selection can be change through the __SelectedItem__ property of __LayoutControlTabGroup__ or the __IsSelected__ property __LayoutControlTabGroupItem__.

__Example 3: Setting up the selection in LayoutControlTabGroup__
<snippet id='radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup-example_3_setting_up_the_selection_in_layoutcontroltabgroup-xaml' />


#### __Figure 3: LayoutControlTabGroupItem selection__
![{{ site.framework_name }} RadLayoutControl LayoutControlTabGroupItem selection](images/layoutcontrol-features-layoutcontroltabgroup-03.png)

## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [LayoutControlGroup]({%slug radlayoutcontrol-features-layougroups-layoutcontrolgroup%})
* [LayoutControlExpanderGroup]({%slug radlayoutcontrol-features-layoutgroups-layoutcontrolexpandergroup%})