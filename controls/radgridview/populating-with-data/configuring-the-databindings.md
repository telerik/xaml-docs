---
title: Configuring the Data Bindings
page_title: Configuring the Data Bindings
description: Configuring the Data Bindings
slug: gridview-configuring-the-databindings
tags: configuring,the,data,bindings
published: True
position: 1
---

# Configuring the Data Bindings

## Setting the ItemsSource

As a typical data control the __RadGridView__ displays data by binding to a source and generating visual elements for each item in it. The first thing you have to do is to set the __ItemsSource__ property of __RadGridView__.

#### __C#__

{{region cs-gridview-configuring-the-databindings_0}}

	this.radGridView.ItemsSource = SampleData.GetData();
{{endregion}}



#### __VB.NET__

{{region vb-gridview-configuring-the-databindings_1}}

	Me.radGridView.ItemsSource = SampleData.GetData()
{{endregion}}

## Types of Sources

Unlike a standard items control, the __RadGridView__'s __ItemsSource__ property is declared to be of type __System.Object__. Of course standard .NET collections that implement the __IEnumerable__ interface are fully supported as well. If you want the insertions or the deletions in the collection to be automatically applied to the UI, the collection to which you bound must also implement the __INotifyCollectionChanged__ interface. Coupling in your code it may be more convenient to manipulate data in the original data source instead of using the __RadGridView__ API. __RadGridView__ listens to data source collection change events and reflects those changes in its visual representation. In {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} there is a built-in implementation of a data collection that exposes the __INotifyCollectionChanged__ interface – the __ObservableCollection<T>__ class.

>tipConsider using __ObservableCollection<T>__ or one of the other existing collection classes like __List<T>__, __Collection<T>__, instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.

Introduced to the __System.ComponentModel__ namespace collection views are fully supported as well. __RadGridView__ will automatically pick up group descriptions, sort descriptions, or filter settings defined on the collection view and use those to display data.

## Binding the Columns

The data in the __RadGridView__ is separated in columns. There are different types of columns, displaying different types of data. Usually the data is displayed in __GridViewDataColumns__, which can be manually generated too. Here is an example of a manually defined column.

#### __XAML__

{{region xaml-gridview-configuring-the-databindings_2}}

	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
		<telerik:RadGridView.Columns>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Id}" 
										Header="Id" />
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

To learn more about defining columns and the different types of columns take a look at the [Grid Columns]({%slug gridview-columns-overview%}) section.

# See Also

 * [Using in-memory Data]({%slug gridview-in-memory-date%})

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%})
