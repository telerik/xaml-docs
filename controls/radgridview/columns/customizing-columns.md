---
title: Customizing Columns
page_title: Customizing Columns
description: Customizing Columns
slug: gridview-columns-customizing-columns
tags: customizing,columns
published: True
position: 6
---

# Customizing Columns

There are three parts of the column that can be customized separately from each other:

* [content cells](#content-cells) - by customizing content cell you define the look of all the cells in the column
* [footer cells](#footer-cells) - customizing footer cells affects the appearance of the column footers
* [header cells](#header-cells) - customizing header cells affects the look of the column headers

## Content Cells

To change the default appearance of a cell you have to either style it or template it:

* In order to template it use __CellTemplate__ property.
* If you want to style it, define an appropriate style targeting all elements of the type or set is as __CellStyle__ for a column. To learn more read the [Styling a Cell]({%slug gridview-styling-cell%}) chapter. 
* You can also change the default look of a cell when it is in edit mode by setting an appropriate __CellEditTemplate__.

This [help article]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) explains how to set __CellTemplate/CellEditTemplate__ in details.    

>In a scenario when there is a column.CellEditTemplate defined, the new value of the editor is not available in the arguments of the __CellEditEnded__ event raised when commiting an edit. To get the right value in __e.NewValue__, you can create your own [custom column]({%slug radgridview-howto-create-custom-editor %}) and override its __GetNewValueFromEditor__ method.        

This [help article]({%slug gridview-add-button-column%}) explains how to create a __custom column with a button__ in details.
        
This [help article]({%slug radgridview-howto-create-custom-editor%}) explains how to create a __column with a custom editor__ in details.
        
You can also check [CellStyleSelector]({%slug gridview-cell-style-selector%}) and [CellTemplateSelector]({%slug gridview-cell-template-selector%}) topics on how to conditionally apply a cell style or a cell template.
        
## Footer Cells

RadGridView provides a way to change the default look and appearance of both column and group footers:
 
* to change column footers' style use __FooterCellStyle__ property. To learn more read the [Styling the Column Footers]({%slug gridview-styling-column-footers%}) topic. 
* to customize group footers' style use __GroupFooterCellStyle__ property. To learn more read the [Styling the Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%}) topic.

To learn more about the group footers take a look at the [Group Footers]({%slug gridview-group-footers%}) topic. For the column footers visit the [Column Footers]({%slug gridview-columns-column-footers%}) topic.

## Header Cells

To change the look and the appearance of header cells you have to define an appropriate style and set it to the __HeaderCellStyle__ property of the column. To learn how to do that take a look at the [Styling the Column Headers]({%slug gridview-styling-column-headers%}) topic.

To learn more about the column headers take a look at the [Column Headers]({%slug gridview-columns-column-headers%}) topic.

>The customizations apply to all cells of a type. 

# See Also

 * [Data Formatting]({%slug gridview-columns-data-formatting%})

 * [Column Headers]({%slug gridview-columns-column-headers%})

 * [Column Footers]({%slug gridview-columns-column-footers%})
 
 * [Add button column]({%slug gridview-add-button-column%})

 * [Create Custom Editor with RadGridView]({%slug radgridview-howto-create-custom-editor%})
 
