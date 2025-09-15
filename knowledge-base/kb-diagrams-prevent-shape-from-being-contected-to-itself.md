---
title: How to Prevent Shapes from Being Connected to Themselves
description: Way to avoid self connecting the same shape on click over its connector, using ReflexiveRouter and ConnectionManipulationCompleted event.
page_title: Prevent RadDiagramShape from connect to itself.
type: how-to
slug: kb-diagrams-prevent-shape-from-being-contected-to-itself
position: 0
tags: reflexiverouter,event
ticketid: 1350293
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2018.2.515</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadDiagram for WPF</td>
	</tr>
</table>

## Description

How to prevent a RadDiagramShape to connect to itself when you single click on one of its connector points.

## Solution

To prevent this use one of the following two solutions:

### Solution #1

Set the __ReflexiveRouter__ of RadDiagram to null.


```C#
	this.diagram.RoutingService.ReflexiveRouter = null;
```

### Solution #2

Handle the __ConnectionManipulationCompleted__ event of RadDiagram, if the connection source is the same as the Shape of the event arguments.


```C#
	private void RadDiagram_ConnectionManipulationCompleted(object sender, Telerik.Windows.Controls.Diagrams.ManipulationRoutedEventArgs e)
	{
		if (e.Connection.Source == e.Shape)
		{           
			e.Handled = true;
		}
	}
```

## See Also
* [Getting Started]({%slug raddiagram-getting-started%})
* [Routing]({%slug raddiagram-features-routing%})
* [Services]({%slug raddiagram-features-services%})
