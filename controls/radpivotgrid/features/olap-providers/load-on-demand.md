---
title: Load on Demand
page_title: Load on Demand
description: Check our &quot;Load on Demand - Lazy Loading &quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-load-on-demand
tags: group,load,demand,on,lazy,loading
published: True
position: 7
---

# Load on Demand

The load on demand feature allows you to fetch the needed data only when the associated group gets expanded.

By default the __OLAP__ data providers (`XmlaDataProvider` and `AdomdDataProvider`) will pre-load all the data from the associated cube and display it in the __PivotGrid__. To change this behavior, set the `EnableLoadOnDemand` property of the data provider to `true`. In that case, all groups will be collapsed initially and only the data that should be displayed at this state is fetched from the cube. On expand of a group (on demand), a new query is generated to load the data for the currently expanded groups.


```XAML
	 <pivot:XmlaDataProvider x:Key="XMLADataProvider" EnableLoadOnDemand="True"/> 
```

>caution The [expand behavior]({%slug radpivotgrid-features-expand-behavior%}) is not supported when the load on demand feature is enabled.

## See Also  
 * [Using XmlaDataProvider]({%slug radpivotgrid-data-xmla%})
{% if site.framework_name == 'WPF' %}
 * [Using AdomdDataProvider]({%slug radpivotgrid-data-adomd%})
{% endif %} 
 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})
 * [Features]({%slug radpivotgrid-features%})
