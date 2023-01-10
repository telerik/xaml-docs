---
title: Styling GridViewNewRow
page_title: Styling GridViewNewRow
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to you can explicitly or implicitly style the GridViewNewRow.
slug: gridview-styling-gridviewnewrow
tags: styling,new,row
published: True
position: 15
---

# {{ site.framework_name }} RadGridView Styling the GridViewNewRow

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewNewRow]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewnewrow).

In this article we will show how you can explicitly or implicitly style the GridViewNewRow.

## Targeting the GridViewNewRow Element

In order to style the GridViewNewRow, you should create an appropriate style targeting the __GridViewNewRow__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewNewRow style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling the GridViewNewRow implicitly__

{{region xaml-gridview-styling-gridviewnewrow-0}}
	<Style TargetType="telerik:GridViewNewRow">
        <Setter Property="Background" Value="Red" />
    </Style>
{{endregion}}

#### __[XAML] Example 2: Styling the GridViewNewRow explicitly__

{{region xaml-gridview-styling-gridviewnewrow-1}}
    <Style x:Key="NewRowStyle" TargetType="telerik:GridViewNewRow">
        <Setter Property="Background" Value="Red" />
    </Style>

    <telerik:RadGridView NewRowPosition="Top"
                         NewRowStyle="{StaticResource NewRowStyle}">
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewNewRowStyle__.

#### __Figure 1: RadGridView with styled GridViewNewRow in the Office 2016 theme__

![Telerik {{ site.framework_name }} DataGrid-new-row-styling](images/gridview-newrow-styling.png)

## See Also

 * [Styling Rows]({%slug gridview-styling-a-row%})

 * [Alternating Rows]({%slug radgridview-rows-alternating-rows%})

 * [Styling the Row Details]({%slug gridview-styling-row-details%})

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})
