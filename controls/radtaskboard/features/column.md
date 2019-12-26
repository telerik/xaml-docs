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

> The __GroupMemberPath__ property of the __RadTaskBoard__ is required in order for the columns to be created.

The control provides two mechanisms for defining its columns:
* [Automatic columns definition](#automatic-columns-generation) based on the underlying data source. 
* [Manual columns definition](#manual-columns-definition) in XAML or code-behind. 

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

## Automatic Columns Generation

By default, __RadTaskBoard__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of __RadTaskBoard__ to a collection of employees (see code in __Example 1__ and the result in __Figure 1__), the control will create a separate column for each value of the property set to the __GroupMemberPath__ of the RadTaskBoard.

#### __[C#] Example 1: Defining the data__
{{region cs-radtaskboard-features-column_0}}
	
	public MainWindow()
	{
		InitializeComponent();
		this.taskBoard.ItemsSource = this.GetTasks();
	}
	
	public ObservableCollection<TaskBoardCardModel> GetTasks()
	{
		ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>();
		TaskBoardCardModel task = new TaskBoardCardModel()
		{
			Assignee = "Bella",
			Title = "Unit Test: RadDocking",
			Description = "Add Unit Tests",
			State = "Not Done",              
		};
		
		tasks.Add(task);
		task = new TaskBoardCardModel()
		{
			Assignee = "Tomas",
			Title = "But RadPanelBar",
			Description = "Fix Bug",
			State = "In Progress",
		};

		tasks.Add(task);
		task = new TaskBoardCardModel()
		{
			Assignee = "Peter",
			Title = "RadChartView: Implement Animation Feature",
			Description = "Implement animations for all series in RadChartView",
			State = "Done",
		};
		tasks.Add(task);
		return tasks;
	}
{{endregion}}

#### __[XAML] Example 2: Defining RadTaskBoard in XAML
{{region xaml-radtaskboard-features-column-1}}
    <telerik:RadTaskBoard ItemsSource="{Binding CustomData}" 
                        GroupMemberPath="State" />
{{endregion}}

## Figure 1: RadTaskBoard with automatically generate columns.
// image here

## Manual Columns Definition

In a case the built-in auto generation of columns does not fit all scenarios, you can manually define the needed columns. You must add the columns to the __Columns__ collection of __RadTaskBoard__.

To declare custom columns you can set the __AutoGenerateColumns__ property of the RadTaskBoard to False. Then you can populate the Columns collection property of the control.

#### __[XAML] Example 3: Define TaskBoardColumn with custom columns__

{{region xaml-radtaskboard-features-column_2}}
	<telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding Data}" GroupMemberPath="State" AutoGenerateColumns="False" >
		<telerik:RadTaskBoard.Columns>
			<telerik:TaskBoardColumn GroupName="Not Done" Header="Not Started"/>
			<telerik:TaskBoardColumn GroupName="In Progress" Header="Working On"/>
			<telerik:TaskBoardColumn GroupName="Done" Header="Ready to go"/>
		</telerik:RadTaskBoard.Columns>
	</telerik:RadTaskBoard>
{{endregion}}

#### __[C#] Example 4: Define TaskBoardColumn in code__
{{region cs-radtaskboard-features-column_3}}
	TaskBoardColumn taskBoardcolumn = new TaskBoardColumn() {  };
	taskBoardcolumn.GroupName = "Not Done";
	taskBoardcolumn.Header = "Not Done";
	this.taskBoard.Columns.Add(taskBoardcolumn);
{{endregion}}

## Figure 2: RadTaskBoard with manually generated columns.
// image here


## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})

