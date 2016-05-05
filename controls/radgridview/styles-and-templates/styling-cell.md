---
title: Styling Cells
page_title: Styling Cells
description: Styling Cells
slug: gridview-styling-cell
tags: styling,cells
published: True
position: 4
---

# Styling Cells

>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the GridViewCell]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewcell).

#### __Figure 1: GridViewCell template structure__

![RadGridView template structure](images/gridviewcell-template.png)

In this article we will discuss the following topics:

* [Targeting the GridViewCell element](#targeting-the-gridviewcell-element)

* [Setting a Column's CellStyle](#setting-a-columns-cellstyle)

## Targeting the GridViewCell element

In order to style all RadGridView cells of an application, you should create an appropriate style targeting the __GridViewCell__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all cells of an application__

	{{region gridview-cells_1}}
	<Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
		<Setter Property="VerticalContentAlignment" Value="Top"/>
		<Setter Property="HorizontalContentAlignment" Value="Center"/>
		<Setter Property="Background" Value="#ffcc00"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewCellStyle__.

#### __Figure 1: RadGridView with styled cells__

![RadGridView with styled cells](images/RadGridView-Cell-Styled.png)

## Setting a Column's CellStyle

__RadGridView Cells__ can also be styled by creating an appropriate __Style__ for the **GridViewCell**  element and setting it as the __CellStyle__ property of the respective __GridView Column__. 

#### __[XAML] Example 2: Setting a column's CellStyle__

	{{region gridview-styling-cell_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                Header="Name"
                                CellStyle="{StaticResource GridViewCellStyle}" />
	{{endregion}}

To learn how to modify the default GridViewCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

# See Also

 * [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})

 * [Change Background for Disabled Grid Elements]({%slug gridview-how-to-set-background-disabled-cell%})
