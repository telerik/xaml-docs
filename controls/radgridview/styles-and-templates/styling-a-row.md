---
title: Styling Rows
page_title: Styling Rows
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to set the background of the selected row.
slug: gridview-styling-a-row
tags: styling,rows
published: True
position: 14
---

# Styling Rows

> `RadGridView` supports setting the background color of the selected row, as well as setting the mouse-over color of the row. More information can be found in the [SelectedBackground and MouseOverBackground]({%slug radgridview-rows-selected-background%}) article.

#### __GridViewRow template structure__

![Telerik UI for {{ site.framework_name }} RadGridView showing the GridViewRow template structure](images/gridview-row-template.png)

## Targeting the GridViewRow Element

In order to style all RadGridView rows of an application, you should create an appropriate style targeting the `GridViewRow` element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

> To learn how to modify the default `GridViewCell` style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

__Styling all rows of an application__
<snippet id='radgridview-styles-and-templates-styling-a-row-styling_all_rows_of_an_application-xaml' />


> If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewRowStyle__.

## Setting RadGridView's RowStyle and AlternateRowStyle

`RadGridView` exposes the `RowStyle` and `AlternateRowStyle` properties of type `Style`. `GridViewRow` elements can be styled by providing an appropriate style for each of these properties.

> In order to use the `AlternateRowStyle`, you should first set the `AlternationCount` property of your RadGridView. For example, if you want to alternate each second row, you have to set its value to 2.

__Creating styles for the RowStyle and AlternativeRowStyle properties__

<snippet id='radgridview-styles-and-templates-styling-a-row-creating_styles_for_the_rowstyle_and_alternativerowstyle_properties-xaml' />


__Applying styles to the RowStyle and AlternateRowStyle properties__
<snippet id='radgridview-styles-and-templates-styling-a-row-applying_styles_to_the_rowstyle_and_alternaterowstyle_properties-xaml' />


#### __RadGridView with styled rows__

![Telerik UI for {{ site.framework_name }} RadGridView with custom RowStyle and AlternateRowStyle applied](images/gridview-styled-row-and-alternaterow.png)

## Setting RadGridView's RowStyleSelector and AlternateRowsStyleSelector

You could also use RadGridView's `RowStyleSelector` and `AlternateRowsStyleSelector` properties to style rows differently based on a specific condition. More details about how this can be achieved can be found in the [RowStyleSelector article]({%slug gridview-rowstyleselector%}).

## See Also

 * [Alternating Rows]({%slug radgridview-rows-alternating-rows%})

 * [Styling the Row Details]({%slug gridview-styling-row-details%})

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})
