---
title: Overview
page_title: Overview
description: Overview
slug: patterns-and-practices-eventtocommand-overview
tags: overview
publish: True
position: 0
---

# Overview



When working in more advanced development scenarios we often find ourselves leaning towards the MVVM pattern for producing cleaner, loosely coupled, easier to test code, but along with this comes the responsibility of ensuring that all controls we are using can follow this pattern.  While it is very easy to work with the event-based model that exists across the .Net framework, events do not play well into the mindset of reducing traditional code-behind and instead handling logic within a viewmodel.

In this series we will first cover the initial setup of our sample that will be used across all four examples and then demonstrate how an event-based approach would be utilized to tackle an event with RadGridView.  From there, we’ll move on to demonstrate several different MVVM-friendly methods for utilizing a concept generally known as event-to-command to allow our events to fire and our code to respond accordingly, all without touching the code-behind of our user controls.
    

## Getting Started

Begin a new project by either using File > New Project, or ideally if you have the Telerik RadControls for Silverlight/WPF installed by using the Telerik menu.  We will be creating a new Silverlight/WPF C# application named RadEventToCommandExamples, which will eventually contain all of the examples demonstrated in this walkthrough.

If using the Telerik extensions, select the node for Telerik.Windows.Controls.GridView and the other required assemblies will be selected automatically.  If not using the Telerik extensions, after starting your new project add the following Telerik references:

* Telerik.Windows.Controls

* Telerik.Windows.Controls.GridView

* Telerik.Windows.Controls.Input

* Telerik.Windows.Data

Next, add the Telerik namespace:

#### __XAML__

{{region patterns-and-practices-eventtocommand-overview_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



Once this is set, add the following XAML to your MainPage.xaml file.  This will give us a shell for loading our examples:
      	

#### __XAML__

{{region patterns-and-practices-eventtocommand-overview_1}}
	<Grid x:Name="LayoutRoot">
		<Grid.RowDefinitions>
			<RowDefinition />
			<RowDefinition Height="Auto" />
		</Grid.RowDefinitions>
	
		<Border x:Name="xContentBorder" />
	
		<Grid Grid.Row="1">
			<Grid.ColumnDefinitions>
				<ColumnDefinition />
				<ColumnDefinition />
				<ColumnDefinition />
				<ColumnDefinition />
			</Grid.ColumnDefinitions>
			<telerik:RadButton x:Name="xGridWithEventsButton"
	                               Content="Grid With Events" />
		</Grid>
	</Grid>
	{{endregion}}



We’ll return here once we create our first example.

## Adding Some Class(es)

In order for this demo to work we will need some data, so go ahead and create a new class named ExampleDataItem.  We’ll be implementing the INotifyPropertyChanged interface as well to ensure class item updates flow correctly, but since this is not the focus of this series here is a quick copy-and-paste code snippet to use for this class:
     

#### __C#__

{{region patterns-and-practices-eventtocommand-overview_2}}
	public class ExampleDataItem : INotifyPropertyChanged
	{
		private int _ID;
		public int ID
		{
			get { return _ID; }
			set
			{
				if (_ID != value)
				{
					_ID = value;
					OnPropertyChanged("ID");
				}
			}
		}
	
		private string _Name;
		public string Name
		{
			get { return _Name; }
			set
			{
				if (_Name != value)
				{
					_Name = value;
					OnPropertyChanged("Name");
				}
			}
		}
	
		private DateTime _Date;
		public DateTime Date
		{
			get { return _Date; }
			set
			{
				if (_Date != value)
				{
					_Date = value;
					OnPropertyChanged("Date");
				}
			}
		}
	
		private bool _IsAvailable;
		public bool IsAvailable
		{
			get { return _IsAvailable; }
			set
			{
				if (_IsAvailable != value)
				{
					_IsAvailable = value;
					OnPropertyChanged("IsAvailable");
				}
			}
		}
	
		public ExampleDataItem()
		{
	
		}
	
		#region INotifyPropertyChanged Implementation
	
		public event PropertyChangedEventHandler PropertyChanged;
	
		public void OnPropertyChanged(string propName)
		{
			if (string.IsNullOrEmpty(propName))
				throw new ArgumentException("propName");
	
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
	
	{{endregion}}



Next up is our ViewModel (VM).  Since we know we will want to utilize MVVM, we can get started with a VM now and just add to that same VM as we move forward.  Create a new class named ExampleViewModel.cs.  Once this is created, we will first add two ObservableCollections to the VM to utilize for our Grid and ListBoxes (you’ll see them in the next section):
     

#### __C#__

{{region patterns-and-practices-eventtocommand-overview_3}}
	public ObservableCollection<ExampleDataItem> GridItems;
	public ObservableCollection<string> ListItems;
	{{endregion}}



Next we want to add the constructor for ExampleViewModel, which will contain a call to SetupData, both here for easy copy-and-paste:
     

#### __C#__

{{region patterns-and-practices-eventtocommand-overview_4}}
	public ExampleViewModel()
	{
	    SetupData();
	}
	 
	public void SetupData()
	{
	    Random rnd = new Random();
	 
	    GridItems = new ObservableCollection<ExampleDataItem>();
	    ListItems = new ObservableCollection<string>();
	 
	    for (int i = 0; i < 100; i++)
	    {
	        ExampleDataItem edi = new ExampleDataItem();
	        edi.ID = i;
	        edi.Name = "Name " + i.ToString();
	        edi.Date = DateTime.Today.AddDays(i);
	        edi.IsAvailable = (i % 3 == 0 ? true : false);
	 
	        GridItems.Add(edi);
	    }
	}
	{{endregion}}



We now have the data we need as well as a VM that we can utilize later in the series.

Proceed to the next section to see how we can utilize this with RadGridView and event-based interactions.
	 

# See Also

 * [Event-Based Setup]({%slug patterns-and-practices-eventtocommand-eventbased%})
