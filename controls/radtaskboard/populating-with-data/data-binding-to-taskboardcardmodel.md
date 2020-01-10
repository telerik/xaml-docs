---
title: Binding to TaskBoardCardModel
page_title: Binding to TaskBoardCardModel
description: Binding to TaskBoardCardModel
slug: radtaskboard-populating-with-data-binding-taskboardcardmodel
tags: binding,to,taskboardcardmodel
published: True
position: 1
---

# Binding to TaskBoardCardModel

The RadTaskBoardControl provides a __TaskBoardCardModel__ ViewModel class designed to serve as a base ViewModel for a __RadTaskBoardCard__ element. This class is designed to expose the most required properties that allow you to track your task life cycle.

## Key Properties

* __Title__: A property of type __string__ that gets or sets the title of the task.
* __Assignee__: A property of type __object__ that gets or sets to whom this task is assigned.
* __Id__: A property of type __string__ that gets or sets the id of the task.
* __Description__: A property of type __string__ that gets or sets the description of the task.
* __State__: A property of type __string__ that gets or sets the current state of the task. The purpose of this property is to be set to the __GroupMemberPath__ of the RadTaskBoard.
* __CategoryName__: A property of type __string__ that gets or sets the category name of the task which will be used for the indicator-color feature of the RadTaskBoard.
* __ShowCategoryIndicator__: A __boolean__ property that gets or sets if the indicator-color of a given task is visible or not.
* __IconPath__: A property of type __string__ that gets or sets the icon path of the task.
* __Tags__: A collection property of __objects__ that gets the tags added to the task. To populate the collection, you can use its __Add()__ method.

The following tutorial will guide you how to bind a __RadTaskBoard__ to a collection of __TaskBoardCardModel__.

First, we will create our data, which is going to be used to populate the RadTaskBoard control.

#### __[C#] Example 1: Creating ViewModel
{{region cs-radtaskboard-populating-with-data-binding-taskboardcardmodel-0}}
    public class MainViewModel: ViewModelBase
    {
        public ObservableCollection<TaskBoardCardModel> Data { get; set; }
		
        public MainViewModel()
        {
            Data = GetTasks();
        }		
        
        public ObservableCollection<TaskBoardCardModel> GetTasks()
        {
            ObservableCollection<TaskBoardCardModel> tasks = new ObservableCollection<TaskBoardCardModel>();
            TaskBoardCardModel task = new TaskBoardCardModel()
            {
                Assignee = "Bella",
                Title = "RadDocking: Unit Test",
                Description = "Add Unit Tests",
                State = "Not Done",
                CategoryName = "Low",
				IconPath= @"/Project_NameSpace;component/Images/Bella.jpg"
                
            };
            task.Tags.Add("Important");
            task.Tags.Add(2);
            task.Tags.Add(DateTime.Now);
            tasks.Add(task);
			
            task = new TaskBoardCardModel()
            {
                Assignee = "Tomas",
                Title = "RadPanelBar: IsExpanded property is not respected",
                Description = "Fix Bug",
                State = "In Progress",
                CategoryName = "Medium",
				IconPath= @"/Project_NameSpace;component/Images/Tomas.jpg"
            };
			task.Tags.Add("R1");
            tasks.Add(task);
			
            task = new TaskBoardCardModel()
            {
                Assignee = "Peter",
                Title = "RadChartView: Implement Animation Feature",
                Description = "Implement animmations for all series in RadChartView.",
                State = "Done",
                CategoryName = "High"
				IconPath= @"/Project_NameSpace;component/Images/Peter.jpg"
            };
			task.Tags.Add("Complex");
            tasks.Add(task);		

            return tasks;
        }        
    }
{{endregion}}

Next, we can go ahead and define the RadTaskBoard in our view:

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

#### __[XAML] Example 2: Defining RadTaskBoard in XAML__
{{region xaml-radtaskboard-populating-with-data-binding-taskboardcardmodel-1}}
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding Data}" GroupMemberPath="State"  >
		<telerik:RadTaskBoard.Categories>
			<taskBoard:CategoryCollection>
				<taskBoard:CategoryModel CategoryName="Low" CategoryBrush="Green"/>
				<taskBoard:CategoryModel CategoryName="Medium" CategoryBrush="Yellow"/>
				<taskBoard:CategoryModel CategoryName="High" CategoryBrush="Red"/>
			</taskBoard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>		
	</telerik:RadTaskBoard>
{{endregion}}

And finally, we need to set the DataContext of the MainWindow:

#### __[C#] Example 3: Setting DataContext
{{region cs-radtaskboard-populating-with-data-binding-taskboardcardmodel-0}}
    public MainWindow() 
    { 
        InitializeComponent(); 
        this.DataContext = new MainViewModel(); 
    }
{{endregion}}

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to Object]({%slug radtaskboard-populating-with-data-data-binding-to-object%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})