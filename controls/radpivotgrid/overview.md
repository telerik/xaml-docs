---
title: Overview
page_title: Overview
description: Overview
slug: radpivotgrid-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![Rad Pivot Grid Overview SL 01](images/RadPivotGrid_Overview_SL01.png){% endif %}{% if site.site_name == 'WPF' %}![Rad Pivot Grid Overview WPF 01](images/RadPivotGrid_Overview_WPF01.png){% endif %}

Telerik __RadPivotGrid__ is a control used to aggregate millions of records in a concise tabular format. The data can be easily grouped, filtered, sorted and manipulated to create different reports.

{% if site.site_name == 'Silverlight' %}![Rad Pivot Grid Overview SL 2](images/RadPivotGrid_Overview_SL2.png){% endif %}{% if site.site_name == 'WPF' %}![Rad Pivot Grid Overview WPF 2](images/RadPivotGrid_Overview_WPF2.png){% endif %}

__Key features__ list includes:

* __RadPivotGrid__ control provides features for filtering and sorting the data, so you can work with a small part of it.
      			

* __RadPivotGrid__ provides support for multiple datasources:
      			{% if site.site_name == 'WPF' %}

* Support for XMLA access to OLAP Cube.

* Support for ADOMD access to OLAP Cube.

* LocalDataSourceProvider with *ItemsSource* that implements *IEnumerable* interface.
                

* QueryableDataProvider gives you the ability to execute all aggregations and calculations on the database server.
                {% endif %}{% if site.site_name == 'Silverlight' %}

* Support for XMLA access to OLAP Cube.

* LocalDataSourceProvider with *ItemsSource* that implements *IEnumerable* interface.{% endif %}

* Built-in Aggregates: *Sum, Min, Max, Average, Count, etc.*

* Grouping and showing hierarchical structure.

* Applying visual represenation (string formats) to the data: currency, numbers after the decimal point, etc.

* Parallel asynchronous data processing.

* Different Pivot UI Layouts:  Compact, Outline, Tabular.

* Built-in runtime configuration control - [RadPivotFieldList]({%slug radpivotgrid-fieldlist%}).

* Export to different formats - xlsx, docx, pdf, HTML.

* Serialization of the DataProviders, so you can save the current state and load it later.

You can check __RadPivotGrid__ demos at:
     	{% if site.site_name == 'Silverlight' %}[RadPivotGrid FirstLook](http://demos.telerik.com/silverlight/#PivotGrid/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[RadPivotGrid FirstLook](http://demos.telerik.com/wpf/#PivotGrid/FirstLook){% endif %}

# See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})
