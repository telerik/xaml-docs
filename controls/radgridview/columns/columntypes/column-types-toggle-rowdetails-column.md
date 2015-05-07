---
title: Toggle RowDetails Column
page_title: Toggle RowDetails Column
description: Toggle RowDetails Column
slug: radgridview-columns-column-types-toggle-rowdetails-column
tags: toggle,rowdetails,column
published: True
position: 10
---

# Toggle RowDetails Column

__GridViewToggleRowDetailsColumn__ derives from [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class, which means that it isn't used to display data. The column is represented by an __GridViewToggleButton__ control. Clicking on it will show [RowDetails]({%slug radgridview-row-details-overview%}) if they are available. 

>You should either configure __RadGridView.RowDetailsVisibilityMode__ property to control the state of __all grid rows__ or use a __GridViewToggleRowDetailsColumn__ to control the state of __each individual row__. Since __GridViewToggleRowDetailsColumn__ operates on the respective __GridViewRow.DetailsVisibilityProperty__, having a __RadGridView.RowDetailsVisibilityMode__ different from collapsed might lead to unexpected results.

Here is a list of the most important properties.

* __ToggleButtonStyle__ - allows you to apply a style to the toggle button.

* __ExpandMode__ - allows you to specify, whether only one row details can be visible on a time. The possible values are:
	* __Single__ 
	* __Multiple__ (default). 

>If ExpandMode property is set to __Single__, expanding a new row with the toggle button will collapse the previous one.

#### __[XAML] Example 1: Define GridViewToggleRowDetailsColumn in XAML.__

{{region radgridview-columns-column-types-toggle-rowdetails-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewToggleRowDetailsColumn />
	        ...
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

# See also:

* [RowDetails]({%slug radgridview-row-details-overview%}) 

* [Row Details Template]({%slug radgridview-row-details-template%})
