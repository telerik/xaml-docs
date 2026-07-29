---
title: Customize the Default Field Filter Editor
page_title: Customize the Default Field Filter Editor
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to customize the default field filter editor.
slug: gridview-filtering-howto-customize-the-default-field-filter-editor
tags: customize,the,default,field,filter,editor
published: True
position: 9
---

# Customize the Default Field Filter Editor

In case you need to slightly modify the default field filter editor that we have provided, you need to attach to the FieldFilterEditorCreated event. The event arguments provide the respective column instance and the editor that we have created in our factory. This event is fired after we have created and configured the editor in the factory and before displaying it in the UI so you get the chance to change its appearance.

Depending on the column DataType the editor will be different. For String columns you will get the StringFilterEditor, for DateTime columns you will get a RadDateTimePicker, for Enum columns you will get a RadComboBox, and for all other types you will get a plain TextBox. Here is an example of how to achieve that:



<snippet id='radgridview-filtering-how-to-howto-customize-the-default-field-filter-editor-block_1-cs' />

<snippet id='radgridview-filtering-how-to-howto-customize-the-default-field-filter-editor-block_1-vb' />



You can adjust anything on the stock field filter editor like this. If the default field filter editor control does not suit your needs you can replace it with a completely different control by following this [article]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%}).

## Filter as user types

In case you need the filtering to be re-applied on every character entered, you may consider using the following approach:



<snippet id='radgridview-filtering-how-to-howto-customize-the-default-field-filter-editor-block_2-cs' />

<snippet id='radgridview-filtering-how-to-howto-customize-the-default-field-filter-editor-block_2-vb' />

