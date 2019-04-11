---
title: Remove the collapsed area of the RadDiagramContainerShape 
description: Get rid of the body area when the RadDiagramContainerShape is collapsed
type: how-to
page_title: Hide the collapse area of the RadDiagramContainerShape
slug: kb-diagram-remove-diagramcontainer-collapsearea
position: 0
tags: diagram, container, diagramcontainershape, collapsearea, collapsedcontainer, collapsedcontent
ticketid: 1403864
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1 401</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadDiagram for WPF</td>
	</tr>
</table>


## Description

Remove the collapsed area when the RadDiagramContainerShape is collapsed.

## Solution

Set the CollapsedContentTemplate property to empty DataTemplate.

#### __[C#]__
{{region kb-diagram-remove-diagramcontainer-collapsearea_2}}
	<telerik:RadDiagramContainerShape>
		<telerik:RadDiagramContainerShape.CollapsedContentTemplate>
			<DataTemplate/>
		</telerik:RadDiagramContainerShape.CollapsedContentTemplate>
	</telerik:RadDiagramContainerShape>
{{endregion}}



