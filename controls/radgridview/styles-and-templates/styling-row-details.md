---
title: Styling Row Details
page_title: Styling Row Details
description: Learn how to create an appropriate style targeting the DetailsPresenter element in Telerik's {{ site.framework_name }} DataGrid in order to style all row details of your application.
slug: gridview-styling-row-details
tags: styling,row,details
published: True
position: 15
---

# Styling Row Details

## Targeting the DetailsPresenter Element

In order to style all row details of an application, you should create an appropriate style targeting the __DetailsPresenter__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default DetailsPresenter style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

__Example 1: Styling all row details of an application__

<snippet id='radgridview-styles-and-templates-styling-row-details-example_1_styling_all_row_details_of_an_application-xaml' />


>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __DetailsPresenterStyle__.

## Setting a Column's RowDetailsStyle
__RadGridView__ exposes the __RowDetailsStyle__ property of type __Style__. It is applied to the details of the __GridViewRow__ controls inside the __RadGridView__.

__Example 2: Setting RadGridView's RowDetailsStyle__

<snippet id='radgridview-styles-and-templates-styling-row-details-example_2_setting_radgridview_s_rowdetailsstyle-xaml' />


#### __Figure 2: RadGridView with styled row details__

![Telerik UI for {{ site.framework_name }} RadGridView with a custom RowDetailsStyle applied to row details](images/RadGridView_Styles_and_Templates_Styling_GridViewRowDetails_03.png)

## Setting RadGridView's RowDetailsStyleSelector

You could also use RadGridView's **RowDetailsStyleSelector** property to style rows details differently based on a specific condition. More details about how this can be achieved can be found in the [RowDetailsStyleSelector article]({%slug gridview-rowdetails-styleselector%}).

## See Also

* [Styling a Row]({%slug gridview-styling-a-row%})
 
* [Styling the Group Row]({%slug gridview-styling-group-row%})

* [Styling the Header Row]({%slug gridview-styling-header-row%})
