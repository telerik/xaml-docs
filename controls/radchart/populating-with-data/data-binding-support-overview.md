---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Data Binding Support Overview
slug: radchart-populating-with-data-data-binding-support-overview
tags: data,binding,support,overview
published: True
position: 4
---

# Data Binding Support Overview



Data binding allows you to establish a link between the UI and the underlying business logic and keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order to work, you have to implement the proper notification or to use objects that have already implemented it.

Binding to __RadChart__ involves the following three properties: 

* __RadChart.ItemsSource__ - gets or sets the data source used to generate the content of the chart control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow. 


* __RadChart.SeriesMappings__ - a collection containing __SeriesMapping__ elements. __SeriesMapping__ defines the chart's type and how to map the data from the data source to the chart's [DataPoint]({%slug radchart-populating-with-data-overview%})s. Each __SeriesMapping__ contains a collection of __ItemMapping__ objects, each one defining how the properties of the data source elements map to the values required by the chart (__YValue__, __XValue__, __XCat__, etc.). __RadChart__ also supports automatic binding mode (when no series mappings are defined). Please take a look at the [Data Binding with Automatic Series Mappings]({%slug radchart-populating-with-data-data-binding-with-automatic-series-binding%}) and [Data Binding with Manual Series Mapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%}) topics for more information. 


* __RadChart.DefaultSeriesDefinition__ - gets or sets the default series type for a data bound chart.

## Supported Data Sources

You can bind __RadChart__ to a data source that implements one of the following interfaces:

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx). 


* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections. 


* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists. 


* [IBindingList](http://msdn.microsoft.com/en-us/library/system.componentmodel.ibindinglist.aspx) - extends [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) and supports binding to a data source. 


* [IListSource](http://msdn.microsoft.com/en-us/library/system.componentmodel.ilistsource.aspx) - provides functionality to an object to return a list that can be bound to a data source. 


* Data binding to a collection of collections or nested collections.

## Change Notification Support

__RadChart__ also provides full support for change notification - changes in data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx){% if site.site_name == 'WPF' %}or the {% endif %}[IBindingList](http://msdn.microsoft.com/en-us/library/system.componentmodel.ibindinglist.aspx){% if site.site_name == 'WPF' %} interfaces{% endif %} are properly tracked and reflected by the UI.

Some of the implementations of these interfaces include:

* [Array](http://msdn.microsoft.com/en-us/library/system.array.aspx)

* [ArrayList](http://msdn.microsoft.com/en-us/library/system.collections.arraylist.aspx)

* [CollectionBase](http://msdn.microsoft.com/en-us/library/system.collections.collectionbase.aspx) objects

* [DataTable](http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx)

* [Generic Lists](http://msdn2.microsoft.com/en-us/library/6sh2ey19.aspx)

* [ObservableCollection](http://msdn.microsoft.com/en-us/library/ms668604.aspx)

* [CollectionView](http://msdn.microsoft.com/en-us/library/system.windows.data.collectionview.aspx){% if site.site_name == 'WPF' %}

__RadChart__ also allows you to bind to DataSourceProvider sources (e.g. [XmlDataSourceProvider](http://msdn.microsoft.com/en-us/library/system.windows.data.xmldataprovider.aspx) and [ObjectDataProvider](http://msdn.microsoft.com/en-us/library/system.windows.data.objectdataprovider.aspx)).{% endif %}

>Be careful when you set as data source collections, where you dynamically add/remove items. Some of the charts, like the __Line__ Chart, requires the data to be sorted by the property bound to __XValue__ in order to properly visualize the chart.

## Data binding scenarios

* [Data Binding with Automatic Series Mappings]({%slug radchart-populating-with-data-data-binding-with-automatic-series-binding%})

* [Data Binding with Manual Series Mapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%})

* [Data Binding to Nested Collections]({%slug radchart-populating-with-data-data-binding-to-nested-collections%})

* [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%})

# See Also

 * [Populating With Data Overview]({%slug radchart-populating-with-data-overview%})

 * [Data Binding with Automatic Series Mappings]({%slug radchart-populating-with-data-data-binding-with-automatic-series-binding%})

 * [Data Binding with Manual Series Mapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%})

 * [Data Binding to Nested Collections]({%slug radchart-populating-with-data-data-binding-to-nested-collections%})

 * [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%})

 * [Data Binding to WCF Service]({%slug radchart-populating-with-data-binding-to-wcf%})

 * [Data Binding to ADO.NET Data Service]({%slug radchart-populating-with-data-binding-to-adonet-service%})

 * [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%})

 * [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%})
