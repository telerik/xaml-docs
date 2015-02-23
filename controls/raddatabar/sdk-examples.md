---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: raddatabar-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadDataBar__.

## List of all RadDataBar SDK examples:

{% if site.site_name == 'WPF' %}

* __[Data bar properties](https://github.com/telerik/xaml-sdk/tree/master/DataBar/WPF/DataBarProperties)__ - This example aims to get you familiar with the specific properties of each databar type.
* __[Data binding](https://github.com/telerik/xaml-sdk/tree/master/DataBar/WPF/DataBinding)__ - Databinding for the RadDataBar control involves the correlation between the business logic/data, and the visualization of the control. The DataBinding involves the following three properties:   - ItemsSource (a property of RadStackedDataBar and RadStacked100Databar) - gets or sets the data source used to generate the content of the databar control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.   - Value (a property of RadDataBar) - expects a value which will be used to determine the size of the bar.   - ValuePath (a property of RadStackedDataBar and RadStacked100DataBar) - expects the name of the property from the underlying datasource, which will determine the value of each bar in the stack.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Data bar properties](https://github.com/telerik/xaml-sdk/tree/master/DataBar/SL/DataBarProperties)__ - This example aims to get you familiar with the specific properties of each databar type.
* __[Data binding](https://github.com/telerik/xaml-sdk/tree/master/DataBar/SL/DataBinding)__ - Databinding for the RadDataBar control involves the correlation between the business logic/data, and the visualization of the control. The DataBinding involves the following three properties:   - ItemsSource (a property of RadStackedDataBar and RadStacked100Databar) - gets or sets the data source used to generate the content of the databar control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.   - Value (a property of RadDataBar) - expects a value which will be used to determine the size of the bar.   - ValuePath (a property of RadStackedDataBar and RadStacked100DataBar) - expects the name of the property from the underlying datasource, which will determine the value of each bar in the stack.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).