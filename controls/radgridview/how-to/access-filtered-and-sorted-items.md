---
title: Access filtered and sorted items
page_title:  Access filtered and sorted items
description: How To Access Filter and Sorted Items
slug: gridview-how-to-access-filtered-and-sorted-items
tags: sorted, filtered, items
published: True
position: 17
---

# How to Access Sorted and Filtered Items Within RadGridView

The RadGridView exposes an __Items__ property which represents a collection of the items after filtering, sorting and grouping operations have been applied upon the RadGridView`s __ItemsSource__.  

Lets assume we have a RadGridView which ItemsSource is an ObservableCollection of Club objects. The collection consists of 4 objects and the control has the following appearance:

#### __Figure1: The original appearance of the RadGridView__ 
![Default RadGridView](images/gridview-ItemsProperty.PNG)


Eventually, we would like to filter and sort the RadGridView:

#### __Figure2: The appearance of the RadGridView after applying the data operations__
![Filtered and Sorted RadGridView](images/gridview-ItemsProperty_SortedFiltered.PNG)


You can access the newly created view through the __Items__ property as the __ItemsSource__ will remain unchanged. 

>tipThe __Items__ collection will be sorted according to the applied changes. Grouping the __RadGridView__ might also result in reordering the collection.  


## See Also

* [RadGridView - Data Binding]({%slug gridview-overview-data-binding%})

* [RadGridView - Sorting]({%slug gridview-sorting-basics%})

* [RadGridView - Filtering]({%slug gridview-filtering-basic%})