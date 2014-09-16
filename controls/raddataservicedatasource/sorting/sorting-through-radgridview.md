---
title: Sorting through RadGridView
page_title: Sorting through RadGridView
description: Sorting through RadGridView
slug: raddataservicedatasource-sorting-sorting-through-radgridview
tags: sorting,through,radgridview
publish: True
position: 1
---

# Sorting through RadGridView



## 

If you bind RadGridView.__ItemsSource__ to RadDataServiceDataSource.__DataView__, you will get automatic server-side sorting. When the user defines his sorting criteria through RadGridView’s UI, RadGridView will automatically transfer the resulting SortDescriptors to RadDataServiceDataSource. If RadDataServiceDataSource.AutoLoad is true, the control will automatically go to the server and get the ordered data. 




         
      ![](images/RadDataServiceDataSource_SortingThroughRadGridView.png)


