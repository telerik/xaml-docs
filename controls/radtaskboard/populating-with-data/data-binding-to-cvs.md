---
title: Binding to CollectionViewSource
page_title: Binding to CollectionViewSource
description: Check our &quot;Binding to CollectionViewSource&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-populating-with-data-data-binding-to-collectionviewsource
tags: binding,to,collectionviewsource
published: True
position: 2
---

# Binding to CollectionViewSource

__RadTaskBoard__ accepts __CollectionViewSource__ as data source and it will evaluate its __GroupDescriptions__ and generate corresponding columns based on that.

The following tutorial will guide you how to bind a __RadTaskBoard__ to a CollectionViewSource of __TaskBoardCardModel__.

First, we will initialize a CollectionViewSource, which is going to be used to populate the RadTaskBoard control. Next, we can create our data and set __PropertyGroupDescription__ to the State property. This property will be used to group the __CollectionViewSource__.

#### __[C#] Example 1:  Creating ViewModel
```C#
    public  class MainViewModel
    {
        public CollectionViewSource CollectionView { get; set; }
		
        public MainViewModel()
        {           
            CollectionView = new CollectionViewSource() { Source = GetTasks()};
            CollectionView.GroupDescriptions.Add(new PropertyGroupDescription("State"));
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
				IconPath= @"/Project_NameSpace;component/Images/Bella.jpg",
				ShowIndicatorColor= true,
                
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
				IconPath= @"/Project_NameSpace;component/Images/Tomas.jpg",
				ShowIndicatorColor= false,
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
				IconPath= @"/Project_NameSpace;component/Images/Peter.jpg",
				ShowIndicatorColor= true,
            };
			task.Tags.Add("Complex");
            tasks.Add(task);		

            return tasks;
        }        
    }
```

What's left is to set the DataContext of the Window and declare RadTaskBoard control in XAML.

> You don't need to set the GroupMemberPath property of the RadTaskBoard when the control's ItemsSource is bound to a CollectionViewSource collection. The first PropertyGroupDescription will be used by the RadTaskBoard to group the items.

__Example 3: Set the ViewModel as DataContext__
```XAML
    public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new MainViewModel();
	}
```

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

__Example 3: Defining RadTaskBoard in XAML__
```XAML
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding CollectionView.View}" >   
		<telerik:RadTaskBoard.Categories>
			<taskBoard:CategoryCollection>
				<taskBoard:CategoryModel CategoryName="Low" CategoryBrush="Green"/>
				<taskBoard:CategoryModel CategoryName="Medium" CategoryBrush="Yellow"/>
				<taskBoard:CategoryModel CategoryName="High" CategoryBrush="Red"/>
			</taskBoard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>
	</telerik:RadTaskBoard>
```

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to Object]({%slug radtaskboard-populating-with-data-data-binding-to-object%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})