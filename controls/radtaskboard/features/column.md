---
title: Column
page_title: Column
description: Check our &quot;Column&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-features-column
tags: Column
published: True
position: 1
---

# Column

The __TaskBoardCardModels__ are added to the respective Column depending on the __GroupMemberPath__ property of the __RadTaskBoard__ control. 

> The __GroupMemberPath__ property of the __RadTaskBoard__ is required in order for the columns to be created.

The control provides two mechanisms for defining its columns:
* [Automatic columns definition](#automatic-columns-generation) based on the underlying data source. 
* [Manual columns definition](#manual-columns-definition) in XAML or code-behind. 
* [Cancel Auto Generation of a Specific Column](#cancel-auto-generation-of-a-specific-column)

## Key Features and Properties

* __GroupName__: A property of type __object__ that gets or sets the group name used to categorize the items in columns.
* __Header__: A property of type __object__ that gets or sets the content inside the header of the columns.
* __HeaderTemplate__: A property of type __DataTemplate__ that gets or sets the content template inside the header of the columns. This property can be used to further customize the column header.
* __IsExpanded__: A __Boolean__ property that gets or sets if a given column is expanded or not.
* __Width__: A property of type __double__ that gets or sets the column width.
* __CollapsedWidth__: A property of type __double__ that gets or sets the width of a collapsed column.
* __Items__: A collection property that holds the items inside the column.

## Automatic Columns Generation

By default, __RadTaskBoard__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of __RadTaskBoard__ to a collection of TaskBoardCardModel (see code in __Example 1__ and the result in __Figure 1__), the control will create a separate column for each value of the property set to the __GroupMemberPath__ of the RadTaskBoard.

__Example 1: Defining the data__
```C#
	
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
```

#### __[XAML] Example 2: Defining RadTaskBoard in XAML
```XAML
    <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" />
```

#### Figure 1: RadTaskBoard with automatically generated columns
![Telerik TaskBoard Column 0](images/taskboard_column_0.png)

## Cancel Auto Generation of a Specific Column

To prevent the automatic generation of a specific column you can handle the __AutoGeneratingColumn__ event of the RadTaskBoard. Inside the event handler you can get the current generated column and you can cancel its generation by setting the __Cancel__ property to true.

__Example 3: Cancel Auto Generation of a Specific Column__
		```C#
			private void TaskBoard_AutoGeneratingColumn(object sender, TaskBoardAutoGeneratingColumnEventArgs e)
			{
				if(e.Column.GroupName.ToString() == "Done")
				{
					e.Cancel = true;
				}
			}
		```


## Manual Columns Definition

When the built-in order of the auto generation of columns does not fit in your case you can declare them manually. You can first disable the autogenerating of the columns by setting the __AutoGenerateColumns__ property of the RadTaskBoard to False. Then you can populate the __Columns__ collection property of the control.

> If the __Header__ property of the TaskBoardColumn is not set, the GroupName property will be used as a Header.

__Example 4: Define RadTaskBoard with custom columns__
	```XAML
		<telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" AutoGenerateColumns="False">
			<telerik:RadTaskBoard.Columns>
				<telerik:TaskBoardColumn GroupName="Not Done"/>
				<telerik:TaskBoardColumn GroupName="In Progress"/>
				<telerik:TaskBoardColumn GroupName="Done"/>
			</telerik:RadTaskBoard.Columns>
		</telerik:RadTaskBoard>
	```

__Example 5: Define TaskBoardColumns in code__
	```C#
		public MainWindow()
		{
			InitializeComponent();
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "Not Done" });
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "In Progress" });
			this.taskBoard.Columns.Add(new TaskBoardColumn() { GroupName = "Done" });
			this.taskBoard.ItemsSource = this.GetTasks();            
		}
	```

#### Figure 2: RadTaskBoard with manually generated columns
![Telerik TaskBoard Column 1](images/taskboard_column_1.png)
	
## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})
