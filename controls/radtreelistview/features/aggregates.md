---
title: Aggregates
page_title: Aggregates
description: Aggregates
slug: radtreelistview-features-aggregates
tags: aggregates
publish: True
position: 8
---

# Aggregates



## 

The column footers can be used to display aggregated information about the data in the column via aggregate functions. The aggregate functions might be found in the __Telerik.Windows.Data__ assembly.

The available functions are:

* __AverageFunction__ – returns the average of the values in the column. 

* __CountFunction__ – returns the number of all items in the column.

* __FirstFunction__ – returns the first element in the column according to the current sorting. 

* __LastFunction__ – returns the last elements in the column according to the current sorting. 

* __MaxFunction__ – returns the Max of the values in the column. 

* __MinFunction__ – returns the Min of the values in the column. 

* __SumFunction__ – returns the Sum of all values in the column. 

To display an aggregate function for a certain column, just instantiate the function you need and add it to the __AggregateFunctions__ collection of that column.

As the __RadTreeListView__ directly inherits the __RadGridView__ it uses its filtering mechanism. To learn more read the 
        {% if site.site_name == 'Silverlight' %}[respective topic](http://www.telerik.com/help/silverlight/gridview-columns-aggregate-functions.html){% endif %}{% if site.site_name == 'WPF' %}[respective topic](http://www.telerik.com/help/wpf/gridview-columns-aggregate-functions.html){% endif %}
          in the __RadGridView's__ documentation. 

# See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Columns]({%slug radtreelistview-features-columns%})
