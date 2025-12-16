---
title: Reevaluation of data operations
page_title: Reevaluation of data operations
description: Learn how to have items displayed in Telerik's {{ site.framework_name }} DataGrid updated correctly when a value is modified in code.
slug: gridview-troubleshooting-reevaluation
tags: filtering,grouping,sortng,not,updated
published: True
position: 1
---

# Data Operations like filtering, sorting or grouping are not re-evaluated

__PROBLEM__

When a value is modified in code, the items displayed in RadGridView are not updated according to defined SortDescroptors, FilterDescriptors or GroupDescriptors.

__CAUSE__

The reason for this behavior is that a CollectionChanged event of the bound source collection is not raised. 

__SOLUTION__

In order to get the items refreshed, you have to notify the GridView that the bound collection has been changed. A __CollectionChanged__ notification of the bound collection should be raised.

There are four possible solutions:

1. You can update the value as illustrated in the [Edit items outside RadGridView]({%slug edit-item-outside-gridview%}) article.

1. Invoke RadGridView.Rebind() method. It will raise CollectionChanged notification with action Reset. Please note that the entire view will be recreated.

1. Ensure that CollectionChanged event is raised from the bound source collection.

>When a __nested property__ is modified and a notification is raised for it as suggested in point 1., then RadGridView will not receive it and the data displayed will not be re-evaluated. In that case the suggested solutuons listed as 2. or 3. should be applied.

>tip You can also find the blog post on [Fast real-time update](http://blogs.telerik.com/vladimirenchev/posts/10-10-04/fast-real-time-data-update-for-your-silverlight-and-wpf-applications.aspx).

## See Also 
* [Basic Filtering]({%slug gridview-filtering-basic%})

* [Basic Grouping]({%slug gridview-grouping-basics%})

* [Basic Sorting]({%slug gridview-sorting-basics%})

* [Aggregates are not updated]({%slug gridview-troubleshooting-aggregates-not-updated%})

