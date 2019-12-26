---
title: Binding to TaskBoardCardModel
page_title: Binding to TaskBoardCardModel
description: Binding to TaskBoardCardModel
slug: radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel
tags: binding,to,taskboardcardmodel
published: True
position: 2
---

# Binding to TaskBoardCardModel

The RadTaskBoardControl provides __TaskBoardCardModel__ ViewModel class designed to serves as a base ViewModel for __RadTaskBoardCard__ element. The class is defined to expose most required properties that allow you to track your task life cycle. More information about this class can be found in the [TaskBoardCardModel]({%slug radtaskboard-getting-started%}) help article.

The following tutorial will guide you how to bind a __RadTaskBoard____ to a collection of __TaskBoardCardModel__.

First, we will create our data, which are going to be used to populate the RadTaskBoard control.

#### __[C#] Example 1:  Creating ViewModel
{{region xaml-radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel-0}}
    public  class MainViewModel: ViewModelBase
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
                Title = "Unit Test: RadDocking",
                Description = "Add Unit Tests",
                State = "Not Done",
                CategoryName = "Red"
                
            };
            task.Tags.Add("Important");
            task.Tags.Add(2);
            task.Tags.Add(DateTime.Now);
            tasks.Add(task);
            task = new TaskBoardCardModel()
            {
                Assignee = "Tomas",
                Title = "Bug RadPanelBar",
                Description = "Fix Bug",
                State = "In Progress",
                CategoryName = "Green"
            };
			task.Tags.Add("Reported");
            tasks.Add(task);
            task = new TaskBoardCardModel()
            {
                Assignee = "Peter",
                Title = "RadChartView: Implement Animation Feature",
                Description = "Implement animmations for all series in RadChartView.",
                State = "Done",
                CategoryName = "Blue"
                // Tags = new System.Collections.Generic.List<string>() { "Complex" }
            };
			task.Tags.Add("Complex");
            tasks.Add(task);

            return tasks;
        }        
    }
{{endregion}}

Next, we can go ahead and define the RadTaskBoard in our view:

#### __[XAML] Example 2: Defining RadTaskBoard in XAML__
{{region xaml-radtaskboard-getting-started-1}}
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding Data}" GroupMemberPath="State"  >
		<telerik:RadTaskBoard.Categories>
			<taskboard:CategoryCollection>
				<taskboard:CategoryModel CategoryBrush="Red" CategoryName="Red" />
				<taskboard:CategoryModel CategoryBrush="Green" CategoryName="Green" />
				<taskboard:CategoryModel CategoryBrush="Blue" CategoryName="Blue" />
			</taskboard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>		
	</telerik:RadTaskBoard>
{{endregion}}

If you run the application now, you should get a structure like in Figure 1:

## Figure 1: RadTaskBoard bind to custom object 
// image here

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to Object]({%slug radtaskboard-populating-with-data-data-binding-to-object%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})