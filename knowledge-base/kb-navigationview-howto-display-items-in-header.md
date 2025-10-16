---
title: How to add a data source to the PaneHeader
description: Bind a collection of items to the pane header.
type: how-to
page_title: Bind a Collection of Items to the PaneHeader
slug: kb-navigationview-howto-display-items-in-header
tags: bind, collection, items, datasource, paneheader
ticketid: 1430859
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.917</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadNavigationView for WPF</td>
		</tr>
	</tbody>
</table>


## Description

How to bind a collection of items to the pane header.

## Solution

You can achieve the desired result by using the [PaneHeaderTemplate]({%slug radnavigationview-header-and-footer%}) property of the control and using a **RelativeSource** binding to point to your header collection.


```C#
      <telerik:RadNavigationView.PaneHeaderTemplate>
          <DataTemplate>
              <StackPanel Orientation="Horizontal">
                  <TextBlock Text="{Binding}" VerticalAlignment="Center" />
                  <ItemsControl ItemsSource="{Binding DataContext.HeaderItems, RelativeSource={RelativeSource AncestorType=telerik:RadNavigationView}}" />
              </StackPanel>
          </DataTemplate>
      </telerik:RadNavigationView.PaneHeaderTemplate>
```

## See Also

* [Header and Footer]({%slug radnavigationview-header-and-footer%})
