---
title: Binding to Collections
page_title: Binding to Collections
description: Binding to Collections
slug: common-data-binding-binding-to-collection
tags: binding,to,collections
publish: True
position: 2
---

# Binding to Collections



This article covers the following topics:

* [Overview](#Overview) - a few words about data binding to collections of objects. 
		

* [Binding to Collections](#Implementing_Collections){% if site.site_name == 'WPF' %}

* [Collection Views](#Collection_Views){% endif %}

* [Implementing Master-Detail Binding Scenario](#Implementing_Master-Detail_Binding_Scenario)

## Overview

A binding source object can be treated either as a single object of which the properties contain data or as a data collection of polymorphic objects that are often grouped together (such as the result of a query to a database). For example, a common scenario is to use an __ItemsControl__ such as a __ListBox__, __RadComboBox__, or __RadTreeView__ to display a data collection.
The simplest data binding of a __RadComboBox__ control is demonstrated in the following example:

#### __XAML__

{{region common-data-binding-binding-to-collection_0}}
	<telerik:RadComboBox x:Name="radComboBox" ItemsSource="{Binding}" />
	{{endregion}}



Instead of __RadComboBox__ you can use __RadTreeView__, 
__RadMenu__ or any other control which inherits from __ItemsControl__.

## Implementing Collections

You can enumerate over any collection that implements the [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) interface. However, to set up dynamic bindings so that insertions or deletions in the collection update the UI automatically, the collection must implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) 
      interface. This interface exposes an event, which should be raised whenever the underlying collection changes.

>tip{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} provides a built-in implementation of a data collection that exposes the __INotifyCollectionChanged__ interface - this is the [ObservableCollection(T)](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) class.

To fully support transferring data values from source objects to targets, each object in your collection must implement the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) interface.

>tipConsider using [ObservableCollection(T)](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) or one of the other existing generic collections, instead of implementing your own collection.

## Implementing Master-Detail Binding Scenario

To know the current item is useful not only for navigation of items in a collection, but also for the master-detail binding scenario. For example, you may have a __ListBox__ which is bound to a collection of objects. Also you have a __ContentControl__ which content is determined by the selection within the __ListBox__. Or in other words, when a __ListBox__ item is selected, the __ContentControl__ shows the details of the selected item. The following example shows you how to implement such a scenario.

#### __XAML__

{{region common-data-binding-binding-to-collection_1}}
	<ListBox x:Name="listBox" ItemsSource="{Binding Source={StaticResource DataSource}}"/>
	
	<ContentControl x:Name="productDetails" ContentTemplate="{StaticResource ProductDetailsTemplate}" Content="{Binding ElementName=listBox, Path=SelectedItem}"/>
	{{endregion}}



>tipFor more information about Data Binding, take a look at the [Overview]({%slug common-data-binding-overview%}) topic.

# See Also

 * [Data Templates]({%slug common-data-binding-data-templates%})

 * [Hierarchical Data]({%slug common-data-binding-hierarchical-data%})

 * [Style Selectors]({%slug common-data-binding-style-selectors%})
