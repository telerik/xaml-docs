---
title: Save/Load Settings
page_title: Save/Load Settings
description: Save/Load Settings
slug: raddatafilter-how-to-filter-save-load
tags: datafilter, save, load, settings
published: True
position: 2
---

# Persisting Settings

You can save and load settings of RadDataFilter by using the [RadPersistenceFramework]({%slug persistence-framework-overview%}) control.

When it comes to saving and loading the user defined filter criteria, you will have to define a [custom property provider]({%slug persistence-framework-custom-property-provider%}) for the __RadDataFilter.FilterDescriptors__ collection.

{% if site.site_name == 'Silverlight' %}
For a good example and sample code of a similar approach, you can check out the "GridView Serialization" online demo [here](http://demos.telerik.com/silverlight/#PersistenceFramework/GridViewCustomSerialization).
{% endif %}

{% if site.site_name == 'WPF' %}
For a good example and sample code of a similar approach, you can check out the "GridView Serialization" demo in the [WPF Controls Samples](http://demos.telerik.com/wpf/).
{% endif %}
        
## See Also

* [RadPersistenceFramework]({%slug persistence-framework-getting-started%})
* [Custom Property Provider]({%slug persistence-framework-custom-property-provider%})
* [Getting Started]({%slug datafilter-getting-started%})
* [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})
* [Data Annotations]({%slug raddatafilter-features-data-annotations%})
