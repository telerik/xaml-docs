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

>tipBefore reading this topic, you might find it useful to get familiar with the [GridViewGroupFooterCell and GridViewGroupFooterRow]({%slug radgridview-styles-and-templates-templates-structure%}).

In this article we will discuss the following topics:

* [Targeting the GridViewGroupFooterRow Element](#targeting-the-gridviewgroupfooterrow-element)

* [Setting RadGridView's GroupFooterRowStyle](#setting-radgridviews-groupfooterrowstyle)

* [Setting RadGridView's GroupFooterRowStyleSelector](#setting-radgridviews-groupfooterrowstyleselector)

* [Targeting the GridViewGroupFooterCell Element](#targeting-the-gridviewgroupfootercell-element)

* [Setting a Column's GroupFooterCellStyle](#setting-a-columns-groupfootercellstyle)

## Targeting the GridViewGroupFooterRow Element

If you want to style all group footer rows of your application, you should create an appropriate style targeting the __GridViewGroupFooterRow__ element.

#### __Figure 1: GridViewGroupFooterRow template structure__

![GridViewRow template structure](images/gridview-groupfooterrow-style.png)

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewFooterCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all group footer rows of an application__

	{{region gridview-styling-group-footers-1}}
	<Style TargetType="telerik:GridViewGroupFooterRow">
		<Setter Property="Foreground" Value="White"/>
		<Setter Property="Background" Value="LightBlue"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewGroupFooterRowStyle__.

## Setting RadGridView's GroupFooterRowStyle

RadGridView's footer rows can also be styled by creating an appropriate __Style__ for the **GridViewGroupFooterRow** element and setting it as RadGridView's __GroupFooterRowStyle__ property. 

#### __[XAML] Example 2: Setting RadGridView's GroupFooterRowStyle__

	{{region gridview-styling-group-footers-2}}
	<telerik:RadGridView GroupFooterRowStyle="{StaticResource GridViewFooterRowStyle}" />
	{{endregion}}

#### __Figure 2: RadGridView with styled group footer rows__

![RadGridView with styled group footer cells](images/gridview-groupfooterrow-styled.png)

## Setting RadGridView's GroupFooterRowStyleSelector

You could also use RadGridView's **GroupFooterRowStyleSelector** property to style group footer rows differently based on a specific condition. More details about how this can be achieved can be found in the [GroupFooterRowStyleSelector article]({%slug gridview-group-footer-row-style-selector%}).

## Targeting the GridViewGroupFooterCell Element

In order to style all __RadGridView__ cells of an application, you should create an appropriate style targeting the __GridViewGroupFooterCell__ element.

#### __[XAML] Example 6: Styling all group footer cells of an application__

	{{region gridview-styling-group-footers-8}}
	<Style TargetType="telerik:GridViewGroupFooterCell">
		<Setter Property="BorderBrush" Value="Red"/>
		<Setter Property="Background" Value="Blue"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewGroupFooterCellStyle__.

## Setting a Column's GroupFooterCellStyle

RadGridView's footer cells can also be styled by creating an appropriate __Style__ for the **GridViewGroupFooterCell** element and setting it as the __GroupFooterCellStyle__ property of the respective __GridViewColumn__. 

#### __[XAML] Example 7: Setting a column's GroupFooterCellStyle__

	{{region gridview-styling-group-footers-9}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                Header="Name"
                                GroupFooterCellStyle="{StaticResource GridViewFooterCellStyle}" />
	{{endregion}}

#### __Figure 2: RadGridView with styled group footer cells__

![RadGridView with styled group footer cells](images/RadGridView_Styles_and_Templates_Styling_GridViewFooterCell_03.png)

## See Also

 * [Styling Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})

 * [Styling a Cell]({%slug gridview-styling-cell%})
