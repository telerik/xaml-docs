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

The __TaskBoardCardModel__ are added to the respective Column depending on the __GroupMemberPath__ property of the __RadTaskBoard__ control. 

> The __GroupMemberPath__ property of the __RadTaskBoard__ is required in order for the columns to be created.

The control provides two mechanisms for defining its columns:
* [Automatic columns definition](#automatic-columns-generation) based on the underlying data source. 
* [Manual columns definition](#manual-columns-definition) in XAML or code-behind. 

## Key Features and Properties

* __DisplayIndex__: A property of type nullable __int?__ that gets or sets the display index of the column.
* __GroupName__: A property of type __string__ that gets or sets the group name used to categorize the items in columns.
* __Header__: A property of type __string__ that gets or sets the content inside the header of the columns.
* __HeaderTemplate__: A property of type __DataTemplate__ that gets or sets the content template inside the header of the columns. This property can be used to further customize the column header.
* __IsExpanded__: A __Boolean__ property that gets or sets if a given column is expanded or not.
* __Width__: A property of type __double__ that gets or sets the column width.
* __CollapsedWidth__: A property of type __double__ that gets or sets the width of a collapsed column.
* __Items__: A collection property that holds the items inside the column.

## Automatic Columns Generation

By default, __RadTaskBoard__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of __RadTaskBoard__ to a collection of TaskBoardCardModel (see code in __Example 1__ and the result in __Figure 1__), the control will create a separate column for each value of the property set to the __GroupMemberPath__ of the RadTaskBoard.

#### __[C#] Example 1: Defining the data__
{{region csharp-radtaskboard-features-column_0}}
	
	public MainWindow()
	{
		InitializeComponent();
		this.taskBoard.ItemsSource = this.GetTasks();
	}
	
	public ObservableCollection<TaskBoardCardModel> GetTasks()
	{
		ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>();
		
		tasks.Add(new TaskBoardCardModel()
		{
			Assignee = "Bella",
			Title = "RadDocking: Create Unit Test ",
			Description = "Add Unit Tests",
			State = "Not Done",              
		});
		
		tasks.Add(new TaskBoardCardModel()
		{
			Assignee = "Tomas",
			Title = "RadPanelBar: Not IsExpanded property is not respected",
			Description = "Fix Bug",
			State = "In Progress",
		});

		tasks.Add(new TaskBoardCardModel()
		{
			Assignee = "Smith",
			Title = "RadChartView: Implement Animation Feature",
			Description = "Implement animations for all series in RadChartView",
			State = "Done",
		});
		
		return tasks;
	}
{{endregion}}

#### __[XAML] Example 2: Defining RadTaskBoard in XAML
{{region xaml-radtaskboard-features-column-1}}
    <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" />
{{endregion}}

#### Figure 1: RadTaskBoard with automatically generated columns
![Telerik TaskBoard Column 0](images/taskboard_column_0.png)

## Manual Columns Definition

When the built-in order of the auto generation of columns does not fit in your case, you have two options to change that.

#### You can manually define the needed columns in the correct order.

	To declare custom columns you can set the __AutoGenerateColumns__ property of the RadTaskBoard to False. Then you can populate the Columns collection property of the control.

	> If the __Header__ property of the TaskBoardColumn is not set, the GroupName property will be used as a Header.

	#### __[XAML] Example 3: Define RadTaskBoard with custom columns__
	{{region xaml-radtaskboard-features-column_2}}
		<telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" AutoGenerateColumns="False">
			<telerik:RadTaskBoard.Columns>
				<telerik:TaskBoardColumn GroupName="Not Done"/>
				<telerik:TaskBoardColumn GroupName="In Progress"/>
				<telerik:TaskBoardColumn GroupName="Done"/>
			</telerik:RadTaskBoard.Columns>
		</telerik:RadTaskBoard>
	{{endregion}}

	#### __[C#] Example 4: Define TaskBoardColumns in code__
	{{region cs-radtaskboard-features-column_3}}
		public MainWindow()
		{
			InitializeComponent();
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "Not Done" });
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "In Progress" });
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "Done" });
			this.taskBoard.ItemsSource = this.GetTasks();            
		}
	{{endregion}}

	#### Figure 2: RadTaskBoard with manually generated columns
	![Telerik TaskBoard Column 1](images/taskboard_column_1.png)
	
#### You can subscribe to the __AutoGeneratingColumn__ event. In the event handler, you can get the currently generated column and change its DisplayIndex property to arrange the columns per your needs.

	#### __[C#] Example 5: Set DisplayIndex of the columns__
	{{region cs-radtaskboard-features-column_4}}
		private void RadTaskBoard_AutoGeneratingColumn(object sender, TaskBoardAutoGeneratingColumnEventArgs e)
		{
			if(e.Column.GroupName == "Not Done")
			{
				e.Column.DisplayIndex = 0;
			}
			else if(e.Column.GroupName == "In Progress")
			{
				e.Column.DisplayIndex = 1;
			}
			else if (e.Column.GroupName == "Done")
			{
				e.Column.DisplayIndex = 2;
			}
		}
	{{endregion}}

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})