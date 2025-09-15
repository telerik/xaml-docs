---
title: Insert New Row on Tab of Last Cell
page_title: Insert New Row on Tab of Last Cell
description: Check out our example of how to insert a new row when you are at the last column of the last row in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-add-new-row-on-tab-last-cell
tags: insert,new,row,tab,last,cell,column,row
published: True
position: 14
---

# Insert New Row on Tab of Last Cell

This article will show you how to insert a new row when you are at the **last column** of the **last row** and press the **Tab** key.

In order to achieve the desired behavior, you should create a [custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%}) and override its **ProvideCommandsForKey** method.

**Example 1** shows how this can be done:

__Example 1: Handling the Tab key__

	```C#
	public override IEnumerable<ICommand> ProvideCommandsForKey(Key key)
	{
	    List<ICommand> commandsToExecute = base.ProvideCommandsForKey(key).ToList();
	
	    // check if the tab key was hit
	    if (key == Key.Tab)
	    {
	        // get the last column index
	        var lastcolumnIndex = parentGrid.Columns.Count - 1;
	        // check if the current column is the last one
	        var isLastColumn = parentGrid.CurrentCell.Column == parentGrid.Columns[lastcolumnIndex];
	
	        // get the last row index
	        var lastRowIndex = parentGrid.Items.Count - 1;
	        // check if the current row is the last one
	        var isLastRow = parentGrid.Items.IndexOf(parentGrid.SelectedItem) == lastRowIndex;
	
	        // check if we're at the last cell
	        if (isLastColumn && isLastRow)
	        {
	            // remove all commands to execute
	            commandsToExecute.Clear();
	
	            // commit any changes if we're on the last column of the newest row
	            if (parentGrid.Items.IsAddingNew)
	            {
	                commandsToExecute.Add(RadGridViewCommands.CommitEdit);
	            }
	
	            // insert the new row and set it's focus to the first cell
	            commandsToExecute.Add(RadGridViewCommands.BeginInsert);
	            parentGrid.CurrentColumn = parentGrid.Columns[0];
	        }
	    }
	
	    return commandsToExecute;
	}
```
```VB.NET
	Public Overrides Function ProvideCommandsForKey(key__1 As Key) As IEnumerable(Of ICommand)
	    Dim commandsToExecute As List(Of ICommand) = MyBase.ProvideCommandsForKey(key__1).ToList()
	
	    ' check if the tab key was hit '
	    If key__1 = Key.Tab Then
	        ' get the last column index '
	        Dim lastcolumnIndex = parentGrid.Columns.Count - 1
	        ' check if the current column is the last one '
	        Dim isLastColumn = parentGrid.CurrentCell.Column Is parentGrid.Columns(lastcolumnIndex)
	
	        ' get the last row index '
	        Dim lastRowIndex = parentGrid.Items.Count - 1
	        ' check if the current row is the last one '
	        Dim isLastRow = parentGrid.Items.IndexOf(parentGrid.SelectedItem) = lastRowIndex
	
	        ' check if we're at the last cell '
	        If isLastColumn AndAlso isLastRow Then
	            ' remove all commands to execute '
	            commandsToExecute.Clear()
	
	            ' commit any changes if we're on the last column of the newest row '
	            If parentGrid.Items.IsAddingNew Then
	                commandsToExecute.Add(RadGridViewCommands.CommitEdit)
	            End If
	
	            ' insert the new row and set it's focus to the first cell '
	            commandsToExecute.Add(RadGridViewCommands.BeginInsert)
	            parentGrid.CurrentColumn = parentGrid.Columns(0)
	        End If
	    End If
	
	    Return commandsToExecute
	End Function
```

## See Also

* [Custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%})
