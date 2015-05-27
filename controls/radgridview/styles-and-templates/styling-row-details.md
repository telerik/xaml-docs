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



>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the GridViewFooterCell control]({%slug radgridview-styles-and-templates-templates-structure%}).

The __RadGridView__ exposes the __RowDetailsStyle__ property of type __Style__. It is applied to the details of the __GridViewRow__ controls inside the __RadGridView__.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

>tipTo learn more about the __Row Details__ read [here]({%slug radgridview-row-details-overview%}).

## Modifying the Default Style

To copy the default style, load your project in Expression Blend and open the User Control that holds the __RadGridView__. In the 'Objects and Timeline' pane select the __RadGridView__ you want to style. From the menu choose *Object -> Edit Additional Styles -> __RowDetailsStyle__ -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __DetailsPresenter__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __DetailsPresenter__. Their names indicate to which part of the __DetailsPresenter__ appearance they are assigned.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewRowDetails_01.png){% endif %}

* __ControlOuterBorder__ -  a brush that represents the outer border color of the details container.

* __DetailsPresenterTemplate__ - the __ControlTemplate__, applied to the __DetailsPresenter__ control.

* __GridView_RowDetailBackground__ - a brush that represents the background color of the details presenter container.

* __ControlInnerBorder__ - a brush that represents the inner border color of the details container.

* __DetailsPresenterStyle__ - the __Style__ applied to the __DetailsPresenter__ control.{% if site.site_name == 'Silverlight' %}

Here is an example of these resource changed.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewRowDetails_02.png){% endif %}{% if site.site_name == 'Silverlight' %}

And here is a snapshot of the result.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewRowDetails_03.png){% endif %}

# See Also

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})

 * [Styling a Row]({%slug gridview-styling-a-row%})
