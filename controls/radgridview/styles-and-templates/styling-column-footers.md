---
title: Styling Column Footers
page_title: Styling Column Footers
description: Styling Column Footers
slug: gridview-styling-column-footers
tags: styling,column,footers
published: True
position: 9
---

# Styling Column Footers


>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewFooterCell]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewfootercell).

In this article we will discuss the following topics:

* [Targeting the GridViewFooterRow Element](#targeting-the-gridviewfooterrow-element)
* [Setting RadGridView's FooterRowStyle](#setting-radgridviews-footerrowstyle)
* [Targeting the GridViewFooterCell Element](#targeting-the-gridviewfootercell-element)
* [Setting a Column's FooterCellStyle](#setting-a-columns-footercellstyle)

## Targeting the GridViewFooterRow Element

If you want to style all footer rows of your application, you should create an appropriate style targeting the __GridViewFooterRow__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewFooterRow style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all footer rows of an application__

	{{region xaml-gridview-styling-column-footers-1}}
	<Style TargetType="telerik:GridViewFooterRow">
        <Setter Property="Foreground" Value="White"/>
        <Setter Property="Background" Value="LightBlue"/>
    </Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewFooterRowStyle__.

## Setting RadGridView's FooterRowStyle

RadGridView's footer rows can also be styled by creating an appropriate __Style__ for the **GridViewFooterRow** element and setting it as RadGridView's __FooterRowStyle__ property. 

#### __[XAML] Example 2: Setting RadGridView's FooterRowStyle__

	{{region xaml-gridview-styling-column-footers-2}}
	<telerik:RadGridView FooterRowStyle="{StaticResource GridViewFooterRowStyle}" />
{{endregion}}

#### __Figure 1: RadGridView with styled footer rows__

![RadGridView with styled footer cells](images/gridview-footerrow-style.png)

## Targeting the GridViewFooterCell Element

In order to style all RadGridView cells of an application, you should create an appropriate style targeting the __GridViewFooterCell__ element.

#### __[XAML] Example 3: Styling all footer cells of an application__

	{{region xaml-gridview-styling-column-footers-3}}
	<Style TargetType="telerik:GridViewFooterCell">
	    <Setter Property="BorderBrush" Value="Red"/>
	    <Setter Property="Background" Value="Blue"/>
	</Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewFooterCellStyle__.

## Setting a Column's FooterCellStyle

RadGridView's footer cells can also be styled by creating an appropriate __Style__ for the **GridViewFooterCell** element and setting it as the __FooterCellStyle__ property of the respective __GridViewColumn__. 

#### __[XAML] Example 4: Setting a column's CellStyle__

	{{region xaml-gridview-styling-column-footers-4}}
	<telerik:GridViewDataColumn Header="ID"
	                DataMemberBinding="{Binding EmployeeID}"
	                Footer="ID"
	                FooterCellStyle="{StaticResource GridViewFooterCellStyle}" />
{{endregion}}

#### __Figure 2: RadGridView with styled footer cells__

![RadGridView with styled footer cells](images/RadGridView_Styles_and_Templates_Styling_GridViewColumnFooterCell_03.png)

## See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})
