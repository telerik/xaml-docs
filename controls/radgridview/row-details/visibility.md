---
title: Row Details Visibility
page_title: Row Details Visibility
description: Row Details Visibility
slug: radgridview-row-details-visibility
tags: row,details,visibility
published: True
position: 2
---

# Row Details Visibility

The display mode of the __Row Details__ can be specified by using the __RowDetailsVisibilityMode__ property. It can have one of the following values: 

* __Collapsed__ - row details won't be displayed for any of the rows.
            
* __Visible__ - row details will be displayed for each of the rows.
            
* __VisibleWhenSelected__ - row details will be displayed only for the selected row.
            
Another approach for displaying the __Row Details__ is to use the [GridViewToggleRowDetailsColumn]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}). It will allow you to __expand / collapse__the __Row Details__ for each row.

>You should either use the __RadGridView.RowDetailsVisibilityMode__ property to control the state of __all grid rows__ or use a [GridViewToggleRowDetailsColumn]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}) to control the state of __each individual row__. Since the __GridViewToggleRowDetailsColumn__ operates on the respective __GridViewRow.DetailsVisibilityProperty__, having a __RadGridView.RowDetailsVisibilityMode__ different from collapsed might lead to unexpected results. To learn more about this type of column read [here]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}).

>tipYou can download a runnable project demonstrating the different options from our online SDK repository [here](https://github.com/telerik/xaml-sdk), after navigating to __GridView/RowDetailsVisibilityOptions__. In addition to make finding and browsing the examples easier, you can take advantage of our [SDK Samples Browser]({%slug sdk-samples-browser%}).

# See Also

 * [RowDetails Overview]({%slug radgridview-row-details-overview%})

 * [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%})

 * [Row Details Template]({%slug radgridview-row-details-template%})

 * [Programming]({%slug radgridview-row-details-programming%})

 * [Row Details TemplateSelector]({%slug radgridview-row-details-templateselector%})
