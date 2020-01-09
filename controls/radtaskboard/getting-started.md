---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtaskboard-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadTaskBoard__ control.

## Assembly References

In order to use __RadTaskBoard__, you will need to add references to the following assemblies:

* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadTaskBoard

> The control can be populated in three different ways. 
> * Binding to a collection of __TaskBoardCardModel__.
> * Binding to a collection of __custom objects__.
> * Binding to a __CollectionView__ collection with predifined groups. 
> For the purpose of this tutorial we are going to use the first one. The other approaches and more complex one can be found in the __Populating With Data__ section.

First, we can go ahead and create our ViewModel with some tasks. The control API provides a built-in __TaskBoardCardModel__ model class which exposes the most needed properties to start organizing your tasks.

#### __[C#] Example 1: Defining ViewModel
{{region csharp-radtaskboard-getting-started-1}}
    public class MainViewModel
	{
		public ObservableCollection<TaskBoardCardModel> Data { get; set; }
		public MainViewModel()
		{
			Data = GetTasks();
		}
		public ObservableCollection<TaskBoardCardModel> GetTasks()
		{
			ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>
			{
				new TaskBoardCardModel() { Assignee = "Nancy Davolio", Description = "Task Description", State = "In Progress", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Andrew Fuller", Description = "Task Description", State = "Not Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Janet Leverling", Description = "Task Description", State = "Not Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Margaret Peacock", Description = "Task Description", State = "Not Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Steven Buchanan", Description = "Task Description", State = "Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Michael Suyama", Description = "Task Description", State = "Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Robert King", Description = "Task Description", State = "Done", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Laura Callahan", Description = "Task Description", State = "In Progress", Title = "Task Title" },

				new TaskBoardCardModel() { Assignee = "Anne Dodsworth", Description = "Task Description", State = "In Progress", Title = "Task Title" }
			};

			return tasks;
		}
	}
{{endregion}}

Next we need to define RadTaskBoard in XAML, bind the ItemsSource property of the RadTaskBoard and set the __GroupMemberPath__ property. The __GroupMemberPath__ property indicates which property from your model will be used to group the tasks.

#### __[XAML] Example 2: Binding RadTaskBoard
{{region xaml-radtaskboard-getting-started-0}}
    <telerik:RadTaskBoard ItemsSource="{Binding Data}" GroupMemberPath="State" />
{{endregion}}

And finally, we need to set the DataContext of the MainWindow:

#### __[C#] Example 3: Setting DataContext
{{region csharp-radtaskboard-getting-started-0}}
    public MainWindow() 
    { 
        InitializeComponent(); 
        this.DataContext = new MainViewModel(); 
    }
{{endregion}}

If you run the application now, you should get a structure like in Figure 1:
#### Figure 1: RadTaskBoard with sample data
![Telerik TaskBoard Getting-Started 0](images/getting_started_1.png)

## See Also
 * [Column]({%slug radtaskboard-features-column%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel%})
 * [Indicator Color]({%slug radtaskboard-features-indicator-color%})