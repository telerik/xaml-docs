---
title: Use Callout with RadToolTip
page_title: Use Callout with RadToolTip
description: Check our &quot;Overview&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-howto-tooltip-integration
tags: tooltip, callout
published: True
position: 1
---

# Use Callout with RadToolTip

The RadCallout can be easily used as a tooltip. The code snippet in __Example 1__ shows how we can do this by using RadToolTip control. 

__Example 1: Place RadCallout Inside RadToolTip__
```C#
	<telerik:RadButton VerticalAlignment="Center" HorizontalAlignment="Center" Content="RadToolTip" Width="80"
						telerik:RadToolTipService.ToolTipContentTemplate="{x:Null}"
						telerik:RadToolTipService.Placement="Top"
						telerik:RadToolTipService.HorizontalOffset="-20">
		<telerik:RadToolTipService.ToolTipContent>
			<telerik:RadCallout Content="Callout in a tooltip" Width="120" Margin="0 0 0 10"/>
		</telerik:RadToolTipService.ToolTipContent>
	</telerik:RadButton>	
```	


