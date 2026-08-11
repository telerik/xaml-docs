---
title: Toggle RowDetails Column
page_title: Toggle RowDetails Column
description: Learn how to use the Toggle RowDetails Column in Telerik's DataGrid to show RowDetails if they are available.
slug: radgridview-columns-column-types-toggle-rowdetails-column
tags: toggle,rowdetails,column
published: True
position: 10
---

# Toggle RowDetails Column

`GridViewToggleRowDetailsColumn` derives from [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class, which means that it isn't used to display data. The column is represented by an `GridViewToggleButton` control. Clicking on it will show [RowDetails]({%slug radgridview-row-details-overview%}) if they are available. This column will automatically link the created toggle buttons to the DetailsVisibilityProperty of each GridViewRow.

__Defining GridViewToggleRowDetailsColumn in XAML__
<snippet id='radgridview-columns-columntypes-column-types-toggle-rowdetails-column-defining_gridviewtogglerowdetailscolumn_in_xaml-xaml' />


__GridViewToggleRowDetailsColumn__

![Telerik UI for {{ site.framework_name }} RadGridView GridViewToggleRowDetailsColumn showing row details expand buttons](images/radgridview-columns-column-types-toggle-rowdetails-column-0.png)

>important You should either configure the `RowDetailsVisibilityMode` property of `RadGridView` to control the state of __all grid rows__ or use a GridViewToggleRowDetailsColumn to control the state of __each individual row__. Since GridViewToggleRowDetailsColumn operates on the respective DetailsVisibilityProperty of the GridViewRow, having the RowDetailsVisibilityMode property of RadGridView different from `Collapsed` might lead to unexpected results.

## Setting the Expand Mode

The GridViewToggleRowDetailsColumn exposes the `ExpandMode` property that will allow you to specify whether or not only one row details can be visible on a time. The possible values are as follows:

* `Single`&mdash;Only a single row details will be visible at a time. 
* `Multiple`&mdash;Multple row details can be visible at a time. This is the default value of the ExpandMode property.

>important If ExpandMode property is set to `Single`, expanding a new row with the toggle button will collapse the previous one.

## Stying the Toggle Button

The GridViewToggleRowDetailsColumn allows you to set a Style for the expand/collapse button. This is done via the `ToggleButtonStyle` property.

__Setting a Style for the ToggleButtonStyle__
<snippet id='radgridview-columns-columntypes-column-types-toggle-rowdetails-column-setting_a_style_for_the_togglebuttonstyle-xaml' />


__GridViewToggleRowDetailsColumn with custom Style for the ToggleButtonStyle property__

![Telerik UI for {{ site.framework_name }} RadGridView GridViewToggleRowDetailsColumn with a custom ToggleButtonStyle](images/radgridview-columns-column-types-toggle-rowdetails-column-1.png)

# See also:

* [RowDetails]({%slug radgridview-row-details-overview%}) 
* [Row Details Template]({%slug radgridview-row-details-template%})
