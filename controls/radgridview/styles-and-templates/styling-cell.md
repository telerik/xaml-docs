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

#### __Figure 1: GridViewCell template structure__

![RadGridView template structure](images/Styling_RadGridView01.png)

__RadGridView Cells__ can be styled by creating an appropriate __Style__ for the **GridViewCell**  element and setting it as the __CellStyle__ property of the respective __GridView Column__. 

#### __[XAML] Example 1: Setting a column's CellStyle__

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
