---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-commands-overview
tags: commands, overview
published: True
position: 0
---

# Overview

__RadVirtualGrid__ provides a set of built-in commands that enables you to easily handle the user interface actions, but still make your logic independent of the UI layout. Thus, you are not obliged to subscribe to a particular event in order to achieve the desired behavior.

All supported commands are defined in the __RadVirtualGridCommands__ class and are listed below:

*   __CommitEdit__: Forces all the changes to be committed.
	
*	__BeginEdit__: Invokes editing of the current cell.
	
*	__BeginInsert__: Starts the process of inserting a new row.

*	__CancelEdit__: Causes the editing of the current cell to be stopped and the changes to be discarded.          

*	__SelectAll__: Selects all elements.

*	__Copy__: Copies the selected data to the Clipboard.
	
*	__Delete__: Deletes the elements present in the __SelectedIndexes__ collection.
	
*	__MoveLeft, MoveRight__: Moves the focus to the cell situated in the left/right side of the selected one.

*	__MoveUp, MoveDown__: Moves the focus to the cell situated above/below the selected one.

*	__MoveNext, MovePrevious__: Moves the focus to the next/ previous cell. Once the first/last cell on the row is reached, it will jump to the cell in the previous/ next row.

*	__MoveFirst, MoveLast__: Moves the focus to the first/last cell situated in the current item.

*	__MoveHome, MoveEnd__: Moves the focus to the first cell of the first item or last cell of last item, respectively.

*	__MovePageUp, MovePageDown__: Moves the focus to the cell situated one viewport away from the current cell.

*	__MoveTop, MoveBottom__: Moves the focus to the cell situated in the first/last item.

*   __PinRowTop, PinRowBottom__: Pins a row at the top/bottom.

*   __PinColumnLeft, PinColumnRight__: Pins a column to the left/right.

*   __UnpinRow, UnpinColumn__: Unpins a row/column.

*	__SelectCurrentUnit__: Selects the current unit. By default the selection unit is "Row", but the SelectionUnit property may also be set to "Cell", thus enabling a cell-based selection.

*   __ExtendSelectionToCurrentUnit__: Selects all the selection unit from the anchor up to the chosen unit.

As the commands provided by __RadVirtualGrid__ are ICommands at their core, they do provide methods for both checking if they can be invoked - __CanExecute()__ and for invoking them - __Execute()__.

__Example 1: Executing different commands__
```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    var moveDownCommand = RadVirtualGridCommands.MoveDown as RoutedUICommand;
	    var selectCommand = RadVirtualGridCommands.SelectCurrentUnit as RoutedUICommand;
	    var deleteCommand = RadVirtualGridCommands.Delete as RoutedUICommand;
	    moveDownCommand.Execute(null, this.VirtualGrid);
	    selectCommand.Execute(null, this.VirtualGrid);
	    deleteCommand.Execute(null, this.VirtualGrid);
	}
```

In order to ensure that all commands will be executed in the correct sequence, it is advised to use __RadVirtualGrid's PendingCommands__ collection as demonstrated in __Example 2__.

__Example 2: Executing different commands with the ExecutePendingCommand method__
```C#
	 private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.VirtualGrid.PendingCommands.Add(RadVirtualGridCommands.MoveDown);
            this.VirtualGrid.PendingCommands.Add(RadVirtualGridCommands.SelectCurrentUnit);
            this.VirtualGrid.PendingCommands.Add(RadVirtualGridCommands.Delete);
            this.VirtualGrid.ExecutePendingCommand();
        }
```

## See Also

* [Implementation]({%slug virtualgrid-commands-implementation%})

* [Keyboard Command Provider]({%slug virtualgrid-commands-keyboard-command-provider%})

