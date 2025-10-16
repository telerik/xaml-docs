---
title: How to Change RadGridView ControlPanel Background Color
page_title: Modify Background Brush of Telerik DataGrid Control Panel
description: Replace the Color of the GridView ControlPanel.
type: how-to
slug: kb-gridview-change-control-panel-background
position: 0
tags: background,brush,controlpanel,datagrid,gridview
ticketid: 1425610
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2 812</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to change the Background color of RadGridView's ControlPanel.

## Solution

1. Subscribe to the Loaded event of RadGridView.

2. In the event handler, get the ItemsControl that represents the Control Panel.

3. Set the Background property of the Control Panel.


```C#
	private void RadGridView_Loaded(object sender, RoutedEventArgs e)
	{
		var controlPanel = this.radGridView.ChildrenOfType<ItemsControl>().FirstOrDefault(x => x.Name == "PART_ControlPanelItemsControl");
		controlPanel.Background = Brushes.OrangeRed;
	}
```

![{{ site.framework_name }} RadGridView Change ControlPanel Background Color](images/kb-gridview-change-control-panel-background-0.png)

## See Also  
* [Control Panel]({%slug gridview-overview-controlpanel%})
* [ChildrenOfType]({%slug common-visual-tree-helpers%})

