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

## ReorderTabRows

Using the __ReorderTabRows__ property you can control how the tab item rows are ordered in case of multiple lines. The default behavior is to keep the selected tab item always on the lowest row and move the other rows above.

>tipThe default value for the __ReorderTabRows__ property is __True__.

#### __[XAML] Example 1: ReorderTabRows__	
	{{region xaml-radtabcontrol-features-controlling-behavior_0}}		
		<telerik:RadTabControl x:Name="radTabControl"  ReorderTabRows="True">
			<telerik:RadTabItem Header="Calendar"/>
			<telerik:RadTabItem Header="Colors" IsBreak="True"/>
			<telerik:RadTabItem Header="Quote"/>
		</telerik:RadTabControl>
	{{endregion}}
	
#### __Figure 1:ReorderTabRows set to True__
![Telerik TabControl ReorderTabRows](images/tabcontrol_controlling_behavior_reordertabrows_1.png)

#### __Figure 2: ReorderTabRows set to False__
![Telerik TabControl ReorderTabRows](images/tabcontrol_controlling_behavior_reordertabrows_2.png)

## AllowDragReorder

You can allow/disallow the user to reorder the tab items of your control throught the __AllowDragReorder__.

>tipThe default value for the __AllowDragReorder__ property is __False__.

#### __[XAML] Example 2: Allow reordering the tab items__	
	{{region xaml-radtabcontrol-features-controlling-behavior_1}}		
		<telerik:RadTabControl x:Name="radTabControl" AllowDragReorder="True">
			<telerik:RadTabItem Header="Calendar"/>
			<telerik:RadTabItem Header="Colors"/>
			<telerik:RadTabItem Header="Quote"/>
		</telerik:RadTabControl>
	{{endregion}}
	
## Enable or Disable Tab Items

You can set the  __IsEnabled__ property to prevent the user from interacting with the whole tab control or with certain tab items. You can find this property in both __RadTabControl__ and __RadTabItem__.

#### __[XAML] Example 3: Disable tab item__	
	{{region xaml-radtabcontrol-features-controlling-behavior_2}}		
		<telerik:RadTabControl x:Name="radTabControl">
            <telerik:RadTabItem Header="Calendar"/>
            <telerik:RadTabItem Header="Colors" />
            <telerik:RadTabItem Header="Disabled Item" IsEnabled="False"/>
            <telerik:RadTabItem Header="Quote"/>
        </telerik:RadTabControl>
	{{endregion}}
	
#### __Figure 3: Disable tab item__
![Telerik TabControl Disabled Tab Item](images/tabcontrol_controlling_behavior_disableditem_3.png)

## TabStripPlacement 

You can change the position of the tab strip throught the __TabStripPlacement__ property. More information regarding this functionality can be found [here]({%slug radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-radtabcontrol%})

## OverflowMode

By default, the RadTabControl will display two arrows when the width of the tab items exceeds the available width with which you can bring the rest of the items into view. To see all the RadTabItem in the ViewPort, you can set the __OverflowMode__ property to __Wrap__.

#### __[XAML] Example 4: Show all tab items in the viewport__	
	{{region xaml-radtabcontrol-features-controlling-behavior_3}}		
		<telerik:RadTabControl x:Name="radTabControl" OverflowMode="Wrap">
		    <!-- large number of items -->
        </telerik:RadTabControl>
	{{endregion}}

#### __Figure 4: Show all items in the ViewPort__
![Telerik TabControl OverflowMode](images/tabcontrol_controlling_behavior_overflowmode_4.png)

## AllowDragOverTab

This property indicates whether dragging objects over a tab item will select this TabItem. The default value for the __AllowDragOverTab__ property is __False__. 

>tipThe DragOverTab feature will work only if the Telerik.Windows.Controls.DragDrop.RadDragAndDropManager is used.

