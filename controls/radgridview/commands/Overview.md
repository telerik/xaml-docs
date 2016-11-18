---
title: Overview
page_title: Overview
description: Overview
slug: gridview-commands-overview
tags: overview
published: True
position: 0
---

# Overview

RadGridView provides a set of built-in commands that enables you to easily handle the user interface actions, but still make your logic independent of the UI layout. Thus, you are not obliged to subscribe to a particular event in order to achieve the desired behavior. 

All supported commands are defined in the **RadGridViewCommands** class and are listed below:

* __ActivateRow__: Activates a particular row programmatically and fires RadGridView's __RowActivated__ event as if the user has double-clicked it.

* __BeginEdit__: Invokes editing of the current cell.

* __BeginInsert__: Starts the process of inserting a new row.

* __CancelCellEdit__: Causes the editing of the current cell to be stopped and the changes to be discarded. However, this command will not overcome failed validation.

* __CancelRowEdit__: Causes the editing of the whole row to be discontinued. Again, this command will not overcome failed validation.

* __CloseSearchPanel__: Executed in order to hide the search panel.

* __CollapseHierarchyItem, ExpandHierarchyItem__: Expands/ collapses a particular item in the hierarchy.

* __CommitCellEdit__: Forces all the changes to the cell to be committed.

* __CommitEdit__: Forces all the changes to be committed.

* __Copy, Paste__: Enable you to take advantage of the clipboard functionality.

* __Delete__: Removes the selected item from the collection.

* __ExtendSelectionToCurrentUnit__: Selects all the selection unit from the anchor upto the chosen unit.

* __MoveUp, MoveDown__: Moves the focus to the cell situated in the item above/below the selected one.

* __MoveFirst, MoveLast__: Moves the focus to the first/last cell situated in the current item.

* __MoveLeft, MoveRight__: Moves the focus to the cell situated in the left/right side of the selected one.

* __MoveUp, MoveDown__: Moves the focus to the cell situated above/below the selected one.

* __MoveNext, MovePrevious__: Moves the focus to the next/ previous cell. Once the first/last cell on the row is reached, it will jump to the cell in the previous/ next row.

* __MoveHome, MoveEnd__: Moves the focus to the first cell of the first item or last cell of last item, respectively.

* __MovePageUp, MovePageDown__: Moves the focus to the cell situated one viewport away from the current cell.

* __MoveTop, MoveBottom__: Moves the focus to the cell situated in the first/last item.

* __Search__: Executed in order to show the search panel.
		  
* __SearchByText__: Adds search criteria programmatically.

* __SelectCurrentItem__: Selects the current item.

* __SelectCurrentUnit__: Selects the current unit. By default the selection unit is __"FullRow"__, but the __SelectionUnit__ property may also be set to __"Cell"__, thus enabling a cell-based selection.

* __TogglePinnedRowState__: Add/Remove the current row from the collection of pinned rows.

As the commands provided by __RadGridView__ are __ICommands__ at their core, they do provide methods for  both checking if they can be invoked - __CanExecute()__ and for invoking them - __Execute()__.

Using the __RadGridViewCommands__ class, you can set a sequence of commands to be performed one after another.  So, for example, you may easily handle the **Click** event of a button, move the focus down, select the current unit and then delete it. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target UI Element as shown in **Exapmle 1**.

#### __[C#] Example 1: Executing different commands__

{{region cs-GridView-Commands-Overview_0}}
	private void Button1_Click(object sender, RoutedEventArgs e)
    {
        var moveDownCommand = RadGridViewCommands.MoveDown as RoutedUICommand;
        var selectCommand = RadGridViewCommands.SelectCurrentUnit as RoutedUICommand;
        var deleteCommand = RadGridViewCommands.Delete as RoutedUICommand;
        moveDownCommand.Execute(null, this.clubsGrid);
        selectCommand.Execute(null, this.clubsGrid);
        deleteCommand.Execute(null, this.clubsGrid);
    }
{{endregion}}

#### __[VB.NET] Example 1: Executing different commands__

{{region vb-GridView-Commands-Overview_0}}
	Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
        Dim moveDownCommand = TryCast(RadGridViewCommands.MoveDown, RoutedUICommand)
        Dim selectCommand = TryCast(RadGridViewCommands.SelectCurrentUnit, RoutedUICommand)
        Dim deleteCommand = TryCast(RadGridViewCommands.Delete, RoutedUICommand)
        moveDownCommand.Execute(Nothing, Me.clubsGrid)
        selectCommand.Execute(Nothing, Me.clubsGrid)
        deleteCommand.Execute(Nothing, Me.clubsGrid)
    End Sub
{{endregion}}

In order to ensure that all commands will be executed in the correct sequence, it is advised to use RadGridView's **PendingCommands** collection as demonstrated in **Example 2**.

#### __[C#] Example 2: Executing different commands with the ExecutePendingCommand method__

{{region cs-GridView-Commands-Overview_1}}
	private void Button2_Click(object sender, RoutedEventArgs e)
	{
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.MoveDown);
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.SelectCurrentUnit);
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.Delete);
	    this.clubsGrid.ExecutePendingCommand();
	}
{{endregion}}

#### __[VB.NET] Example 2: Executing different commands with the ExecutePendingCommand method__

{{region vb-GridView-Commands-Overview_1}}
	Private Sub Button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.MoveDown)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.SelectCurrentUnit)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.Delete)
	    Me.clubsGrid.ExecutePendingCommand()
	End Sub
{{endregion}}