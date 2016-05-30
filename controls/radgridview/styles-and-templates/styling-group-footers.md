---
title: Styling Group Footers
page_title: Styling Group Footers
description: Styling Group Footers
slug: gridview-styles-and-templates-styling-group-footers
tags: styling,group,footers
published: True
position: 10
---

# Styling Group Footers

>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the GridViewGroupFooterCell control]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewgroupfootercell).

In this article we will discuss the following topics:

* [Targeting the GridViewGroupFooterCell Element](#targeting-the-gridviewgroupfootercell-element)

* [Setting a Column's GroupFooterCellStyle](#setting-a-columns-groupfootercellstyle)

## Targeting the GridViewGroupFooterCell Element

In order to style all RadGridView cells of an application, you should create an appropriate style targeting the __GridViewGroupFooterCell__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewFooterCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all group footer cells of an application__

	{{region gridview-styling-group-footers-1}}
	<Style TargetType="telerik:GridViewGroupFooterCell">
		<Setter Property="BorderBrush" Value="Red"/>
		<Setter Property="Background" Value="Blue"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewGroupFooterCellStyle__.

## Setting a Column's GroupFooterCellStyle

RadGridView's footer cells can also be styled by creating an appropriate __Style__ for the **GridViewGroupFooterCell** element and setting it as the __GroupFooterCellStyle__ property of the respective __GridViewColumn__. 

#### __[XAML] Example 2: Setting a column's GroupFooterCellStyle__

	{{region gridview-styling-group-footers-2}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                Header="Name"
                                GroupFooterCellStyle="{StaticResource GridViewFooterCellStyle}" />
	{{endregion}}

#### __Figure 2: RadGridView with styled group footer cells__

![RadGridView with styled group footer cells](images/RadGridView_Styles_and_Templates_Styling_GridViewFooterCell_03.png)

# See Also

 * [Styling Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})

 * [Styling a Cell]({%slug gridview-styling-cell%})
