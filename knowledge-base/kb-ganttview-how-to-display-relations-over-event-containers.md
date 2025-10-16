---
title: How to Display Relations over Event Containers
description: An article explaining how to position the relations arrows over the containers of the GanttView events.
type: how-to
page_title: Position the Event Containers under the GanttView Task Relations
slug: kb-ganttview-how-to-display-relations-over-event-containers
position: 0
tags: ganttview, tasks, display, relations, over, event, containers 
ticketid: 1478139
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGanttView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display relations over event containers.

## Solution

To have the relations appear over the GanttView tasks, you need to set the **ZIndexManager.ZIndex** attached property of the **RelationContainer** to a value larger than **40**.



```XAML
	<!-- If you're using the NoXaml binaries, you need to also add the following attribute to the style:
	BasedOn="{StaticResource RelationContainerStyle}" -->
	<Style TargetType="telerik:RelationContainer">
		<Setter Property="telerik:ZIndexManager.ZIndex" Value="50"/>
					<!-- ... -->
	</Style>
```

## See Also
* [GanttView Styles]({%slug radganttview-styles-and-templates-overview%})
