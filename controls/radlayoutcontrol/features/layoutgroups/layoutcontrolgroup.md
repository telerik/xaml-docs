---
title: LayoutControlGroup
page_title: LayoutControlGroup
description: Check our &quot;LayoutControlGroup&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-features-layougroups-layoutcontrolgroup
tags: feature, displaymode, display, mode, layoutcontrolgroup
published: True
position: 1
---

# LayoutControlGroup

__LayoutControlGroup__ is one of the few layout groups supported by the __RadLayoutControl__. When it comes to visual appearance __LayoutControlGroup__ is the most simple of the groups. It displays only a border around its items. 

> You can read the [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%}) article to get better understanding on how the layout groups are arranging their children. 

__Figure 1__ shows how a LayoutControlGroup with few children looks. And __Example 1__ demonstrates how to set up a group.

__Example 1: Setting up LayoutControlGroup__
```XAML
	<telerik:RadLayoutControl>            
		<telerik:LayoutControlGroup >                
			<Button Content="Item 1" />
			<Button Content="Item 2" />
			<Button Content="Item 3" />
			<Button Content="Item 4" />
		</telerik:LayoutControlGroup>
	</telerik:RadLayoutControl>      
```	

#### __Figure 1: LayoutControlGroup__
![{{ site.framework_name }} RadLayoutControl LayoutControlGroup](images/layoutcontrol-features-layoutcontrolgroup-01.png)

You can add __LayoutControlGroup__ into another layout group (see __Example 2__).

__Example 2: Nesting LayoutControlGroups__
```XAML
	<telerik:RadLayoutControl>
		<telerik:LayoutControlGroup>
			<telerik:LayoutControlGroup Orientation="Vertical">                    
				<Button Content="Item 1" />
				<Button Content="Item 2" />
				<telerik:LayoutControlGroup>
					<Button Content="Item 1" />
					<Button Content="Item 2" />
				</telerik:LayoutControlGroup>
				<Button Content="Item 3" />
			</telerik:LayoutControlGroup>
			<Button Content="Item 4" />
			<Button Content="Item 5" />
			<Button Content="Item 6" />
		</telerik:LayoutControlGroup>
	</telerik:RadLayoutControl>
```    

#### __Figure 2: Nested LayoutControlGroups__
![{{ site.framework_name }} RadLayoutControl Nested LayoutControlGroups](images/layoutcontrol-features-layoutcontrolgroup-02.png)	

## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [LayoutControlTabGroup]({%slug radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup%})
* [LayoutControlExpanderGroup]({%slug radlayoutcontrol-features-layoutgroups-layoutcontrolexpandergroup%})