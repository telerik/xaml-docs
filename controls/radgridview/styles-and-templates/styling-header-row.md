---
title: Styling Header Row
page_title: Styling Header Row
description: Styling Header Row
slug: gridview-styling-header-row
tags: styling,header,row
published: True
position: 13
---

# Styling Header Row

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewHeaderRow]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewheaderrow).

In this article we will discuss the following topics:

* [Targeting the GridViewHeaderRow Element](#targeting-the-gridviewheaderrow-element)

* [Setting RadGridView's HeaderRowStyle](#setting-radgridviews-headerrowstyle)

#### __Figure 1: GridViewHeaderRow template structure__

![GridViewHeaderRow template structure](images/gridview-headerrow-template.png)

## Targeting the GridViewHeaderRow Element

In order to style all __RadGridView__ header rows of an application, you should create an appropriate style targeting the __GridViewHeaderRow__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewHeaderRow style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all header rows of an application__

	{{region xaml-gridview-styling-header-row-1}}
	<Style TargetType="telerik:GridViewHeaderRow">
	    <Setter Property="Background" Value="Red"/>
	</Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewHeaderRowStyle__.

## Setting RadGridView's HeaderRowStyle

__RadGridView's header row__ can also be styled by creating an appropriate __Style__ for the **GridViewHeaderRow**  element and setting it as the __HeaderRowStyle__ property.

#### __[XAML] Example 2: Setting RadGridView's HeaderRowStyle__

	{{region xaml-gridview-styling-header-row-2}}
	<telerik:RadGridView HeaderRowStyle="{StaticResource HeaderRowStyle}" />
{{endregion}}

#### __Figure 1: RadGridView with styled header row__

![RadGridView with styled header row](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderRow_03.png)

>As you can see, the changes we made apply only for the row. The header cells remain unchanged. To learn how to style them, take a look at the [Styling Column Headers]({%slug gridview-styling-column-headers%}) topic.

# See Also

 * [Styling a Row]({%slug gridview-styling-a-row%})

 * [Styling the Row Details]({%slug gridview-styling-row-details%})

 * [Styling the Group Row]({%slug gridview-styling-group-row%})
