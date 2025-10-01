---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-populating-with-data-overview
tags: overview
published: True
position: 0
---

# Overview



In order to display a chart, you have to populate __RadChart__ control with some data. You can do that in two ways:

* Manually, by adding chart points - __DataPoints__. 


* With data binding by using __SeriesMapping/ItemMapping__.

In this section you will find:

* [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%}) and  [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%}) - explains how to create a chart in XAML and in the code-behind with some static data. 


* Data binding [overview]({%slug radchart-populating-with-data-data-binding-support-overview%}) - here you will find information about the supported data sources and __RadChart__'s data binding basics. 


* [Data Binding with Automatic Series Mappings]({%slug radchart-populating-with-data-data-binding-with-automatic-series-binding%}) and [Data Binding with Manual Series Mapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%})

* [Data Binding to Nested Collections]({%slug radchart-populating-with-data-data-binding-to-nested-collections%})

* [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%})

## Understanding DataPoint

__DataPoint__ class represents a single piece of data that is visualized in a chart series. Each __DataPoint__ has various properties that allow you to define every chart piece, such as: __XValue__, __YValue__, __BubleSize__, etc. Notice that depending on the selected chart type only a subset of them will be applied to the distinct chart series e.g. __DataPoint.BubbleSize__ is applicable only to __Bubble__ / __Bubble3D__ series types, while the __Open__, __Close__, __High__, __Low__ values are applicable only to __Stick__ / __CandleStick__ charts.

However, even if some of the __DataPoint__ properties are not required for the selected chart type, you can still bind or set them in order to use their values to format the item labels and/or tooltips. See [Format Expressions]({%slug radchart-features-format-expressions%}).

Usually, data points are used when you want to show a chart with static data. For more information take a look at the [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%}) topic and the [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%}) topic.

## Understanding SeriesMapping/ItemMapping

Data binding is one of the most powerful features provided by the .Net platform, that makes it easier to bind UI with the business logic. __RadChart__ control supports data binding via __SeriesMapping__ / __ItemMapping.__

__SeriesMapping__ is used to define a single chart series. You need to add a separate __SeriesMapping__ for each chart series that you would like to create from the data bound to the chart control. Each __SeriesMapping__ holds a collection of __ItemMapping__ instances which define the relation between individual data fields (in the context of the __RadChart.ItemsSource__) and the chart series fields (in the context of __DataPointMember__ values) i.e. if you would like to bind the __XValue__ and __YValue__ of a __Bar__ chart series items, you need to add a single __SeriesMapping__ instance with two __ItemMapping__ instances for the __DataPointMember.XValue__ and the __DataPointMember.YValue__ relations respectively.

__DataPointMember__ and __DataPoint__ classes are related. For each data item of the underlying data source, __RadChart__ will create an instance of __DataPoint__ and depending on the value of __ItemMapping.DataPointMember__ will set the value of the corresponding property. What happens if you have __SeriesMapping__ with two __ItemMapping__ instances for the __DataPointMember.XValue__ and the __DataPointMember.YValue__. __RadChart__ will create one __DataPoint__ where __DataPoint.XValue__ will be set to the value of the data field specified for __DataPointMember.XValue__ and __DataPoint.YValue__ with the value of the data field specified for the __DataPointMember.YValue__.

More about data binding and supported data types you can see [here]({%slug radchart-populating-with-data-data-binding-support-overview%}).

## See Also

 * [Creating a Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%})

 * [Creating a Chart in Code-behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})

 * [Data Binding to Nested Collections]({%slug radchart-populating-with-data-data-binding-to-nested-collections%})

 * [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%})

 * [Data Binding to WCF Service]({%slug radchart-populating-with-data-binding-to-wcf%})

 * [Data Binding to ADO.NET Data Service]({%slug radchart-populating-with-data-binding-to-adonet-service%})
