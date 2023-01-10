---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-getting-started
tags: getting,started
published: True
position: 2
---

# {{ site.framework_name }} RadTaskBoard Getting Started

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

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Slider/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadTaskBoard, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

__Example 4__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 4: Merge the ResourceDictionaries__  
{{region radtaskboard-getting-started_7}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 2__ shows a RadTaskBoard with the **Windows8** theme applied.

#### __Figure 2: RadTaskBoard with the Windows8 theme__
![RadTaskBoard with Windows8 theme](images/RadTaskBoard-setting-theme.png)

## See Also
 * [Column]({%slug radtaskboard-features-column%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Indicator Color]({%slug radtaskboard-features-category-indicator%})
