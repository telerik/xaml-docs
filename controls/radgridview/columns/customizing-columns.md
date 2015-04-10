---
title: Customizing Columns
page_title: Customizing Columns
description: Customizing Columns
slug: gridview-columns-customizing-columns
tags: customizing,columns
published: True
position: 4
---

# Customizing Columns


There are three parts of the column that can be customized separately from each other - content cells, footer cells and header cells. By customizing the content cell you define the look of all the cells in the column. Customizing the footer cells will affect the appearance of the column footers. And finally the header cells will affect the look of the column headers.

>The customizations apply to all cells of a type. For example, all of the content cells in your column will look alike.

## Content Cells

To change the default appearance of a cell you have to either style it or template it. In order to template it use the __CellTemplate__ property. If you want to style it, define an appropriate style and set the __CellStyle__ property to it (to learn more read the [Styling a Cell]({%slug gridview-styling-cell%}) chapter). 
You can also change the default look of the cell when it is in edit mode by setting the __CellEditTemplate__ property to an appropriate template.

This [help article]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) explains how to set __CellTemplate/CellEditTemplate__ in details.    

>In a scenario when there is a column.CellEditTemplate defined, the new value of the editor is not available in the arguments of the __CellEditEnded__ event raised when commiting an edit. To get the right value in __e.NewValue__, you can create your own [custom column]({%slug radgridview-howto-create-custom-editor %}) and override its __GetNewValueFromEditor__ method.        

This [help article]({%slug gridview-add-button-column%}) explains how to create a __custom column with a button__ in details.
        

This [help article]({%slug radgridview-howto-create-custom-editor%}) explains how to create a __column with a custom editor__ in details.
        

You can also check [CellStyleSelector]({%slug gridview-cell-style-selector%}) and [CellTemplateSelector]({%slug gridview-cell-template-selector%}) topics on how to conditionally apply a cell style or a cell template.
        

## Footer Cells

You are able to change the default look and appearance of both the column and the group footers. To change the column footers style use the __FooterCellStyle__ property (to learn more read the [Styling the Column Footers]({%slug gridview-styling-column-footers%}) topic). To customize the group footers use the __GroupFooterCellStyle__ property (to learn more read the [Styling the Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%}) topic).

To learn more about the group footers take a look at the [Group Footers]({%slug gridview-group-footers%}) topic. For the column footers visit the [Column Footers]({%slug gridview-columns-column-footers%}) topic.

## Header Cells

To change the look and the appearance of the header cells you have to define an appropriate style and set it to the __HeaderCellStyle__ property of the column. To learn how to do that take a look at the [Styling the Column Headers]({%slug gridview-styling-column-headers%}) topic.

To learn more about the column headers take a look at the [Column Headers]({%slug gridview-columns-column-headers%}) topic.

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Add a button column]({%slug gridview-add-button-column%})

 * [Create Custom Editor with RadGridView]({%slug radgridview-howto-create-custom-editor%})

 * [Data Formatting]({%slug gridview-columns-data-formatting%})

 * [Column Headers]({%slug gridview-columns-column-headers%})

 * [Column Footers]({%slug gridview-columns-column-footers%})
