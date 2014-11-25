---
title: Aggregates
page_title: Aggregates
description: Aggregates
slug: radtreelistview-features-aggregates
tags: aggregates
published: True
position: 8
---

# Aggregates



## 

The column footers can be used to display aggregated information about the data in the column via aggregate functions. The aggregate functions might be found in the __Telerik.Windows.Data__ assembly.

The available functions are:

* __AverageFunction__ – returns the __average__ of the values in the column. 

* __CountFunction__ – returns the __number of all items__ in the column.

* __FirstFunction__ – returns the __first element__ in the column according to the current sorting. 

* __LastFunction__ – returns the __last elements__ in the column according to the current sorting. 

* __MaxFunction__ – returns the __Max__ of the values in the column. 

* __MinFunction__ – returns the __Min__ of the values in the column. 

* __SumFunction__ – returns the __Sum__ of all values in the column. 

To display an aggregate function for a certain column, just instantiate the function you need and add it to the __AggregateFunctions__ collection of that column.

As the __RadTreeListView__ directly inherits the __RadGridView__ it uses its filtering mechanism. To learn more read the [respective topic]({%slug gridview-columns-aggregate-functions%}) in the __RadGridView's__ documentation. 

# See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Columns]({%slug radtreelistview-features-columns%})
