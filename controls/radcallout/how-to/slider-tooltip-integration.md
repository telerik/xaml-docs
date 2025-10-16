---
title: Use Callout as RadToolTip in RadSlider
page_title: Use Callout as RadToolTip in RadSlider
description: Check our &quot;Overview&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-howto-tooltip-slider
tags: tooltip, callout, slider
published: True
position: 1
---

# Use Callout as Thumb ToolTip in RadSlider

The RadCallout can be easily used as a tooltip for the RadSlider control. To do that, we can use the __AutoToolTipContentTemplate__ property of the RadSlider to place the RadCallout inside the Thumb ToolTip. Then we need to remove the Border of the ToolTip and make it transparent so that only the content (RadCallout) is visible. The code snippet in __Example 1__ demonstrates this approach.  

__Example 1: Callout as a ToolTip for RadSlider Thumb__
```C#
	<telerik:RadSlider AutoToolTipPlacement="TopLeft" Minimum="0" Maximum="100" LargeChange="5" SmallChange="1" VerticalAlignment="Center" HorizontalAlignment="Center" Width="500" >
		<telerik:RadSlider.ThumbToolTipStyle>
			<Style TargetType="ToolTip">
				<Setter Property="BorderThickness" Value="0"/>
				<Setter Property="Background" Value="Transparent"/>
			</Style>
		</telerik:RadSlider.ThumbToolTipStyle>
		<telerik:RadSlider.AutoToolTipContentTemplate>
			<DataTemplate>
				<telerik:RadCallout  Margin="5 5 5 10" >
					<TextBlock Text="{Binding .,  StringFormat=N2}" />
				</telerik:RadCallout>
			</DataTemplate>
		</telerik:RadSlider.AutoToolTipContentTemplate>
	</telerik:RadSlider>	
```	
	
#### __Figure 1:  Callout as a ToolTip for RadSlider Thumb__
![RadSlider ToolTip ThumbToolTipStyle Callout](images/RadSlider_ToolTip_ThumbToolTipStyle.png)


