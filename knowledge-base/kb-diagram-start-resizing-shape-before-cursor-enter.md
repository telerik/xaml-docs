---
title: How to Start Resizing Diagram Shape Before Mouse Cursor Enters it
page_title: Change Shape Size When Mouse is Outside of RadDiagramShape
description: Begin resizing a shape with SizeAll cursor before the mouse entering the RadDiagramShape, like in Microsoft PowerPoint.
type: how-to
slug: kb-diagram-start-resizing-shape-before-cursor-enter
position: 0
tags: resize,enter,shape,mouse,cursor,powerpoint
ticketid: 1427251
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2 826</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDiagram for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to start resizing a shape (SizeAll cursor shown) before the mouse enters the RadDiagramShape. This behavior can be observed with the Microsoft PowerPoint shapes.

## Solution

To introduce a small tolerance between the shape bounds and the mouse position where you can start the resizing operation, create a __custom PointerTool__ and replace the default one in the __ToolService__.


```C#
	public class CustomPointerTool : PointerTool
    {
        private GroupService groupService;
        private RadDiagram graph;
		
        public CustomPointerTool(RadDiagram graph)
        {
            this.graph = graph;
            this.groupService = this.graph.ServiceLocator.GetService<IGroupService>() as GroupService;
        }

        public override bool MouseMove(PointerArgs e)
        {
            var baseResult = base.MouseMove(e);
            var selectionMode = this.graph.SelectionMode;
            if (this.HitItem == null && this.ToolService.IsMouseDown && selectionMode != SelectionMode.None)
            {
                foreach (var shape in this.graph.Shapes)
                {
                    var inflatedBounds = shape.ActualBounds.InflateRect(30);
                    if (inflatedBounds.Contains(e.TransformedPoint))
                    {
                        if (!shape.IsSelected)
                        {
                            bool addToExistingSelection = selectionMode != SelectionMode.Single && (this.ToolService.IsControlDown || selectionMode == SelectionMode.Multiple);
                            SelectWithGroups(addToExistingSelection, shape);
                        }
                        bool isDraggingEnabled = this.SelectionService.SelectedItems.Any(d => d.IsDraggingEnabled == false) ? false : true;
                        if (isDraggingEnabled)
                        {
                            this.ToolService.ActivateTool(DraggingTool.ToolName);
                            return false;
                        }

                        return true;
                    }
                }
            }
            return baseResult;
        }
             
        private void SelectWithGroups(bool addToExistingSelection, IDiagramItem hitItem)
        {
            var itemsToSelect = this.groupService.GetItemSiblings(hitItem, addToExistingSelection).Union(new[] { hitItem });
            this.SelectionService.SelectItems(itemsToSelect, addToExistingSelection);
        }
    }
```


```C#
	public MainWindow()
	{
		InitializeComponent();
		
		var toolService = this.radDiagram.ServiceLocator.GetService<IToolService>() as ToolService;
		toolService.ToolList[0] = new CustomPointerTool(this.diagram);            
	}
```

## See Also  
* [RadDiagram Getting Started]({%slug raddiagram-getting-started%})
* [Services]({%slug raddiagram-features-services%})