---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Data Binding Support Overview
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

## Data Templates

The __ItemsSource__ property allows the __RadListBox__ to be bound to any collection that implements the __IEnumerable__ interface. For each item in the collection, a container of type __RadListBoxItem__ is created. By using the __ItemTemplate__, __ItemContainerStyle__ and __TemplateSelectors__ you can control the appearance of the dynamically created items.

Besides the __RadListBox's ItemTemplate__ property, you could use the __DisplayMemberPath__ property for controlling the appearance of the created items.

>tipIf neither the __DisplayMemberPath__ nor the __ItemTemplate__ are set, the content of the item would be set to the value returned by the __ToString()__ method of the business object.