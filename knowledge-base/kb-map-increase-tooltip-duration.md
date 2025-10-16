---
title: How to Increase Tooltip Duration for Items Added to Visualization Layer
description: How to set show tooltip duration to items in VisualizationLayer.
type: how-to
page_title: How to Set Tooltip Timeout Duration for Elements Added to RadMap
slug: kb-map-increase-tooltip-duration
position: 0
tags: mapshapevisualizationcreated,setshowduration,tooltipservice
ticketid: 1408026
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.1.116</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadMap for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to increase the tooltip duration for the items in the VisualizationLayer.

## Solution

1. Subscribe to the __MapShapeVisualizationCreated__ event of VisualizationLayer.
2. Use the __ToolTipService.SetShowDuration__ method to set the tooltip duration for the generated visual element. To get the visual element use the Visualization property of the event arguments.


```C#
	private void VisualizationLayer_MapShapeVisualizationCreated(object sender, MapShapeOperationEventArgs e)
	{
		ToolTipService.SetShowDuration(e.Visualization, 1000);
	}
```

## See Also
* [VisualizationLayer]({%slug radmap-visualization-layer-introduction%})
* [ToolTipService]({%slug radtooltip-getting-started%})
* [MapShapeVisualizationCreated]({%slug radmap-visualization-layer-input-events%})
