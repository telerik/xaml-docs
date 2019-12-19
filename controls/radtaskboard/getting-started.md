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
> * Binding to a collection of __TaskBoardItemModel__.
> * Binding to a collection of __custom objects__.
> * Binding to a __CollectionView__ collection with predifined groups. 
> For the purpose of this tutorial we are going to use the first one. The other approaches and more complex one can be found in the __Populating With Data__ section.

First, we can go ahead and create our ViewModel with some tasks. The control API provides out of the __TaskBoardItemModel__ class which expose most needed properties to start organized your tasks.

#### __[C#] Example 1: Defining ViewModel
{{region xaml-radtaskboard-getting-started-1}}
    public  class MainViewModel 
    {
        public ObservableCollection<TaskBoardItemModel> Data { get; set; }
        public MainViewModel()
        {
            Data = GetTasks();
        }
        public  ObservableCollection<TaskBoardItemModel> GetTasks()
        {
            ObservableCollection<TaskBoardItemModel> tasks = new ObservableCollection<TaskBoardItemModel>();

            TaskBoardItemModel task;
            task = new TaskBoardItemModel() { Assignee = "Nancy Davolio", Description = "This is a nice description", Id = "3", State = "In Progress", Title = "This is a Title" };
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Andrew Fuller", Description = "This is a nice description", Id = "1", State = "Not Done", Title = "This is a Title" };
            task.Tags.Add("Tag1");
            task.Tags.Add("Tag2");
            task.Tags.Add("Tag3");
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Janet Leverling", Description = "This is a nice description", Id = "2", State = "Not Done", Title = "This is a Title" };
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Margaret Peacock", Description = "This is a nice description", Id = "3", State = "Not Done", Title = "This is a Title" };
            tasks.Add(task);

            task = new TaskBoardItemModel() { Assignee = "Steven Buchanan", Description = "This is a nice description", Id = "2", State = "Done", Title = "This is a Title" };
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Michael Suyama", Description = "This is a nice description", Id = "2", State = "Done", Title = "This is a Title" };
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Robert King", Description = "This is a nice description", Id = "2", State = "Done", Title = "This is a Title" };
            tasks.Add(task);


            task = new TaskBoardItemModel() { Assignee = "Laura Callahan", Description = "This is a nice description", Id = "3", State = "In Progress", Title = "This is a Title" };
            tasks.Add(task);
            task = new TaskBoardItemModel() { Assignee = "Anne Dodsworth", Description = "This is a nice description", Id = "3", State = "In Progress", Title = "This is a Title" };
            tasks.Add(task);

            return tasks;
        }
    }	
{{endregion}}

Next we need to define RadTaskBoard in XAML and bind the ItemsSource property of the RadTaskBoard and set the __GroupMemberPath__ property. The __GroupMemberPath__ property represent which property from your model will be used to group the tasks.

#### __[XAML] Example 2: Binding RadTaskBoard
{{region xaml-radtaskboard-getting-started-0}}
    <telerik:RadTaskBoard ItemsSource="{Binding Data}" 
                        GroupMemberPath="State" />
{{endregion}}

And finally, we need to set the DataContext of the MainWindow:

#### __[C#] Example 3: Setting DataContext
{{region xaml-radtaskboard-getting-started-0}}
    public MainWindow() 
    { 
        InitializeComponent(); 
        this.DataContext = new MainViewModel(); 
    }
{{endregion}}

If you run the application now, you should get a structure like in Figure 1:
#### Figure 1: RadGridView and RadTreeView
![Telerik {{ site.framework_name }} TaskBoard getting-started 0](images/ .PNG)


