---
title: Styling Row Details
page_title: Styling Row Details
description: Styling Row Details
slug: gridview-styling-row-details
tags: styling,row,details
published: True
position: 15
---

# Styling Row Details

>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the DetailsPresenter]({%slug radgridview-styles-and-templates-templates-structure%}#detailspresenter).

In this article we will discuss the following topics:

* [Targeting the DetailsPresenter Element](#targeting-the-detailspresenter-element)

* [Setting RadGridView's RowDetailsStyle](#setting-radgridviews-rowdetailsstyle)

## Targeting the DetailsPresenter Element

In order to style all row details of an application, you should create an appropriate style targeting the __DetailsPresenter__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default DetailsPresenter style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all row details of an application__

	{{region gridview-styling-row-details-1}}
	<Style TargetType="telerik:DetailsPresenter">
		<Setter Property="Background" Value="Red"/>
		<Setter Property="HorizontalContentAlignment" Value="Right"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __DetailsPresenterStyle__.

## Setting a Column's RowDetailsStyle

__RadGridView__ exposes the __RowDetailsStyle__ property of type __Style__. It is applied to the details of the __GridViewRow__ controls inside the __RadGridView__.

#### __[XAML] Example 2: Setting RadGridView's RowDetailsStyle__

	{{region gridview-styling-row-details-2}}
	<telerik:RadGridView RowDetailsStyle="{StaticResource RowDetailsStyle}" />
	{{endregion}}

#### __Figure 2: RadGridView with styled row details__

![](images/RadGridView_Styles_and_Templates_Styling_GridViewRowDetails_03.png)

# See Also

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})

 * [Styling a Row]({%slug gridview-styling-a-row%})
