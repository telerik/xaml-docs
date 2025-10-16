---
title: Key Properties
page_title: Key Properties
description: This article describes the key features of Progress Telerik RadTabControl.
slug: radtabcontrol-features-controlling-behavior
tags: controlling,behavior
published: True
position: 4
---

# Key Properties

__RadTabControl__ is an advanced control that allows you to control its behavior in order to achieve maximum UX satisfaction.

In this chapter we will show you some of the ways you can use to customize the control behavior. 

## Reorder Tab Rows

Using the __ReorderTabRows__ property you can control how the tab item rows are ordered in case of multiple lines. The default behavior is to keep the selected tab item always on the lowest row and move the other rows above.

The default value for the __ReorderTabRows__ property is __True__.

__ReorderTabRows__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" ReorderTabRows="True">
		<telerik:RadTabItem Header="Calendar"/>
		<telerik:RadTabItem Header="Colors" IsBreak="True"/>
		<telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
```

__ReorderTabRows set to True__  

![Telerik TabControl ReorderTabRows](images/tabcontrol_controlling_behavior_reordertabrows_1.png)

__ReorderTabRows set to False__  

![Telerik TabControl ReorderTabRows](images/tabcontrol_controlling_behavior_reordertabrows_2.png)

## Allow Drag Reorder

You can allow/disallow the user to reorder the tab items of your control throught the __AllowDragReorder__.

>tip The default value for the __AllowDragReorder__ property is __False__.

__Allow reordering the tab items__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" AllowDragReorder="True">
		<telerik:RadTabItem Header="Calendar"/>
		<telerik:RadTabItem Header="Colors"/>
		<telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
```

## Enable or Disable Tab Items

You can set the  __IsEnabled__ property to prevent the user from interacting with the whole tab control or with certain tab items. You can find this property in both __RadTabControl__ and __RadTabItem__.

__Disable tab item__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl">
		<telerik:RadTabItem Header="Calendar"/>
		<telerik:RadTabItem Header="Colors" />
		<telerik:RadTabItem Header="Disabled Item" IsEnabled="False"/>
		<telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
```

__Disable tab item__  

![Telerik TabControl Disabled Tab Item](images/tabcontrol_controlling_behavior_disableditem_3.png)

## Tabstrip Placement 

You can change the position of the tab strip throught the __TabStripPlacement__ property. More information regarding this functionality can be found [here]({%slug radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-radtabcontrol%})

## Overflow Mode

The overflow mode determines how the tab items will be handled in case there isn't enough space in the tabstrip to fit them. The mode is controlled via the `OverflowMode` property of `RadTabControl`. The default value is `Scroll`. When this mode is enabled and there isn't enough space for all tab items, two arrow buttons are displayed. The buttons allow you to scroll the tabs left and right.

When the overflow mode is `Scroll`, the mouse wheel can be used to scroll as well. In that case, scrolling the wheel up will move the items from right to left, and scrolling it down will move them from left ro right. To change the scroll direction on mouse wheel, set the `InvertMouseWheelScrollDirection` property of `RadTabControl` to `true`.

__Invert the mouse wheel scroll direction__	
```XAML		
	<telerik:RadTabControl InvertMouseWheelScrollDirection="True">
		<!-- large number of items -->
	</telerik:RadTabControl>
```

The other overflow mode is `Wrap`. In that case, if no space is available for all tab items, they will be split into multiple rows.

__Show all tab items in the viewport__	
```XAML		
	<telerik:RadTabControl OverflowMode="Wrap">
		<!-- large number of items -->
	</telerik:RadTabControl>
```

__Show all items in the viewport__  

![Telerik TabControl OverflowMode](images/tabcontrol_controlling_behavior_overflowmode_4.png)

## Allow Drag Over Tab

This property indicates whether dragging objects over a tab item will select this TabItem. The default value for the __AllowDragOverTab__ property is __False__. 

>tip The DragOverTab feature will work only if the Telerik.Windows.Controls.DragDrop.RadDragAndDropManager is used.

__Setting AllowDragOverTab to true__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" OverflowMode="Wrap"/>
```

## Align

The RadTabControl allows you to control the alignment of the tab items in the row - Left, Right, Center, Justify. More information can be found in the [Tabstrip alignment]({%slug radtabcontrol-fetures-tabstrip-alignment%})

## TabOrientation

RadTabControl allows you to control whether to display the tabs horizontally or vertically. You can do that through the Orientation property of the tab control. Its default value is Horizontal and therefore the items are positioned horizontally. Setting the property to Vertical will rotate the headers of the tab items at 90 degrees.

__Change orientation of the tab items__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" TabOrientation="Vertical" >
		<telerik:RadTabItem Header="Calendar" />
		<telerik:RadTabItem Header="Colors" />
		<telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
```

__TabOrientation set to Vertical__  

![Telerik TabControl TabOrientation](images/tabcontrol_controlling_behavior_taborientation_5.png)

## AdditionalContent

The __RadTabControl__ control exposes a property, which allows you to display additional content on its right side of the control.

__Add AdditionalContent__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" >
		<telerik:RadTabControl.AdditionalContent>
			<TextBlock Text="Sample Text" VerticalAlignment="Center"/>
		</telerik:RadTabControl.AdditionalContent>
		<telerik:RadTabItem Header="Calendar" />
		<telerik:RadTabItem Header="Colors" />
		<telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
```

__Add AdditionalContent__  

![Telerik TabControl AdditionalContent](images/tabcontrol_controlling_behavior_additionalcontent_6.png)	

## Close Tab On Mouse Middle Button Click

To close the tab on mouse middle button down you can set the __CloseTabsOnMouseMiddleButtonDown__ property of the RadTabControl to __True__.

## Scroll Mode

When the width of the control does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. You can choose one of the __ScrollMode__ values in order to control how the tab items should be scrolled. 

## AllTabsEqualHeight

This property specifies whether all displayed tabs have equal height.

>tip The default value for the __AllTabsEqualHeight__ property is __True__.

## TabControl DropDown Menu

When the width of the control does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. For faster navigation the control expose drop down menu which contains a list of all tab items inside the control. To show the dropdown button menu you can set the __DropDownDisplayMode__ to __Visible.

The __DropDownDisplayMode__ property could be set to any of the following values:
	* __Collapsed__: The drop down will never be shown.
	* __Visible__: The drop down will always be visible.
	* __WhenNeeded__: The drop down will be shown only when there is not enough space the Tabs to be arranged. 

__Show DropDownMenu button__	
```XAML		
	<telerik:RadTabControl x:Name="radTabControl" DropDownDisplayMode="Visible">
		<!-- large number of items -->
	</telerik:RadTabControl>
```

__Show DropDownMenu button__  

![Telerik TabControl DropDownMenu Button](images/tabcontrol_controlling_behavior_dropdownmenu_7.png)		
	
## See Also  
 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})
 * [Create Multi-line Tabs]({%slug radtabcontrol-features-multiline-tabs%})
 * [Enable and Disable Tabs]({%slug radtabcontrol-enable-disable-tabs%})