#### __[XAML] Example 5: Setting AllowDragOverTab to true__	
	{{region xaml-radtabcontrol-features-controlling-behavior_4}}		
		<telerik:RadTabControl x:Name="radTabControl" OverflowMode="Wrap"/>
	{{endregion}}

## Align

The RadTabControl allows you to control the alignment of the tab items in the row - Left, Right, Center, Justify. More information can be found in the [Tabstrip alignment]({%slug radtabcontrol-fetures-tabstrip-alignment%})

## TabOrientation

RadTabControl allows you to control whether to display the tabs horizontally or vertically. You can do that through the Orientation property of the tab control. Its default value is Horizontal and therefore the items are positioned horizontally. Setting the property to Vertical will rotate the headers of the tab items at 90 degrees.

#### __[XAML] Example 6: Change orientation of the tab items__	
	{{region xaml-radtabcontrol-features-controlling-behavior_5}}		
		<telerik:RadTabControl x:Name="radTabControl" TabOrientation="Vertical" >
			<telerik:RadTabItem Header="Calendar" />
			<telerik:RadTabItem Header="Colors" />
			<telerik:RadTabItem Header="Quote"/>
		</telerik:RadTabControl>
	{{endregion}}

#### __Figure 5: TabOrientation set to Vertical__
![Telerik TabControl TabOrientation](images/tabcontrol_controlling_behavior_taborientation_5.png)

## AdditionalContent

The __RadTabControl__ control exposes a property, which allows you to display additional content on its right side of the control.

#### __[XAML] Example 7: Add AdditionalContent__	
	{{region xaml-radtabcontrol-features-controlling-behavior_6}}		
		<telerik:RadTabControl x:Name="radTabControl" >
			<telerik:RadTabControl.AdditionalContent>
				<TextBlock Text="Sample Text" VerticalAlignment="Center"/>
			</telerik:RadTabControl.AdditionalContent>
			<telerik:RadTabItem Header="Calendar" />
			<telerik:RadTabItem Header="Colors" />
			<telerik:RadTabItem Header="Quote"/>
		</telerik:RadTabControl>
	{{endregion}}

#### __Figure 6: Add AdditionalContent__
![Telerik TabControl AdditionalContent](images/tabcontrol_controlling_behavior_additionalcontent_6.png)	

## CloseTabsOnMouseMiddleButtonDown

To close the tab on mouse middle button down you can set the __CloseTabsOnMouseMiddleButtonDown__ property of the RadTabControl to __True__.

## ScrollMode

When the width of the control does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. You can choose one of the __ScrollMode__ values in order to control how the tab items should be scrolled. 

## AllTabsEqualHeight

This property specifies whether all displayed tabs have equal height.

>tipThe default value for the __AllTabsEqualHeight__ property is __True__.

## TabControl DropDown Menu

When the width of the control does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. For faster navigation the control expose drop down menu which contains a list of all tab items inside the control. To show the dropdown button menu you can set the __DropDownDisplayMode__ to __Visible.

The __DropDownDisplayMode__ property could be set to any of the following values:
	* __Collapsed__: The drop down will never be shown.
	* __Visible__: The drop down will always be visible.
	* __WhenNeeded__: The drop down will be shown only when there is not enough space the Tabs to be arranged. 

#### __[XAML] Example 8: Show DropDownMenu button__	
	{{region xaml-radtabcontrol-features-controlling-behavior_7}}		
		<telerik:RadTabControl x:Name="radTabControl" DropDownDisplayMode="Visible">
		    <!-- large number of items -->
        </telerik:RadTabControl>
	{{endregion}}

#### __Figure 7: Show DropDownMenu button__
![Telerik TabControl DropDownMenu Button](images/tabcontrol_controlling_behavior_dropdownmenu_7.png)		
	
## See Also

 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})

 * [Create Multi-line Tabs]({%slug radtabcontrol-features-multiline-tabs%})

 * [Enable and Disable Tabs]({%slug radtabcontrol-enable-disable-tabs%})
