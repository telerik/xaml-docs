---
title: Distinct Values Work Only the First Time in RadGridView
description: The RadGridView filters work only the first time they are applied
page_title: Filters Work Only the First Time in RadGridView
type: how-to
slug: kb-gridview-non-working-filters-with-custom-control-template-of-filtering-control
position: 0
tags: gridview, distinct values, filters, not working
res_type: kb
ticketid: 1629324
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.3.1114</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

The filters in the RadGridView control work only the first time that they are created.

This behavior can occur when a custom `ControlTemplate` is applied to the `Template` property of `FilteringControl` element with a product version equal to or higher than __2022.2.511__. The cause for it is an update to the `Path` property's value of the `Binding` instance for the `ItemsSource` property of the `ListBox` control, which displays the distinct values.

## Solution

To prevent this behavior from occurring, set the `Path` property of the Binding instance for the ItemsSource property to __FilteredDistinctValues__. The outdated value was __DistinctValues__. The ListBox element has an __x:Name="PART_DistinctValuesList"__.

#### __[XAML] Modifying the Path property of the ItemsSource Binding instance__
{{region kb-gridview-non-working-filters-with-custom-control-template-of-filtering-control-0}}
    <ListBox x:Name="PART_DistinctValuesList"
            ItemsSource="{Binding FilteredDistinctValues}">
    </ListBox>
{{endregion}}