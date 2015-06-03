---
title: Customizing Rows
page_title: Customizing Rows
description: Customizing Rows
slug: gridview-customizing-rows
tags: customizing,rows
published: True
position: 2
---

## Hiding the Row Indicator

By default the first cell of a row represents row indicator, which appears when the row is set as current.

![](images/RadGridView_CustomizingRows_1.png)

To hide the row indicator set the __RowIndicatorVisibility__ property to __Collapsed__.

#### __XAML__

{{region gridview-customizing-rows_0}}
	<telerik:RadGridView x:Name="radGridView"
	                     RowIndicatorVisibility="Collapsed">
	    ...
	</telerik:RadGridView>
{{endregion}}

![](images/RadGridView_CustomizingRows_2.png)

RadGridView allows you to easily customize each of the row types by just assigning a style to it. 

## Styling Row and Alternating Row

To style rows or alternating rows you can use the __RowStyle__ or the __AlternateRowStyle__ properties. To learn how to do this take a look at the [Styling Rows]({%slug gridview-styling-a-row%}) topic.

## Styling the Group Row

To style the group row you can use the __GroupRowStyle__ property. To learn how to do this take a look at the [Styling Group Row]({%slug gridview-styling-group-row%}) topic.

## Styling the Header Row

To style the header row you can use the __HeaderRowStyle__ property. To learn how to do this take a look at the [Styling Header Row]({%slug gridview-styling-header-row%}) topic.

# See Also

 * [Grid Rows - Overview]({%slug gridview-rows-overview%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
 
 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
