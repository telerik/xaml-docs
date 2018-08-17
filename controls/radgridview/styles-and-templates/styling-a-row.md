---
title: Styling Rows
page_title: Styling Rows
description: Styling Rows
slug: gridview-styling-a-row
tags: styling,rows
published: True
position: 14
---

# Styling Rows

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewRow]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewrow).

In this article we will discuss the following topics:

* [Targeting the GridViewRow Element](#targeting-the-gridviewrow-element)

* [Setting RadGridView's RowStyle and AlternateRowsStyle](#setting-radgridviews-rowstyle-and-alternaterowsstyle)

* [Setting RadGridView's RowStyleSelector and AlternateRowsStyleSelector](#setting-radgridviews-rowstyleselector-and-alternaterowsstyleselector)

#### __Figure 1: GridViewRow template structure__

![GridViewRow template structure](images/gridview-row-template.png)

## Targeting the GridViewRow Element

In order to style all RadGridView rows of an application, you should create an appropriate style targeting the __GridViewRow__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all rows of an application__

	{{region xaml-gridview-styling-row-1}}
	<Style TargetType="telerik:GridViewRow">
	    <Setter Property="Background" Value="Red"/>
	    <Setter Property="Foreground" Value="White"/>
	</Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewRowStyle__ and __AlternateGridViewRowStyle__.

## Setting RadGridView's RowStyle and AlternateRowStyle

__RadGridView__ exposes the __RowStyle__ and __AlternateRowStyle__ properties of type __Style__. __GridViewRow__ elements can be styled by providing an appropriate style for each of these properties.

>In order to use the __AlternateRowStyle__, you should first set the **AlternationCount** property of your __RadGridView__. For example, if you want to alternate each second row, you have to set its value to 2.

#### __[XAML] Example 2: Setting a column's CellStyle__

	{{region xaml-gridview-styling-row-2}}
	<telerik:RadGridView RowStyle="{StaticResource GridViewRowStyle}"
	AlternationCount="2"
	AlternateRowStyle="{StaticResource GridViewAlternateRowStyle}" />
{{endregion}}

#### __Figure 2: RadGridView with styled rows__

![RadGridView with styled cells](images/gridview-styled-row-and-alternaterow.png)

## Setting RadGridView's RowStyleSelector and AlternateRowsStyleSelector

You could also use RadGridView's **RowStyleSelector** and **AlternateRowsStyleSelector** properties to style rows differently based on a specific condition. More details about how this can be achieved can be found in the [RowStyleSelector article]({%slug gridview-rowstyleselector%}).

## See Also

 * [Alternating Rows]({%slug radgridview-rows-alternating-rows%})

 * [Styling the Row Details]({%slug gridview-styling-row-details%})

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})
