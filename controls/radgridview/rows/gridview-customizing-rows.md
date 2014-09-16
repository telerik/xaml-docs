---
title: Customizing Rows
page_title: Customizing Rows
description: Customizing Rows
slug: gridview-customizing-rows
tags: customizing,rows
publish: True
position: 2
---

# Customizing Rows



## Hiding the Row Indicator

By default the first cell of a row is used by the row indicator, which appears when the row is set as current.

![](images/RadGridView_CustomizingRows_1.png)

To hide the row indicator set the __RowIndicatorVisibility__ property of the __RadGridView__ to __Collapsed__.

#### __XAML__

{{region gridview-customizing-rows_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         RowIndicatorVisibility="Collapsed">
	    ...
	</telerik:RadGridView>
	{{endregion}}



![](images/RadGridView_CustomizingRows_2.png)

The __RadGridView__ allows you to easily customize each of the row types by just assigning a style to it. 

## Styling Row and Alternating Row

To style the row or the alternating row of the __RadGridView__ use the __RowStyle__ or the __AlternateRowStyle__ properties. To learn how to do this take a look at the [Styling a Row]({%slug gridview-styling-a-row%}) topic.

## Styling the Group Row

To style the group row of the __RadGridView__ use the __GroupRowStyle__ property. To learn how to do this take a look at the [Styling the Group Row]({%slug gridview-styling-group-row%}) topic.

## Styling the Header Row

To style the header row of the __RadGridView__ use the __HeaderRowStyle__ property. To learn how to do this take a look at the [Styling the Header Row]({%slug gridview-styling-header-row%}) topic.

# See Also

 * [Grid Rows - Overview]({%slug gridview-rows-overview%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
