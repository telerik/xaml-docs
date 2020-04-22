---
title: How to integrate the RadCallout control inside RadToolTip
page_title: How to integrate the RadCallout control inside RadToolTip
description: Check our &quot;Overview&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-howto-tooltip-integration
tags: tooltip,callout,
published: True
position: 1
---

# Integrate the RadCallout control inside RadToolTip

The RadCallout can be easily used as a tooltip. The code snippet in __Example 1__ shows how we can do this by using RadToolTip control. 

#### __[C#] Example 1: Remove event handlers__
	{{region cs-radcallout-howto-tooltip-integration}}
		<telerik:RadButton VerticalAlignment="Center" HorizontalAlignment="Center" Content="RadToolTip" Width="80"
							telerik:RadToolTipService.ToolTipContentTemplate="{x:Null}"
							telerik:RadToolTipService.Placement="Top"
							telerik:RadToolTipService.HorizontalOffset="-20">
			<telerik:RadToolTipService.ToolTipContent>
				<!-- Margin is to provide space for the arrow which is not measured in the size of the callout-->
				<telerik:RadCallout Content="Callout in a tooltip" Width="120" Margin="0 0 0 10"/>
			</telerik:RadToolTipService.ToolTipContent>
		</telerik:RadButton>	
	{{endregion}}	

