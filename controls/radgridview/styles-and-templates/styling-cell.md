---
title: Styling Cells
page_title: Styling Cells
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to create an appropriate style targeting the Cell element.
slug: gridview-styling-cell
tags: styling,cells
published: True
position: 4
---

# Styling Cells

In this article, we discuss various approaches to style the RadGridView cells.

__GridViewCell template structure__

![Telerik UI for {{ site.framework_name }} RadGridView showing the GridViewCell template structure](images/gridviewcell-template.png)

## Styling all RadGridView Cells

> The examples from this article assume that the RadGridView is set up as demonstrated in its [Getting Started]({%slug gridview-getting-started2%}) article.

To style all `RadGridView` cells of an application, create a style that targets the `GridViewCell` element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and [modify it]({%slug gridview-modifying-default-styles%}).

__Styling all cells of an application__

<snippet id='radgridview-styles-and-templates-styling-cell-styling_all_cells_of_an_application-xaml' />


>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), base your style on the `GridViewCellStyle` that is defined for the corresponding theme.

__RadGridView with styled cells in the Office2016 theme__

![Telerik UI for {{ site.framework_name }} RadGridView with custom styled cells in the Office2016 theme](images/RadGridView-Cell-Styled.png)

## Setting a Column's CellStyle

You can also style __RadGridView Cells__ by creating an appropriate `Style` for the `GridViewCell` element and setting it as the `CellStyle` property of the respective __GridView Column__. 

__Setting a column's CellStyle__
<snippet id='radgridview-styles-and-templates-styling-cell-setting_a_column_s_cellstyle-xaml' />


## Setting a Column's CellStyleSelector

You could also use a column's `CellStyleSelector` property to style cells differently based on a specific condition. For more details about this approach, see the [CellStyleSelector article]({%slug gridview-cell-style-selector%}).

## Setting the SelectedBackground of the Cell

You can set the Background of the selected cell by setting the `SelectedBackground` property of the GridViewCell element.

__Setting the SelectedBackground of the GridViewCell__
<snippet id='radgridview-styles-and-templates-styling-cell-setting_the_selectedbackground_of_the_gridviewcell-xaml' />


__Result when setting the SelectedBackground property in the Office2016 theme__

![Telerik UI for {{ site.framework_name }} RadGridView showing a custom SelectedBackground on grid cells](images/gridview-selectedbackground-cell.png)

## Setting the BorderBrush of the CurrentCell

You can set the BorderBrush of the current cell, by setting the `CurrentBorderBrush` property of the GridViewCell. 

The following example demonstrates how to set the BorderBrush of the current cell to transparent.

__Setting the CurrentBorderBrush of the GridViewCell__
<snippet id='radgridview-styles-and-templates-styling-cell-setting_the_currentborderbrush_of_the_gridviewcell-xaml' />


__Result when setting the CurrentBorderBrush property in the Office2016 theme__

![Telerik UI for {{ site.framework_name }} RadGridView with the current cell border brush set to transparent](images/gridview-currentborderbrush.png)

> After you have set the `CurrentBorderBrush` to `Transparent`, if you start navigating through the cells with the keyboard, you will be able to see the FocusVisual border. If you want to hide it as well, you can set the `FocusVisualStyle` of the GridViewCell to null through a style similar to the above example.

## Setting the MouseOverBackground of the Cell

You can change the MouseOver Background of the cells through the `MouseOverBackground` property of the GridViewCell. This is demonstrated in the following example.

__Setting the MouseOverBackground of the GridViewCell__
<snippet id='radgridview-styles-and-templates-styling-cell-setting_the_mouseoverbackground_of_the_gridviewcell-xaml' />


__Result when setting the MouseOverBackground property in the Office2016 theme__

![Telerik UI for {{ site.framework_name }} RadGridView with a custom MouseOverBackground applied to cells](images/gridviewcell-mouseoverbackground.png)

> In order for the MouseOverBackground of the cell to take effect, set the [SelectionUnit]({%slug gridview-selection-basics%}#selection-units) of RadGridView to `Mixed` or `Cell`.

## Setting the HighlightedBackground of the Cell

You can change the highlighted background color of a matched `GridViewCell` element when search as you type is performed. This color can be modified through the `HighlightedBackground` property.

__Setting the HighlightedBackground of the GridViewCell__
<snippet id='radgridview-styles-and-templates-styling-cell-setting_the_highlightedbackground_of_the_gridviewcell-xaml' />


__Result when setting the HighlightedBackground property in the Office2016 theme__

![Telerik UI for {{ site.framework_name }} RadGridView with a custom HighlightedBackground for matched search cells](images/gridviewcell-matched-highlighted-background.png)

## See Also

 * [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})

 * [Change Background for Disabled Grid Elements]({%slug gridview-how-to-set-background-disabled-cell%})
