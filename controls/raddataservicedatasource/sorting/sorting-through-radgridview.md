---
title: Sorting through RadGridView
page_title: Sorting through RadGridView
description: Sorting through RadGridView
slug: raddataservicedatasource-sorting-sorting-through-radgridview
tags: sorting,through,radgridview
published: True
position: 1
---

# Sorting through RadGridView



## 

If you bind __RadGridView.ItemsSource__ to __RadDataServiceDataSource.DataView__, you will get automatic server-side sorting. When the user defines his sorting criteria through __RadGridView’s__ UI, __RadGridView__ will automatically transfer the resulting __SortDescriptors__ to __RadDataServiceDataSource__. If __RadDataServiceDataSource.AutoLoad__ is ___true___, the control will automatically go to the server and get the ordered data. 

![](images/RadDataServiceDataSource_SortingThroughRadGridView.png)


>caution If __AutoLoad__ is ___false___, the descriptors will be transferred to __RadDataServiceDataSource__, but no trip to the server will be made until the __Load__ method is called.