---
title: Save/Load Settings
page_title: Save/Load Settings
description: Learn more about the PersistenceFramework control which you can use to save and load settings of RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-overview-saveload-settings
tags: save/load,settings
published: True
position: 10
---

# {{ site.framework_name }} RadGridView Save/Load Settings

You can save and load settings of RadGridView using the [PersistenceFramework]({%slug persistence-framework-overview%}).

For the purpose, you need to create and register a **custom property provider** and persist the complex settings you require (such as filter, sort and group descriptors) as by default, the **PersistenceManager** can only save and load properties which are of a **primitive**, **UIElement** or **IEnumerable** type. More information on the matter can be found in [this article]({%slug persistence-framework-custom-property-provider%}).

{% if site.site_name == 'Silverlight' %}

Good examples on how to achieve this requirement can be found in the "GridView Serialization" demos in the [Silverlight examples application](https://demos.telerik.com/silverlight/#PersistenceFramework/GridViewCustomSerialization) and in our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser).{% endif %}

{% if site.site_name == 'WPF' %}

Good examples on how to achieve this requirement can be found in the "GridView Serialization" demos in the [WPF examples application](https://demos.telerik.com/wpf/) and in our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser).{% endif %}

## See Also

* [RadPersistenceFramework]({%slug persistence-framework-overview%})
* [Custom Property Providers]({%slug persistence-framework-custom-property-provider%})
* [SDK Samples Browser]({%slug sdk-samples-browser%})