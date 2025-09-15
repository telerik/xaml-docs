---
title: Prevent RadDiagramConnection Point from Delete
description: How to prevent RadDiagramConnection point from delete.
type: how-to
page_title: Prevent RadDiagramConnection Point from Delete
slug: kb-prevent-diagramconnection-point-from-delete
position: 0
tags: raddiagramconnection, point, delete, prevent
ticketid: 1449311
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDiagram for WPF</td>
		</tr>
	</tbody>
</table>


## Description

How to prevent RadDiagramConnection point from delete.

## Solution

To achieve this requirement you can handle the __PreviewMouseLeftButtonDown__ event of RadDiagram in the situation when Ctrl is pressed and a RadDiagramConnection point is under the mouse. 

__Example 1: Prevent RadDiagramConnection Point from Delete__
    ```C#
        private void Diagram_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var selectionService = this.diagram.ServiceLocator.GetService<ISelectionService<IDiagramItem>>() as SelectionService;
			if (KeyboardModifiers.IsControlDown)
			{
				var selectedConnection = selectionService.SelectedConnections.FirstOrDefault();
				if (selectedConnection != null)
				{
					var position = e.GetPosition(this.diagram);
					var transformedPosition = this.diagram.GetTransformedPoint(position);
					var relativePoint = new Point(transformedPosition.X - 5, transformedPosition.Y - 5);
					var rect = new Rect(relativePoint, new Size(10, 10));
					if (connection.ConnectionPoints.Any(rect.Contains))
					{
						e.Handled = true;
					}
				}
			}
		}
    ```