---
title: Column Headers
page_title: Column Headers
description: See examples of setting value and adding a corresponding picture to the column's header in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-column-headers
tags: column,headers
published: True
position: 5
---

# Column Headers

This topic will guide you through the usage of the column headers, their customization as well through performing different data operations. 

* [Customizing Headers](#customizing-the-headers)
* [Hiding the Headers](#hiding-the-headers)
* [Sorting](#sorting)
* [Filtering](#filtering)
* [Grouping](#grouping)
* [Merging the Headers](#merging-the-headers)
* [Text Properties](#text-properties)

Usually the top cell of a column is called Header. Its purpose is to set a caption for the column, which describes the data displayed in it.

#### __Figure 1: Displaying column headers__ 

![Telerik UI for {{ site.framework_name }} RadGridView displaying standard column headers](images/RadGridView_ColumnHeaders_1.png)

To set value for the header use the __Header__ property of the column. 

__Example 1: Setting the Header Property__

<snippet id='radgridview-columns-column-headers-example_1_setting_the_header_property-xaml' />


The __Header__ property is of type __object__ and you are not limited to just using plain text. For example, you can add a corresponding picture to be displayed as header.

__Example 2: Setting Custom Content to the Header Property__

<snippet id='radgridview-columns-column-headers-example_2_setting_custom_content_to_the_header_property-xaml' />


#### __Figure 2: Displaying custom content in column headers__ 

![Telerik UI for {{ site.framework_name }} RadGridView column header with custom image and text content](images/RadGridView_ColumnHeaders_2.png)

## Customizing the Headers

There are two elements on the headers that can be customized:

* __Header Row__ - it is modified by setting an appropriate style as __HeaderRowStyle__ of __RadGridView__. To learn  how to style it take a look at the [Styling the Header Row]({%slug gridview-styling-header-row%}) topic.
* __Header Cell__ - it is styled by setting __HeaderCellStyle__ for the column, which means that for each column you can have a differently styled header. To learn more about how to style the header cell take a look at the [Styling the Column Headers]({%slug gridview-styling-column-headers%}) topic.

## Hiding the Headers

Column headers can only be hidden by setting __ShowColumnHeaders__ property of __RadGridView__ to __False__.

__Example 3: Setting the ShowColumnHeaders property to False__

<snippet id='radgridview-columns-column-headers-example_3_setting_the_showcolumnheaders_property_to_false-xaml' />


#### __Figure 3: Hiding the column headers__ 

![Telerik UI for {{ site.framework_name }} RadGridView with column headers hidden](images/RadGridView_ColumnHeaders_3.png)

## Sorting

The header of the column plays the main role when we want to sort it. It also hosts all the visual logic around this functionality. When the data is sorted by a column, its header changes its appearance and shows the sort direction via an indicator.

#### __Figure 4: Sorting the column__ 

![Telerik UI for {{ site.framework_name }} RadGridView sorted column header with a sort direction indicator](images/RadGridView_ColumnHeaders_4.png)

>tip As of Q2 2013, the user can benefit from __Column Sort Sequence Indicator__. In order to have this feature enabled you need to set ShowColumnSortIndexes property of RadGridView to True.

To learn more about the sorting functionality take a look at the [Basic Sorting]({%slug gridview-sorting-basics%}) topic in the Sorting chapter.

## Filtering

The header of the column hosts the built-in filtering mechanism, which allows you to filter data by the columns' values.

#### __Figure 5: Filtering the column__ 

![Telerik UI for {{ site.framework_name }} RadGridView column header with the built-in filtering interface](images/RadGridView_ColumnHeaders_5.png)

To learn more about the filtering functionality take a look at the [Basic Filtering]({%slug gridview-filtering-basic%}) topic in the Filtering chapter.

## Grouping

The header is also used for grouping data. It has to be dragged into the group panel at the top of the control in order to get the data grouped by that column.

#### __Figure 6: Grouping the column__ 

![Telerik UI for {{ site.framework_name }} RadGridView column header dragged to the group panel for grouping](images/RadGridView_ColumnHeaders_6.png)

To learn more about the grouping functionality take a look at the [Basic Grouping]({%slug gridview-grouping-basics%}) topic in the Grouping chapter.

## Merging the Headers

Columns in RadGridView can be grouped in __column groups__(added with __Q3 2011__). [Read more]({%slug gridview-column-groups%}).

## Text Properties

As of __Q2 2016__, __GridViewHeaderCell__ exposes __TextWrapping__, __TextAlignment__, __TextTrimming__ and __TextDecorations__ properties. These customizations can be also applied on column level through the __HeaderTextWrapping__, __HeaderTextAlignment__, __HeaderTextTrimming__ and __HeaderTextDecorations__ properties. If the same property is set to __both elements__, the value of the one corresponding to __GridViewColumn__ will be respected.


__Example 5: Setting the Text Properties of GridViewHeaderCell and GridViewColumn__
<snippet id='radgridview-columns-column-headers-example_5_setting_the_text_properties_of_gridviewheadercell_and_gridviewcolumn-xaml' />


#### Figure 5: Setting the text properties of GridViewHeaderCell and GridViewColumn

![Telerik UI for {{ site.framework_name }} RadGridView column headers using custom text alignment, trimming, and decorations](images/gridview-header-textproperties.png)

Note, that the first column has a __HeaderCellStyle__ defined, which aligns the content of the __HeaderCell__ to the left, but the __Style__ is not applied, as the __HeaderTextAlignment__ of __GridViewColumn__ is also being set.
        
## See Also
 * [Column Footers]({%slug gridview-columns-column-footers%}) 
 * [Column Groups]({%slug gridview-column-groups%})
 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})
