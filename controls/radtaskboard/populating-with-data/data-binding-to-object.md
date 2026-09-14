---
title: Binding to Object
page_title: Binding to Object
description: Check our &quot;Binding to Object&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
components: ["taskboard"]
slug: radtaskboard-populating-with-data-data-binding-to-object
tags: binding,to,object,dynamic,add,runtime,troubleshooting
published: True
position: 3
---

# Binding to Object

To bind the __RadTaskBoard__ to a collection with custom objects you can use its __ItemsSource__ property. 

The following tutorial will guide you how to bind a __RadTaskBoard__ to a collection of custom business objects.

First, we will specify the following classes, which are going to be used to populate the RadTaskBoard control.

__Example 1: Creating ViewModels__
```C#
    public class Task
    {
        public Employee Assignee { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public bool ShowIndicator { get; set; }    
        public string CategoryName { get; set; }
        public List<object> Tags { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string IconPath { get; set; }
        public string Name { get; set; }
    }
	public class MainViewModel 
    {
        private List<Employee> _employees;
        public ObservableCollection<Task> Tasks { get; set; }
        public MainViewModel()
        {
            Tasks = GetCustomTasks2();
        }
        public List<Employee> Employess
        {
            get {
                if(_employees == null)
                {
                    _employees = new List<Employee>
                    {
                        new Employee() { Id = 1, Name ="Bella", IconPath= @"/Project_NameSpace;component/Images/Bella.jpg"},
                        new Employee() { Id = 2, Name ="Smith", IconPath= @"/Project_NameSpace;component/Images/Smith.jpg" },
                        new Employee() { Id = 3, Name ="John",IconPath= @"/Project_NameSpace;component/Images/John.jpg" },
                    };
                }
                return _employees;
            }            
        }
        private ObservableCollection<Task> GetCustomTasks2()
        {
            ObservableCollection<Task> tasks = new ObservableCollection<Task>
            {
                new Task()
                {
                    Assignee = this.Employess[0],
                    Header = "RadDocking: Create Unit Test ",
                    Description = "Add Unit Tests",
                    State = "Done",
                    CategoryName = "Low",
                    ShowIndicator = true,
                    Tags = new List<object>(){ ".Net Core", "R3" }
                },

                new Task()
                {
                    Assignee = this.Employess[1],
                    Header = "RadPanelBar: IsExpanded property is not respected",
                    Description = "Fix Bug",
                    State = "Not Done",
                    CategoryName = "Medium",
                    ShowIndicator= true,
                    Tags = new List<object>(){ "Important", "R2" }
                },

                new Task()
                {
                    Assignee = this.Employess[2],
                    Header = "RadChartView: Implement Animation Feature",
                    Description = "Implement animations for all series in RadChartView",
                    State = "In Progress",
                    CategoryName = "High",
                    ShowIndicator = true,
                    Tags = new List<object>(){ "R1", DateTime.Now }
                }
            };
            return tasks;
        }
    }
```

Next, we can go ahead and define the RadTaskBoard in our view:

__Example 2: Defining RadTaskBoard in XAML__
```XAML
    <telerik:RadTaskBoard ItemsSource="{Binding Tasks}" GroupMemberPath="State" />
```

Since the control is bound a collection of custom objects, you need to declare the ItemTemplate property. You have two options here. 

* If you want to use the default look of the card, you can just bind your properties. You can place a __RadTaskBoardCard__ element in the DataTemplate and bind its properties to the properties from the business object.

>The CategoryCollection and CategoryModel class can be accessed in XAML through the following namespace:  
>`xmlns:taskBoard="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"`

__Example 3: Defining RadTaskBoardCard in ItemTemplate__
```XAML
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding Tasks}" GroupMemberPath="State">
		<telerik:RadTaskBoard.Categories>
			<taskBoard:CategoryCollection>
				<taskBoard:CategoryModel CategoryName="Low" CategoryBrush="Green"/>
				<taskBoard:CategoryModel CategoryName="Medium" CategoryBrush="Yellow"/>
				<taskBoard:CategoryModel CategoryName="High" CategoryBrush="Red"/>
			</taskBoard:CategoryCollection>
		</telerik:RadTaskBoard.Categories>
		<telerik:RadTaskBoard.ItemTemplate>
			<DataTemplate>
				<telerik:RadTaskBoardCard Assignee="{Binding Assignee.Name}" 
										Tags="{Binding Tags}" 
										Content="{Binding Description}"
										Header="{Binding Header}"  
										Icon="{Binding Assignee.IconPath}"
										CategoryName="{Binding CategoryName}"
										ShowCategoryIndicator="{Binding ShowIndicator}"/>
			</DataTemplate>
		</telerik:RadTaskBoard.ItemTemplate>
	</telerik:RadTaskBoard>
```

* If you want to have your own look. You can place your structure in the DataTemplate applied to the ItemTemplate property of the __RadTaskBoard__.

__Example 3: Defining RadTaskBoard in XAML__
```XAML
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding CustomData}" GroupMemberPath="State"  >
		<telerik:RadTaskBoard.ItemTemplate>
			<DataTemplate>
				<StackPanel>
					<TextBlock Text={Binding State}/>
					<TextBlock Text={Binding Assignee}/>
					<TextBlock Text={Binding Header}/>
					<TextBlock Text={Binding Description}/>
				</StackPanel>
			</DataTemplate>
		</telerik:RadTaskBoard.ItemTemplate>
	</telerik:RadTaskBoard>
```

## Troubleshooting Dynamically Added Tasks

If you add new items to your bound `ObservableCollection` at runtime (for example, on a button click) and they do not appear on the board:

* **Verify the Grouping Property:** RadTaskBoard distributes items into columns using the property specified by `GroupMemberPath` (such as `State`). Ensure that the new item has this property populated with a valid value before or upon calling `Add()`.
* **Column Matching:** If `AutoGenerateColumns` is set to `False`, the item's grouping value must match the `GroupName` of one of the declared `TaskBoardColumn`s. If no column matches, the task cannot be assigned to any column and will not be displayed.
* **Null or Empty Group Values:** Items whose grouping property evaluates to `null` or an empty string will not generate a column and will not be rendered.

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})