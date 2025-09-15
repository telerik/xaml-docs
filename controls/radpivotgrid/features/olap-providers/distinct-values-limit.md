---
title: Distinct Values Limit
page_title: Distinct Values Limit
description: This article shows how to change the distinct values limit in the OlapDataProviders of RadPivotGrid for {{ site.framework_name }}.
slug: radpivotgrid-features-distinct-values-limit
tags: olap,distinct,values,limit,pivotlist
published: True
position: 7
---

# Distinct Values Limit

The providers that derives from OlapDataProvider (XmlaDataProvider{% if site.site_name == 'WPF' %} and AdomdDataProvider{% endif %}) has a default limit of 1000 distinct values that will be fetched from the database. This limit is set on purpose to avoid accidental performance hits. You can alter this limit by setting the __DistinctValuesLimit__ property of the provider. 

#### __XAML__
```XAML
	<pivot:XmlaDataProvider DistinctValuesLimit="5000">
```

<br/>
>tip Check the [Using XmlaDataProvider]({%slug radpivotgrid-data-xmla%}){% if site.site_name == 'WPF' %} and [Using AdomdDataProvider]({%slug radpivotgrid-data-adomd%}){% endif %} to see how to set up the provider.

## See Also  
 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})
 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})
 * [Features]({%slug radpivotgrid-features%})
