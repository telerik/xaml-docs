---
title: Access filtered and sorted items
page_title:  Filtered-Sorted-Items-RadGridView
description: How To Access Filter and Sorted Items
slug: gridview-how-to-access-filtered-and-sorted-items
tags: sorted, filtered, items
published: True
position: 17
---

# How to access sorted and filtered items within the RadGridView

The RadGridView exposes an __Items__ property which represents a collection of the items after filtering, sorting and grouping operations have been applied upon the RadGridView`s __ItemsSource__.  

Lets assume we have a RadGridView which ItemsSource is an ObservableCollection of Club objects. The collection consists of 4 objects and the control has the following appearance:


![Default RadGridView](images/gridview-ItemsProperty.PNG)


Eventually, we would like to filter and sort the RadGridView:


![Filtered and Sorted RadGridView](images/gridview-ItemsProperty_SortedFiltered.PNG)


You can access the newly created view through the __Items__ property as the __ItemsSource__ will remain unchanged. 

>tipThe __Items__ collection will be sorted according to the applied changes. Grouping the __RadGridView__ might also result in reordering the collection.  


## See Also

* [RadGridView - Data Binding]({%slug gridview-overview-data-binding%})

* [RadGridView - Sorting]({%slug gridview-sorting-basics%})

* [RadGridView - Filtering]({%slug gridview-filtering-basic%})