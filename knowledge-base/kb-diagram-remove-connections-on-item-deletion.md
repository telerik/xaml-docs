---
title: Removing Connected Connections on Item Deletion in RadDiagram
description: How to automatically remove connections in RadDiagram when deleting a RadDiagramShape that the connections are attached to.
type: how-to
page_title: Delete RadDiagramConnections When Removing Shapes in RadDiagram
slug: kb-diagram-remove-connections-on-item-deletion
tags: rad-diagram, wpf, remove, connections, item, deletion
res_type: kb
ticketid: 1668052
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadDiagram for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2023.3.1114</td>
</tr>
</tbody>
</table>

## Description

How to remove attached RadDiagramConnections when the associated diagram shape is deleted.

## Solution

To do this, you can use the RadDiagram's `ItemsChanging` event. In the event handler, you can access the deleted shape and remove its connections from the diagram. To access the connections attached to the shape, you can use the `IncomingLinks` and `OutgoingLinks` properties of the shape.


```C#
	private void RadDiagram_ItemsChanging(object sender, Telerik.Windows.Controls.Diagrams.DiagramItemsChangingEventArgs e)
	{
		if (e.OldItems.Count() > 0)
		{
			var diagram = (RadDiagram)sender;
			var shapes = e.OldItems.OfType<RadDiagramShapeBase>();
			foreach (var shape in shapes)
			{
				foreach (var connection in shape.IncomingLinks.ToList())
				{
					diagram.RemoveConnection(connection, true);
				}

				foreach (var connection in shape.OutgoingLinks.ToList())
				{
					diagram.RemoveConnection(connection, true);
				}
			}
		}
	}
```
