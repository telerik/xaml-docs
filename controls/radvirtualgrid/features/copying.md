---
title: Copying
page_title: Copying
description: Copying
slug: virtualgrid-copying
tags: copying
published: True
position: 8
---

# Copying

This article will go through the mechanisms that the control provides for controlling how its content can be copied to the Clipboard.

* [ClipboardCopyMode](#clipboardcopymode)

* [Events](#events)

## ClipboardCopyMode

Copying to the Clipboard is controlled by the __ClipboardCopyMode__ property of __RadVirtualGrid__. It is a Flags Enumeration of type __VirtualGridClipboardCopyMode__. It has the following values.

* __None__: Copying is disabled.

* __Cells__: Copy grid cells.

* __SkipEmptyRows__: Will not copy rows with values that are all null or empty.

## Events

There are two events that allow you to control the copying operation: __Copying__ and __CopyingCellClipboardContent__. The first allows you to cancel a copying operation, whereas the second event allows you to cancel copying for a single cell or override the value to be copied to the Clipboard. 

#### __[C#] Example 1: Subscribing to the Copying event__

{{region radvirtualgrid-features_copying_0}}
	private void VirtualGrid_Copying(object sender, VirtualGridClipboardEventArgs e)
        {
            e.Cancel = true;
        }
{{endregion}}

#### __[C#] Example 2: Subscribing to the CopyingCellClipboardContent event__

{{region radvirtualgrid-features_copying_1}}
	private void VirtualGrid_CopyingCellClipboardContent(object sender, VirtualGridCellClipboardEventArgs e)
        {
            if (e.Cell.ColumnIndex == 0)
            {
                var item = this.clubsSource.ElementAt(e.Cell.RowIndex);
                e.Value = string.Format("{0} {1}", item.Name, item.StadiumCapacity);
            }
        }
{{endregion}}

## See Also

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})