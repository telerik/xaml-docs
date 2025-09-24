---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-populating-data-binding
tags: data,binding
published: True
position: 1
---

# Data Binding

## DataContext

The purpose of the __DataContext__ is to hold the data that will be bound (like a data source). If the __DataContext__ is empty no binding will be applied. The __DataContext__ can be set from both XAML and managed code:
				



```XAML
	<telerik:RadTabControl x:Name="radTabControl" DataContext="{Binding MyTabItems}" />
```

  
```C#
	RadTabControl radTabControl= new RadTabControl();
	radTabControl.DataContext = new Collection<WordDocument>();
```
```VB.NET
	Dim radTabControl As New RadTabControl()
	radTabControl.DataContext = New Collection(Of WordDocument)()
```

>The __DataContext__ is inherited in the visual tree, which means that the child controls of the __RadTabControl__ will have the same __DataContext__, if it is not explicitly changed.

>important The __PropagateItemDataContextToContent__ property of the RadTabControl specifies whether the DataContext of the RadTabItem should be assigned as the DataContext of its content when the selection changes. The default value of this property is __True__.

## Item Source

The __ItemsSource__ property allows the __RadTabControl__ to be bound to any collection that implements the __IEnumerable__ interface. For each item in the collection, a container of type __RadTabItem__ is created. By using the __ItemTemplate__, __ItemContainerStyle__ and __TemplateSelectors__ you can control the appearance of the dynamically created tabs. [Read more about that here]({%slug radtabcontrol-populating-binding-to-collection%}).
				
>When binding the __RadTabControl__ to a collection, the dynamically created __RadTabItems__ have the item they are bound to as __DataContext__.

## Types of Sources

The __ItemsSource__ property can be bound to any collection that implements the __IEnumerable__ interface. If you want insertions or deletions in the collection to be automatically applied to the UI, the collection we bound to must also implement the __ICollectionChanged__ interface. This interface exposes an event that should be raised whenever the underlying collection changes. In {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} there is a built-in implementation of a data collection that exposes the __INotifyCollectionChanged__ interface – the __ObservableCollection<T>__ class.

>tip Consider using __ObservableCollection<T>__ or one of the other existing collection classes like __List<T>__, __Collection<T>__, instead of implementing your own collection. If the scenario requires a custom collection to be implemented, use the __IList__ interface, which provides individual access by index to its items and the best performance.

## DisplayMemberPath

When no __ItemTemplate__ is defined the __DisplayMemberPath__ is used to determine which property of the __DataContext__ object to be visualized in the tab content.


```XAML
	<telerik:RadTabControl x:Name="radTabControl" ItemsSource="{Binding Persons}" DisplayMemberPath="Name" />
```


```C#
	RadTabControl radTabControl= new RadTabControl();
	radTabControl.ItemsSource = new Collection<Person>();
	radTabControl.DisplayMemberPath = "Name";
```
```VB.NET
	Dim radTabControl As New RadTabControl()
	radTabControl.ItemsSource = New Collection(Of Person)()
	radTabControl.DisplayMemberPath = "Name"
```

>If neither the __DisplayMemberPath__ nor the __ItemTemplate__ are set, then the content of the tab would be set to the value returned by the __ToString()__ method.

## See Also  
 * [Binding To Collection]({%slug radtabcontrol-populating-binding-to-collection%})
 * [PopulatingRadTabControl with Data]({%slug radtabcontrol-populating-with-tabs%})
 * [Getting Started]({%slug radtabcontrol-getting-started%})
