---
title: Working with Data
page_title: Working with Data
description: Working with Data
slug: gridview-working-with-data
tags: working,with,data
published: True
position: 2
---

# Working with Data

To work with data means to load it, display it and manage it. The __RadGridView__ control gives you the possibility to do the three of them.

## Loading Data

To load the data means to fetch it to the __RadGridView__, so it can display it. The loading part is most commonly associated with consuming a web service or reading a local data source. To learn more about the different ways of loading data take a look at the topics about loading data:

* [Using in-memory Data]({%slug gridview-in-memory-date%})

* [From XML]({%slug gridview-loading-data-from-xml%})
 
* [From WCF Services]({%slug gridview-loading-data-from-wcf-services%})

* [From ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

{% if site.site_name == 'Silverlight' %}

* [From RIA Services]({%slug gridview-loading-data-from-ria-services%})

* [From Web Services]({%slug gridview-loading-data-from-web-services%})
{% endif %}

## Displaying Data

To display the data in the __RadGridView__ you have to set it to its __ItemsSource__ property.

#### __C#__

{{region gridview-working-with-data_0}}

	this.RadGridView.ItemsSource = SampleData.GetData();
{{endregion}}


#### __VB.NET__

{{region gridview-working-with-data_1}}

	Me.RadGridView.ItemsSource = SampleData.GetData()
{{endregion}}


The __ItemsSource__ property takes any collection that implements __IEnumerable__.

When set to the __ItemsSource__ property the data appears in the form of columns. The columns are bound to the data in the __ItemsSource__. By default you don't have to explicitly define the columns, as they will be auto generated. If you want, you are allowed to define the columns manually and specify the bindings for each one. To learn more about the columns take a look at the [Grid Columns]({%slug gridview-columns-overview%}) topic.

Via the functionality implemented by the columns you can [sort]({%slug gridview-sorting-basics%}), [filter]({%slug gridview-filtering-basic%}) or [group]({%slug gridview-grouping-basics%}) the data.

Usually when you display data, there are cases when you don't want to put all your data in one row. The __RadGridView__ provides you with a __Row Details View__, which can display the additional information. To learn more take a look at the [Row Details]({%slug radgridview-row-details-overview%}) topics.

If the data you want to display is hierarchical you can still display it in an appropriate format - in the form of nested __RadGridViews__. More about the __Hierarchical GridViews__ can be found [here]({%slug gridview-hierachy-overview%}). 

## Managing Data

Except displaying sets of data, Telerik's __RadGridView__ allows you to manage them. You are able to execute the standard operations - __Insert__, __Update__ and __Delete__, also you can validate the data. Besides using this functionality you are able to control it via the several events raised at the most important key-points of the action. 

You can find more about managing data in __RadGridView__ [here]({%slug gridview-managing-data-overview%}) or you can check out the following topics:

* [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})

* [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

* [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%})

* [Data Validation]({%slug gridview-managing-data-validation%})

# See Also

 * [Getting Started]({%slug gridview-getting-started2%})

 * [Building Hierarchical Grid View]({%slug gridview-building-hierarchical-grid-view%})
