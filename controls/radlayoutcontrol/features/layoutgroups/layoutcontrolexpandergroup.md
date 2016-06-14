---
title: LayoutControlExpanderGroup
page_title: LayoutControlExpanderGroup
description: LayoutControlExpanderGroup
slug: radlayoutcontrol-features-layoutgroups-layoutcontrolexpandergroup
tags: feature, displaymode, display, mode, layoutcontrolexpandergroup, expander, expand, collapse
published: True
position: 3
---

# LayoutControlExpanderGroup

__LayoutControlExpanderGroup__ is one of the few layout groups supported by the __RadLayoutControl__. __LayoutControlExpanderGroup__ behaves as the __LayoutControlGroup__ but its children are displayed in an __expander control__. Clicking on the group’s header or the expand arrow will expand or collapse its children.

> You can read the [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%}) article to get better understanding on how the layout groups are arranging their children. 

#### __[XAML] Example 1: Setting up LayoutControlExpanderGroup__
{{region layoutcontrol-features-layoutcontrolexpandergroup-01}}
	<telerik:RadLayoutControl >            
		<telerik:LayoutControlExpanderGroup Header="Layout Control Expander Group">                    
			<Button Content="Item 1" />
			<Button Content="Item 2" />
		</telerik:LayoutControlExpanderGroup>            
	</telerik:RadLayoutControl>  
{{endregion}}

#### __Figure 1: LayoutControlExpanderGroup__
![](images/layoutcontrol-features-layoutcontrolexpandergroup-01.png)

The header of the expander group can be set through its __Header__ property. The property is of type __Object__ which allows you to place any visual (or not) element in it.

#### __[XAML] Example 2: Setting up the header of LayoutControlExpanderGroup__
{{region layoutcontrol-features-layoutcontrolexpandergroup-02}}
	<telerik:RadLayoutControl>            
		<telerik:LayoutControlExpanderGroup>
			<telerik:LayoutControlExpanderGroup.Header>
				<StackPanel Orientation="Horizontal">
					<Rectangle Width="10" Height="10" Fill="Orange" Margin="0 0 5 0" />
					<TextBlock Text="Layout Control Expander Group" FontWeight="Bold" />
				</StackPanel>
			</telerik:LayoutControlExpanderGroup.Header>
			<Button Content="Item 1" />
			<Button Content="Item 2" />
		</telerik:LayoutControlExpanderGroup>            
	</telerik:RadLayoutControl>   
{{endregion}}	

#### __Figure 2: LayoutControlExpanderGroup with UIElements in its header__
![](images/layoutcontrol-features-layoutcontrolexpandergroup-02.png)

The group’s content state (collapsed/expanded) can be manually controlled via the __IsExpanded__ property. 

#### __[XAML] Example 3: Setting the state of LayoutControlExpanderGroup__
{{region layoutcontrol-features-layoutcontrolexpandergroup-03}}
	<telerik:LayoutControlExpanderGroup IsExpanded="False">
{{endregion}}
	
#### __Figure 3: Collapsed LayoutControlExpanderGroup__
![](images/layoutcontrol-features-layoutcontrolexpandergroup-03.png)

> You can notice that the size of the group demonstrated in __Figure 3__ and __Example 3__ doesn't collapse, but only its children are hidden (collapsed). This is because the group's __VerticalAlignment__ is set to __Stretch__ by default. In this example, if you want to collapse also the size of the group itself you can set the __VerticalAlignment__ to __Top__.

The __IsExpandable__ property of LayoutControlExpanderGroup controls whether the expanding arrow should be displayed and the collapse/expand action can be executed by clicking on the header.
	
#### __[XAML] Example 4: Setting the IsExpandable property of LayoutControlExpanderGroup__
{{region layoutcontrol-features-layoutcontrolexpandergroup-04}}
	<telerik:LayoutControlExpanderGroup IsExpandable="False">
{{endregion}}

#### __Figure 4: LayoutControlExpanderGroup with disabled collapse/expand interactions__
![](images/layoutcontrol-features-layoutcontrolexpandergroup-04.png)

> When the __IsExpandable__ property is set to __False__ the content of the group can still be collapsed and expanded via the __IsExpanded__ property.

<!-- -->

> When no explicit dimensions are set the size of the group depends on its position in the layout and also its alignment. When a group is collapsed it is not necessary that its size collapses too. This depends on its size and alignment.

## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [LayoutControlGroup]({%slug radlayoutcontrol-features-layougroups-layoutcontrolgroup%})
* [LayoutControlTabGroup]({%slug radlayoutcontrol-features-layoutgroups-layoutcontroltabgroup%})