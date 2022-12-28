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

By default the __OLAP__ data providers (`XmlaDataProvider` and `AdomdDataProvider`) will pre-load all the data from the associated cube and display it in the __PivotGrid__. To change this behavior, set the `EnableLoadOnDemand` property of the data provider to `true`. In that case, all groups will be collapsed initially and only the data that should be displayed at this state is fetched from the cube. On expand of a group (on demand), its data will be loaded from the source and displayed in the view.

#### __[XAML]__
{{region radpivotgrid-features-load-on-demand-0}}
	 <pivot:XmlaDataProvider x:Key="XMLADataProvider" EnableLoadOnDemand="True"/> 
{{endregion}}

## See Also  
 * [Using XmlaDataProvider]({%slug radpivotgrid-data-xmla%})
 * [Using AdomdDataProvider]({%slug radpivotgrid-data-adomd%})
 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})
 * [Features]({%slug radpivotgrid-features%})
