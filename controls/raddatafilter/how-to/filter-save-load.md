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

You can save and load settings of RadDataFilter using [PersistenceFramework]({%slug persistence-framework-overview%}) control.

When it comes to saving and loading the user defined filter criteria, you will have to manually go over __RadDataFilter.FilterDescriptors__ collection and save the object graph into format that you can save to your storage. Then, in order to apply the settings back you can parse this saved data and restore the FilterDescriptors back. 

{% if site.site_name == 'Silverlight' %}
For example and a sample code on a similar approach you can check out the "GridView Serialization" online demo [here.](http://demos.telerik.com/silverlight/#PersistenceFramework/GridViewCustomSerialization){% endif %}

{% if site.site_name == 'WPF' %}

For example and a sample code on a similar approach you can check out the "GridView Serialization" WPF Demo [here.](http://demos.telerik.com/wpf/){% endif %}
        
# See Also

 * [Getting Started]({%slug datafilter-getting-started%})

 * [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})

 * [Data Annotations]({%slug raddatafilter-features-data-annotations%})
