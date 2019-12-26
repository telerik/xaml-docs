---
title: Binding to Object
page_title: Binding to Object
description: Binding to Object
slug: radtaskboard-populating-with-data-data-binding-to-object
tags: binding,to,object
published: True
position: 1
---

# Binding to Object

To bind the __RadTaskBoard__ to a collection with custom objects you can use its __ItemsSource__ property. 

The following tutorial will guide you how to bind a __RadTaskBoard____ to a collection of custom business objects.

First, we will specify the following classes, which are going to be used to populate the RadTaskBoard control.

#### __[C#] Example 1:  Creating ViewModels__
{{region xaml-radtaskboard-getting-started-0}}
    public class Task
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
		public List<string> Tags { get; set; }
    }
	public  class MainViewModel: ViewModelBase
    {
        public ObservableCollection<Task> CustomData { get; set; }
        public MainViewModel()
        {
            CustomData = GetCustomTasks();
            this.SelectedItem = this.Data[1];
        }

        private ObservableCollection<Task> GetCustomTasks()
        {
            ObservableCollection<Task> tasks = new ObservableCollection<Task>();
            tasks.Add(new Task() { Assignee = "Bella", Header="Unit Test: RadDocking", Description="Add Unit Tests", State = "Not Done", Tags= new System.Collections.Generic.List<string>() { "Important" } });
            tasks.Add(new Task() { Assignee = "Tomas", Header="Bug RadPanelBar", Description="Fix Bug", State = "In Progress", Tags = new System.Collections.Generic.List<string>() { "Reported" } });
            tasks.Add(new Task() { Assignee = "Peter", Header="RadChartView: Implement Animation Feature", Description="Implement animmations for all series in RadChartView.", State = "Done", Tags = new System.Collections.Generic.List<string>() { "Complex" } });
            return tasks;
        }
    }	
{{endregion}}

Next, we can go ahead and define the RadTaskBoard in our view:

#### __[XAML] Example 2: Defining RadTaskBoard in XAML__
{{region xaml-radtaskboard-getting-started-1}}
    <telerik:RadTaskBoard ItemsSource="{Binding CustomData}" 
                        GroupMemberPath="State" />
{{endregion}}

Since the control is bound a collection of custom objects, you need to declare ItemTemplate property. You have two options here. 

* If you want to use the default look of the card and just bind your properties. You can place in the DataTemplate __RadTaskBoardCard __ element and bind its properties to the properties from the business object.

#### __[XAML] Example 3: Defining RadTaskBoardCard in ItemTemplate__
{{region xaml-radtaskboard-getting-started-2}}
    <telerik:RadTaskBoard x:Name="taskBoard" ItemsSource="{Binding CustomData}" GroupMemberPath="State"  >
		<telerik:RadTaskBoard.ItemTemplate>
			<DataTemplate>
				<telerik:RadTaskBoardCard Assignee="{Binding Assignee}" 
										 CategoryName="{Binding State}"  
										 Tags="{Binding Tags}" 
										 Content="{Binding Description}"
										 Header="{Binding Header}"  />
			</DataTemplate>
		</telerik:RadTaskBoard.ItemTemplate>
	</telerik:RadTaskBoard>
{{endregion}}

* If you want to have your own look. You can place your structure in the DataTemplate applied to the ItemTemplate property of the __RadTaskBoard__.

#### __[XAML] Example 3: Defining RadTaskBoard in XAML__
{{region xaml-radtaskboard-getting-started-2}}
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
{{endregion}}

If you run the application now, you should get a structure like in Figure 1:

## Figure 1: RadTaskBoard bind to custom object 
// image here

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-data-binding-to-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})