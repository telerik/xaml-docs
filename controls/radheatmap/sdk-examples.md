---
title: SDK Example
page_title: SDK Example
description: SDK Example
slug: radheatmap-sdk-examples
tags: sdk,example
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadHeatMap__.

## List of all RadHeatMap SDK examples:

{% if site.site_name == 'WPF' %}

* __[Colorizers Categorical definition](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/WPF/Colorizers_CategoricalDefinition)__ - This example aims to walk you through colorizers in categorical definition. The only difference between the Categorical and the Horizontal/Vertical definition is that in the Categorical only one colorizer at a time can be applied. Besides this, the colorizers behave in the same way
* __[Colorizers Vertical definition](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/WPF/Colorizers_VerticalDefinition)__ - This example aims to walk you through colorizers in Vertical definition. In the scenario of Vertical Definition, the colorizer is defined in the MemberMappings of the corresponding definition.
* __[Drag to select](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/WPF/DragToSelect)__ - An example that demonstrates how easily you can implement drag-to-select with the heatmap, using the custom utilities class.
* __[Populating with data](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/WPF/PopulatingWithData)__ - This example aims to demonstrate the data binding feature of RadHeatMap. You can bind the RadHeatMap to any source that implements one of the following interfaces:   - IEnumerable - supports simple iteration of a collection. See the MSDN article for more on IEnumerable.   - ICollection - extends IEnumerable and supports size, enumerator, and synchronization methods for collections.   - IList - extends ICollection and is the base class for lists. 
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Colorizers Categorical definition](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/SL/Colorizers_CategoricalDefinition)__ - This example aims to walk you through colorizers in categorical definition. The only difference between the Categorical and the Horizontal/Vertical definition is that in the Categorical only one colorizer at a time can be applied. Besides this, the colorizers behave in the same way
* __[Colorizers Vertical definition](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/SL/Colorizers_VerticalDefinition)__ - This example aims to walk you through colorizers in Vertical definition. In the scenario of Vertical Definition, the colorizer is defined in the MemberMappings of the corresponding definition.
* __[Drag to select](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/SL/DragToSelect)__ - An example that demonstrates how easily you can implement drag-to-select with the heatmap, using the custom utilities class.
* __[Populating with data](https://github.com/telerik/xaml-sdk/tree/master/HeatMap/SL/PopulatingWithData)__ - This example aims to demonstrate the data binding feature of RadHeatMap. You can bind the RadHeatMap to any source that implements one of the following interfaces:   - IEnumerable - supports simple iteration of a collection. See the MSDN article for more on IEnumerable.   - ICollection - extends IEnumerable and supports size, enumerator, and synchronization methods for collections.   - IList - extends ICollection and is the base class for lists. 
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).