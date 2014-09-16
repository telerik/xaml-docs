---
title: Overview
page_title: Overview
description: Overview
slug: gridview-commands-overview
tags: overview
publish: True
position: 0
---

# Overview



## 

RadGridView provides a set of built-in commands that enables you to easily handle the User Interface actions, but still make your logic independent of the UI layout. Thus, you are free of subscribing to a particular event for achieving the desired behavior. 

All supported commands are defined in the RadGridViewCommands class and are listed below:

* __ActivateRow__ - activates a particular row programmatically and fires the __RowActivated__ event of the __RadGridView__.
		  

* __BeginEdit__ - invokes editing of the selected item.
		  

* __BeginInsert__ - starts the process of inserting a new row in the __RadGridView__.
		  

* __CancelCellEdit__ - causes the editing of the current cell to be stopped and the changes to be discarded. However, this command will not overcome failed validation.
		  

* __CancelRowEdit__ - causes the editing of the whole row to be discontinued. Again, this command will not overcome failed validation.
			

* __CollapseHierarchyItem, ExpandHierarchyItem__ - expands/ collapses a particular item in the hierarchy.
		  

* __CommitCellEdit__ - forces all the changes to the cell to be committed.
		  

* __CommitEdit__ - forces all the changes to be committed.
		  

* __Copy, Paste__ - enable you to take advantage of the clipboard functionality.
		  

* __Delete__ - removes the selected item from the collection.
		  

* __MoveBottom, MoveTop__ - moves the focus to the cell situated in the bottom/top item.
		  

* __MoveUp, MoveDown__ - moves the focus to the cell situated in the item above/below the selected one.
		  

* __MoveFirst, MoveLast__ - moves the focus to the cell situated in the first/last item.
		  

* __MoveLeft, MoveRight__ - moves the focus to the cell situated in the left/right side of the selected one.
		  

* __MoveUp, MoveDown__ - moves the focus to the cell situated above/ below the selected one.
		  

* __MoveNext, MovePrevious__ - moves the focus to the next/ previous cell. Once the first/last cell on the row is reached, it will jump to the cell in the previous/ next row.
		  

* __MoveHome__ - moves the focus to the cell situated in the first item.
		  

* __SelectCurrentItem__ - selects the current item.
		  

* __SelectCurrentUnit__ - selects the current unit. By default the selection unit is __"FullRow"__, but the __SelectionUnit__ property may also be set to __"Cell"__, thus enabling a cell-based selection.
		  

* __ExtendSelectionToCurrentUnit__ - selects all the selection unit from the anchor upto the chosen unit.

As the commands provided by __RadGridView__ are __ICommands__ at their core, they do provide methods both for checking if they can be invoked - __CanExecute()__ and for invoking it - __Execute()__. 
		

Using the __RadGridViewCommands__ class, you can set a consequence of commands to be performed one after another as if simultaneously.  So, for example, you may easily handle the Click event of a button that moves the focus down, selects the current unit and delete it. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target UI Element.
		

#### __C#__

{{region GridView-Commands-Overview_0}}
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



#### __VB.NET__

{{region GridView-Commands-Overview_1}}
	Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
	 Dim moveDownCommand = TryCast(RadGridViewCommands.MoveDown, RoutedUICommand)
	 Dim selectCommand = TryCast(RadGridViewCommands.SelectCurrentUnit, RoutedUICommand)
	 Dim deleteCommand = TryCast(RadGridViewCommands.Delete, RoutedUICommand)
	 moveDownCommand.Execute(Nothing, Me.clubsGrid)
	 selectCommand.Execute(Nothing, Me.clubsGrid)
	 deleteCommand.Execute(Nothing, Me.clubsGrid)
	End Sub
	{{endregion}}


