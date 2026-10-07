---
title: Column and Row Resize Events
page_title: Column and Row Resize Events
description: Learn how to use the ColumnWidthChanging, ColumnWidthChanged, RowHeightChanging, and RowHeightChanged events of the RadVirtualGrid {{ site.framework_name }} control to restrict or track column and row resizing.
components: ["virtualgrid"]
slug: virtualgrid-resize-events
tags: virtualgrid,resize,column,row,width,height,events
published: True
position: 11
---

# Column and Row Resize Events

When the user resizes a column or a row through the UI, `RadVirtualGrid` raises events that let you restrict the operation and react to its result. This article explains how to use the `ColumnWidthChanging`, `ColumnWidthChanged`, `RowHeightChanging`, and `RowHeightChanged` events.

>important The events are raised only for resizing performed by the user through the UI. Column resizing requires the `CanUserResizeColumns` property to be `True` (the default value), and row resizing requires the `CanUserResizeRows` property to be `True`. For more information, see [Column and Row Resizing]({%slug virtualgrid-column-and-row-resizing%}).

## Resize Events Overview

The following table describes when each event is raised.

| Event | Event arguments | Description |
|---|---|---|
| `ColumnWidthChanging` | `VirtualGridColumnWidthChangingEventArgs` | Raised while a column is being resized, on each step of the drag operation. Can be canceled. |
| `ColumnWidthChanged` | `VirtualGridColumnWidthChangedEventArgs` | Raised once after the user finishes resizing a column. |
| `RowHeightChanging` | `VirtualGridRowHeightChangingEventArgs` | Raised while a row is being resized, on each step of the drag operation. Can be canceled. |
| `RowHeightChanged` | `VirtualGridRowHeightChangedEventArgs` | Raised once after the user finishes resizing a row. |

The event arguments of the column events expose the following properties:

| Property | Type | Description |
|---|---|---|
| `ColumnIndex` | `int` | The index of the column being resized. |
| `OldWidth` | `double` | The width of the column before the resize operation started. |
| `NewWidth` | `double` | The new width of the column. In the `ColumnWidthChanging` event, this is the width that is about to be applied. In the `ColumnWidthChanged` event, this is the final width. |

The event arguments of the row events expose the following properties:

| Property | Type | Description |
|---|---|---|
| `RowIndex` | `int` | The index of the row being resized. |
| `OldHeight` | `double` | The height of the row before the resize operation started. |
| `NewHeight` | `double` | The new height of the row. In the `RowHeightChanging` event, this is the height that is about to be applied. In the `RowHeightChanged` event, this is the final height. |

The `VirtualGridColumnWidthChangingEventArgs` and `VirtualGridRowHeightChangingEventArgs` classes inherit from `CancelEventArgs`, so they also expose the `Cancel` property.

## Restricting the Resize Operation

Use the `ColumnWidthChanging` and `RowHeightChanging` events to prevent the user from resizing a column or a row to an unwanted size. Set the `Cancel` property of the event arguments to `True` to skip the pending size change. Because the events are raised on each step of the drag operation, the column or row keeps the last size that was not canceled.

The following example prevents the user from making the first column wider than 300 pixels and the rows taller than 80 pixels.

__Subscribing to the resize events__

```xml
<telerik:RadVirtualGrid x:Name="virtualGrid"
                        CanUserResizeRows="True"
                        InitialColumnCount="5"
                        InitialRowCount="20" />
```
```C#
this.virtualGrid.ColumnWidthChanging += this.VirtualGrid_ColumnWidthChanging;
this.virtualGrid.RowHeightChanging += this.VirtualGrid_RowHeightChanging;
```

__Canceling the resize operation__

```C#
private void VirtualGrid_ColumnWidthChanging(object sender, VirtualGridColumnWidthChangingEventArgs e)
{
    if (e.ColumnIndex == 0 && e.NewWidth > 300)
    {
        e.Cancel = true;
    }
}

private void VirtualGrid_RowHeightChanging(object sender, VirtualGridRowHeightChangingEventArgs e)
{
    if (e.NewHeight > 80)
    {
        e.Cancel = true;
    }
}
```

The `VirtualGridColumnWidthChangingEventArgs` and `VirtualGridRowHeightChangingEventArgs` classes are defined in the `Telerik.Windows.Controls.VirtualGrid` namespace.

## Reacting to the Completed Resize

Use the `ColumnWidthChanged` and `RowHeightChanged` events to run logic after the user releases the mouse button and the resize operation completes. The `OldWidth` and `OldHeight` properties hold the size at the start of the operation, and `NewWidth` and `NewHeight` hold the final size.

The following example stores the final column widths and row heights so that they can be restored later.

__Storing the resized dimensions__

```C#
private readonly Dictionary<int, double> columnWidths = new Dictionary<int, double>();
private readonly Dictionary<int, double> rowHeights = new Dictionary<int, double>();

private void SubscribeToResizedEvents()
{
    this.virtualGrid.ColumnWidthChanged += this.VirtualGrid_ColumnWidthChanged;
    this.virtualGrid.RowHeightChanged += this.VirtualGrid_RowHeightChanged;
}

private void VirtualGrid_ColumnWidthChanged(object sender, VirtualGridColumnWidthChangedEventArgs e)
{
    this.columnWidths[e.ColumnIndex] = e.NewWidth;
}

private void VirtualGrid_RowHeightChanged(object sender, VirtualGridRowHeightChangedEventArgs e)
{
    this.rowHeights[e.RowIndex] = e.NewHeight;
}
```

## See Also

* [Column and Row Resizing]({%slug virtualgrid-column-and-row-resizing%})
* [Headers]({%slug virtualgrid-headers%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
