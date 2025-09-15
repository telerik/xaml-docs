---
title: Select GridView row on Row Indicator Click 
description: How to select RadGridView row when you click on the cell on the left side of the row (the row indicator).
type: how-to
page_title: Row selection on click over the button on the left side of the row.
slug: kb-gridview-select-row-on-rowindicator-click
position: 0
tags: click,select,row,indicator
ticketid: 1571138
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to select RadGridView row when you click on the cell on the left side of the row (the row indicator).

## Solution

Get the `Border` element that represents the row indicator and subscribe to its `MouseLeftButtonDown`  event. Then, in the event handler, select the row manually. To get the `Border` you can use the `RowLoaded` event of `RadGridView` in combination with the [ChildrenOfType]({%slug common-visual-tree-helpers%}) extension method. The `RowUnloaded` event can be used to unsubscribe from the mouse event, thus preventing memory leaks.


```XAML
	private void RadGridView_RowLoaded(object sender, Telerik.Windows.Controls.GridView.RowLoadedEventArgs e)
	{
		var indicator = e.Row.ChildrenOfType<Border>().FirstOrDefault(x => x.Name == "PART_IndicatorPresenter");
		if (indicator != null)
		{
			indicator.MouseLeftButtonDown += Indicator_MouseLeftButtonDown;
		}
	}
	
	private void RadGridView_RowUnloaded(object sender, Telerik.Windows.Controls.GridView.RowUnloadedEventArgs e)
	{
		var indicator = e.Row.ChildrenOfType<Border>().FirstOrDefault(x => x.Name == "PART_IndicatorPresenter");
		if (indicator != null)
		{
			indicator.MouseLeftButtonDown -= Indicator_MouseLeftButtonDown;
		}
	}

	private void Indicator_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		var indicator = (Border)sender;
		var dataItem = indicator.DataContext;
		this.gridView.SelectedItems.Add(dataItem);
	}
```