---
title: GridView ItemsSourceProvider
page_title: GridView ItemsSourceProvider
description: GridView ItemsSourceProvider
slug: multicolumncombobox-gridview-itemssourceprovider
tags: gridview, itemssource, provider
published: True
position: 4
---

# GridView ItemsSourceProvider

By default, __RadMultiColumnComboBox__ will have the RadGridView component integrated as its DropDown. For this purpose, the control utilizes the __GridViewItemsSourceProvider__.  This article will go through the different functionalities of RadGridView supported by the __GridViewItemsSourceProvider__.

## Alternation

In case when readability needs to be improved, the alternation support comes in handy. The following set of properties are provided for manipulating it.

> More information can be found in the [Alternating Rows]({%slug radgridview-rows-alternating-rows%}) and [RowStyleSelector]({%slug gridview-rowstyleselector%}) topics.

* __AlternationCount__: The interval for each alternated row. For example, if each second row needs to be alternated the value can be set to 2.
* __AlternateRowStyle__: The alternated __GridViewRow__ can be styled through it.
* __AlternateRowStyleSelector__: Conditional styling support for the alternated rows.

## Columns

> The topic is discussed in details in the [Defining Columns]({%slug gridview-columns-defining-columns%}) article.

Both manual and automatic column definitions are supported. Also, the width of the columns of RadGridView can be set. The following two properties are exposed by __GridViewItemsSourceProvider__ for this purpose.

* __AutoGenerateColumns__: A boolean property determining whether the columns will be automatically or manually generated. Its default value is __True__.
* __ColumnWidth__: The value set to it will be applied to all columns of RadGridView.

## Rows Styling

> More info can be found in the [Styling Rows]({%slug gridview-styling-a-row%}) and [RowStyleSelector]({%slug gridview-rowstyleselector%}) topics.

In order to style the rows of __RadGridView__ the __GridViewItemsSourceProvider__ provides the following two mechanisms.

* __RowStyle__: Through it a __Style__ targeting all __GridViewRow__ elements can be defined.
* __RowStyleSelector__: Used in case styling the rows needs to be applied conditionally based on the bound data.

## Keyboard support

> This functionality is covered in details in the [Keyboard Command Provider]({%slug gridview-commands-keyboardcommandprovider%}) topic.

By default, __RadGridView__ will execute a certain command corresponding to a given keyboard scenario. __GridViewItemsSourceProvider__ supports implementing a custom Keyboard Command Provider through the __CustomCommandProvider__ property. Thus, the whole user interaction with the control through the keyboard can be customized.

## Column Headers and Footers

The visibility of the column headers and footers can be controlled through the following boolean properties of __GridViewItemsSourceProvider__. 

* __ShowColumnHeaders__: The default value is __True__ meaning that the column headers will be visible. Setting it to __False__ will hide them.
* __ShowColumnFooters__: The default value is __False__ meaning that the column footers will be hidden. Setting it to __True__ will make them visible.

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})
* [Key Properties and Methods]({%slug multicolumncombobox-dropdown-key-properties-and-methods%})
