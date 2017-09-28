---
title: Configure the Data Bindings
page_title: Configure the Data Bindings
description: This article demonstrates how to bind RadGridView to a collection of items and configure the data bindings for its columns.
slug: gridview-configuring-the-databindings
tags: configure,the,data,bindings
published: True
position: 1
---

# Configure the Data Bindings

This article is split into the following sections:

* [Setting the ItemsSource](#setting-the-itemssource)
* [Types of Sources](#types-of-sources)
* [Binding the Columns](#binding-the-columns)

## Setting the ItemsSource

As a typical data control __RadGridView__ displays its data by binding to a source and generating visual elements for each item in it. The first thing you have to do is to set the __ItemsSource__ property of __RadGridView__ as shown in **Example 1**.

#### __[C#] Example 1: Set RadGridView's ItemsSource__

{{region cs-gridview-configuring-the-databindings_0}}
	// In this example, GetData() is a static method of the SampleData class that returns a collection of items.
	this.radGridView.ItemsSource = SampleData.GetData();
{{endregion}}

#### __[VB.NET] Example 1: Set RadGridView's ItemsSource__

{{region vb-gridview-configuring-the-databindings_1}}
	' In this example, GetData() is a static method of the SampleData class that returns a collection of items.
	Me.radGridView.ItemsSource = SampleData.GetData()
{{endregion}}

## Types of Sources

Unlike a standard items control, __RadGridView__'s __ItemsSource__ property is declared to be of type __System.Object__.
Of course, standard .NET collections that implement the __IEnumerable__ interface are fully supported as well.

>important When binding the **ItemsSource** to a **DataTable**, you should use its **DefaultView** property.

To avoid coupling in your code, it may be more convenient to manipulate data in the original source collection instead of using __RadGridView__'s API.
__RadGridView__ listens for collection change events and reflects those changes in its visual representation.
In {{ site.framework_name }} there is a built-in implementation of a data collection that exposes the __INotifyCollectionChanged__ interface – the __ObservableCollection&lt;T&gt;__ class.

#### __[C#] Example 2: Set RadGridView's ItemsSource to an ObservableCollection__

{{region cs-gridview-configuring-the-databindings_2}}
	var players = new ObservableCollection<Player>();
	players.Add(new Player() { Name = "Pepe Reina", Number = 25 });
	players.Add(new Player() { Name = "Jamie Carragher", Number = 23 });
	players.Add(new Player() { Name = "Steven Gerrard", Number = 8 });
	players.Add(new Player() { Name = "Fernando Torres", Number = 9 });
	this.playersGrid.ItemsSource = players;
{{endregion}}

#### __[VB.NET] Example 2: Set RadGridView's ItemsSource to an ObservableCollection__

{{region vb-gridview-configuring-the-databindings_3}}
	Dim players = New ObservableCollection(Of Player)()
	players.Add(New Player() With {
		.Name = "Pepe Reina",
		.Number = 25
	})
	players.Add(New Player() With {
		.Name = "Jamie Carragher",
		.Number = 23
	})
	players.Add(New Player() With {
		.Name = "Steven Gerrard",
		.Number = 8
	})
	players.Add(New Player() With {
		.Name = "Fernando Torres",
		.Number = 9
	})
	Me.playersGrid.ItemsSource = players
{{endregion}}

>tip Consider using an __ObservableCollection&lt;T&gt;__ or one of the other existing collection classes like __List<T>__, __Collection<T>__, instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.

Implementations of the __System.ComponentModel.ICollectionView__ interface are fully supported as well. When such a source is provided, __RadGridView__ will automatically pick up group descriptions, sort descriptions, or filter settings defined on the collection view and use those to display data.

## Binding the Columns

The data in __RadGridView__ is separated in columns. There are different types of columns, displaying different types of data. Usually the data is displayed in __GridViewDataColumns__, which can be generated automatically or manually.

#### __[XAML] Example 3: Define a column in XAML__

{{region xaml-gridview-configuring-the-databindings_4}}
	<telerik:RadGridView x:Name="playersGrid" AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Number}" Header="Number" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### Figure 1: The rendered RadGridView

![The rendered RadGridView](images/RadGridView_ObservableCollection_ItemsSource.png)

> To learn more about defining columns and the different types of columns, take a look at the [Columns]({%slug gridview-columns-overview%}) section.

## See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})
 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})