---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-overview
tags: overview
published: True
position: 0
CTAControlName: RadPivotGrid
---

# {{ site.framework_name }} RadPivotGrid Overview

Thank you for choosing __RadPivotGrid__!	

RadPivotGrid is a control used to aggregate millions of records in a concise tabular format. The data can be easily grouped, filtered, sorted and manipulated to create different reports.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

{% if site.site_name == 'Silverlight' %}![Rad Pivot Grid Overview SL 2](images/RadPivotGrid_Overview_SL2.png){% endif %}{% if site.site_name == 'WPF' %}![Rad Pivot Grid Overview WPF 2](images/RadPivotGrid_Overview_WPF2.png){% endif %}

As every control from UI for {{ site.framework_name }}, RadPivotGrid comes with a set of pre-defined themes. You can also design your own templates for a completely custom look.

## Key Features

* __Filtering and Sorting__  			

* __Multiple Data Sources Support__:
	{% if site.site_name == 'WPF' %}

	* Support for XMLA access to OLAP Cube.

	* Support for ADOMD access to OLAP Cube.

	* LocalDataSourceProvider with *ItemsSource* that implements *IEnumerable* interface.

	* QueryableDataProvider gives you the ability to execute all aggregations and calculations on the database server.
	{% endif %}
	{% if site.site_name == 'Silverlight' %}

	* Support for XMLA access to OLAP Cube.

	* LocalDataSourceProvider with *ItemsSource* that implements *IEnumerable* interface.
	{% endif %}

* __Built-in Aggregates__: *Sum, Min, Max, Average, Count, etc.*

* __Grouping__

* __Data Formatting__: Currency, numbers after the decimal point, etc.

* __Parallel Asynchronous Data Processing__

* __Different Pivot UI Layouts__:  Compact, Outline, Tabular.

* __Built-in Runtime Configuration Control__: [RadPivotFieldList]({%slug radpivotgrid-fieldlist%}).

* __Export to Different Formats__: xlsx, docx, pdf, HTML.

* __DataProvider Serialization__: Save the current state and load it later.

>tip Get started with the control with its [Getting Started]({%slug radpivotgrid-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the online examples at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#PivotGrid/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})