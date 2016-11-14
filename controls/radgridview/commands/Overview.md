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

* __ActivateRow__: Activates a particular row programmatically and fires the __RowActivated__ event of the __RadGridView__.

* __BeginEdit__: Invokes editing of the selected item.

* __BeginInsert__: Starts the process of inserting a new row in the __RadGridView__.

* __CancelCellEdit__: Causes the editing of the current cell to be stopped and the changes to be discarded. However, this command will not overcome failed validation.

* __CancelRowEdit__: Causes the editing of the whole row to be discontinued. Again, this command will not overcome failed validation.

* __CloseSearchPanel__: Executed in order to hide the search panel.

* __CollapseHierarchyItem, ExpandHierarchyItem__: Expands/ collapses a particular item in the hierarchy.

* __CommitCellEdit__: Forces all the changes to the cell to be committed.

* __CommitEdit__: Forces all the changes to be committed.

* __Copy, Paste__: Enable you to take advantage of the clipboard functionality.

* __Delete__: Removes the selected item from the collection.

* __ExtendSelectionToCurrentUnit__: Selects all the selection unit from the anchor upto the chosen unit.

* __MoveBottom, MoveTop__: Moves the focus to the cell situated in the bottom/top item.

* __MoveUp, MoveDown__: Moves the focus to the cell situated in the item above/below the selected one.

* __MoveFirst, MoveLast__: Moves the focus to the cell situated in the first/last item.

* __MoveLeft, MoveRight__: Moves the focus to the cell situated in the left/right side of the selected one.

* __MoveUp, MoveDown__: Moves the focus to the cell situated above/ below the selected one.

* __MoveNext, MovePrevious__: Moves the focus to the next/ previous cell. Once the first/last cell on the row is reached, it will jump to the cell in the previous/ next row.

* __MoveHome__: Moves the focus to the cell situated in the first item.

* __Search__: Executed in order to show the search panel.
		  
* __SearchByText__: Adds search criteria programmatically.

* __SelectCurrentItem__: Selects the current item.

* __SelectCurrentUnit__: Selects the current unit. By default the selection unit is __"FullRow"__, but the __SelectionUnit__ property may also be set to __"Cell"__, thus enabling a cell-based selection.

As the commands provided by __RadGridView__ are __ICommands__ at their core, they do provide methods both for checking if they can be invoked - __CanExecute()__ and for invoking it - __Execute()__. 

Using the __RadGridViewCommands__ class, you can set a sequence of commands to be performed one after another.  So, for example, you may easily handle the **Click** event of a button and move the focus down, select the current unit and then delete it. In order to ensure that all commands will be executed in the correct sequence, it is advised to use RadGridView's **PendingCommands** collection as demonstrated in **Example 1**.

#### __[C#] Example 1: Executing different commands__

{{region cs-GridView-Commands-Overview_0}}
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.MoveDown);
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.SelectCurrentUnit);
	    this.clubsGrid.PendingCommands.Add(RadGridViewCommands.Delete);
	    this.clubsGrid.ExecutePendingCommand();
	}
{{endregion}}

#### __[VB.NET] Example 1: Executing different commands__

{{region vb-GridView-Commands-Overview_1}}
	Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.MoveDown)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.SelectCurrentUnit)
	    Me.clubsGrid.PendingCommands.Add(RadGridViewCommands.Delete)
	    Me.clubsGrid.ExecutePendingCommand()
	End Sub
{{endregion}}