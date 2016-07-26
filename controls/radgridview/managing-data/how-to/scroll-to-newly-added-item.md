---
title: Scroll to newly added item
page_title: Scroll to newly added item
description: Scroll to newly added item
slug: gridview-how-to-scroll-to-newly-added-item
tags: scroll,to,newly,added,item
published: True
position: 5
---

# Scroll to newly added item

This article shows how to scroll RadGridView to the newly added item.

When you insert a new item, it is added as last item in of __RadGridView__. If you want to scroll to it, you will have to handle RadGridView's  __RowEditEnded__ event and execute the following code:
        

#### __C#__

{{region cs-gridview-how-to-scroll-to-newly-added-item_0}}
	private void clubsGrid_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
    {
        if (e.Row is GridViewNewRow)            
        {
            this.clubsGrid.SelectedItem = e.Row.Item;
            this.clubsGrid.ScrollIntoView(this.clubsGrid.SelectedItem);
        }
    }
{{endregion}}

#### __VB.NET__

{{region vb-gridview-how-to-scroll-to-newly-added-item_1}}

	Private Sub clubsGrid_RowEditEnded(sender As Object, e As GridViewRowEditEndedEventArgs)
		If TypeOf e.Row Is GridViewNewRow Then
			Me.clubsGrid.SelectedItem = e.Row.Item
			Me.clubsGrid.ScrollIntoView(Me.clubsGrid.SelectedItem)
		End If
	End Sub
{{endregion}}


