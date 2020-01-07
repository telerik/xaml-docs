---
title: Indicator Color
page_title: Indicator Color
description: Indicator Color
slug: radtaskboard-features-indicator-color
tags: indicator color
published: True
position: 0
---

# Indicator Color

There are different ways to organize your RadTaskBoard cards. The control provides indicator-color functionality, which allows you to apply different colors to its tasks. Using colors is a quick way to make tasks stand out on the board. 

The purpose of this tutorial is to show you how to set different colors to your RadTaskBoard tasks.

First, we can go ahead and create some sample data and applied directly to the ItemSource of the RadTaskBoard. The RadTaskBoard control will be populated with a collection of __TaskBoardCardModel__. The color functionality uses the __CategoryName__ property of the TaskBoardCardModel to match the item with the color.

#### __[C#] Example 1: Defining ViewModel
{{region cs-radtaskboard-features-indicator-color-0}}
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
{{endregion}}

The next step is to declare our colors. The __Categories__ collection property of the RadTaskBoard needs to be set. We can create __CategoryCollection__ with __CategoryModel__ objects inside. The CategoryModel expose __CategoryName__ and __CategoryBrush__ properties. The value of the __CategoryName__ will be used to match the value of the __CategoryName__ of the TaskBoardCardModel. And the color set to the CategoryBrush will be applied to the task.

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

#### __[XAML] Example 2: Specifying custom colors
{{region xaml-radtaskboard-features-indicator-color-1}}
   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" >
		<telerik:RadTaskBoard.Categories>
			<taskBoard:CategoryCollection>
				<taskBoard:CategoryModel CategoryName="Low" CategoryBrush="Green"/>
				<taskBoard:CategoryModel CategoryName="Medium" CategoryBrush="Yellow"/>
				<taskBoard:CategoryModel CategoryName="High" CategoryBrush="Red"/>
			</taskBoard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>
	</telerik:RadTaskBoard>
{{endregion}}

If you run the application now, you should get a structure like in Figure 1:
#### Figure 1: Tasks with different Indicator Color
![Telerik TaskBoard Indicator Color 0](images/taskboard_indicator_color_0.png)

## Hide indicator color

In a case, you want a given task to not to have a color, you can set the __ShowCategoryIndicator__ property of the TaskBoardCardModel to false. We are going to set this property to false to the second TaskBoardCardModel element from __Example 1__. __Figure 2__ demonstrates this change.

#### Figure 2: A task with no color
![Telerik TaskBoard Indicator Color 1](images/taskboard_indicator_color_1.png)

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})