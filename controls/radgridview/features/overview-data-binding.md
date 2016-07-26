---
title: Data Binding
page_title: Data Binding
description: Data Binding
slug: gridview-overview-data-binding
tags: data,binding
published: True
position: 0
---

# Data Binding


Displaying data in the __RadGridView__ depends on the data binding mechanism. The entry point for the data to be bound is the __ItemsSource__ property, which you must set in order to display data in your __RadGridView__ control.

#### __C#__

{{region cs-gridview-overview-data-binding_0}}

	this.radGridView.ItemsSource = GetObservableObjectData();
{{endregion}}


#### __VB.NET__

{{region vb-gridview-overview-data-binding_1}}

	Me.radGridView.ItemsSource = GetObservableObjectData()
{{endregion}}


The next step is to configure the data bindings for the __RadGridView__ [columns]({%slug gridview-columns-overview%}). To learn more about the data binding in the context of the __RadGridView__ take a look at the [Configuring the Data Bindings]({%slug gridview-configuring-the-databindings%}) topic.

## Asynchronous Data Binding 


After the __ItemsSource__ is set, the __RadGridView__ continues to internally load the data. The same loading finds place when filtering, sorting, grouping and etc.

To learn more about data binding and find answers to your questions take a look at the following topics:

* [Populating with Data]({%slug gridview-data-overview%})

* [Configuring the Data Binding]({%slug gridview-configuring-the-databindings%})

# See Also

 * [Managing Data]({%slug gridview-overview-managing-data%})

 * [Sorting]({%slug gridview-overview-sorting%})

 * [Grouping]({%slug gridview-overview-grouping%})
