---
title: How to get the contents of a row (Model) by mousing over the row
description: Retrieve the underlying data item when the user mouses over a row.
type: howto
page_title: Access the model shown in the hovered GridViewRow 
slug: kb-gridview-howto-get-item-on-mouseover
position: 0
tags: mouseover, item, model, row
ticketid: 1445462
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to obtain a reference to the underlying GridViewRow data model on mouse over.

## Solution

Subscribe to the __MouseEnter__ event of the GridViewRow elements. To do this, you can use the __RowLoaded__ and __RowUnloaded__ events of RadGridView as shown in __Examples 1 and 2__.

__Add handlers for RowLoaded and RowUnloaded__
```XAML
	<telerik:RadGridView RowLoaded="RadGridView_RowLoaded" RowUnloaded="RadGridView_RowUnloaded"/>
```

__Add MouseEnter event handler and access the hovered item__
```C#

   private object hoveredRowModel;

    private void RadGridView_RowLoaded(object sender, Telerik.Windows.Controls.GridView.RowLoadedEventArgs e)
    {
        if (e.Row is GridViewRow)
        {
            e.Row.MouseEnter += Row_MouseEnter;
        }
    }

    private void RadGridView_RowUnloaded(object sender, Telerik.Windows.Controls.GridView.RowUnloadedEventArgs e)
    {
        if (e.Row is GridViewRow)
        {
            e.Row.MouseEnter -= Row_MouseEnter;
        }
    }

    private void Row_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        var row = (GridViewRow)sender;
        this.hoveredRowModel = row.Item;
    } 
```

## See Also  
* [RadGridView Getting Started]({%slug gridview-getting-started2%})
