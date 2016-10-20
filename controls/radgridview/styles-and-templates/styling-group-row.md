---
title: Styling Group Row
page_title: Styling Group Row
description: Styling Group Row
slug: gridview-styling-group-row
tags: styling,group,row
published: True
position: 12
---

# Styling Group Row

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewGroupRow and GroupHeaderRow]({%slug radgridview-styles-and-templates-templates-structure%}).

>importantWith R3 2012, Telerik introduced __GroupRenderMode="Flat"__ which uses the **GroupHeaderRow** element as opposed to the **Nested** group render mode that uses the **GridViewGroupRow**. You should target the correct element in order for your styles to be applied. Please look at this [help article]({%slug gridview-grouping-groupingmodes%}) for details.

In this article we will discuss the following topics:

* [Targeting the GridViewGroupRow Element](#targeting-the-gridviewgrouprow-element)

* [Targeting the GroupHeaderRow Element](#targeting-the-groupheaderrow-element)

* [Setting RadGridView's GroupRowStyle](#setting-radgridviews-grouprowstyle)

## Targeting the GridViewGroupRow Element

In order to style all group rows of __RadGridView__ instances with **GroupRenderMode="Nested"** in your application, you should create an appropriate style targeting the __GridViewGroupRow__ element.

#### __Figure 1: GridViewGroupRow template structure__

![GridViewGroupRow template structure](images/gridview-group-row-template.png)

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Targetting GridViewGroupRow__

	{{region xaml-gridview-styling-group-row-1}}
	<Style TargetType="{x:Type telerik:GridViewGroupRow}">
	    <Setter Property="MinHeight" Value="60" />
	</Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewGroupRowStyle__.

## Targeting the GroupHeaderRow Element

If you have set your **GroupRenderMode** to **Flat**, your style should target the __GroupHeaderRow__ element.

#### __Figure 2: GroupHeaderRow template structure__

![GroupHeaderRow template structure](images/gridview-groupheaderrow-template.png)

#### __[XAML] Example 2: Targetting GroupHeaderRow__

	{{region xaml-gridview-styling-group-row-2}}
	<Style TargetType="{x:Type telerik:GroupHeaderRow}">
	    <Setter Property="MinHeight" Value="60" />
	</Style>
{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GroupHeaderRowStyle__.

## Setting RadGridView's GroupRowStyle

The __RadGridView__ exposes the __GroupRowStyle__ property of type __Style__. It is applied to the __GridViewGroupRow__/__GroupHeaderRow__ visual elements inside the __RadGridView__.

#### __[XAML] Example 2: Setting RadGridView's GroupRowStyle__

	{{region xaml-gridview-styling-group-row-3}}
	<telerik:RadGridView GroupRowStyle="{StaticResource GroupRowStyle}" />
{{endregion}}

#### __Figure 3: RadGridView with styled group rows__

![](images/RadGridView_Styles_and_Templates_Styling_GridViewGroupRow_03.png)

>In order to fully style the grouping appearance you have to also modify the styles for [GridViewRow]({%slug gridview-styling-a-row%}), [GridViewGroupFooterRow]({%slug gridview-styles-and-templates-styling-group-footers%}) and [indent cells]({%slug radgridview-styling-indent-cells%}).

# See Also

 * [Styling Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%})

 * [Grouping Modes]({%slug gridview-grouping-groupingmodes%})

 * [Basic Grouping]({%slug gridview-grouping-basics%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Group Footers]({%slug gridview-group-footers%})
