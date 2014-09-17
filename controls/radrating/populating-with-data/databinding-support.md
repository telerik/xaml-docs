---
title: DataBinding Support Overview
page_title: DataBinding Support Overview
description: DataBinding Support Overview
slug: databinding-support
tags: databinding,support,overview
published: True
position: 4
---

# DataBinding Support Overview



Data binding allows you to establish a link between the UI and the underlying business logic and to keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order for this to work, you have to implement the proper notification or to use objects that have already implemented it.

Binding to __RadRating__ involves the following property:

* __RadRating.ItemsSource__ - gets or sets the data source (__IEnumerable__) used to generate the content of the rating control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects.

## Supported Data Sources

You can bind __RadRating__ to the following types of data sources:

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more information on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx)

* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections

* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists

## Change Notification Support

To bind the __RadRating__ to a collection of business objects, you should use its __ItemsSource__ property. If you want the changes to the collection to be automatically reflected to the __RadRatingItems__, the collection should implement the __INotifyCollectionChanged__ interface. There is a build-in collection in Silverlight, which implements the __INotifyCollectionChanged__ interface and you could use it without making any effort - this is the generic __ObservableCollection<T>.__ However, to get full benefit from the change notification support, your custom business objects should implement the __INotifyPropertyChanged__ interface.

>tipConsider using __ObservableCollection<T>__ or one of the other existing collection classes like__List<T>, Collection<T>,__ instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.
