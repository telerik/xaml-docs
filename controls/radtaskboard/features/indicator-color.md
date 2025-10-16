---
title: Category Indicator
page_title: Category Indicator
description: Check our &quot;Category Indicator&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-features-category-indicator
tags: category, indicator, color
published: True
position: 0
---

# Category Indicator

There are different ways to organize your RadTaskBoard cards. The control provides category indicator color functionality, which allows you to apply different colors to its tasks. Using colors is a quick way to make tasks stand out on the board. 

The purpose of this tutorial is to show you how to set different colors to your RadTaskBoard tasks.

First, we can go ahead and create some sample data and apply it directly to the ItemSource of the RadTaskBoard. The RadTaskBoard control will be populated with a collection of __TaskBoardCardModel__. The category indicator functionality uses the __CategoryName__ property of the TaskBoardCardModel to match the item with the color.

__Example 1: Defining ViewModel__
```C#
    public MainWindow()
	{
		InitializeComponent();  
		taskBoard.ItemsSource = GetTasks();
	}

	public ObservableCollection<TaskBoardCardModel> GetTasks()
	{
		ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>
		{
			new TaskBoardCardModel()
			{
				Assignee = "Bella",
				Title = "RadDocking: Create Unit Test ",
				Description = "Add Unit Tests",
				State = "Done",
				CategoryName = "Low"
			},

			new TaskBoardCardModel()
			{
				Assignee = "Tomas",
				Title = "RadPanelBar: IsExpanded property is not respected",
				Description = "Fix Bug",
				State = "Not Done",
				CategoryName = "Medium"
			},

			new TaskBoardCardModel()
			{
				Assignee = "Smith",
				Title = "RadChartView: Implement Animation Feature",
				Description = "Implement animations for all series in RadChartView",
				State = "In Progress",
				CategoryName = "High",
			}
		};

		return tasks;
	}
```

The next step is to declare our colors. The __Categories__ collection property of the RadTaskBoard needs to be set. We can create a __CategoryCollection__ with __CategoryModel__ objects inside. The CategoryModel exposes __CategoryName__ and __CategoryBrush__ properties. The value of the __CategoryName__ will be used to match the value of the __CategoryName__ of the TaskBoardCardModel. And the color set to the CategoryBrush will be applied to the task.

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

__Example 2: Specifying custom colors__

```XAML
   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State">
		<telerik:RadTaskBoard.Categories>
			<taskBoard:CategoryCollection>
				<taskBoard:CategoryModel CategoryName="Low" CategoryBrush="Green"/>
				<taskBoard:CategoryModel CategoryName="Medium" CategoryBrush="Yellow"/>
				<taskBoard:CategoryModel CategoryName="High" CategoryBrush="Red"/>
			</taskBoard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>
	</telerik:RadTaskBoard>
```

If you run the application now, you should get a structure like in Figure 1:

#### Figure 1: Tasks with different categories Color
![Telerik TaskBoard Category Indicator 0](images/taskboard_indicator_color_0.png)

## Hide Categories Color

When you don't want a given task to have a color, you can set the __ShowCategoryIndicator__ property of the TaskBoardCardModel to false. We are going to set this property to false to the second TaskBoardCardModel element from __Example 1__. 

__Example 3: Hide Category Indicator on the second item__

```C#
    public MainWindow()
	{
		InitializeComponent();  
		taskBoard.ItemsSource = GetTasks();
	}

	public ObservableCollection<TaskBoardCardModel> GetTasks()
	{
		ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>
		{
			new TaskBoardCardModel()
			{
				Assignee = "Bella",
				Title = "RadDocking: Create Unit Test ",
				Description = "Add Unit Tests",
				State = "Done",
				CategoryName = "Low"
			},

			new TaskBoardCardModel()
			{
				Assignee = "Tomas",
				Title = "RadPanelBar: IsExpanded property is not respected",
				Description = "Fix Bug",
				State = "Not Done",
				CategoryName = "Medium",
				ShowCategoryIndicator = false
			},

			new TaskBoardCardModel()
			{
				Assignee = "Smith",
				Title = "RadChartView: Implement Animation Feature",
				Description = "Implement animations for all series in RadChartView",
				State = "In Progress",
				CategoryName = "High",
			}
		};

		return tasks;
	}
```

__Figure 2__ demonstrates this change.

#### Figure 2: A task with no color
![Telerik TaskBoard categories Color 1](images/taskboard_indicator_color_1.png)

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})