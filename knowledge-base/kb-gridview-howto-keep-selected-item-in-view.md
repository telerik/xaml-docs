---
title: How to Keep the Selected Item in the Viewport when the Collection is Changed
description: Keep the selection in view when items are added or removed.
type: how-to
page_title: Keep Selected Item in Viewport when Collection Changes
slug: kb-gridview-howto-keep-selected-item-in-view
tags: selected, item, viewport, keep, collection, change
ticketid: 1531899
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

When an item is added or removed from the source collection of the RadGridView control, the scroll position is changed.

This article explains how to keep the selected item in the viewport when the collection is changed. 

## Solution

To keep the position of the selected item, you can handle the `CollectionChanged` event of its `Items` collection and offset the `GridViewScrollViewer` by the amount of items added/removed multiplied by the `RowHeight`.

__Handle CollectionChanged event to keep item in viewport__
```C#
    gridView.Items.CollectionChanged += (s, a) =>
    {
        var selectedItem = gridView.SelectedItem;
        var selectedItemIndex = gridView.Items.IndexOf(selectedItem);

        double offset = 0;

        if (a.NewItems != null)
        {
            foreach (var item in a.NewItems)
            {
                if (gridView.Items.IndexOf(item) < selectedItemIndex)
                {
                    offset += gridView.RowHeight;
                }
            }
        }

        if (a.OldItems != null)
        {
            foreach (var item in a.OldItems)
            {
                if (a.OldStartingIndex < selectedItemIndex)
                {
                    offset -= gridView.RowHeight;
                }
            }
        }

        var scrollViewer = gridView.ChildrenOfType<GridViewScrollViewer>().FirstOrDefault();
        scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + offset);
        scrollViewer.UpdateLayout(); // required so that the value of the VerticalOffset property is updated
    };
```
```VB.NET
    AddHandler gridView.Items.CollectionChanged, Sub(s, a)
		Dim selectedItem = gridView.SelectedItem
		Dim selectedItemIndex = gridView.Items.IndexOf(selectedItem)

		Dim offset As Double = 0

		If a.NewItems IsNot Nothing Then
			For Each item In a.NewItems
				If gridView.Items.IndexOf(item) < selectedItemIndex Then
					offset += gridView.RowHeight
				End If
			Next item
		End If

		If a.OldItems IsNot Nothing Then
			For Each item In a.OldItems
				If a.OldStartingIndex < selectedItemIndex Then
					offset -= gridView.RowHeight
				End If
			Next item
		End If

		Dim scrollViewer = gridView.ChildrenOfType(Of GridViewScrollViewer)().FirstOrDefault()
		scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + offset)
		scrollViewer.UpdateLayout() ' required so that the value of the VerticalOffset property is updated
	End Sub

```

> A working example of this approach can be found in our [SDK Samples Browser]({%slug sdk-samples-browser%}). It is titled [Preserve Selected Item Scroll Position](https://github.com/telerik/xaml-sdk/tree/master/GridView/PreserveScrollPosition).

## See Also
* [Selection]({%slug gridview-selection-basics%})
* [Scrolling]({%slug gridview-scrolling%})