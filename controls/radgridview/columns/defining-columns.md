---
title: Defining Columns
page_title: Defining Columns
description: See examples of how you can define, either automatically or manually, the columns in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-defining-columns
tags: defining,columns
published: True
position: 0
---

# Defining Columns

__RadGridView__ provides two mechanisms for defining its columns: 

* [Automatic columns definition](#automatic-columns-generation) based on the underlying data source. 

* [Manual columns definition](#manual-columns-definition) in XAML or code-behind. 

This help article explains how to do both with code examples. You can also 
[copy properties from one column to another](#copying-properties-from-another-column).

## Automatic Columns Generation

By default, __RadGridView__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of __RadGridView__ to a collection of employees (see code in __Example 1__ and the result in __Figure 1__), the control will create a separate column for each public property of the __Employee__ object.

Specific editors will be generated for the following types:

* **String**: **TextBox** editor (default)
* **Boolean**: **CheckBox** editor accompanied by **GridViewCheckBox** element displayed in view mode 
* **DateTime**: **RadDatePicker** editor

However, if you wish to explicitly specify the column name for certain property of your data class or to prevent the creation of a column for it, use the __System.ComponentModel.DataAnnotations.DisplayAttribute__, as it is shown in **Example 1**.

__Example 1: Defining the business object__

<snippet id='radgridview-columns-defining-columns-example_1_defining_the_business_object-cs' />


__Defining the business object__

<snippet id='radgridview-columns-defining-columns-defining_the_business_object-vb' />


If you wish to further customize the generated columns, you can handle the [AutoGeneratingColumn]({%slug gridview-column-resize-event%}#autogeneratingcolumn) event as shown in **Example 2**.

__Example 2: Customizing auto-generated columns__

<snippet id='radgridview-columns-defining-columns-example_2_customizing_auto_generated_columns-cs' />

<snippet id='radgridview-columns-defining-columns-example_2_customizing_auto_generated_columns-vb' />


## Manual Columns Definition

Using the built-in auto generation of columns does not fit all scenarios. In such cases you can manually define the needed columns. When defining a column you can choose between several column types:

*  [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) 
*  [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%})
*  [Data Column]({%slug radgridview-columns-column-types-data-column%})
*  [Hyperlink Column]({%slug radgridview-columns-column-types-hyperlink-column%}) 
*  [Dynamic Hyperlink Column]({%slug radgridview-columns-column-types-dynamic-hyperlink-column%})
*  [Expression Column]({%slug gridview-expression-column%})
*  [Image Column]({%slug radgridview-columns-columntypes-image-column%})
*  [Select Column]({%slug radgridview-columns-column-types-select-column%})
*  [CheckBox Column]({%slug gridview-checkbox-column%})
*  [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})
{% if site.site_name == 'WPF' %}*  [MultiColumnComboBox Column]({%slug radgridview-columns-column-types-multicolumncombobox-column%}){% endif %}
*  [Masked Input Column]({%slug radgridview-columns-column-types-masked-input-column%})
*  [Toggle Row Details Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}).

You must add the columns to the __Columns__ collection of __RadGridView__. Later on in the application lifecycle, you can easily access them via the **Columns** indexer by specifying the name of the property the column is bound to or the index of the column.

Examples 2 and 3 demonstrate how to define a column both in XAML and code-behind.

__Example 3: Defining a GridViewDataColumn declaratively__

<snippet id='radgridview-columns-defining-columns-example_3_defining_a_gridviewdatacolumn_declaratively-xaml' />


>You will find the column types in the same namespace (__Telerik.Windows.Controls__) and assembly (__Telerik.Windows.Controls.GridView.dll__) as __RadGridView__.

__Example 4: Defining a GridViewDataColumn programmatically__

<snippet id='radgridview-columns-defining-columns-example_4_defining_a_gridviewdatacolumn_programmatically-cs' />


__Example 4: Defining a GridViewDataColumn programmatically__

<snippet id='radgridview-columns-defining-columns-example_4_defining_a_gridviewdatacolumn_programmatically-vb' />


You can then set the column's __Header__ property and add the column to the __Columns__ collection. The __default Header__ will be the property specified as __DataMemberBinding__.
			  
__Example 5: Defining a column declaratively with DataMemberBinding property set__

<snippet id='radgridview-columns-defining-columns-example_5_defining_a_column_declaratively_with_datamemberbinding_property_set-xaml' />


__Example 6: Defining a column programmatically with UniqueName property set__

<snippet id='radgridview-columns-defining-columns-example_6_defining_a_column_programmatically_with_uniquename_property_set-cs' />


__Example 6: Defining a column programmatically with UniqueName property set__

<snippet id='radgridview-columns-defining-columns-example_6_defining_a_column_programmatically_with_uniquename_property_set-vb' />


Similarly, you can set any of the column's other properties or [copy them from another column](#copying-properties-from-another-column).

To access the column later, use the string used for the DataMemberBinding value or its __column index__ as a key for the __Columns__ collection.

__Example 7: Accessing a column by index__

<snippet id='radgridview-columns-defining-columns-example_7_accessing_a_column_by_index-cs' />


__Example 7: Accessing a column by index__

<snippet id='radgridview-columns-defining-columns-example_7_accessing_a_column_by_index-vb' />



## Copying Properties from Another Column

__RadGridView__ provides a mechanism for easily fetching the properties of one column to another. This can be done through the __CopyPropertiesFrom__ method of __GridViewColumn__. 

__Example 8: Copying the properties of one column to another__

<snippet id='radgridview-columns-defining-columns-example_8_copying_the_properties_of_one_column_to_another-cs' />


__Example 8: Copying the properties of one column to another__

<snippet id='radgridview-columns-defining-columns-example_8_copying_the_properties_of_one_column_to_another-vb' />


## See Also

 * [Basic Column]({%slug radgridview-columns-column-types-basic-column%})
 
 * [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})
 
 * [Column Groups]({%slug gridview-column-groups%})

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
