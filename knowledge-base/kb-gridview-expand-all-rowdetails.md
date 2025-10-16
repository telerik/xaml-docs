---
title: Expand and Collapse All Row Details in RadGridView
page_title: Toggle Expand State of Row Details in DataGrid
description: Expand or collapse all row details in GridView by binding the DetailsVisibility property.
type: how-to
slug: kb-gridview-expand-all-rowdetails
position: 0
tags: collapse,expand,all,row,details
ticketid: 1581543
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

How to implement custom logic that expands or collapses all row details in GridView.

## Solution

The row details visibility of the GridView rows is controlled via their `DetailsVisibility` property. To implement logic that expands/collapses all row details, the `DetailsVisibility` property of the `GridViewRow` element can be bound to a property in the row's data item. Then, on button click or another action, the data item property of all items can be changed accordingly to the needed expand state.

__Defining the data item's property__
```C#
	public class RowInfo : ViewModelBase
    {
        private Visibility detailsVisibility = Visibility.Collapsed;

        public Visibility DetailsVisibility
        {
            get { return detailsVisibility; }
            set { detailsVisibility = value; OnPropertyChanged("DetailsVisibility"); }
        }

        // other row related properties here
    }
```

__Data bind the visibility property__
```XAML
	<telerik:RadGridView.RowStyle>
		<!-- if using the NoXaml Telerik dlls, set the following setting on the Style object: BasedOn="{StaticResource GridViewRowStyle}"-->
		<Style TargetType="telerik:GridViewRow">
			<Setter Property="DetailsVisibility" Value="{Binding DetailsVisibility, Mode=TwoWay}"/>
		</Style>
	</telerik:RadGridView.RowStyle>
```

__Expand/Collapse all row details__
```C#
	private void ToggleRowDetailsVisibility(Visibility visibility)
	{
		// this.source is a collection of RowInfo objects assigned to the ItemsSource of RadGridView
		foreach (var item in this.source)
		{
			item.DetailsVisibility = visibility;
		}
	}
```

## See Also 
* [Row Details]({%slug radgridview-row-details-overview%})
* [ViewModelBase]({%slug common-viewmodelbase-class%})
* [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})