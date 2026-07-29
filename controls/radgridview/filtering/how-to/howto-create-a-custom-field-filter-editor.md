---
title: Create a Custom Field Filter Editor
page_title: Create a Custom Field Filter Editor
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to create a custom field filter editor.
slug: gridview-filtering-howto-create-a-custom-field-filter-editor
tags: create,a,custom,field,filter,editor
published: True
position: 10
---

# Create a Custom Field Filter Editor

In case you do not like the default field filter editors that show up in the filtering UI you can easily replace them with your own. To do that you need to inherit from GridViewDataColumn and override the __CreateFieldFilterEditor__ method. You then have to return your editor from this method. You have to data-bind your editor’s significant property to the property called __Value__ which resides on its DataContext. You will also need to define an IValueConverter on this Binding that will be able to convert the FilterDescriptor.UnsetValue to the editor’s “empty” value. When the special singleton value FilterDescriptor.UnsetValue is assigned to a filter descriptor it turns it off. So your custom field filter editor will be able to “clear” or “turn off” the underlying FilterDescriptor.

__Example 1__ shows how to create a RadDateTimePicker and use it as a custom field filter editor. Of course, in real life you will not need to do this since DateTime columns provide RadDateTimePickers automatically. This is juts an example illustrating how to wire up your custom field filter editor.

__Example 1: Overriding the CreateFieldFilterEditor method__

<snippet id='radgridview-filtering-how-to-howto-create-a-custom-field-filter-editor-example_1_overriding_the_createfieldfiltereditor_method-cs' />

<snippet id='radgridview-filtering-how-to-howto-create-a-custom-field-filter-editor-example_1_overriding_the_createfieldfiltereditor_method-vb' />


{% if site.site_name == 'WPF' %}
> You can check out a fully runnable example in the [Create a Custom TimeSpanPickerColumn]({%slug kb-gridview-howto-create-timespanpickercolumn%}) KB article. 
{% endif %}