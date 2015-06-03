---
title: Frozen Columns
page_title: Frozen Columns
description: Frozen Columns
slug: gridview-columns-frozen-columns
tags: frozen,columns
published: True
position: 9
---

# Frozen Columns

__RadGridView__ provides an easy way to select one or more columns and exclude them from the horizontal scrolling. The frozen columns stay static on top of the horizontal scrolling. To freeze a column the user has to drag the frozen columns separator.

![Rad Grid View Frozencolumns 1](images/RadGridView_Frozencolumns_1.png)

Once there is a frozen column you can freeze other columns by dragging their headers behind the frozen columns separator.

![Rad Grid View Frozencolumns 2](images/RadGridView_Frozencolumns_2.png)

Similarly, you can unfreeze columns by dragging their headers outside the frozen columns separator.

A frozen column always stays on top of horizontal scrolling.

![Rad Grid View Frozencolumns 3](images/RadGridView_Frozencolumns_3.png)

## Freezing Columns

You can freeze your columns programmatic using the __FrozenColumnCount__ property of the __RadGridView__ control. The property is numeric and you have to set it to the number of columns you wish to freeze.

In this sample, the first two columns are frozen starting from left to right.

#### __XAML__

{{region gridview-columns-frozen-columns_0}}

	<telerik:RadGridView FrozenColumnCount="2" />
{{endregion}}

#### __C#__

{{region gridview-columns-frozen-columns_1}}

	this.radGridView.FrozenColumnCount = 2;
{{endregion}}

#### __VB.NET__

{{region gridview-columns-frozen-columns_2}}

	Me.radGridView.FrozenColumnCount = 2
{{endregion}}

## Disabling Frozen Columns

To disable the freezing of a column just set the __CanUserFreeze to False__ and the frozen columns separator will disappear.

#### __XAML__

{{region gridview-columns-frozen-columns_3}}

	<telerik:RadGridView x:Name="radGridView"
	                     CanUserFreezeColumns="False">
	    ...
	</telerik:RadGridView>
{{endregion}}

![Rad Grid View Frozencolumns 4](images/RadGridView_Frozencolumns_4.png)

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})
