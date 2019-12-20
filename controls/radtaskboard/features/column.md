---
title: Column
page_title: Column
description: Column
slug: radtaskboard-features-column
tags: Column
published: True
position: 0
---

# Column

The RadTaskBoardItems are added to the respective Column depending on the __GroupMemberPath__ property of the __RadTaskBoard__ control.

> The __GroupMemberPath__ property of the __RadTaskBoard__ is required in order the cards to be grouped.

#### __[XAML] Example 1: Define TaskBoardColumn in XAML__

{{region xaml-radtaskboard-features-column_0}}
	<telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding Data}" GroupMemberPath="State" AutoGenerateColumns="False" >
		<telerik:RadTaskBoard.Columns>
			<telerik:TaskBoardColumn GroupName="Not Done" Header="Not Done"/>
			<telerik:TaskBoardColumn GroupName="In Progress" Header="In Progress"/>
			<telerik:TaskBoardColumn GroupName="Done" Header="Done"/>
		</telerik:RadTaskBoard.Columns>
	</telerik:RadTaskBoard>
{{endregion}}

#### __[C#] Example 1: Define TaskBoardColumn in code__
{{region cs-radtaskboard-features-column_0}}
	TaskBoardColumn taskBoardcolumn = new TaskBoardColumn() {  };
	taskBoardcolumn.GroupName = "Not Done";
	taskBoardcolumn.Header = "Not Done";
	this.taskBoard.Columns.Add(taskBoardcolumn);
{{endregion}}


## Key Features and Properties

* __DisplayIndex__: A property of type __int?__ that gets or sets the display index of the column.
* __GroupName__: A property of type __string__ that gets or sets the group name used to categorized the items in columns.
* __Header__: A property of type __string__ that gets or sets the content inside the header of the columns.
* __HeaderTemplate__: A property of type __string__ that gets or sets the content template inside the header of the columns. This property can be used to further customized the column header.
* __IsExpanded__: A __Boolean__ property that gets or sets if given column is expanded or not.
* __Width__: A property of type __double__ that gets or set the column width.
* __CollapsedWidth__: A property of type __double__ that gets or set the width of a collapsed column.
* __Items__: A collection property that holds the items inside the column.
* __ItemsCount__: A property of type __int__ that gets the number of items inside a column.
