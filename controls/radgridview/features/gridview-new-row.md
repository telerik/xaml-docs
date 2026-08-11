---
title: Add New Row Button
page_title: Add New Row Button
description: This article will provide information about the new row functionality of Telerik UI for WPF RadGridView.
slug: gridview-new-row
tags: gridview, new, row, new row, position
published: True
position: 23
---

# Add New Row Button

`RadGridView` allows you to display an additional row that will allow you to insert new entries in the bound collection. To display it, set the `NewRowPosition` property to either `Top` or `Bottom` and expose an empty constructor in the underlying object.

>important The Bottom option works only when the `GroupRenderMode` property of `RadGridView` is set to `Flat`.

The following example shows how to display the new row:

__Defining the underlying object and view model__
<snippet id='radgridview-features-gridview-new-row-defining_the_underlying_object_and_view_model-cs' />

<snippet id='radgridview-features-gridview-new-row-defining_the_underlying_object_and_view_model-vb' />


__Defining the RadGridView to show the new row__
<snippet id='radgridview-features-gridview-new-row-defining_the_radgridview_to_show_the_new_row-xaml' />


__The new row of RadGridView for inserting data__

![Telerik UI for WPF RadGridView new row displayed at the top for inserting data](images/gridview-features-new-row-0.png)

## New Row Position

The `NewRowPosition` property allows you to specify whether the new row will be visible on the top or on the bottom of the items, or not be displayed at all. The property is of the type of `GridViewNewRowPosition` and it exposes the following options:

* `None`&mdash;With this option, the new row will not be displayed. This is the default value of the NewRowPosition property.
* `Top`&mdash;Displays the new row on top of the displayed items.
* `Bottom`&mdash;Displays the new row on the bottom of the items in the current view port. For this option, the `GroupRenderMode` property of RadGridView has to be set to `Flat`.

__Setting the new row position to be on the bottom__
<snippet id='radgridview-features-gridview-new-row-setting_the_new_row_position_to_be_on_the_bottom-xaml' />


__RadGridView's new row positioned on the bottom__

![Telerik UI for WPF RadGridView new row positioned at the bottom of the grid](images/gridview-features-new-row-1.png)

## Customizing the New Row's Content

RadGridView provides the ability to customize the content of the new row. To do so, you can utilize the `GridViewNewRowContent` and `GridViewNewRowContentTemplate` properties. 

__Using the GridViewNewRowContent and GridViewNewRowContentTemplate__
<snippet id='radgridview-features-gridview-new-row-using_the_gridviewnewrowcontent_and_gridviewnewrowcontenttemplate-xaml' />


__RadGridView's new row with customized content__

![Telerik UI for WPF RadGridView new row with customized content and icon template](images/gridview-features-new-row-2.png)

## Styling the New Row Element

The new row of RadGridView is represented by the `GridViewNewRow` element. You can style it either implicitly (via a global Style) or utilize the NewRowStyle property of RadGridView. To learn how to style the GridViewNewRow element, check the [Styling the GridViewNewRow]({%slug gridview-styling-gridviewnewrow%}) article.
