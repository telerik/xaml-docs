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

#### __[XAML] Add handlers for RowLoaded and RowUnloaded__
{{region xaml-kb-gridview-howto-get-item-on-mouseover-0}}
	<telerik:RadGridView RowLoaded="RadGridView_RowLoaded" RowUnloaded="RadGridView_RowUnloaded"/>
{{endregion}}

#### __[C#] Add MouseEnter event handler and access the hovered item__
{{region cs-kb-gridview-howto-get-item-on-mouseover-1}}

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
{{endregion}}

## See Also  
* [RadGridView Getting Started]({%slug gridview-getting-started2%})
