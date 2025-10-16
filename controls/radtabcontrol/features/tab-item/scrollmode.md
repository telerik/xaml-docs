---
title: ScrollMode
page_title: ScrollMode
description: This article describes the ScrollMode property.
slug: radtabcontrol-features-tabs-scrollmode
tags: scrollmode, tabs
published: True
position: 2
---

# ScrollMode

__RadTabControl__ exposes the __ScrollMode__ property which allows you to control the scrolling of the tab items. When the width of the window does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. You can choose one of the __ScrollMode__ values in order to control how the tab items should be scrolled. To demonstrate the different type of scrolling we are going to use the code in Example 1.

>The default value of the ScrollMode is __Pixel__.

__Example 1: Setting the ScrollMode property__
```XAML
	<telerik:RadTabControl ScrollMode="Viewport" >
		<telerik:RadTabControl.Resources>
			<Style TargetType="telerik:RadTabItem">
				<Setter Property="CloseButtonVisibility" Value="Visible"/>
				<Setter Property="PinButtonVisibility" Value="Visible"/>
			</Style>
		</telerik:RadTabControl.Resources>
		<telerik:RadTabItem Header="Tab Item 1" />
		<telerik:RadTabItem Header="Tab Item 2"/>
		<telerik:RadTabItem Header="Tab Item 3"/>
		<telerik:RadTabItem Header="Tab Item 4"/>
		<telerik:RadTabItem Header="Tab Item 5"/>
		<telerik:RadTabItem Header="Tab Item 6"/>
		<telerik:RadTabItem Header="Tab Item 7"/>
		<telerik:RadTabItem Header="Tab Item 8"/>
		<telerik:RadTabItem Header="Tab Item 9"/>
	</telerik:RadTabControl>
```

### __Pixel__

When set, the tab items will be scrolled 16 pixels per button click.

![RadTabControl with ScrollMode Pixel](images/radtabcontrol-features-tabs-scrollmode_pixel_0_1.gif)
	
### __Item__

When set, the tab items will be scrolled one item per button click.

![RadTabControl with ScrollMode Item](images/radtabcontrol-features-tabs-scrollmode_item_1_1.gif)
	
###__Viewport__

When set, the tab items will be scrolled an amount equal to the available viewport width.

![RadTabControl with ScrollMode Viewport](images/radtabcontrol-features-tabs-scrollmode_viewport_2_1.gif)
	
## See Also
 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})
 * [Add and Remove Tabs]({%slug radtabcontrol-populating-add-remove-tabs%})
