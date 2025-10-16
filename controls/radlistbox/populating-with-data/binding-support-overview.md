---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Check our &quot;Data Binding Support Overview&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-populating-with-data-binding-support-overview
tags: data,binding,support,overview
published: True
position: 3
---

# Data Binding Support Overview

Data binding allows you to establish a link between the UI and the underlying business logic and to keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order for this to work, you have to implement the proper notification or to use objects that have already implemented it.

Binding to __RadListBox__ involves the following property:

* __RadListBox.ItemsSource__ - gets or sets the data source (__IEnumerable__) used to generate the content of the __RadListBox__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects.

## Change Notification Support

To bind the __RadListBox__ to a collection of business objects, you should use its __ItemsSource__ property. If you want the changes to the collection to be automatically reflected to the __RadListBoxItems__, the collection should implement the __INotifyCollectionChanged__ interface. There is a build-in collection in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}, which implements the __INotifyCollectionChanged__ interface and you could use it without making any effort - this is the generic __ObservableCollection<T>__. However, to get a full benefit from the change notification support, your custom business objects should implement the __INotifyPropertyChanged__ interface.

>tipConsider using __ObservableCollection<T>__ or one of the other existing collection classes like __List<T>__, __Collection<T>__, instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.

__Exmaple 1: Create an objects class__

```C#
	public class Country
	{
		public string Name { get; set; }
		public string Capital { get; set; }
	}
```

__Exmaple 2: Create the ViewModel__

```C#
	public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = new ObservableCollection<Country>();
                    this.countries.Add(new Country() { Name = "Australia", Capital = "Canberra" });
                    this.countries.Add(new Country() { Name = "Bulgaria", Capital = "Sofia" });
                    this.countries.Add(new Country() { Name = "Canada", Capital = "Ottawa" });
                    this.countries.Add(new Country() { Name = "Denmark", Capital = "Copenhagen" });
                    this.countries.Add(new Country() { Name = "France", Capital = "Paris" });
                    this.countries.Add(new Country() { Name = "Germany", Capital = "Berlin" });
                    this.countries.Add(new Country() { Name = "India", Capital = "New Delhi" });
                    this.countries.Add(new Country() { Name = "Italy", Capital = "Rome" });
                    this.countries.Add(new Country() { Name = "Norway", Capital = "Oslo" });
                    this.countries.Add(new Country() { Name = "Russia", Capital = "Moscow" });
                    this.countries.Add(new Country() { Name = "Spain", Capital = "Madrid" });
                    this.countries.Add(new Country() { Name = "United Kingdom", Capital = "London" });
                    this.countries.Add(new Country() { Name = "United States", Capital = "Washington, D.C." });
                }
                return countries;
            }
        }
    }
```

__Example 3: Create the RadListBox and set its ItemsSource__
```XAML
	<Window.DataContext>
        <local:MyViewModel/>
    </Window.DataContext>
    <Grid>
        <telerik:RadListBox x:Name="listBox"
                            Width="200" Height="100"
                            ItemsSource="{Binding Countries}"/>
    </Grid>
```

## Data Templates

The __ItemsSource__ property allows the __RadListBox__ to be bound to any collection that implements the __IEnumerable__ interface. For each item in the collection, a container of type __RadListBoxItem__ is created. By using the __ItemTemplate__, __ItemContainerStyle__ and __TemplateSelectors__ you can control the appearance of the dynamically created items.

__Example 4: Create DataTemplate and bind the Text property of the TextBlock to 'Name' to show the names of the countries or set it to 'Capital' to show their capitals__
```XAML
	<Window.DataContext>
        <local:MyViewModel/>
    </Window.DataContext>
    <Grid>
        <Grid.Resources>
            <DataTemplate x:Key="ListBoxCustomItemTemplate">
                <Grid>
                    <TextBlock Text="{Binding Name}"/>
                </Grid>
            </DataTemplate>
        </Grid.Resources>
        <telerik:RadListBox x:Name="listBox"
                            Width="200" Height="100"
                            ItemsSource="{Binding Countries}"
                            ItemTemplate="{StaticResource ListBoxCustomItemTemplate}"/>
    </Grid>
```

Besides the __RadListBox's ItemTemplate__ property, you could use the __DisplayMemberPath__ property for controlling the appearance of the created items.

__Example 5: Set DisplayMemberPath to 'Name' to show the names of the countries or set it to 'Capital' to show their capitals__
```XAML
	<Window.DataContext>
        <local:MyViewModel/>
    </Window.DataContext>
    <Grid>
        <telerik:RadListBox x:Name="listBox"
                            Width="200" Height="100"
                            ItemsSource="{Binding Countries}"
                            DisplayMemberPath="Capital"/>
    </Grid>
```

#### __Figure 1: Result of Examples 4 and 5__
![Rad List Box ItemsSource DisplayMemberPath 01](images/RadListBox_PopulatingWithData_DataBindingSupportOverview_01.png)

>tipIf neither the __DisplayMemberPath__ nor the __ItemTemplate__ are set, the content of the item would be set to the value returned by the __ToString()__ method of the business object.