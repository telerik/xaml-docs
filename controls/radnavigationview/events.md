---
title: Events
page_title: Events
description: This article describes the RadNavigationView events.
slug: radnavigationview-events
tags: events, paneopened, paneclosed
position: 3
---

# {{ site.framework_name }} RadNavigationView Events

This article lists the events specific for RadNavigationView.

## RadNavigationView Events

RadNavigationView inherits the __Selector__ class. Almost all of the exposed events are inherited from it. Here are the additional events that are exposed:            

* __ItemClick__: Occurs each time an item in the __RadNavigationView__ gets clicked. The event handler receives two arguments:

	* The sender argument contains the __RadNavigationView__. This argument is of type object, but can be cast to the __RadNavigationView__ type.              

	* A __RoutedEventArgs__ object.                      

	>The __ItemClick__ event is fired after the __Click__ event of the clicked __RadNavigationViewItem__.     

* __PaneOpened__: Occurs when the RadNavigationView pane is opened.  The event handler receives two arguments:  

    * The sender argument contains the __RadNavigationView__. This argument is of type object, but can be cast to the __RadNavigationView__ type.              

	* A __RoutedEventArgs__ object. 

* __PaneClosed__: Occurs when the RadNavigationView pane is closed.  The event handler receives two arguments:  
  
    * The sender argument contains the __RadNavigationView__. This argument is of type object, but can be cast to the __RadNavigationView__ type.              

	* A __RoutedEventArgs__ object. 

* __SelectionChanged__: Occurs when the selected RadNavigationViewItem gets changed. The event arguments are of type __System.Windows.Controls.SelectionChangedEventArgs__ which can be used to get the new and the old selection via the __AddedItems__ and __RemovedItems__ properties.	

* __ItemExpanded__: Occurs when a RadNavigationViewItem gets expanded. The event arguments are of type __RoutedEventArgs__. The expanded item can be accessed via the __OriginalSource__ property of the arguments.

* __ItemCollapsed__: Occurs when a RadNavigationViewItem gets collapsed. The event arguments are of type __RoutedEventArgs__. The collapsed item can be accessed via the __OriginalSource__ property of the arguments.

## RadNavigationViewItem Events

* __Expanded__: Occurs when the corresponding RadNavigationViewItem gets expanded. The event arguments are of type __RoutedEventArgs__.

* __Collapsed__: Occurs when the corresponding RadNavigationViewItem gets collapsed. The event arguments are of type __RoutedEventArgs__.

## See Also 

* [Getting Started]({%slug radnavigationview-getting-started%})
* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Display Mode]({%slug radnavigationview-display-mode%})
