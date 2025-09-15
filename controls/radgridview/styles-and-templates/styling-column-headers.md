---
title: Styling Column Headers
page_title: Styling Column Headers
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to create an appropriate style targeting the HeaderCell element.
slug: gridview-styling-column-headers
tags: styling,column,headers
published: True
position: 7
---

# Styling Column Headers

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewHeaderCell]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewheadercell).

In this article we will discuss the following topics:

* [Targeting the GridViewHeaderCell element](#targeting-the-gridviewheadercell-element)

* [Setting a Column's HeaderCellStyle](#setting-a-columns-headercellstyle)

#### __Figure 1: GridViewHeaderCell template structure__

![Telerik {{ site.framework_name }} DataGrid Header Cell Template](images/gridviewheadercell-template.png)

## Targeting the GridViewHeaderCell element

In order to style all header cells in your application, you should create an appropriate style targeting the __GridViewHeaderCell__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewHeaderCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

The style in **Example 1** will style all the column headers in your application.

__Example 1: Styling all header cells of an application__

```XAML
	<Application.Resources>
		<Style TargetType="telerik:GridViewHeaderCell">
			<Setter Property="Foreground" Value="Red"/>
			<Setter Property="HorizontalContentAlignment" Value="Center"/>
		</Style>
	</Application.Resources>
```

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you need to base your style on the __GridViewHeaderCellStyle__.

## Setting a Column's HeaderCellStyle

__RadGridView__ header cells can also be styled by creating an appropriate __Style__ for the **GridViewHeaderCell** element and setting it as the __HeaderCellStyle__ property of the respective __GridView Column__. 

The style from **Example 2** will only be applied to the **Number** column as we've set its HeaderCellStyle property.

__Example 2: Setting a column's HeaderCellStyle__

```XAML
    <Grid>
        <Grid.Resources>
            <Style x:Key="CustomGridViewHeaderCellStyle" TargetType="telerik:GridViewHeaderCell" BasedOn="{StaticResource GridViewHeaderCellStyle}">
                <Setter Property="Foreground" Value="Red"/>
                <Setter Property="HorizontalContentAlignment" Value="Center"/>
            </Style>
        </Grid.Resources>
        <telerik:RadGridView ItemsSource="{Binding Players}" AutoGenerateColumns="False">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Number}" HeaderCellStyle="{StaticResource CustomGridViewHeaderCellStyle}" />
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>
    </Grid>
```

#### __Figure 2: RadGridView with styled header cell__

![Telerik {{ site.framework_name }} DataGrid Styles and Templates Styling GridViewHeaderCell](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderCell_03.png)

## See Also

* [Styling a Cell]({%slug gridview-styling-cell%})
* [Styling the Column Footers]({%slug gridview-styling-column-footers%})