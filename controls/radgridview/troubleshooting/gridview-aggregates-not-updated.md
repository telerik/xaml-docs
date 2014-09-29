---
title: Aggregates are not updated
page_title: Aggregates are not updated
description: Aggregates are not updated
slug: gridview-troubleshooting-aggregates-not-updated
tags: aggregates,are,not,updated
published: True
position: 1
---

# Aggregates are not updated



## Column footer aggregates

__PROBLEM__

When a value is modified in code, the aggregate results are not updated.



__CAUSE__

The reason for this behavior is that a CollectionChanged event of the bound source collection is not raised. 



__SOLUTION__

In order to get the aggregate results refreshed, you have to notify the GridView that the bound collection has been changed. A __CollectionChanged__ notification of the bound collection should be raised.

There are four possible solutions:
        

1. You can update the value as illustrated in this [help article]({%slug edit-item-outside-gridview%}) on how to edit an item outside RadGridView.
          

1. Ensure thatCollectionChanged event is raised from the bound source collection.

1. Invoke RadGridView.CalculateAggregates() method.

1. Invoke RadGridView.Rebind() method. It will raise CollectionChanged notification with action Reset. Please note that the entire view will be recreated.

## Column group aggregates

__PROBLEM__

When a value is modified in code, the aggregate results in the group rows are not updated.



__CAUSE__

The reason for this behavior is that a CollectionChanged event of the bound source collection is not raised. 



__SOLUTION__

In order to get the group aggregates refreshed, a CollectionChanged notification of the bound collection should be raised. 
        

There are four possible solutions:
        



1. You can update the value as illustrated in this [help article]({%slug edit-item-outside-gridview%}) on how to edit an item outside RadGridView.
            

1. Ensure that a CollectionChanged event is raised from the bound source collection.

1. Invoke RadGridView.GroupDescriptors.Reset(). This action will reset all the group rows.

1. Invoke RadGridView.Rebind() method. It will raise CollectionChanged event with action Reset. Please note that the entire view will be recreated. 

# See Also
