---
title: Styling FilterRow
page_title: Styling FilterRow
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to style the FilterRow element.
slug: gridview-styling-filterrow
tags: styling,filterrow
published: True
position: 20
---

# Styling Filter Row

This article shows how to style the filter row element in RadGridView.

![Telerik UI for {{ site.framework_name }} RadGridView showing the default FilterRow appearance](images/RadGridView_Styles_and_Templates_Styling_FilterRow_01.PNG)

## Type of Editors

The type of the actual editor, which is determined, created and inserted at runtime, depends on the __DataType__ of the column.

Here are the four different scenarios that you can get:

* String: __StringFilterEditor__
* DateTime: __RadDateTimePicker__
* Boolean: Nothing
* Other: __TextBox__

>tip When the DataType of the column is of __Boolean__ type, you will have **IsTrue** and **IsFalse** filter operators in the drop-down. For that reason, you do not need an editor.
      
## Modifying the StringFilterEditor's Style

The __StringFilterEditor__ is nothing more than a __TextBox__ and a __ToggleButton__ wrapped in a control. In order to change __StringFilterEditor__'s visual appearance, you should modify its default style.

>To learn how to modify the default StringFilterEditor style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

__Example 1: Styling the StringFilterEditor__

<snippet id='radgridview-styles-and-templates-styling-filterrow-example_1_styling_the_stringfiltereditor-xaml' />


>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __StringFilterEditorStyle__.
          
## Modifying the FieldFilterControl's Style

In order to change RadDropDownButton's (the funnel) visual appearance, you should create an appropriate style, targeting the **FieldFilterControl** element.

__Example 2: Styling the FieldFilterControl__

<snippet id='radgridview-styles-and-templates-styling-filterrow-example_2_styling_the_fieldfiltercontrol-xaml' />


>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __FieldFilterControlStyle__.

## Modifying Other Editors

Since the created editor will be inserted as the **Content** of __PART_FilterEditorContentControl__, you can attach to a __FieldFilterEditorCreated__ event and apply the respective style to the respective editor. For example, if the editor is a plain __TextBox__, you can change its __Background__ like so:

__Example 3: Setting a background for the filtering row TextBox__

<snippet id='radgridview-styles-and-templates-styling-filterrow-example_3_setting_a_background_for_the_filtering_row_textbox-cs' />

<snippet id='radgridview-styles-and-templates-styling-filterrow-example_3_setting_a_background_for_the_filtering_row_textbox-vb' />


#### __Figure 2: RadGridView with styled filter row__

![Telerik UI for {{ site.framework_name }} RadGridView with a custom styled FilterRow](images/gridview-styled-filter-row.png)

## See Also

 * [Styling the FilteringControl]({%slug gridview-styling-filteringcontrol%})
