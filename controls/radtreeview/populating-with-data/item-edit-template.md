---
title: ItemEditTemplate
page_title: ItemEditTemplate
description: Check our &quot;ItemEditTemplate&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-item-edit-template
tags: itemedittemplate
published: True
position: 10
---

# ItemEditTemplate

Telerik __RadTreeView__ supports defining a DataTemplate that controls how the items can be edited through the __ItemEditTemplate__. This tutorial will walk you through the common task of creating and applying an __ItemEditTemplate__.

> The definition of the __RadTreeViewSampleData__ class is the same as in the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) article. 

## Defining a RadTreeView and an ItemEditTemplate

__Example 1__ demonstrates how to define a RadTreeView in xaml and setup a DataTemplate that will be used for editing the items. This DataTemplate is displayed when an item enters edit mode (for example after pressing the __F2__ key).

{% if site.site_name == 'Silverlight' %}
__Example 1: Defining the ItemEditTemplate__
<snippet id='radtreeview-populating-with-data-item-edit-template-block_1-xaml' />

{% endif %}
{% if site.site_name == 'WPF' %}
__Example 1: Defining the ItemEditTemplate__
<snippet id='radtreeview-populating-with-data-item-edit-template-block_2-xaml' />
{% endif %}

{% if site.site_name == 'WPF' %}
#### __Figure 1: Result from Example 1 in the Fluent theme__
![RadTreeView in edit mode](images/RadTreeView_TemplatingItemEditTemplate_070.PNG)
{% endif %}

>Don't forget to set the __IsEditable__ property of your __RadTreeView__ to __True__.

## See Also
 * [ItemEditTemplateSelector]({%slug radtreeview-populating-with-data-item-edit-template-selector%})
 * [ItemTemplate]({%slug radtreeview-populating-with-data-item-template%})
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})