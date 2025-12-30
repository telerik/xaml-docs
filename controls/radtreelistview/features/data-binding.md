---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-features-data-binding
tags: data,binding
published: True
position: 4
---

# Data Binding



Displaying data in the __RadGridView__ depends on the data binding mechanism. The entry point for the data to be bound is the __ItemsSource__ property, which you must set in order to display data in your __RadGridView__ control. 

>tip For additional information regarding data binding and populating the __RadTreeListView__ with data you can check the respective topics in the [RadGridView's documentation]({%slug gridview-data-overview%}).

## Setting the ItemsSource property

As a typical data control the __RadGridView__ displays data by binding to a source and generating visual elements for each item in it. The first thing that you have to do is to set the __ItemsSource__ property of the __RadGridView__.



```C#

	this.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData();
```
```VB.NET

	Me.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData()
```



## Types of Sources

Unlike the standard items control, the __RadGridView__'s __ItemsSource__ property is declared to be of type __System.Object__. Of course, standard .NET collections that implement the __IEnumerable__ interface are fully supported as well. If you want the insertions or the deletions in the collection to be automatically applied to the UI, the collection to which you bind must also implement the __INotifyCollectionChanged__ interface. Coupling in your code, it may be more convenient to manipulate data in the original data source instead of using the __RadGridView__ API. __RadGridView__ listens to data source collection change events and reflects those changes in its visual representation. In Silverlight there is a built-in implementation of a data collection that exposes the __INotifyCollectionChanged__ interface – the __ObservableCollection<T>__ class.

>tip Consider using __ObservableCollection<T>__ or one of the other existing collection classes like __List<T>__, __Collection<T>__, instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.

Introduced to the __System.ComponentModel__ namespace collection views are fully supported as well. __RadGridView__ will automatically pick up group descriptions, sort descriptions, or will filter settings defined on the collection view and will use those settings to display data.

## Binding the Columns

The data in the __RadGridView__ is separated in columns. There are different types of columns, displaying different types of data. Usually the data is displayed in __GridViewDataColumns__, which can be manually generated, too. In order to display the data in it you can bind its __DataMemberBinding__ property. Here is an example of a manually defined column.



```XAML

	<telerik:RadTreeListView x:Name="radTreeListView"
	                            AutoGenerateColumns="False">
	    <telerik:RadTreeListView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                    Header="Name" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Count}"
	                                    Header="Count" />
	    </telerik:RadTreeListView.Columns>
	</telerik:RadTreeListView>
```



## Binding the TreeListViewTableDefinitions

In order to display the hierarchical data the __RadTreeListView__ uses child table definition of type __TreeListViewTableDefinition__. In order to display the underlying items in the hierarchy you have to bind its __ItemsSource__ to the appropriate property.

>Note that a table definition will be generated for each row and it will have the same __DataContext__ as the row. So you have to bind to the property, marking the collection that contains the next level of the hierarchy. This property should have the same name at each level of the hierarchy. 



```XAML

	<telerik:RadTreeListView x:Name="radTreeListView">
	    <telerik:RadTreeListView.ChildTableDefinitions>
	        <telerik:TreeListViewTableDefinition ItemsSource="{Binding Items}">
	        </telerik:TreeListViewTableDefinition>
	    </telerik:RadTreeListView.ChildTableDefinitions>
	</telerik:RadTreeListView>
```



## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Managing Data]({%slug radtreelistview-features-managing-data%})
